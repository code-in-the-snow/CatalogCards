﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogCards
{
    public struct Book
    {
        public string title { get; set; }
        public string publish_place { get; set; }
        public string publisher { get; set; }
        public string publish_date { get; set; }
        public string pages { get; set; }
        public List<string> authors { get; set; }
        public List<string> subjects { get; set; }
        public List<string> call_number { get; set; }
    }

    public partial class frmCatalogCard : Form
    {
        public string isbn { get; set; }
        public string id { get; set; }
        public bool fiction { get; set; }
        
        private void DoNotDisplay()
        {
            this.Close();
        }

        private void SplitOnSpace(string name)
        {
            int spaceIndex = name.IndexOf(" ");
            lblName.Text = name.Substring(spaceIndex+1);
        }

        public void AddAuthorToTitle( List<string> names)
        {
            if (names.ToArray().Length > 1) 
            {
                lblTitle.Text += " / " + names[0] + " et al.";
                lblAuthor.Text += ", authors.";
            }
            else
            {
                lblTitle.Text += " / " + names[0] + ".";
                lblAuthor.Text += ", author.";
            }
        }

        private void SplitOnComma(string name)
        {
            int commaIndex = name.IndexOf(",");
            lblName.Text = name.Substring(0, commaIndex);
            lblTitle.Text += " / " + name.Substring(commaIndex + 1) + " " + name.Substring(0, commaIndex);
        }

        private void SetControls(Book B)
        {
            if (this.fiction) { lblFiction.Text = "FICTION"; };
            lblTitle.Text = B.title;
            lblPublisherInfo.Text= B.publish_place + " : " + B.publisher + ", (" + B.publish_date + ")";
            lblPages.Text = B.pages + " pages";
            lblISBN.Text = "ISBN " + isbn;

            int i = 1;
            foreach (string subject in B.subjects)
            {
                lstSubjects.Items.Add(i + ". " + subject);
                i++;
            }
        }

        private void AuthorsToString(List<string> authors)
        {
            lblAuthor.Text = authors[0];
            int numAuthors = authors.ToArray().Length;
            if (numAuthors > 1)
            {
                for (int i = 1; i < numAuthors; i++)
                {
                    lblAuthor.Text += ", " + authors[i];
                }
                lblAuthor.Text += ", authors.";
                lblTitle.Text += " et al.";
            }
            else
            {
                lblAuthor.Text += ", author.";
                lblTitle.Text += ".";
            }
        }

        private void AuthorsReversedToString(List<string> authors)
        {
            List<String> lastFirst = new List<String>();
            foreach ( string name in authors)
            {
                List<string> temp = new List<string>(name.Split( new char[] {' '} ));
                temp.Reverse();
                lastFirst.Add(String.Join(", ", temp));
            }
            lblAuthor.Text = lastFirst[0];
            int numAuths = lastFirst.ToArray().Length;
            for (int i = 1; i < numAuths; i++)
            {
                lblAuthor.Text += ", " + lastFirst[i];
            }
        }
       
        public frmCatalogCard()
        {
            InitializeComponent();
        }

        private void frmCatalogCard_Load(object sender, EventArgs e)
        {
            clsApiData apiData = new clsApiData();
            apiData.id = this.id;
            var raw_data = apiData.GetAPIData();

            clsParsing parser = new clsParsing();
            parser.id = this.id;
            parser.data = raw_data;

            try
            {
                if ((string)raw_data[this.id]["title"] != "")
                {
                    // load details for current ISBN
                    Book B = new Book();
                    try
                    {
                        B.publish_place = (string)raw_data[this.id]["publish_places"][0]["name"];
                    }
                    catch (NullReferenceException)
                    {
                        B.publish_place = " ";
                    }
                    B.title = (string)raw_data[this.id]["title"];
                    B.publisher = (string)raw_data[this.id]["publishers"][0]["name"];
                    B.publish_date = (string)raw_data[this.id]["publish_date"];
                    B.pages = (string)raw_data[this.id]["number_of_pages"];
                    B.subjects = parser.PullDictionaryData(raw_data, "subjects", id);
                    B.authors = parser.PullDictionaryData(raw_data, "authors", id);

                    SetControls(B);

                    // Check if the author name(s) is stored "First Last" or "Last, First" and then 
                    //   populate the form labels that include name: Name (for call number), Title and Author.
                    //   Fiction call numbers use entire last name.  Nonfiction call numbers use first 
                    //   three characters of last name.

                    if ((this.fiction == false) && B.authors[0].IndexOf(',') == -1)
                    {
                        lblFiction.Text = parser.GetCallNumber(raw_data); 
                        SplitOnSpace(B.authors[0]); 
                        lblName.Text = lblName.Text.Substring(0, 3); 

                        AuthorsReversedToString(B.authors);  
                        AddAuthorToTitle(B.authors);
                    }

                    else if (this.fiction == false && B.authors[0].IndexOf(',') != -1)
                    {
                        lblFiction.Text = parser.GetCallNumber(raw_data); 
                        SplitOnComma(B.authors[0]);
                        lblName.Text = lblName.Text.Substring(0, 3); 
                        AuthorsToString(B.authors); 
                    }

                    else if (this.fiction && (B.authors[0].IndexOf(',') != -1))
                    {
                        SplitOnComma(B.authors[0]);
                        AuthorsToString(B.authors); 
                    }

                    else // (this.fiction && B.authors[0].IndexOf(',') == -1)
                    {
                        SplitOnSpace(B.authors[0]); 
                        AuthorsReversedToString(B.authors); 
                        AddAuthorToTitle(B.authors);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Oops! We didn't find that edition. Check the ISBN.");
                DoNotDisplay();
            }
        }
    }
}

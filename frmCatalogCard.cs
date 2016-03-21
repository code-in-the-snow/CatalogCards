using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        
        public Newtonsoft.Json.Linq.JObject GetAPIData()
        {
            string url_base = @"https://openlibrary.org/api/books?bibkeys=";
            string url_params = "&jscmd=data&format=json";

            WebClient client = new WebClient();
            Stream stream = client.OpenRead(url_base + this.id + url_params);
            StreamReader reader = new StreamReader(stream);

            Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadLine());
            stream.Close();
            return obj;
        }

        public static List<string> PullDictionaryData(Newtonsoft.Json.Linq.JObject obj, string detail, string root)
        {
            int i = 0;
            bool is_more = true;
            List<string> dataList = new List<string>();

            while ((is_more) && (i < 5))
            {
                try
                {
                    dataList.Add((string)obj[root][detail][i]["name"]); ;
                    i++;
                }

                catch (NullReferenceException oEx)
                {
                    is_more = false;
                }

                catch (ArgumentOutOfRangeException oEx)
                {
                    is_more = false;
                }
            }
            return dataList;
        }

        public void GetCallNumber(Newtonsoft.Json.Linq.JObject obj)
        {
            string temp = "";
            int i = 0;
            bool is_more = true;
            while (is_more)
                try
                {
                    temp += (string)obj[id]["classifications"]["dewey_decimal_class"][i];
                    i++;
                }
                catch (ArgumentOutOfRangeException oEx)
                {
                    is_more = false;
                }
                catch (NullReferenceException oEx)
                {
                    is_more = false;
                }
            lblFiction.Text = temp;
        }

        public void SplitOnSpace(string name)
        {
            int spaceIndex = name.IndexOf(" ");
            lblName.Text = name.Substring(spaceIndex+1);
        }

        public void SplitOnComma(string name)
        {
            int commaIndex = name.IndexOf(",");
            lblName.Text = name.Substring(0, commaIndex);
        }

        public void SetControls(Book B)
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

        public void AuthorsToString(List<string> authors)
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
            }
            else
            {
                lblAuthor.Text += ", author.";
            }
        }

        public void AuthorsReversedToString(List<string> authors)
        {
            List<String> lastFirst = new List<String>();
            foreach ( string name in authors)
            {
                List<string> temp = new List<string>(name.Split( new char[] {' '} ));
                temp.Reverse();
                lastFirst.Add(String.Join(",", temp));
            }
            
            if (authors.ToArray().Length > 1)
            {
                lblTitle.Text += " / " + lastFirst[0] + " et al.";
                lblAuthor.Text += ", authors.";
            }
            else
            {
                lblTitle.Text += " / " + lastFirst[0] + ".";
                lblAuthor.Text += ", author.";
            }
        }
       
        public frmCatalogCard()
        {
            InitializeComponent();
        }

        public void frmCatalogCard_Load(object sender, EventArgs e)
        {

            Newtonsoft.Json.Linq.JObject raw_data = new Newtonsoft.Json.Linq.JObject();
            raw_data = GetAPIData();
            
            // load details for current book
            Book B = new Book();

            try
            {
                B.publish_place = (string)raw_data[this.id]["publish_places"][0]["name"]; 
            }
            catch (NullReferenceException nObj)
            {
                B.publish_place = " ";
            }
            B.publisher = (string)raw_data[this.id]["publishers"][0]["name"];
            B.publish_date = (string)raw_data[this.id]["publish_date"];
            B.pages = (string)raw_data[this.id]["number_of_pages"];
            B.title = (string)raw_data[this.id]["title"];
            B.subjects = PullDictionaryData(raw_data, "subjects", id);
            B.authors = PullDictionaryData(raw_data, "authors", id);

            SetControls(B);

            // Populate form labels depending on type of call number (ie fiction or nonfiction) and
            // whether the author's name is returned from the API Last, First or First Last. 
            if ((this.fiction == false) && B.authors[0].IndexOf(',') == -1)
            {
                GetCallNumber(raw_data);
                SplitOnSpace(B.authors[0]);
                lblName.Text = lblName.Text.Substring(0, 3);

                lblTitle.Text += " / " + B.authors[0] + ".";
                AuthorsToString(B.authors);                
            }
            else if (this.fiction && (B.authors[0].IndexOf(',') != -1))
            {
                SplitOnComma(B.authors[0]);
                
            }
        }

    }
}

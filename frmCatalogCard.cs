using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogCards
{
    public partial class frmCatalogCard : Form
    {
        public string isbn { get; set; }
        
        struct Book
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
        
        public frmCatalogCard()
        {
            InitializeComponent();
        }

        public void frmCatalogCard_Load(object sender, EventArgs e)
        {
            // load detail for current book
            Book B = new Book();
            B.authors = new List<string>();
            B.subjects = new List<string>();
            B.call_number = new List<string>();
            B.title = "The terrorists";
            B.publish_place = "New York";
            B.publish_date = "1976";
            B.publisher  = "Pantheon Books";
            B.pages = "281";
            B.authors.Add("Maj Sojwall");
            B.subjects.Add("Fiction");
            B.subjects.Add("Accessible Book");
            B.subjects.Add("Police");
            B.subjects.Add("Martin Beck (Fictitious character)");
            B.call_number.Add("839.7/3/74");

            // assign current book values to CardCatalog controls
            foreach (string name in B.authors)
            {
                lblAuthor.Text += name;
            }
            lblAuthor.Text += ", author.";
            lblTitle.Text = B.title + " / by " + B.authors[0];
            lblPublisherInfo.Text = B.publish_place + " : " + B.publisher + ", (" + B.publish_date + ")";
            lblPages.Text = B.pages + " pages";
        }


    }
}

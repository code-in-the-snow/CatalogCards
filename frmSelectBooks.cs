using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogCards
{
    public partial class frmSelectBooks : Form
    {        
        

        public frmSelectBooks()
        {
            InitializeComponent();
        }

        private void btnMakeCard_Click(object sender, EventArgs e)
        {
            // Check txtISBN.Text is 10 digits or 13 digits
            if (!(txtISBN.Text.Length == 10 || txtISBN.Text.Length == 13))
            {
                MessageBox.Show("An ISBN must be 10 or 13 digits.");
                return;
            }
            if (!txtISBN.Text.All(char.IsDigit))
            {
                MessageBox.Show("An ISBN contains only digits.");
                return;
            }

            // pass txtISBN to function GetAPIData()
            
            frmCatalogCard objCard = new frmCatalogCard();
            objCard.isbn = txtISBN.Text;
            objCard.Show();
        }
    }
}

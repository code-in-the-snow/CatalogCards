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
    public partial class frmSelectBooks : Form
    {
        public frmSelectBooks()
        {
            InitializeComponent();
        }

        private void btnMakeCard_Click(object sender, EventArgs e)
        {
            frmCatalogCard objCard = new frmCatalogCard();
            objCard.ShowDialog();
        }
    }
}

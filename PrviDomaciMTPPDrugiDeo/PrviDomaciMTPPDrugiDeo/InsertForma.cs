using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrviDomaciMTPPDrugiDeo
{
    public partial class InsertForma : Form
    {
        clsDataAccess x = new clsDataAccess();
        public InsertForma()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            x.InsertKlijenti(txtNaziv.Text, txtKontakt.Text, txtGrad.Text, txtZemlja.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 GlavnaForma = new Form1();
            GlavnaForma.Show();
            
        }
    }
}

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
    public partial class UpdateForma : Form
    {
        clsDataAccess x = new clsDataAccess();
        private int KlijentID;

        public UpdateForma(int Klijent)
        {
            InitializeComponent();
            txtNaziv.Text = x.InfoKlijenti(Klijent).Parameters["@Naziv"].Value.ToString();
            txtKontakt.Text = x.InfoKlijenti(Klijent).Parameters["@Kontakt"].Value.ToString();
            txtGrad.Text = x.InfoKlijenti(Klijent).Parameters["@Grad"].Value.ToString();
            txtZemlja.Text = x.InfoKlijenti(Klijent).Parameters["@Zemlja"].Value.ToString();
            this.KlijentID = Klijent;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            x.UpdateKlijenti(txtNaziv.Text, txtKontakt.Text, txtGrad.Text, txtZemlja.Text, this.KlijentID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 GlavnaForma = new Form1();
            GlavnaForma.Show();
        }
    }
}

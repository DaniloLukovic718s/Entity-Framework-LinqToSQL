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
    public partial class Form1 : Form
    {
        clsDataAccess x = new clsDataAccess();
        public Form1()
        {
            InitializeComponent();
            dgKlijenti.DataSource = x.SelectKlijenti();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertForma insertForma = new InsertForma();
            insertForma.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgKlijenti.DataSource = x.SelectKlijenti();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int KlijentID = 0;
            KlijentID = (int) dgKlijenti.SelectedRows[0].Cells[0].Value;
            x.DeleteKlijenti(KlijentID);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int KlijentID = 0;
            KlijentID = (int)dgKlijenti.SelectedRows[0].Cells[0].Value;
            this.Hide();
            UpdateForma updateForma = new UpdateForma(KlijentID);
            updateForma.ShowDialog();
        }
    }
}

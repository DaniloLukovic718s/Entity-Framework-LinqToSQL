using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrviDomaciMTPP
{
    public partial class Form1 : Form
    {
        DataTable dataKupac, dataFaktura, dataFakturaStavka;


        private void btnDodajKupca_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow kupac = dataKupac.NewRow();
                kupac["NazivKupca"] = txtNaziv.Text;
                kupac["Adresa"] = txtAdresa.Text;

                dataKupac.Rows.Add(kupac);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom dodavanja kupca - error: " + ex.ToString(), "Greška prilikom dodavanja kupca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodajFakturu_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow faktura = dataFaktura.NewRow();
                faktura["KupacID"] = Convert.ToInt32(cmbKupacFaktura.SelectedValue);
                faktura["Datum"] = Convert.ToDateTime(dtpFaktura.Value);

                dataFaktura.Rows.Add(faktura);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom dodavanja fakture - error: " + ex.ToString(), "Greška prilikom dodavanja fakture", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodajStavkuFakture_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow fakturaStavke = dataFakturaStavka.NewRow();
                fakturaStavke["NazivStavke"] = txtDodajNazivStavke.Text;
                fakturaStavke["CenaStavke"] = Convert.ToDecimal(txtDodajCenuStavke.Text);
                fakturaStavke["FakturaID"] = Convert.ToInt32(cmbFakturaFakturaStavke.SelectedValue);

                dataFakturaStavka.Rows.Add(fakturaStavke);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom dodavanja stavki fakture - error: " + ex.ToString(), "Greška prilikom dodavanja stavki fakture", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnConvertXML_Click(object sender, EventArgs e)
        {
            try
            {
                dataKupac.AcceptChanges();
                dataFaktura.AcceptChanges();
                dataFakturaStavka.AcceptChanges();
                placanje.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\XMLDomaci.xml", XmlWriteMode.WriteSchema);
                MessageBox.Show("Uspesno ste konvertovali podatke u XML");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom konvertovanja u XML - error: " + ex.ToString(), "Greška prilikom dodavanja konvertovanja u XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        DataSet placanje;

        public Form1()
        {
            InitializeComponent();
            dataKupac = new DataTable("DataKupac");
            dataFaktura = new DataTable("DataFaktura");
            dataFakturaStavka = new DataTable("DataFakturaStavka");
            placanje = new DataSet("Placanje");

            //----------------------------------------------------Tabela Kupac-------------------------------------------------------------------------------------------//
            try
            {
                DataColumn kupacID = new DataColumn("KupacID")
                {
                    DataType = typeof(int),
                    AutoIncrement = true,
                    AutoIncrementSeed = 1,
                    AutoIncrementStep = 1,
                    AllowDBNull = false
                };


                dataKupac.Columns.Add(kupacID);

                DataColumn nazivKupca = new DataColumn("NazivKupca")
                {
                    DataType = typeof(string),
                    MaxLength = 50,
                    AllowDBNull = false
                };

                dataKupac.Columns.Add(nazivKupca);

                DataColumn adresa = new DataColumn("Adresa")
                {
                    DataType = typeof(string),
                    MaxLength = 200,
                    AllowDBNull = true
                };

                dataKupac.Columns.Add(adresa);

                dataKupac.PrimaryKey = new DataColumn[]
                {
                kupacID
                };

                //----------------------------------------------------Tabela Faktura----------------------------------------------------------------------------------------//

                DataColumn fakturaID = new DataColumn("FakturaID")
                {
                    DataType = typeof(int),
                    AutoIncrement = true,
                    AutoIncrementSeed = 1,
                    AutoIncrementStep = 1,
                    AllowDBNull = false
                };

                dataFaktura.Columns.Add(fakturaID);

                DataColumn IDkupac = new DataColumn("KupacID")
                {
                    DataType = typeof(int),
                    AllowDBNull = false
                };

                dataFaktura.Columns.Add(IDkupac);

                DataColumn datum = new DataColumn("Datum")
                {
                    DataType = typeof(DateTime),
                    AllowDBNull = false,
                    DefaultValue = DateTime.Now
                };

                dataFaktura.Columns.Add(datum);


                dataFaktura.PrimaryKey = new DataColumn[]
                {
                fakturaID
                };

                //----------------------------------------------------Tabela Faktura Stavka---------------------------------------------------------------------------------//

                DataColumn IDfaktura = new DataColumn("FakturaID")
                {
                    DataType = typeof(int),
                    AllowDBNull = false
                };

                dataFakturaStavka.Columns.Add(IDfaktura);

                DataColumn nazivStavke = new DataColumn("NazivStavke")
                {
                    DataType = typeof(string),
                    MaxLength = 40,
                    AllowDBNull = false
                };

                dataFakturaStavka.Columns.Add(nazivStavke);

                DataColumn cenaStavke = new DataColumn("CenaStavke")
                {
                    DataType = typeof(decimal),
                    AllowDBNull = false
                };

                dataFakturaStavka.Columns.Add(cenaStavke);


                dataFakturaStavka.PrimaryKey = new DataColumn[]
                {
                IDfaktura, nazivStavke
                };

                //---------------------------------------------------Foreign keys/relacije/rules i dodavanje u dataset------------------------------------------------------//

                placanje.Tables.Add(dataKupac);
                placanje.Tables.Add(dataFaktura);
                placanje.Tables.Add(dataFakturaStavka);


                DataRelation relacijaKupacFaktura = new DataRelation("RelacijaKupacFaktura", dataKupac.Columns["KupacID"], dataFaktura.Columns["KupacID"], true);

                placanje.Relations.Add(relacijaKupacFaktura);

                DataRelation relacijaFakturaFakturaStavke = new DataRelation("RelacijaFakturaFakturaStavke", dataFaktura.Columns["FakturaID"], dataFakturaStavka.Columns["FakturaID"], true);

                placanje.Relations.Add(relacijaFakturaFakturaStavke);

                ForeignKeyConstraint FKKupacFaktura = (ForeignKeyConstraint)dataFaktura.Constraints["RelacijaKupacFaktura"];

                FKKupacFaktura.DeleteRule = Rule.None;
                FKKupacFaktura.UpdateRule = Rule.None;

                ForeignKeyConstraint FKFakturaFakturaStavke = (ForeignKeyConstraint)dataFakturaStavka.Constraints["RelacijaFakturaFakturaStavke"];

                FKFakturaFakturaStavke.DeleteRule = Rule.None;
                FKFakturaFakturaStavke.UpdateRule = Rule.None;

                dgKupac.DataSource = placanje.Tables["DataKupac"];
                dgFaktura.DataSource = placanje.Tables["DataFaktura"];
                dgFakturaStavka.DataSource = placanje.Tables["DataFakturaStavka"];

                cmbKupacFaktura.DataSource = dataKupac;
                cmbKupacFaktura.DisplayMember = "NazivKupca";
                cmbKupacFaktura.ValueMember = "KupacID";


                cmbFakturaFakturaStavke.DataSource = dataFaktura;
                cmbFakturaFakturaStavke.DisplayMember = "FakturaID";
                cmbFakturaFakturaStavke.ValueMember = "FakturaID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom pravljenja modela: " + ex.ToString());
            }
            

        }

    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrviDomaciMTPPDrugiDeo
{
    class clsDataAccess
    {
        private static string Konekcija = ConfigurationManager.ConnectionStrings["SQLBazaKonekcija"].ConnectionString;
        private SqlConnection cn = new SqlConnection(Konekcija);
        public DataTable SelectKlijenti()
        {
            int returnValue = 0;
            SqlCommand SelectNaredba = new SqlCommand()
            {
                Connection = cn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "dbo.SelectKlijenti"
            };
            SelectNaredba.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = SelectNaredba;
            DataSet klijent = new DataSet("Klijent");
            da.Fill(klijent);

            returnValue = (int)SelectNaredba.Parameters["@RETURN_VALUE"].Value;
            if (returnValue == 0)
            {
                return klijent.Tables[0];
            }
            else
            {
                MessageBox.Show("ERROR: " + returnValue.ToString());
                return klijent.Tables[0];
            }

        }

        public void InsertKlijenti(string Naziv, string Kontakt, string Grad, string Zemlja)
        {
            int returnValue = 0;
            SqlCommand InsertNaredba = new SqlCommand()
            {
                Connection = cn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "dbo.InsertKlijenti"
            };
            InsertNaredba.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));
            InsertNaredba.Parameters.AddWithValue("@Naziv", Naziv);
            InsertNaredba.Parameters.AddWithValue("@Kontakt", Kontakt);
            InsertNaredba.Parameters.AddWithValue("@Grad", Grad);
            InsertNaredba.Parameters.AddWithValue("@Zemlja", Zemlja);
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                InsertNaredba.ExecuteNonQuery();
                returnValue = (int)InsertNaredba.Parameters["@RETURN_VALUE"].Value;
                if (returnValue == 0)
                {
                    MessageBox.Show("Uspešno ste insertovali podatke");
                }
                else
                {
                    MessageBox.Show("ERROR: " + returnValue.ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void DeleteKlijenti(int KlijentId)
        {
            int returnValue = 0;
            SqlCommand DeleteNaredba = new SqlCommand()
            {
                Connection = cn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "dbo.DeleteKlijenti"
            };
            DeleteNaredba.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));
            DeleteNaredba.Parameters.AddWithValue("@KlijentId", KlijentId);
            DialogResult deleteProvera = MessageBox.Show("Da li ste sigurni da želite da obrišete klijenta?", "Brisanje klijenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteProvera == DialogResult.Yes)
            {
                try
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                    DeleteNaredba.ExecuteNonQuery();
                    returnValue = (int)DeleteNaredba.Parameters["@RETURN_VALUE"].Value;
                    if (returnValue == 0)
                    {
                        MessageBox.Show("Uspešno ste izbrisali podatke");
                    }
                    else
                    {
                        MessageBox.Show("ERROR: " + returnValue.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else if (deleteProvera == DialogResult.No)
            {
                return;
            }

        }

        public SqlCommand InfoKlijenti(int KlijentId)
        {
            int returnValue = 0;
            SqlCommand KlijentInfoNaredba = new SqlCommand()
            {
                Connection = cn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "dbo.UpdateKlijentiInfo"
            };
            KlijentInfoNaredba.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));
            KlijentInfoNaredba.Parameters.Add(new SqlParameter("@KlijentId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, KlijentId));
            KlijentInfoNaredba.Parameters.Add(new SqlParameter("@Naziv", SqlDbType.NVarChar, 40, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Current, ""));
            KlijentInfoNaredba.Parameters.Add(new SqlParameter("@Kontakt", SqlDbType.NVarChar, 30, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Current, ""));
            KlijentInfoNaredba.Parameters.Add(new SqlParameter("@Grad", SqlDbType.NVarChar, 15, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Current, ""));
            KlijentInfoNaredba.Parameters.Add(new SqlParameter("@Zemlja", SqlDbType.NVarChar, 15, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Current, ""));

            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                KlijentInfoNaredba.ExecuteNonQuery();
                returnValue = (int)KlijentInfoNaredba.Parameters["@RETURN_VALUE"].Value;
                cn.Close();
                return KlijentInfoNaredba;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            


        }

        public void UpdateKlijenti(string Naziv, string Kontakt, string Grad, string Zemlja, int KlijentID)
        {
            int returnValue = 0;
            SqlCommand UpdateNaredba = new SqlCommand()
            {
                Connection = cn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "dbo.UpdateKlijenti"
            };
            UpdateNaredba.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));
            UpdateNaredba.Parameters.AddWithValue("@KlijentId", KlijentID);
            UpdateNaredba.Parameters.AddWithValue("@Naziv", Naziv);
            UpdateNaredba.Parameters.AddWithValue("@Kontakt", Kontakt);
            UpdateNaredba.Parameters.AddWithValue("@Grad", Grad);
            UpdateNaredba.Parameters.AddWithValue("@Zemlja", Zemlja);
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                UpdateNaredba.ExecuteNonQuery();
                returnValue = (int)UpdateNaredba.Parameters["@RETURN_VALUE"].Value;
                if (returnValue == 0)
                {
                    MessageBox.Show("Uspešno ste izmenili podatke");
                }
                else
                {
                    MessageBox.Show("ERROR: " + returnValue.ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }



    }


}

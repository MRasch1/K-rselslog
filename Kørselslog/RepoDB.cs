using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kørselslog
{
    public class RepoDB
    {
        private bool _hasRows;
        //private SqlDataReader _sqlReader;
        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Visual Studio\Kørselslog\Kørselslog\DatabaseKørselslog.mdf;Integrated Security=True";
        public RepoDB()
        {

        }



        public int CreatePersonInPersonale(Personale personale)
        {
            int result = -1;


            // Open the connection.
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO stamdata (Navn,Dato) VALUES(@Navn,@Dato)";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@Navn", personale.Navn);
                        sqlCommand.Parameters.AddWithValue("@Dato", personale.Dato);
                        var antalgemteRækker = sqlCommand.ExecuteNonQuery();
                        result = antalgemteRækker;
                        conn.Close();
                    }
                }
                catch (Exception ex)//catch exeption
                {
                    conn.Close();
                    //displaying errors message.
                    MessageBox.Show(ex.Message);
                }
                return result;
            }
        }
        public List<Personale> Readall()
        {
            throw new NotImplementedException();
        }

        public int Update(Personale p)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int SELECTPersonInPersonale(Personale personale)
        {
            int result = -1;
            _hasRows = false;

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Navn, Dato FROM stamdata WHERE Person_ID = @Person_ID", con))
                {
                    sqlCommand.Parameters.AddWithValue("@Person_ID", personale.Id);
                    try
                    {
                        con.Open();
                        //var reader = sqlCommand.ExecuteReader();
                        // store a value locally indicating if the previous update has rows.   
                        _hasRows = sqlCommand.ExecuteReader().HasRows;
                        con.Close();
                    }
                    catch (Exception ex)//catch exeption
                    {
                        con.Close();
                        //displaying errors message.
                        MessageBox.Show(ex.Message);
                    }
                    return result;
                }
            }

        }

        public int UPDATEPersonInPersonale(Personale personale)
        {
            int result = -1;
            if (!_hasRows) return result;
            string sql = "UPDATE [stamdata] SET Navn = @Navn, Dato = @Dato WHERE Person_ID = @Person_ID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(sql, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@Navn", personale.OpdaterNavn);
                        sqlCommand.Parameters.AddWithValue("@Dato", personale.OpdaterDato);
                        sqlCommand.Parameters.AddWithValue("@Person_ID", personale.Id);
                        //cm.Parameters.AddWithValue("@OpdaterNavn", SqlDbType.VarChar).Value = personale.OpdaterNavn;
                        //cm.Parameters.AddWithValue("@OpdaterDato", SqlDbType.DateTime).Value = personale.OpdaterDato;
                        var antalgemteRækker = sqlCommand.ExecuteNonQuery();
                        result = antalgemteRækker;
                        // store a value locally indicating if the previous update has rows.   

                    }
                }
                catch (Exception ex)//catch exeption
                {
                    conn.Close();
                    //displaying errors message.
                    MessageBox.Show(ex.Message);
                }
            }
            return result;
        }
        public int CreateBilInBil(Bil bil)
        {
            int result = -1;
            // Open the connection.
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO Bildata (Navn,NrPlade,Dato) VALUES(@Navn,@NrPlade,@Dato)";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@Navn", bil.Navn);
                        sqlCommand.Parameters.AddWithValue("@NrPlade", bil.NrPlade);
                        sqlCommand.Parameters.AddWithValue("@Dato", bil.Dato);
                        var antalgemteRækker = sqlCommand.ExecuteNonQuery();
                        result = antalgemteRækker;
                        conn.Close();
                    }
                }
                catch (Exception ex)//catch exeption
                {
                    conn.Close();
                    //displaying errors message.
                    MessageBox.Show(ex.Message);
                }
                return result;
            }
        }
        public int SELECTBilInBil(Bil bil)
        {
            int result = -1;
            _hasRows = false;

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Navn, NrPlade, Dato FROM BilData WHERE Bil_ID = @Bil_ID", con))
                {
                    sqlCommand.Parameters.AddWithValue("@Bil_ID", bil.Id);
                    try
                    {
                        con.Open();
                        //var reader = sqlCommand.ExecuteReader();
                        // store a value locally indicating if the previous update has rows.   
                        _hasRows = sqlCommand.ExecuteReader().HasRows;
                        con.Close();
                    }
                    catch (Exception ex)//catch exeption
                    {
                        con.Close();
                        //displaying errors message.
                        MessageBox.Show(ex.Message);
                    }
                    return result;
                }
            }

        }
        public int UPDATEBilInBil(Bil bil)
        {
            int result = -1;
            if (!_hasRows) return result;
            string sql = "UPDATE [BilData] SET Navn = @BilNavn, Nrplade = @NrPlade, Dato = @Dato WHERE Bil_ID = @Bil_ID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(sql, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@BilNavn", bil.OpdaterNavn);
                        sqlCommand.Parameters.AddWithValue("@NrPlade", bil.OpdaterNrPlade);
                        sqlCommand.Parameters.AddWithValue("@Dato", bil.OpdaterDato);
                        sqlCommand.Parameters.AddWithValue("@Bil_ID", bil.Id);
                        //cm.Parameters.AddWithValue("@OpdaterNavn", SqlDbType.VarChar).Value = personale.OpdaterNavn;
                        //cm.Parameters.AddWithValue("@OpdaterDato", SqlDbType.DateTime).Value = personale.OpdaterDato;
                        var antalgemteRækker = sqlCommand.ExecuteNonQuery();
                        result = antalgemteRækker;
                        // store a value locally indicating if the previous update has rows.   

                    }
                }
                catch (Exception ex)//catch exeption
                {
                    conn.Close();
                    //displaying errors message.
                    MessageBox.Show(ex.Message);
                }
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kørselslog
{
    public class RepoDB
    {
        private SqlConnection _con = new SqlConnection();
        private SqlCommand _sql_command = new SqlCommand();
        private bool _hasRows;
        private string _sql;
        //private SqlDataReader _sqlReader;
        string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Visual Studio\Kørselslog\Kørselslog\DatabaseKørselslog.mdf;Integrated Security=True";
        public RepoDB()
        {
            _con.ConnectionString = _connectionString;
        }



        public int CreatePersonInPersonale(Personale personale)
        {
            int result = -1;
            try
            {
                // Open the connection.
                using (_con = new SqlConnection(_connectionString))
                {
                    _con.Open();
                    string sql = "INSERT INTO stamdata (Navn,Dato) VALUES(@Navn,@Dato)";

                    using (_sql_command = new SqlCommand(sql, _con))
                    {
                        _sql_command.Parameters.AddWithValue("@Navn", personale.Navn);
                        _sql_command.Parameters.AddWithValue("@Dato", personale.Dato);
                        var antalgemteRækker = _sql_command.ExecuteNonQuery();
                        result = antalgemteRækker;
                        _con.Close();
                    }
                }

            }
            catch (Exception ex)//catch exeption
            {
                _con.Close();
                //displaying errors message.
                MessageBox.Show(ex.Message);
            }
            return result;
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

            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                string commandText = "SELECT Navn FROM stamdata WHERE Navn = @Navn";

                try
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand(commandText, cn))
                    {
                        {
                            cm.Parameters.AddWithValue("@Navn", personale.Navn);
                            // store a value locally indicating if the previous update has rows.   
                            _hasRows = cm.ExecuteReader().HasRows;
                        }
                    }
                }
                catch (Exception ex)//catch exeption
                {
                    _con.Close();
                    //displaying errors message.
                    MessageBox.Show(ex.Message);
                }
                return result;
            }

        }

        public int UPDATEPersonInPersonale(Personale personale)
        {
            Form1 form1 = new Form1();
            show

            int result = -1;
            if (_hasRows)
            {
                _sql = "UPDATE [stamdata] SET Navn = @Navn, Dato = @Dato WHERE Navn = @Navn";
            }
            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand(_sql, cn))
                    {
                        _sql_command.Parameters.AddWithValue("@Navn", personale.OpdaterNavn);
                        _sql_command.Parameters.AddWithValue("@Dato", personale.OpdaterDato);
                        //cm.Parameters.AddWithValue("@OpdaterNavn", SqlDbType.VarChar).Value = personale.OpdaterNavn;
                        //cm.Parameters.AddWithValue("@OpdaterDato", SqlDbType.DateTime).Value = personale.OpdaterDato;
                        var antalgemteRækker = cm.ExecuteNonQuery();
                        result = antalgemteRækker;
                        // store a value locally indicating if the previous update has rows.   

                    }
                }
                catch (Exception ex)//catch exeption
                {
                    cn.Close();
                    //displaying errors message.
                    MessageBox.Show(ex.Message);
                }
            }
            return result;
        }



        public int CreateBilInBil(Bil bil)
        {
            int result = -1;
            try
            {
                // Open the connection.
                using (_con = new SqlConnection(_connectionString))
                {
                    _con.Open();
                    string sql = "INSERT INTO Bildata (Navn,Nrplade,Dato) VALUES(@Navn,@NrPlade,@Dato)";

                    using (_sql_command = new SqlCommand(sql, _con))
                    {
                        _sql_command.Parameters.AddWithValue("@Navn", bil.Navn);
                        _sql_command.Parameters.AddWithValue("@NrPlade", bil.NrPlade);
                        _sql_command.Parameters.AddWithValue("@Dato", bil.Dato);
                        var antalgemteRækker = _sql_command.ExecuteNonQuery();
                        result = antalgemteRækker;
                        _con.Close();
                    }

                }

            }
            catch (Exception ex)//catch exeption
            {
                _con.Close();
                //displaying errors message.
                MessageBox.Show(ex.Message);
            }

            return result;
        }


        public int InsertExcemple()
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Mem_Basic(Mem_Na,Mem_Occ) output INSERTED.ID VALUES(@na,@occ)", _con))
            {
                //cmd.Parameters.AddWithValue("@na", Mem_NA);
                //cmd.Parameters.AddWithValue("@occ", Mem_Occ);
                //con.Open();

                //int modified = (int)cmd.ExecuteScalar();

                //if (con.State == System.Data.ConnectionState.Open)
                //    con.Close();

                //return modified;
                return -1;
            }
        }
    }

}

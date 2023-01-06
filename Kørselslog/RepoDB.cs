using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kørselslog
{
    public class RepoDB
    {
        private SqlConnection _con = new SqlConnection();
        private SqlCommand _sql_command = new SqlCommand();
        string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Visual Studio\Kørselslog\Kørselslog\DatabaseKørselslog.mdf;Integrated Security=True";
        public RepoDB()
        {
            _con.ConnectionString = _connectionString;
        }



        public int CreatePersonInPersonle(Personale personale)
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

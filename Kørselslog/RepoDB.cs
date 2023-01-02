using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kørselslog
{
    public class RepoDB
    {
        SqlConnection con = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        public RepoDB()
        {
            //bridge between sql server to c#
            con.ConnectionString = "Data Source = tecstudentserver.database.windows.net; Database=Personale; User ID = serveradmin; Password = Passw0rd; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        }

   
        public int CreatePersonInPersonla(Personale personale)
        {
            int result = -1; 
            try
            {
                //opening connection
                con.Open();
                //create an insert query;
                string sql = "INSERT INTO stamdata (Navn,Dato,[Nr.Plade]) VALUES('" + personale.Navn + "','" + personale.Dato.DayOfYear + "','" + personale.NrPlade + "')";
                //initialize a new instance of sqlcommand
                sql_command = new SqlCommand();
                //set a connection used by this instance of sqlcommand
                sql_command.Connection = con;
                //set the sql statement to execute at the data source
                sql_command.CommandText = sql;
                //execute the data.
                result = (int) sql_command.ExecuteNonQuery();
                //validate the result of the executed query.
                if (result > 0)
                {
                    MessageBox.Show("Data has been saved in the SQL database");
                }
                else
                {
                    MessageBox.Show("SQL QUERY ERROR");
                }
                //closing connection
                con.Close();

            }
            catch (Exception ex)//catch exeption
            {
                con.Close();
                //displaying errors message.
                MessageBox.Show(ex.Message);
            }

            return -1;
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
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Mem_Basic(Mem_Na,Mem_Occ) output INSERTED.ID VALUES(@na,@occ)", con))
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            using (var conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO stamdata (Navn,Dato) VALUES(@Navn,@Dato)";

                    using (var sqlCommand = new SqlCommand(sql, conn))
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

        public int CreateLogInLog(Log log)
        {
            int result = -1;

            // Open the connection.
            using (var conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO LogData (Navn,Dato,NrPlade,Tur) VALUES(@Navn,@Dato,@NrPlade,@Tur)";

                    using (var sqlCommand = new SqlCommand(sql, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@Navn", log.Navn);
                        sqlCommand.Parameters.AddWithValue("@Dato", log.Dato);
                        sqlCommand.Parameters.AddWithValue("@NrPlade", log.NrPlade);
                        sqlCommand.Parameters.AddWithValue("@Tur", log.Tur);
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

        public Personale SELECTPersonInPersonaleById(int id)
        {
            List<Personale> result = new List<Personale>();
            Personale person = new Personale();

            using (var con = new SqlConnection(_connectionString))
            {
                using (var sqlCommand = new SqlCommand("SELECT Person_ID, Navn, Dato FROM stamdata WHERE Person_ID = @Person_ID", con))
                {
                    sqlCommand.Parameters.AddWithValue("@Person_ID", id);
                    try
                    {
                        con.Open();
                        var reader = sqlCommand.ExecuteReader();
                        // store a value locally indicating if the previous update has rows.   
                        
                        while (reader.Read())
                        {
                            person.Id = reader.GetInt32(0);
                            person.Navn = reader.GetString(1);
                            person.Dato = reader.GetDateTime(2);
                        }
                        con.Close();
                    }
                    catch (Exception ex)//catch exeption
                    {
                        con.Close();
                        //displaying errors message.
                        MessageBox.Show(ex.Message);
                    }
                    return person;
                }
            }
        }

        public int UPDATEPersonInPersonale(Personale personale)
        {
            int result = -1;

            if (SELECTPersonInPersonaleById(personale.Id) == null) return result;

            string sql = "UPDATE [stamdata] SET Navn = @Navn, Dato = @Dato WHERE Person_ID = @Person_ID";

            using (var conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    using (var sqlCommand = new SqlCommand(sql, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@Navn", personale.OpdaterNavn);
                        sqlCommand.Parameters.AddWithValue("@Dato", personale.OpdaterDato);
                        sqlCommand.Parameters.AddWithValue("@Person_ID", personale.Id);
                        sqlCommand.Parameters.AddWithValue("@OpdaterNavn", SqlDbType.VarChar).Value = personale.OpdaterNavn;
                        sqlCommand.Parameters.AddWithValue("@OpdaterDato", SqlDbType.DateTime).Value = personale.OpdaterDato;
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
        public DataTable GetPersonDataTable()
        {
            SqlDataAdapter dataAdapter = null;
            DataTable dataTable = null;

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var _dataSet = new DataSet();

                using (var _cmd = new SqlCommand("select * from stamdata", conn))
                {
                    dataAdapter = new SqlDataAdapter(_cmd);
                    int numberOFRowsAddedToDataSet = dataAdapter.Fill(_dataSet, "StamTable");
                }

                dataTable = _dataSet.Tables["StamTable"];
                conn.Close();
            }
            return dataTable;
        }

        public DataTable GetAllPersonsFromStamdataTable_For_DeletePersonById()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Person_ID, Navn, Dato FROM stamdata", conn))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public void DeletePersonById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM stamdata WHERE Person_ID = @Person_ID", conn))
                {
                    sqlCommand.Parameters.AddWithValue("Person_ID", id);

                    conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public int CreateBilInBil(Bil bil)
        {
            int result = -1;
            // Open the connection.
            using (var conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO Bildata (Navn,NrPlade,Dato) VALUES(@Navn,@NrPlade,@Dato)";

                    using (var sqlCommand = new SqlCommand(sql, conn))
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

            using (var con = new SqlConnection(_connectionString))
            {
                using (var sqlCommand = new SqlCommand("SELECT Navn, NrPlade, Dato FROM BilData WHERE Bil_ID = @Bil_ID", con))
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

            using (var conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    using (var sqlCommand = new SqlCommand(sql, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@BilNavn", bil.OpdaterNavn);
                        sqlCommand.Parameters.AddWithValue("@NrPlade", bil.OpdaterNrPlade);
                        sqlCommand.Parameters.AddWithValue("@Dato", bil.OpdaterDato);
                        sqlCommand.Parameters.AddWithValue("@Bil_ID", bil.Id);
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
        public DataTable GetBilDataTable()
        {
            SqlDataAdapter dataAdapter = null;
            DataTable dataTable = null;

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var _dataSet = new DataSet();

                using (var _cmd = new SqlCommand("select * from BilData", conn))
                {
                    dataAdapter = new SqlDataAdapter(_cmd);
                    int numberOFRowsAddedToDataSet = dataAdapter.Fill(_dataSet, "StamTable");
                }

                dataTable = _dataSet.Tables["StamTable"];
                conn.Close();
            }
            return dataTable;
        }

        public DataTable GetAllBilerFromStamdataTable()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Bil_ID, Navn, NrPlade, Dato FROM BilData", conn))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public void DeleteBilById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM BilData WHERE Bil_ID = @Bil_ID", conn))
                {
                    sqlCommand.Parameters.AddWithValue("Bil_ID", id);

                    conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public DataTable GetLogDataTable()
        {
            SqlDataAdapter dataAdapter = null;
            DataTable dataTable = null;

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var _dataSet = new DataSet();

                using (var _cmd = new SqlCommand("select * from LogData", conn))
                {
                    dataAdapter = new SqlDataAdapter(_cmd);
                    int numberOFRowsAddedToDataSet = dataAdapter.Fill(_dataSet, "StamTable");
                }

                dataTable = _dataSet.Tables["StamTable"];
                conn.Close();
            }
            return dataTable;
        }

        public void DeleteLogById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM LogData WHERE Log_ID = @Log_ID", conn))
                {
                    sqlCommand.Parameters.AddWithValue("Log_ID", id);

                    conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public DataTable GetAllLogFromLogDataTable_For_DeleteLogById()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Log_ID, Navn, Dato, NrPlade, Tur FROM LogData", conn))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        /// <summary>
        /// <b>Returns</b> Returns true if a row is deleted
        /// </summary>
        /// <param name="id"></param>
        /// <returns ></returns>
        public bool DeletePerson(int id)
        {
            int lines = -1;

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM stamdata WHERE Person_ID = @Id", conn))
                {
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    lines = sqlCommand.ExecuteNonQuery();
                }
            }

            return lines > 0;
        }
    }

}

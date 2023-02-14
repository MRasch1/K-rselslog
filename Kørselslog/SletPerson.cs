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
    public partial class SletPerson : Form
    {
        RepoDB _repo;
        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Visual Studio\Kørselslog\Kørselslog\DatabaseKørselslog.mdf;Integrated Security=True";

        public SletPerson()
        {
            InitializeComponent();
        }

        private void SletPerson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseKørselslogDataSet.stamdata' table. You can move, or remove it, as needed.
            this.stamdataTableAdapter.Fill(this.databaseKørselslogDataSet.stamdata);

            load_data();
        }

        private void load_data()
        {
            dataGridView2.Columns.Clear();
            using(SqlConnection conn = new SqlConnection(_connectionString))
            {
                using(SqlCommand sqlCommand = new SqlCommand("SELECT Person_ID, Navn, Dato FROM stamdata", conn))
                {
                    using(SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        using(DataTable dataTable = new DataTable())
                        {
                            dataAdapter.Fill(dataTable);
                            dataGridView2.DataSource = dataTable;
                        }
                    }
                }
            }
            dataGridView2.AllowUserToAddRows = false;
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            dataGridView2.Columns.Insert(3, buttonColumn);
            buttonColumn.HeaderText = "Delete Row";
            buttonColumn.Width = 100;
            buttonColumn.Text = "Delete";
            buttonColumn.UseColumnTextForButtonValue = true;
        }

        private void button1_Slet_Click(object sender, EventArgs e)
        {
            
        }

        

    }
}

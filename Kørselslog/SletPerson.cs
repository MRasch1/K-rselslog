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
            //dataGridView2.Columns.Clear();
            dataGridView2.DataSource = GetAllPersonsFromStamdataTable();

            dataGridView2.AllowUserToAddRows = false;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

            dataGridView2.Columns.Insert(3, buttonColumn);
            buttonColumn.HeaderText = "Delete Row";
            buttonColumn.Width = 100;
            buttonColumn.Text = "Delete";
            buttonColumn.UseColumnTextForButtonValue = true;
        }

        private DataTable GetAllPersonsFromStamdataTable()
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                DataGridView grid = (DataGridView)sender;
                if (grid == null) return;

                //var p = (Personale) grid.CurrentRow.DataBoundItem;
                int id = (int)grid.CurrentRow.Cells[0].Value;

                if (MessageBox.Show(string.Format("Do you want to delete this row?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeletePersonById(id);
                    load_data();
                }
            }
        }

        private void DeletePersonById(int id)
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

        private void button1_Slet_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

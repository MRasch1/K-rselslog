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
    public partial class SletBil : Form
    {
        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Visual Studio\Kørselslog\Kørselslog\DatabaseKørselslog.mdf;Integrated Security=True";

        public SletBil()
        {
            InitializeComponent();
        }

        private void SletBil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseKørselslogDataSet.BilData' table. You can move, or remove it, as needed.
            this.bilDataTableAdapter.Fill(this.databaseKørselslogDataSet.BilData);

            load_data();
        }

        private void load_data()
        {
            //dataGridView2.Columns.Clear();
            dataGridView3.DataSource = GetAllBilerFromStamdataTable();

            dataGridView3.AllowUserToAddRows = false;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

            dataGridView3.Columns.Insert(4, buttonColumn);
            buttonColumn.HeaderText = "Delete Row";
            buttonColumn.Width = 100;
            buttonColumn.Text = "Delete";
            buttonColumn.UseColumnTextForButtonValue = true;
        }

        private DataTable GetAllBilerFromStamdataTable()
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

        private void dataGridView3_SletBil(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];

                DataGridView grid = (DataGridView)sender;
                if (grid == null) return;

                //var p = (Personale) grid.CurrentRow.DataBoundItem;
                int id = (int)grid.CurrentRow.Cells[0].Value;

                if (MessageBox.Show(string.Format("Do you want to delete this row?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteBilById(id);
                    load_data();
                }
            }
        }

        private void DeleteBilById(int id)
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
    }
}

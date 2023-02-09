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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Slet_Click(object sender, EventArgs e)
        {
            RefreshGridView();
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM stamdata WHERE Person_ID =@Index", conn);
                    sqlCommand.Parameters.AddWithValue("@Index", item.Index);
                    int i = sqlCommand.ExecuteNonQuery();

                    if (i != 0)
                    {
                        dataGridView2.Rows.RemoveAt(item.Index);
                        MessageBox.Show("Delete Successful!", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Delete Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                    }
                }
            }
            RefreshGridView();
        }

        private void RefreshGridView()
        {
            if (dataGridView2.InvokeRequired)
            {
                dataGridView2.Invoke((MethodInvoker)delegate ()
                {
                    RefreshGridView();
                });
            }
            else
                dataGridView2.Refresh();
        }

        private void SletPerson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseKørselslogDataSet.stamdata' table. You can move, or remove it, as needed.
            this.stamdataTableAdapter.Fill(this.databaseKørselslogDataSet.stamdata);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

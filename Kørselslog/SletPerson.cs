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

        }

        private void button1_Slet_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                var succes = new RepoDB().DeletePerson((item.DataBoundItem as Personale).Id);

                if (succes)
                {
                    dataGridView2.Rows.RemoveAt(item.Index);
                    MessageBox.Show("Delete Successful!", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Delete Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private List<string> GetUsers()
        {
            List<string> users = null; /*new RepoDB().SelectPersonInPersonale();*/
            BindingSource source = new BindingSource();
            source.DataSource = users;
            dataGridView2.DataSource = source;

            users = GetUsers();
            source.ResetBindings(false);

            return users;
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
            {
                dataGridView2.Refresh();
            }
        }




    }
}

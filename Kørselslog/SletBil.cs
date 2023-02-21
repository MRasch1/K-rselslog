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
        RepoDB _repo;
        int _tæller = 0;

        public SletBil()
        {
            InitializeComponent();
            _repo = new RepoDB();
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
            dataGridView3.DataSource = _repo.GetAllBilerFromStamdataTable();

            dataGridView3.AllowUserToAddRows = false;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

            if (_tæller == 0)
            {
            dataGridView3.Columns.Insert(4, buttonColumn);
            buttonColumn.HeaderText = "Delete Row";
            buttonColumn.Width = 100;
            buttonColumn.Text = "Delete";
            buttonColumn.UseColumnTextForButtonValue = true;
            }
            else
            {

            }
            _tæller++;
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
                    _repo.DeleteBilById(id);
                    load_data();
                }
            }
        }
    }
}

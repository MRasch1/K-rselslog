﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kørselslog
{
    public partial class SletLog : Form
    {
        RepoDB _repo;
        int _tæller = 0;

        public SletLog()
        {
            InitializeComponent();
            _repo = new RepoDB();
        }

        private void SletLog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseKørselslogDataSet.LogData' table. You can move, or remove it, as needed.
            this.logDataTableAdapter.Fill(this.databaseKørselslogDataSet.LogData);

            load_data();
        }

        private void load_data()
        {
            //dataGridView2.Columns.Clear();
            dataGridView2.DataSource = _repo.GetAllLogFromLogDataTable_For_DeleteLogById();

            dataGridView2.AllowUserToAddRows = false;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

            if (_tæller == 0)
            {
            dataGridView2.Columns.Insert(5, buttonColumn);
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                DataGridView grid = (DataGridView)sender;
                if (grid == null) return;

                //var p = (Personale) grid.CurrentRow.DataBoundItem;
                int id = (int)grid.CurrentRow.Cells[0].Value;

                if (MessageBox.Show(string.Format("Do you want to delete this row?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _repo.DeleteLogById(id);
                    load_data();
                }
            }
        }
    }
}

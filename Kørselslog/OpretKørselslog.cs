using System;
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
    public partial class OpretKørselslog : Form
    {
        RepoDB _repo;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            GetNewDataSetLog();
        }        

        public OpretKørselslog()
        {
            InitializeComponent();
            _repo = new RepoDB();
        }

        private void button7_SaveLog_Click(object sender, EventArgs e)
        {
            var L = new Log() { Navn = comboBox3.Text, Dato = DateTime.Parse(dateTimePicker2.Text), NrPlade = comboBox1.Text, Tur = textBox8.Text };
            int id = _repo.CreateLogInLog(L);
            GetNewDataSetLog();
            listView1.Refresh();
        }

        private void OpretKørselslog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseKørselslogDataSet.BilData' table. You can move, or remove it, as needed.
            this.bilDataTableAdapter.Fill(this.databaseKørselslogDataSet.BilData);
            // TODO: This line of code loads data into the 'databaseKørselslogDataSet.stamdata' table. You can move, or remove it, as needed.
            this.stamdataTableAdapter.Fill(this.databaseKørselslogDataSet.stamdata);
        }

        private void GetNewDataSetLog()
        {
            listView1.Clear();
            listView1.Columns.Add("Log_ID", 55, HorizontalAlignment.Left);
            listView1.Columns.Add("Navn", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Dato", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("NrPlade", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Tur", 110, HorizontalAlignment.Center);
            listView1.View = View.Details;

            var dataTable = _repo.GetLogDataTable();

            for (int i = 0; i <= dataTable.Rows.Count - 1; i++)
            {
                listView1.Items.Add(dataTable.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[3].ToString());
                listView1.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[4].ToString());
            }
        }
    }
}

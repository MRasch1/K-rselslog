using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kørselslog
{
    public partial class Form3 : Form
    {
        RepoDB _repo;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            GetNewDataSetBil();
        }

        public Form3()
        {
            InitializeComponent();
            _repo = new RepoDB();
        }

        private void button2_Update_Click(object sender, EventArgs e)
        {
            var b = new Bil() { Id = int.Parse(textBox1.Text), OpdaterNavn = textBox2.Text, OpdaterNrPlade = textBox3.Text, OpdaterDato = DateTime.Parse(dateTimePicker2.Text) };
            int id = _repo.SELECTBilInBil(b);
            _repo.UPDATEBilInBil(b);
            GetNewDataSetBil();
        }

        private void GetNewDataSetBil()
        {
            listView1.Clear();
            listView1.Columns.Add("Bil_ID", 55, HorizontalAlignment.Left);
            listView1.Columns.Add("Navn", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("NrPlade", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Dato", 80, HorizontalAlignment.Center);
            listView1.View = View.Details;

            var dataTable = _repo.GetBilDataTable();

            for (int i = 0; i <= dataTable.Rows.Count - 1; i++)
            {
                listView1.Items.Add(dataTable.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[3].ToString());
            }
        }
    }
}

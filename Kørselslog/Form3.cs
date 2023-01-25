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
        private SqlConnection _con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Visual Studio\Kørselslog\Kørselslog\DatabaseKørselslog.mdf;Integrated Security=True");
        string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Visual Studio\Kørselslog\Kørselslog\DatabaseKørselslog.mdf;Integrated Security=True";
        private SqlCommand _cmd;
        private DataTable _dataTable;
        private SqlDataAdapter _dataAdapter;
        private DataSet _dataSet;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.button1_Form3_ShowBil_Click(null, null);

        }

        public Form3()
        {
            InitializeComponent();
            _repo = new RepoDB();
            _con.ConnectionString = _connectionString;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Update_Click(object sender, EventArgs e)
        {
            var b = new Bil() { Id = int.Parse(textBox1.Text), OpdaterNavn = textBox2.Text, OpdaterNrPlade = textBox3.Text, OpdaterDato = DateTime.Parse(dateTimePicker2.Text) };
            int id = _repo.SELECTBilInBil(b);
            _repo.UPDATEBilInBil(b);
            this.button1_Form3_ShowBil_Click(null, null);
        }

        private void button1_Form3_ShowBil_Click(object sender, EventArgs e)
        {
            this.button1.Hide();

            _con.Open(); listView1.Clear(); _con.Close();

            listView1.Columns.Add("Bil_ID", 55, HorizontalAlignment.Left);
            listView1.Columns.Add("Navn", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("NrPlade", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Dato", 80, HorizontalAlignment.Center);
            listView1.View = View.Details;

            _con.Open();
            _cmd = new SqlCommand("select * from Bildata", _con);
            _dataAdapter = new SqlDataAdapter(_cmd);
            _dataSet = new DataSet();
            _dataAdapter.Fill(_dataSet, "StamTable");
            _con.Close();

            _dataTable = _dataSet.Tables["StamTable"];

            for (int i = 0; i <= _dataTable.Rows.Count - 1; i++)
            {
                listView1.Items.Add(_dataTable.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(_dataTable.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(_dataTable.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(_dataTable.Rows[i].ItemArray[3].ToString());
            }
        }

        private void RedigerStamdata_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

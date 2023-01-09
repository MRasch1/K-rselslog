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
    public partial class Form1 : Form
    {
        RepoDB _repo;
        private SqlConnection _con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Visual Studio\Kørselslog\Kørselslog\DatabaseKørselslog.mdf;Integrated Security=True");
        private SqlCommand _cmd;
        private DataTable _dataTable;
        private SqlDataAdapter _dataAdapter;
        private DataSet _dataSet;
        

        public Form1()
        {
            InitializeComponent();
            _repo = new RepoDB();
        }

        private void button2_Save_Click(object sender, EventArgs e)
        {
            DatabaseKørselslogDataSetTableAdapters.stamdataTableAdapter DataSetAdapter = new DatabaseKørselslogDataSetTableAdapters.stamdataTableAdapter();

            //udfylder textboksen hvis ingen text - altså ved string.Empty
            //textBox3.Text = textBox3.Text != string.Empty ? textBox3.Text : "BR12365";
            dateTimePicker1.Text = dateTimePicker1.Text != string.Empty ? dateTimePicker1.Text : "2001/10/12";
            textBox1.Text = textBox1.Text != string.Empty ? textBox1.Text : "Mathias";

            var p = new Personale() { Navn = textBox1.Text, /*NrPlade = textBox3.Text,*/ Dato = (DateTime.Parse(dateTimePicker1.Text)) };
            int id = _repo.CreatePersonInPersonle(p);
        }

        private void button9_Save_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text != string.Empty ? textBox3.Text : "Grøn bil";
            dateTimePicker3.Text = dateTimePicker3.Text != string.Empty ? dateTimePicker3.Text : "1998/10/5";
            textBox5.Text = textBox5.Text != string.Empty ? textBox5.Text : "HKWTF";

            var p = new Bil() { Navn = textBox3.Text, Dato = DateTime.Parse(dateTimePicker3.Text), NrPlade = textBox5.Text };
            int id = _repo.CreateBilInBil(p);
        }

        private void button4_show_Person_Click(object sender, EventArgs e)
        {
            _con.Open(); listView1.Clear(); _con.Close();

            listView1.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("Navn", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Dato", 80, HorizontalAlignment.Center);
            listView1.View = View.Details;

            _con.Open();
            _cmd = new SqlCommand("select * from stamdata", _con);
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
            }
        }

        private void button11_show_Bil_Click(object sender, EventArgs e)
        {
            _con.Open(); listView1.Clear(); _con.Close();

            listView1.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("Navn", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("NrPlade", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("Dato", 80, HorizontalAlignment.Center);
            listView1.View = View.Details;

            _con.Open();
            _cmd = new SqlCommand("select * from BilData", _con);
            _dataAdapter = new SqlDataAdapter(_cmd);
            _dataSet = new DataSet();
            _dataAdapter.Fill(_dataSet, "testTable");
            _con.Close();

            _dataTable = _dataSet.Tables["testTable"];

            for (int i = 0; i <= _dataTable.Rows.Count - 1; i++)
            {
                listView1.Items.Add(_dataTable.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(_dataTable.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(_dataTable.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(_dataTable.Rows[i].ItemArray[3].ToString());
            }



        }

        private void ClearListView1(object sender, EventArgs e)
        {
            _con.Open();
            listView1.Clear();
            _con.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BoxForShowData(object sender, EventArgs e)
        {
            

            
        }

        private void ShowDataBox(object sender, EventArgs e)
        {

            //int id = _repo.PullDataFromBilData
        }

        private void button3_Save_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void OpretStamdata_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}

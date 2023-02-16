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
    public partial class KørselslogForside : Form
    {
        RepoDB _repo;

        public KørselslogForside()
        {
            InitializeComponent();
            _repo = new RepoDB();
        }

        private void button2_Save_Click(object sender, EventArgs e)
        {
            DatabaseKørselslogDataSetTableAdapters.stamdataTableAdapter DataSetAdapter = new DatabaseKørselslogDataSetTableAdapters.stamdataTableAdapter();

            //udfylder textboksen hvis ingen text - altså ved string.Empty            
            dateTimePicker1.Text = dateTimePicker1.Text != string.Empty ? dateTimePicker1.Text : "2001/10/12";
            textBox1.Text = textBox1.Text != string.Empty ? textBox1.Text : "Mathias";

            var p = new Personale() { Navn = textBox1.Text, Dato = DateTime.Parse(dateTimePicker1.Text) };
            int id = _repo.CreatePersonInPersonale(p);
        }

        private void button9_Save_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text != string.Empty ? textBox3.Text : "Grøn bil";
            dateTimePicker3.Text = dateTimePicker3.Text != string.Empty ? dateTimePicker3.Text : "1998/10/5";
            textBox5.Text = textBox5.Text != string.Empty ? textBox5.Text : "HKWTF";

            var p = new Bil() { Navn = textBox3.Text, Dato = DateTime.Parse(dateTimePicker3.Text), NrPlade = textBox5.Text };
            int id = _repo.CreateBilInBil(p);

        }

        private void ShowPersonClick_Form1(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.Columns.Add("Person_ID", 90, HorizontalAlignment.Left);
            listView1.Columns.Add("Navn", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Dato", 80, HorizontalAlignment.Center);
            listView1.View = View.Details;

            var dataTable = _repo.GetPersonDataTable();

            for (int i = 0; i <= dataTable.Rows.Count - 1; i++)
            {
                listView1.Items.Add(dataTable.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[2].ToString());
            }
        }

        private void button11_show_Bil_Click(object sender, EventArgs e)
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

        private void button15__show_Log_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.Columns.Add("Log_ID", 55, HorizontalAlignment.Left);
            listView1.Columns.Add("Navn", 55, HorizontalAlignment.Left);
            listView1.Columns.Add("Dato", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("NrPlade", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Tur", 80, HorizontalAlignment.Center);
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

        private void ClearListView1(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void KørselslogForside_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseKørselslogDataSet.BilData' table. You can move, or remove it, as needed.
            this.bilDataTableAdapter.Fill(this.databaseKørselslogDataSet.BilData);
            // TODO: This line of code loads data into the 'databaseKørselslogDataSet.stamdata' table. You can move, or remove it, as needed.
            this.stamdataTableAdapter.Fill(this.databaseKørselslogDataSet.stamdata);

        }

        private void button7_Save_Kørselslog(object sender, EventArgs e)
        {
            var L = new Log() { Navn = comboBox3.Text, Dato = DateTime.Parse(dateTimePicker2.Text), NrPlade = comboBox1.Text, Tur = textBox8.Text };
            int id = _repo.CreateLogInLog(L);
        }

        private void button12_RedigerPerson_Click(object sender, EventArgs e)
        {
            RedigerPerson form2 = new RedigerPerson();
            form2.ShowDialog();
        }

        private void button13_RedigerBil_Click(object sender, EventArgs e)
        {
            RedigerBil form3 = new RedigerBil();
            form3.ShowDialog();
        }
        private void button5_SletPerson_Click(object sender, EventArgs e)
        {
            SletPerson sletPerson = new SletPerson();
            sletPerson.ShowDialog();
        }

        private void button6_SletBil_Click(object sender, EventArgs e)
        {
            SletBil sletBil = new SletBil();
            sletBil.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_refresh_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}

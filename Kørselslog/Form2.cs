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
    public partial class Form2 : Form
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
            GetNewDataSetDriver();
        }



        public Form2()
        {
            InitializeComponent();
            _repo = new RepoDB();
            _con.ConnectionString = _connectionString;            
        }

        private void button1_Update_Click(object sender, EventArgs e)
        {
            var p = new Personale() {Id = int.Parse(textBox1.Text), OpdaterNavn = textBox2.Text, OpdaterDato = DateTime.Parse(dateTimePicker2.Text)};
            int id = _repo.SELECTPersonInPersonale(p);
            _repo.UPDATEPersonInPersonale(p);
            //this.button1_form2_Click(null, null);
            GetNewDataSetDriver();


            //// Sørger for at programmet ikke acceptere intet input fra bruger.
            //if (p.OpdaterNavn == "" || p.OpdaterDato == DateTime.Now)
            //{
            //    // Pop up fejlmeddelelse.
            //    MessageBox.Show("Alle felter skal udfyldes");
            //}
            //else
            //{
            //    _con.Open();

            //    // Executer stored procedure SQL command som opdatere dataen.
            //    SqlCommand cmd = new SqlCommand("EXEC UpdateData '" + p.OpdaterNavn + "','" + p.OpdaterDato + "'", _con);
            //    cmd.ExecuteNonQuery();

            //    // Pop up for at fortælle brugeren at dataen er blevet opdateret.
            //    MessageBox.Show("Data opdateret");
            //    _con.Close();
            //}


        }

        private void GetNewDataSetDriver()
        {
            var dataTable = GetDriverDataTable();

            for (int i = 0; i <= dataTable.Rows.Count - 1; i++)
            {
                listView1.Items.Add(dataTable.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[2].ToString());
            }
        }

        private DataTable GetDriverDataTable()
        {
            _con.Open(); listView1.Clear(); _con.Close();

            listView1.Columns.Add("Person_ID", 90, HorizontalAlignment.Left);
            listView1.Columns.Add("Navn", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Dato", 80, HorizontalAlignment.Center);
            listView1.View = View.Details;

            _con.Open();
            _cmd = new SqlCommand("select * from stamdata", _con);
            _dataAdapter = new SqlDataAdapter(_cmd);
            _dataSet = new DataSet();
            int numberOFRowsAddedToDataSet = _dataAdapter.Fill(_dataSet, "StamTable");
            _con.Close();


            DataTable dataTable = _dataSet.Tables["StamTable"];

            return dataTable;
        }

        private void listView1_form2_ShowPersoner(object sender, EventArgs e)
        {
            
        }

        public List<Personale> Readall()
        {
            throw new NotImplementedException();
        }

        public int Update(Personale p)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_form2(object sender, EventArgs e)
        {
             
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private int UpdatePersonInPerson(Personale p)
        {
            throw new NotImplementedException();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void RedigerStamdata_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        internal void textBox1_TextChanged()
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

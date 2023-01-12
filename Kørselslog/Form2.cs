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
        private SqlCommand _cmd;
        private DataTable _dataTable;
        private SqlDataAdapter _dataAdapter;
        private DataSet _dataSet;
        private SqlDataReader _sqlReader;
        string _sqlQuery;


        public Form2()
        {
            InitializeComponent();
            _repo = new RepoDB();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Update_Click(object sender, EventArgs e)
        {
            //_con.Open();
            //_sqlQuery = "UPDATE [stamdata] SET [Navn] ='" + textBox1.Text + "'Where [Navn] ='" + textBox2.Text + "'";
            ////sqlQuery = "INSERT INTO [User] ([Name], [NrPlade]) VALUES(" + "'" + textBox2.Text + "'" + ", " + "'" + textBox3.Text + "'" + ")";

            //_cmd = new SqlCommand(_sqlQuery, _con);
            //_sqlReader = _cmd.ExecuteReader();
            //_con.Close();


            //DatabaseKørselslogDataSetTableAdapters.stamdataTableAdapter DataSetAdapter = new DatabaseKørselslogDataSetTableAdapters.stamdataTableAdapter();

            _sqlQuery = "UPDATE [stamdata] SET [Navn, Dato] ='" + textBox1.Text + "'Where [Navn] ='" + textBox2.Text + "'" + dateTimePicker1.Text + "'Where[Dato] = '" + dateTimePicker2.Text + "'";

            var p = new Personale();
            int id = _repo.UpdatePersonInPersonale(p);
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
    }
}

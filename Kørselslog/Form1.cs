﻿using System;
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
    }
}

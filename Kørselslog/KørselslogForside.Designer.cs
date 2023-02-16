using System;

namespace Kørselslog
{
    partial class KørselslogForside
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KørselslogForside));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OpretStamdata = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.RedigerStamdata = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SletStamdata = new System.Windows.Forms.Label();
            this.PersonaleData = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bilDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseKørselslogDataSet = new Kørselslog.DatabaseKørselslogDataSet();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.stamdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label14 = new System.Windows.Forms.Label();
            this.stamdataTableAdapter = new Kørselslog.DatabaseKørselslogDataSetTableAdapters.stamdataTableAdapter();
            this.bilDataTableAdapter = new Kørselslog.DatabaseKørselslogDataSetTableAdapters.BilDataTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bilDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseKørselslogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stamdataBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.dateTimePicker3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.OpretStamdata);
            this.panel1.Location = new System.Drawing.Point(8, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 264);
            this.panel1.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(90, 227);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 23);
            this.button10.TabIndex = 19;
            this.button10.Text = "Cancel";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(152, 227);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(38, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "Ok";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Save_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 197);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Dato:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Navn:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Nr. plade:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(90, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(90, 190);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker3.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Opret Bildata:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dato:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Navn:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // OpretStamdata
            // 
            this.OpretStamdata.AutoSize = true;
            this.OpretStamdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpretStamdata.Location = new System.Drawing.Point(39, 7);
            this.OpretStamdata.Name = "OpretStamdata";
            this.OpretStamdata.Size = new System.Drawing.Size(110, 17);
            this.OpretStamdata.TabIndex = 0;
            this.OpretStamdata.Text = "Opret stamdata:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.RedigerStamdata);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(224, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 264);
            this.panel2.TabIndex = 1;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(59, 121);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(89, 31);
            this.button13.TabIndex = 3;
            this.button13.Text = "Bil";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_RedigerBil_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(59, 60);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 32);
            this.button12.TabIndex = 2;
            this.button12.Text = "Person";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_RedigerPerson_Click);
            // 
            // RedigerStamdata
            // 
            this.RedigerStamdata.AutoSize = true;
            this.RedigerStamdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedigerStamdata.Location = new System.Drawing.Point(32, 7);
            this.RedigerStamdata.Name = "RedigerStamdata";
            this.RedigerStamdata.Size = new System.Drawing.Size(140, 20);
            this.RedigerStamdata.TabIndex = 1;
            this.RedigerStamdata.Text = "Rediger stamdata:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button14);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.SletStamdata);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.Location = new System.Drawing.Point(440, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 264);
            this.panel3.TabIndex = 2;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(62, 187);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(89, 31);
            this.button14.TabIndex = 5;
            this.button14.Text = "Slet Kørselslog";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(62, 121);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 31);
            this.button6.TabIndex = 4;
            this.button6.Text = "Slet Bil";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_SletBil_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(62, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 32);
            this.button5.TabIndex = 4;
            this.button5.Text = "Slet Person";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_SletPerson_Click);
            // 
            // SletStamdata
            // 
            this.SletStamdata.AutoSize = true;
            this.SletStamdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SletStamdata.Location = new System.Drawing.Point(59, 9);
            this.SletStamdata.Name = "SletStamdata";
            this.SletStamdata.Size = new System.Drawing.Size(102, 18);
            this.SletStamdata.TabIndex = 1;
            this.SletStamdata.Text = "Slet stamdata:";
            // 
            // PersonaleData
            // 
            this.PersonaleData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonaleData.Location = new System.Drawing.Point(158, 6);
            this.PersonaleData.Name = "PersonaleData";
            this.PersonaleData.Size = new System.Drawing.Size(276, 23);
            this.PersonaleData.TabIndex = 3;
            this.PersonaleData.Text = "Personale data:";
            this.PersonaleData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.textBox8);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.comboBox3);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel4.Location = new System.Drawing.Point(708, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 236);
            this.panel4.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bilDataBindingSource;
            this.comboBox1.DisplayMember = "NrPlade";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "Bil_ID";
            // 
            // bilDataBindingSource
            // 
            this.bilDataBindingSource.DataMember = "BilData";
            this.bilDataBindingSource.DataSource = this.databaseKørselslogDataSet;
            // 
            // databaseKørselslogDataSet
            // 
            this.databaseKørselslogDataSet.DataSetName = "DatabaseKørselslogDataSet";
            this.databaseKørselslogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(95, 76);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Tur:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(95, 128);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Navn:";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.stamdataBindingSource;
            this.comboBox3.DisplayMember = "Navn";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(95, 49);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.ValueMember = "Person_ID";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // stamdataBindingSource
            // 
            this.stamdataBindingSource.DataMember = "stamdata";
            this.stamdataBindingSource.DataSource = this.databaseKørselslogDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Dato:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(120, 196);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Ok";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Save_Kørselslog);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nr. plade:";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(25, 196);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Refresh";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_refresh_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Opret kørsels log:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button15);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Controls.Add(this.listView1);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(71, 313);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(398, 236);
            this.panel5.TabIndex = 13;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(30, 141);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(59, 23);
            this.button15.TabIndex = 23;
            this.button15.Text = "Log Data";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15__show_Log_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 41);
            this.button4.TabIndex = 22;
            this.button4.Text = "Person Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ShowPersonClick_Form1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ClearListView1);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(30, 112);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(59, 23);
            this.button11.TabIndex = 20;
            this.button11.Text = "Bil Data";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_show_Bil_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(95, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 145);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(110, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(211, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Se Stam data eller Log data:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // stamdataTableAdapter
            // 
            this.stamdataTableAdapter.ClearBeforeFill = true;
            // 
            // bilDataTableAdapter
            // 
            this.bilDataTableAdapter.ClearBeforeFill = true;
            // 
            // KørselslogForside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Kørselslog.Properties.Resources.taxi_baggrundsbillede;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 561);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.PersonaleData);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KørselslogForside";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Kørselslog";
            this.Load += new System.EventHandler(this.KørselslogForside_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bilDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseKørselslogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stamdataBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label OpretStamdata;
        private System.Windows.Forms.Label RedigerStamdata;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label SletStamdata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PersonaleData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private DatabaseKørselslogDataSet databaseKørselslogDataSet;
        private System.Windows.Forms.BindingSource stamdataBindingSource;
        private DatabaseKørselslogDataSetTableAdapters.stamdataTableAdapter stamdataTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bilDataBindingSource;
        private DatabaseKørselslogDataSetTableAdapters.BilDataTableAdapter bilDataTableAdapter;
        private System.Windows.Forms.Button button15;
    }
}


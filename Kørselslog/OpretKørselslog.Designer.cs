namespace Kørselslog
{
    partial class OpretKørselslog
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.stamdataTableAdapter = new Kørselslog.DatabaseKørselslogDataSetTableAdapters.stamdataTableAdapter();
            this.databaseKørselslogDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilDataTableAdapter = new Kørselslog.DatabaseKørselslogDataSetTableAdapters.BilDataTableAdapter();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bilDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseKørselslogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stamdataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseKørselslogDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
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
            this.panel4.Location = new System.Drawing.Point(300, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 229);
            this.panel4.TabIndex = 13;
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
            this.button7.Click += new System.EventHandler(this.button7_SaveLog_Click);
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
            this.button8.Text = "Genindlæs";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Opret kørselslog:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(136, 263);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(538, 175);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // stamdataTableAdapter
            // 
            this.stamdataTableAdapter.ClearBeforeFill = true;
            // 
            // databaseKørselslogDataSetBindingSource
            // 
            this.databaseKørselslogDataSetBindingSource.DataSource = this.databaseKørselslogDataSet;
            this.databaseKørselslogDataSetBindingSource.Position = 0;
            // 
            // bilDataTableAdapter
            // 
            this.bilDataTableAdapter.ClearBeforeFill = true;
            // 
            // OpretKørselslog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Kørselslog.Properties.Resources.taxi_baggrundsbillede;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel4);
            this.Name = "OpretKørselslog";
            this.Text = "OpretKørselslog";
            this.Load += new System.EventHandler(this.OpretKørselslog_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bilDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseKørselslogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stamdataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseKørselslogDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listView1;
        private DatabaseKørselslogDataSet databaseKørselslogDataSet;
        private System.Windows.Forms.BindingSource stamdataBindingSource;
        private DatabaseKørselslogDataSetTableAdapters.stamdataTableAdapter stamdataTableAdapter;
        private System.Windows.Forms.BindingSource databaseKørselslogDataSetBindingSource;
        private System.Windows.Forms.BindingSource bilDataBindingSource;
        private DatabaseKørselslogDataSetTableAdapters.BilDataTableAdapter bilDataTableAdapter;
    }
}
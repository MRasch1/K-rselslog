using System;
using System.Windows.Forms;

namespace Kørselslog
{
    partial class SletPerson
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stamdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseKørselslogDataSet = new Kørselslog.DatabaseKørselslogDataSet();
            this.label14 = new System.Windows.Forms.Label();
            this.stamdataTableAdapter = new Kørselslog.DatabaseKørselslogDataSetTableAdapters.stamdataTableAdapter();
            this.stamdataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stamdataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseKørselslogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stamdataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(163, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(514, 265);
            this.panel5.TabIndex = 14;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.DataSource = this.stamdataBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(34, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 169);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Person_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Person_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Navn";
            this.dataGridViewTextBoxColumn2.HeaderText = "Navn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Dato";
            this.dataGridViewTextBoxColumn3.HeaderText = "Dato";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // stamdataBindingSource
            // 
            this.stamdataBindingSource.DataMember = "stamdata";
            this.stamdataBindingSource.DataSource = this.databaseKørselslogDataSet;
            // 
            // databaseKørselslogDataSet
            // 
            this.databaseKørselslogDataSet.DataSetName = "DatabaseKørselslogDataSet";
            this.databaseKørselslogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(180, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "Slet person:";
            // 
            // stamdataTableAdapter
            // 
            this.stamdataTableAdapter.ClearBeforeFill = true;
            // 
            // stamdataBindingSource1
            // 
            this.stamdataBindingSource1.DataMember = "stamdata";
            this.stamdataBindingSource1.DataSource = this.databaseKørselslogDataSet;
            // 
            // SletPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kørselslog.Properties.Resources.taxi_baggrundsbillede;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Name = "SletPerson";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SletPerson_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stamdataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseKørselslogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stamdataBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private DatabaseKørselslogDataSet databaseKørselslogDataSet;
        private System.Windows.Forms.BindingSource stamdataBindingSource;
        private DatabaseKørselslogDataSetTableAdapters.stamdataTableAdapter stamdataTableAdapter;
        private System.Windows.Forms.BindingSource stamdataBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
namespace Kørselslog
{
    partial class SletLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SletLog));
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.databaseKørselslogDataSet = new Kørselslog.DatabaseKørselslogDataSet();
            this.logDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logDataTableAdapter = new Kørselslog.DatabaseKørselslogDataSetTableAdapters.LogDataTableAdapter();
            this.logIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrPladeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseKørselslogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(12, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(776, 265);
            this.panel5.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logIDDataGridViewTextBoxColumn,
            this.navnDataGridViewTextBoxColumn,
            this.datoDataGridViewTextBoxColumn,
            this.nrPladeDataGridViewTextBoxColumn,
            this.turDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.logDataBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(36, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(690, 169);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(337, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "Slet Log:";
            // 
            // databaseKørselslogDataSet
            // 
            this.databaseKørselslogDataSet.DataSetName = "DatabaseKørselslogDataSet";
            this.databaseKørselslogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logDataBindingSource
            // 
            this.logDataBindingSource.DataMember = "LogData";
            this.logDataBindingSource.DataSource = this.databaseKørselslogDataSet;
            // 
            // logDataTableAdapter
            // 
            this.logDataTableAdapter.ClearBeforeFill = true;
            // 
            // logIDDataGridViewTextBoxColumn
            // 
            this.logIDDataGridViewTextBoxColumn.DataPropertyName = "Log_ID";
            this.logIDDataGridViewTextBoxColumn.HeaderText = "Log_ID";
            this.logIDDataGridViewTextBoxColumn.Name = "logIDDataGridViewTextBoxColumn";
            this.logIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // navnDataGridViewTextBoxColumn
            // 
            this.navnDataGridViewTextBoxColumn.DataPropertyName = "Navn";
            this.navnDataGridViewTextBoxColumn.HeaderText = "Navn";
            this.navnDataGridViewTextBoxColumn.Name = "navnDataGridViewTextBoxColumn";
            // 
            // datoDataGridViewTextBoxColumn
            // 
            this.datoDataGridViewTextBoxColumn.DataPropertyName = "Dato";
            this.datoDataGridViewTextBoxColumn.HeaderText = "Dato";
            this.datoDataGridViewTextBoxColumn.Name = "datoDataGridViewTextBoxColumn";
            // 
            // nrPladeDataGridViewTextBoxColumn
            // 
            this.nrPladeDataGridViewTextBoxColumn.DataPropertyName = "NrPlade";
            this.nrPladeDataGridViewTextBoxColumn.HeaderText = "NrPlade";
            this.nrPladeDataGridViewTextBoxColumn.Name = "nrPladeDataGridViewTextBoxColumn";
            // 
            // turDataGridViewTextBoxColumn
            // 
            this.turDataGridViewTextBoxColumn.DataPropertyName = "Tur";
            this.turDataGridViewTextBoxColumn.HeaderText = "Tur";
            this.turDataGridViewTextBoxColumn.Name = "turDataGridViewTextBoxColumn";
            // 
            // SletLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kørselslog.Properties.Resources.taxi_baggrundsbillede;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SletLog";
            this.Text = "Slet Log";
            this.Load += new System.EventHandler(this.SletLog_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseKørselslogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label14;
        private DatabaseKørselslogDataSet databaseKørselslogDataSet;
        private System.Windows.Forms.BindingSource logDataBindingSource;
        private DatabaseKørselslogDataSetTableAdapters.LogDataTableAdapter logDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn logIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn navnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPladeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
    }
}
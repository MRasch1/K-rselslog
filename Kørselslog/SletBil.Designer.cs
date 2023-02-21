namespace Kørselslog
{
    partial class SletBil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SletBil));
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.bilIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrPladeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseKørselslogDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseKørselslogDataSet = new Kørselslog.DatabaseKørselslogDataSet();
            this.label14 = new System.Windows.Forms.Label();
            this.bilDataTableAdapter = new Kørselslog.DatabaseKørselslogDataSetTableAdapters.BilDataTableAdapter();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseKørselslogDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseKørselslogDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.Controls.Add(this.dataGridView3);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(90, 94);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(632, 265);
            this.panel5.TabIndex = 15;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bilIDDataGridViewTextBoxColumn,
            this.navnDataGridViewTextBoxColumn,
            this.nrPladeDataGridViewTextBoxColumn,
            this.datoDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.bilDataBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(34, 67);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(561, 169);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_SletBil);
            // 
            // bilIDDataGridViewTextBoxColumn
            // 
            this.bilIDDataGridViewTextBoxColumn.DataPropertyName = "Bil_ID";
            this.bilIDDataGridViewTextBoxColumn.HeaderText = "Bil_ID";
            this.bilIDDataGridViewTextBoxColumn.Name = "bilIDDataGridViewTextBoxColumn";
            this.bilIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // navnDataGridViewTextBoxColumn
            // 
            this.navnDataGridViewTextBoxColumn.DataPropertyName = "Navn";
            this.navnDataGridViewTextBoxColumn.HeaderText = "Navn";
            this.navnDataGridViewTextBoxColumn.Name = "navnDataGridViewTextBoxColumn";
            // 
            // nrPladeDataGridViewTextBoxColumn
            // 
            this.nrPladeDataGridViewTextBoxColumn.DataPropertyName = "NrPlade";
            this.nrPladeDataGridViewTextBoxColumn.HeaderText = "NrPlade";
            this.nrPladeDataGridViewTextBoxColumn.Name = "nrPladeDataGridViewTextBoxColumn";
            // 
            // datoDataGridViewTextBoxColumn
            // 
            this.datoDataGridViewTextBoxColumn.DataPropertyName = "Dato";
            this.datoDataGridViewTextBoxColumn.HeaderText = "Dato";
            this.datoDataGridViewTextBoxColumn.Name = "datoDataGridViewTextBoxColumn";
            // 
            // bilDataBindingSource
            // 
            this.bilDataBindingSource.DataMember = "BilData";
            this.bilDataBindingSource.DataSource = this.databaseKørselslogDataSetBindingSource;
            // 
            // databaseKørselslogDataSetBindingSource
            // 
            this.databaseKørselslogDataSetBindingSource.DataSource = this.databaseKørselslogDataSet;
            this.databaseKørselslogDataSetBindingSource.Position = 0;
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
            this.label14.Location = new System.Drawing.Point(267, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "Slet bil:";
            // 
            // bilDataTableAdapter
            // 
            this.bilDataTableAdapter.ClearBeforeFill = true;
            // 
            // SletBil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kørselslog.Properties.Resources.taxi_baggrundsbillede;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SletBil";
            this.Text = "Slet Bil";
            this.Load += new System.EventHandler(this.SletBil_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseKørselslogDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseKørselslogDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label14;
        private DatabaseKørselslogDataSet databaseKørselslogDataSet;
        private System.Windows.Forms.BindingSource databaseKørselslogDataSetBindingSource;
        private System.Windows.Forms.BindingSource bilDataBindingSource;
        private DatabaseKørselslogDataSetTableAdapters.BilDataTableAdapter bilDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn navnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPladeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoDataGridViewTextBoxColumn;
    }
}
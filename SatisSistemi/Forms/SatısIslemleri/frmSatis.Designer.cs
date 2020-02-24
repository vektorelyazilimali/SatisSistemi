namespace SatisSistemi.Forms.SatısIslemleri
{
    partial class frmSatis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbmusteriDataSet = new SatisSistemi.dbmusteriDataSet();
            this.tblsatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblsatisTableAdapter = new SatisSistemi.dbmusteriDataSetTableAdapters.tblsatisTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemesekliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamtutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odenenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eklemetarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guncellemetarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmusteriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsatisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.personelidDataGridViewTextBoxColumn,
            this.musteriidDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.odemesekliDataGridViewTextBoxColumn,
            this.toplamtutarDataGridViewTextBoxColumn,
            this.odenenDataGridViewTextBoxColumn,
            this.kalanDataGridViewTextBoxColumn,
            this.silidDataGridViewTextBoxColumn,
            this.eklemetarihiDataGridViewTextBoxColumn,
            this.guncellemetarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblsatisBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbmusteriDataSet
            // 
            this.dbmusteriDataSet.DataSetName = "dbmusteriDataSet";
            this.dbmusteriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblsatisBindingSource
            // 
            this.tblsatisBindingSource.DataMember = "tblsatis";
            this.tblsatisBindingSource.DataSource = this.dbmusteriDataSet;
            // 
            // tblsatisTableAdapter
            // 
            this.tblsatisTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "personel_id";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "personel_id";
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            // 
            // musteriidDataGridViewTextBoxColumn
            // 
            this.musteriidDataGridViewTextBoxColumn.DataPropertyName = "musteri_id";
            this.musteriidDataGridViewTextBoxColumn.HeaderText = "musteri_id";
            this.musteriidDataGridViewTextBoxColumn.Name = "musteriidDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // odemesekliDataGridViewTextBoxColumn
            // 
            this.odemesekliDataGridViewTextBoxColumn.DataPropertyName = "odeme_sekli";
            this.odemesekliDataGridViewTextBoxColumn.HeaderText = "odeme_sekli";
            this.odemesekliDataGridViewTextBoxColumn.Name = "odemesekliDataGridViewTextBoxColumn";
            // 
            // toplamtutarDataGridViewTextBoxColumn
            // 
            this.toplamtutarDataGridViewTextBoxColumn.DataPropertyName = "toplam_tutar";
            this.toplamtutarDataGridViewTextBoxColumn.HeaderText = "toplam_tutar";
            this.toplamtutarDataGridViewTextBoxColumn.Name = "toplamtutarDataGridViewTextBoxColumn";
            // 
            // odenenDataGridViewTextBoxColumn
            // 
            this.odenenDataGridViewTextBoxColumn.DataPropertyName = "odenen";
            this.odenenDataGridViewTextBoxColumn.HeaderText = "odenen";
            this.odenenDataGridViewTextBoxColumn.Name = "odenenDataGridViewTextBoxColumn";
            // 
            // kalanDataGridViewTextBoxColumn
            // 
            this.kalanDataGridViewTextBoxColumn.DataPropertyName = "kalan";
            this.kalanDataGridViewTextBoxColumn.HeaderText = "kalan";
            this.kalanDataGridViewTextBoxColumn.Name = "kalanDataGridViewTextBoxColumn";
            // 
            // silidDataGridViewTextBoxColumn
            // 
            this.silidDataGridViewTextBoxColumn.DataPropertyName = "sil_id";
            this.silidDataGridViewTextBoxColumn.HeaderText = "sil_id";
            this.silidDataGridViewTextBoxColumn.Name = "silidDataGridViewTextBoxColumn";
            // 
            // eklemetarihiDataGridViewTextBoxColumn
            // 
            this.eklemetarihiDataGridViewTextBoxColumn.DataPropertyName = "ekleme_tarihi";
            this.eklemetarihiDataGridViewTextBoxColumn.HeaderText = "ekleme_tarihi";
            this.eklemetarihiDataGridViewTextBoxColumn.Name = "eklemetarihiDataGridViewTextBoxColumn";
            // 
            // guncellemetarihiDataGridViewTextBoxColumn
            // 
            this.guncellemetarihiDataGridViewTextBoxColumn.DataPropertyName = "guncelleme_tarihi";
            this.guncellemetarihiDataGridViewTextBoxColumn.HeaderText = "guncelleme_tarihi";
            this.guncellemetarihiDataGridViewTextBoxColumn.Name = "guncellemetarihiDataGridViewTextBoxColumn";
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatis";
            this.Text = "frmSatis";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmusteriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsatisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbmusteriDataSet dbmusteriDataSet;
        private System.Windows.Forms.BindingSource tblsatisBindingSource;
        private dbmusteriDataSetTableAdapters.tblsatisTableAdapter tblsatisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemesekliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamtutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odenenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn silidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eklemetarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guncellemetarihiDataGridViewTextBoxColumn;
    }
}
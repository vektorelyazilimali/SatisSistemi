namespace SatisSistemi.Forms.MusteriIslemleri
{
    partial class frmMusteriKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriKayit));
            this.dataGridView_musterilistesi = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumtarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.iptalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttelefon = new System.Windows.Forms.MaskedTextBox();
            this.txttckimlik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_dogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.btnyenikayit = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_musterilistesi)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_musterilistesi
            // 
            this.dataGridView_musterilistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_musterilistesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tc,
            this.ad,
            this.soyad,
            this.telefon,
            this.dogumtarihi});
            this.dataGridView_musterilistesi.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_musterilistesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_musterilistesi.Location = new System.Drawing.Point(0, 251);
            this.dataGridView_musterilistesi.Name = "dataGridView_musterilistesi";
            this.dataGridView_musterilistesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_musterilistesi.Size = new System.Drawing.Size(644, 258);
            this.dataGridView_musterilistesi.TabIndex = 99;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // tc
            // 
            this.tc.HeaderText = "Tc Kimlik";
            this.tc.Name = "tc";
            this.tc.ReadOnly = true;
            // 
            // ad
            // 
            this.ad.HeaderText = "Ad";
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            this.ad.Width = 140;
            // 
            // soyad
            // 
            this.soyad.HeaderText = "Soyad";
            this.soyad.Name = "soyad";
            this.soyad.ReadOnly = true;
            this.soyad.Width = 110;
            // 
            // telefon
            // 
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            this.telefon.ReadOnly = true;
            // 
            // dogumtarihi
            // 
            this.dogumtarihi.HeaderText = "Doğum Tarihi";
            this.dogumtarihi.Name = "dogumtarihi";
            this.dogumtarihi.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.toolStripMenuItem1,
            this.iptalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 98);
            // 
            // seçToolStripMenuItem
            // 
            this.seçToolStripMenuItem.Name = "seçToolStripMenuItem";
            this.seçToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.seçToolStripMenuItem.Text = "Seç";
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 6);
            // 
            // iptalToolStripMenuItem
            // 
            this.iptalToolStripMenuItem.Name = "iptalToolStripMenuItem";
            this.iptalToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.iptalToolStripMenuItem.Text = "İptal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(65, 9);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(58, 20);
            this.txtid.TabIndex = 98;
            // 
            // txtad
            // 
            this.txtad.Enabled = false;
            this.txtad.Location = new System.Drawing.Point(65, 84);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(129, 20);
            this.txtad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Enabled = false;
            this.txtsoyad.Location = new System.Drawing.Point(65, 123);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(129, 20);
            this.txtsoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefon";
            // 
            // txttelefon
            // 
            this.txttelefon.Enabled = false;
            this.txttelefon.Location = new System.Drawing.Point(292, 9);
            this.txttelefon.Mask = "(999) 000-0000";
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(151, 20);
            this.txttelefon.TabIndex = 3;
            // 
            // txttckimlik
            // 
            this.txttckimlik.Enabled = false;
            this.txttckimlik.Location = new System.Drawing.Point(65, 44);
            this.txttckimlik.MaxLength = 11;
            this.txttckimlik.Name = "txttckimlik";
            this.txttckimlik.Size = new System.Drawing.Size(129, 20);
            this.txttckimlik.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tc Kimlik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Doğum Tarihi";
            // 
            // dtp_dogumtarihi
            // 
            this.dtp_dogumtarihi.Enabled = false;
            this.dtp_dogumtarihi.Location = new System.Drawing.Point(292, 41);
            this.dtp_dogumtarihi.Name = "dtp_dogumtarihi";
            this.dtp_dogumtarihi.Size = new System.Drawing.Size(151, 20);
            this.dtp_dogumtarihi.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Adres";
            // 
            // txtadres
            // 
            this.txtadres.Enabled = false;
            this.txtadres.Location = new System.Drawing.Point(292, 84);
            this.txtadres.MaxLength = 11;
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(202, 59);
            this.txtadres.TabIndex = 5;
            // 
            // btnyenikayit
            // 
            this.btnyenikayit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnyenikayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyenikayit.Location = new System.Drawing.Point(15, 158);
            this.btnyenikayit.Name = "btnyenikayit";
            this.btnyenikayit.Size = new System.Drawing.Size(108, 38);
            this.btnyenikayit.TabIndex = 6;
            this.btnyenikayit.Text = "Yeni Kayıt";
            this.btnyenikayit.UseVisualStyleBackColor = false;
            this.btnyenikayit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.RosyBrown;
            this.btnkaydet.Enabled = false;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Location = new System.Drawing.Point(129, 158);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(108, 38);
            this.btnkaydet.TabIndex = 7;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.button2_Click);
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.RosyBrown;
            this.btniptal.Enabled = false;
            this.btniptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniptal.Location = new System.Drawing.Point(243, 158);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(108, 38);
            this.btniptal.TabIndex = 8;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.RosyBrown;
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncikis.Location = new System.Drawing.Point(462, 177);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(170, 57);
            this.btncikis.TabIndex = 12;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(0, 219);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(443, 29);
            this.textBox6.TabIndex = 9;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Image = global::SatisSistemi.Properties.Resources.loading_gif_transparent_4;
            this.pictureBox2.Location = new System.Drawing.Point(228, 301);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(509, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // frmMusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 509);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnyenikayit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtp_dogumtarihi);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txttckimlik);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_musterilistesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusteriKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Kayıt Formu";
            this.Load += new System.EventHandler(this.frmMusteriKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_musterilistesi)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_musterilistesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txttelefon;
        private System.Windows.Forms.TextBox txttckimlik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_dogumtarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnyenikayit;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumtarihi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iptalToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
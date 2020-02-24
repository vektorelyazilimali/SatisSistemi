using SatisSistemi.Bll;
using SatisSistemi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SatisSistemi.Forms.MusteriIslemleri
{
    public partial class frmMusteriKayit : Form
    {
        private tblmusterimanager _tblmusterimanager;
        private List<tblmusteri> musteri_listesi;
        public frmMusteriKayit()
        {
            InitializeComponent();
            _tblmusterimanager = new tblmusterimanager();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AcKapat(true);
        }
        private void frmMusteriKayit_Load(object sender, EventArgs e)
        {
            // panel1.BackColor = Color.Transparent;
            yukle();
        }

        private void AcKapat(bool item) {
            txtad.Enabled = item;
            txtadres.Enabled = item;
            txtsoyad.Enabled = item;
            txttckimlik.Enabled = item;
            txttelefon.Enabled = item;
            dtp_dogumtarihi.Enabled = item;
            btnkaydet.Enabled = item;
            btniptal.Enabled = item;
        }


        private void yukle() {
            pictureBox2.Visible = true;
            timer1.Enabled = true;
            Task.Run(() =>
            { musteri_listesi = _tblmusterimanager.MyList(); });
        }

        private void TabloDoldur() {
            int i = 0;
            //Tabloyu temizlemeyi unutma
            dataGridView_musterilistesi.Rows.Clear();
          
            foreach (var item in musteri_listesi)
            {
                // önemli -> Satır eklemeyi unutma
                dataGridView_musterilistesi.Rows.Add();
                dataGridView_musterilistesi
                    .Rows[i].Cells[0].Value = item.id;
                dataGridView_musterilistesi
                    .Rows[i].Cells[1].Value = item.tckimlik;
                dataGridView_musterilistesi
                    .Rows[i].Cells[2].Value = item.ad;
                dataGridView_musterilistesi
                    .Rows[i].Cells[3].Value = item.soyad;
                dataGridView_musterilistesi
                    .Rows[i].Cells[4].Value = item.telefon;
                dataGridView_musterilistesi
                    .Rows[i].Cells[5].Value = item.dogumtarihi;
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtad.Text.Trim().Equals("") ||
                 txtsoyad.Text.Trim().Equals("") ||
                 txttckimlik.Text.Trim().Equals("") ||
                 txttelefon.Text.Trim().Equals(""))
                MessageBox.Show("Zorunlu Alanları Boş Bırakamazsınız.");
            else
                Kaydet(); 
                        
        }

        private void Kaydet() {
            AcKapat(false);
            tblmusteri mst = new tblmusteri();
            mst.ad = txtad.Text;
            mst.adres = txtadres.Text;
            mst.dogumtarihi = dtp_dogumtarihi.Value;
            mst.soyad = txtsoyad.Text;
            mst.tckimlik = txttckimlik.Text;
            mst.telefon = txttelefon.Text;
            try
            {
                _tblmusterimanager.Add(mst);
                yukle();
                MessageBox.Show("Kayıt Başarı ile Yapıldı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Başarsız Bekelenmeyen bir hata" +
                    "oluştu. Lütfen yöneticinize başvurunuz.", "Hata!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (musteri_listesi != null)
            {
                pictureBox2.Visible = false;
                timer1.Enabled = false;
                TabloDoldur();
            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            AcKapat(false);
            pictureBox1.Image = 
                Image.FromFile(@"d:\musteriresimleri\"+txttckimlik.Text+".png");

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            musteri_listesi = _tblmusterimanager
                .MyList()
                .Where(x=> x.ad.ToUpper().Contains(textBox6.Text.ToUpper())||
                           x.tckimlik.ToUpper().Contains(textBox6.Text.ToUpper()) ||
                           x.soyad.ToUpper().Contains(textBox6.Text.ToUpper())).ToList();
          TabloDoldur();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            MessageBox.Show(openFile.FileName);
            string hedef = @"d:\musteriresimleri\" + txttckimlik.Text + ".png";
            File.Copy(openFile.FileName,
               hedef ,true);

        }
    }
}

using SatisSistemi.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SatisSistemi.Entity;
using System.Data.SqlClient;
using SatisSistemi.Bll;
namespace SatisSistemi
{
    public partial class Login : Form
    {
        private frmMainPage frmmainpage;
        private dbmusteriEntities _db;
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (isAdoLogin(txtUseName.Text,txtPassword.Text))
            {
                frmmainpage = new frmMainPage();
                frmmainpage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı yada Şifre Hatalı");
            }           
        }
        // EF ile kodlanmıştır.
        private bool isLogin(string ka,string sf){
            _db = new dbmusteriEntities();
            var kullanici = _db.tblusers.Where(x => x.kullanici_adi.Equals(ka) && x.sifre.Equals(sf));
            if (kullanici.Count()==0)
                return false;
            else
                return true;
            
        }
        // Ado.NET Connection kodlanmıştır.
        private bool isAdoLogin(string ka, string sf) { 
        
            // 1- Connection String
            // 2- SqlConnection
            string connectionString = "Data Source=.;Initial Catalog=dbmusteri;Integrated Security=true;";
            // Set -> ayar yapmak
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlQuery = "select * from tblusers";
            // Set-> ayar yapmak
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            // Bağlantıyı Aç !!! Açılan Bağlantı Muhakkak Kapatılmalıdır.
            connection.Open();
            // Emri(sql query) aktif connection(bağlantıya) uygula
            // Soru sonucu Gelen tabloyu DataReader a yükle
            SqlDataReader datareader = command.ExecuteReader();

            while (datareader.Read())
            {
                string kullaniciadi = datareader.GetString(2);
                string sifre = datareader.GetString(3);
                if (kullaniciadi.Equals(ka) && sifre.Equals(sf))
                {
                    connection.Close();
                    return true;
                }
                   
            }
            datareader.Close();
            connection.Close();
            return false;
        }


        private void islemler() {
            tblmusterimanager mm = new tblmusterimanager();
            //mm.Get();
            tblmusteriborcumanager mbm = new tblmusteriborcumanager();
            mbm.GetList();
            mbm.Get(x=> x.borc>0);


        }

    }
}

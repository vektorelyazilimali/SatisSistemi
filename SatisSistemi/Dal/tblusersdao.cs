using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatisSistemi.Utility;
using SatisSistemi.Models;
using System.Data.SqlClient;
using System.Data;

namespace SatisSistemi.Dal
{
    public class tblusersdao: ICRUD<model_tblusers>
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _datareader;
        private void baglantiAc() {
            _connection = new SqlConnection(StaticValues.connectionString);
            _connection.Open();
        }
        private void baglantiKapat() {
            if (_connection.State != ConnectionState.Closed)
                _connection.Close();               
        }
        private void QueryExecute(string query, SqlConnection connection) {
            _command = new SqlCommand(query, connection);
            baglantiAc();
            _command.ExecuteNonQuery();
            baglantiKapat();
        }
        public void Add(model_tblusers t)
        {             
            string query = "insert into tblusers(kullanici_adi,sifre) values ('"+t.kullanici_adi+"','"+t.sifre+"')";
            QueryExecute(query,_connection);
        }
        public void Delete(model_tblusers t)
        {
            string query = "update tblusers set sil_id=0 where id=" + t.id;
            QueryExecute(query, _connection);
        }
        public void Update(model_tblusers t)
        {
            string query = "update tblusers set personel_id = "+t.personel_id+",kullanici_adi='"+t.kullanici_adi+"',sifre='"+t.sifre+"' where id="+t.id;
            QueryExecute(query, _connection);
        }
        public model_tblusers Get(int id)
        {
            string query = "select * from tblusers where id=" + id;
            _command = new SqlCommand(query,_connection);
            baglantiAc();
            _datareader = _command.ExecuteReader();
            model_tblusers users = new model_tblusers();
            while(_datareader.Read()){
                users.id = _datareader.GetInt32(0);
                users.personel_id = _datareader.GetInt32(1);
                users.kullanici_adi = _datareader.GetString(2);
                users.sifre = _datareader.GetString(3);
                users.sil_id = _datareader.GetInt32(4);
            }
            return users;
        }
        public List<model_tblusers> MyList()
        {
            string query = "select * from tblusers";
            _command = new SqlCommand(query, _connection);
            baglantiAc();
            _datareader = _command.ExecuteReader();
            List<model_tblusers> liste = new List<model_tblusers>();
            model_tblusers users;
            while (_datareader.Read())
            {
                users = new model_tblusers();
                users.id = _datareader.GetInt32(0);
                users.personel_id = _datareader.GetInt32(1);
                users.kullanici_adi = _datareader.GetString(2);
                users.sifre = _datareader.GetString(3);
                users.sil_id = _datareader.GetInt32(4);
                liste.Add(users);
            }
            return liste;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


using nLayer.Service;
using nLayer.Domain;
using nLayer.DAL;


namespace nLayer.DAL
{
    class bolumlerDAO
    {
        public MySqlConnection baglan()
        {
            //MySqlConnection conn = new MySqlConnection("Server=localhost;Database=dededb;Uid=root;Pwd=");
            MySqlConnection conn = new MySqlConnection("Server=172.21.54.3;Database=dededb;Uid=ugurcandede;Pwd=dede.123");
            conn.Open();
            MessageBox.Show("Veri Tabanı Bağlantısı Başarılı!");
            return conn;
        }
        //public MySqlCommand CreateConnection(string sorgu)
        //{
        //    MySqlCommand komut = new MySqlCommand(sorgu, baglan());
        //    return komut;
        //}
    }
}

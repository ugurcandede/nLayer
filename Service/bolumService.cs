using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using nLayer.Service;
using nLayer.Domain;
using nLayer.DAL;

using MetroFramework;
using MetroFramework.Forms;
namespace nLayer.Service
{
    class bolumService
    {
        public void bolumKaydet(string gAd,string gTel)
        {
            try
            {
                MySqlCommand komut = new MySqlCommand("insert into bolum(bolumAdi,bolumTel) values ('" + gAd + "','" + gTel + "')", (new bolumlerDAO()).baglan());
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılıyla Kaydedildi", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt Oluşturulurken Hata Meydana Geldi\n" + hata.ToString(), "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public MySqlDataReader bolumListele()
        {
            MySqlCommand komut = new MySqlCommand("SELECT * FROM bolum", (new bolumlerDAO()).baglan());
           return komut.ExecuteReader();
        }
        public void bolumGuncelle(int gID, string gAd, string gTel)
        {
            MySqlCommand komut = new MySqlCommand("UPDATE bolum SET bolumAdi = '" + gAd + "', bolumTel = " + gTel + " WHERE (`id` = '" + gID + "')", new bolumlerDAO().baglan());            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılıyla Kaydedildi", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}

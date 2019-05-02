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
        public void bolumListele()
        {
            try
            {
                MySqlCommand komut = new MySqlCommand("SELECT * FROM dededb.bolum", (new bolumlerDAO()).baglan());
                komut.ExecuteNonQuery();
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt Oluşturulurken Hata Meydana Geldi\n" + hata.ToString(), "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}

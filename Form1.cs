using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework.Controls;

using nLayer.Service;
using nLayer.Domain;
using nLayer.DAL;
using MySql.Data.MySqlClient;

namespace nLayer
{
    public partial class frmBolumKaydet : MetroForm
    {
        public frmBolumKaydet()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            (new bolumService()).bolumKaydet(bAdTxb.Text, bTelTxb.Text);
        }
        private void BtnListele_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Bu Buton Henüz Aktif Değil!", btnListele);

        }
        private void BtnListele_Click(object sender, EventArgs e)
        {
            // toolTip1.Show("Bu Buton Henüz Aktif Değil!", btnListele);

            MySqlDataReader mdr = (new bolumService()).bolumListele();
            //listBox1.DataSource=(new bolumService()).bolumListele();
            while (mdr.Read())
            { 
                listBox1.Items.Add(new bolumler(mdr[0].ToString(),mdr[1].ToString(),mdr[2].ToString()));
            }
            //bolumService bService = new bolumService();
            //listBox1.Items.Add(bService.bolumListele());
        }

        private void MetroLabel3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ugurcandede/nLayer");
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/ugurcandede");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ugurcandede");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            bAdTxb.Text=((bolumler)listBox1.SelectedItem).BolumAd;
            //(new bolumService()).bolumGuncelle(listBox1.SelectedIndex,bAdTxb.Text, bTelTxb.Text);
        }
    }
}

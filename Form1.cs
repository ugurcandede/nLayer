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
            toolTip1.Show("Bu Buton Henüz Aktif Değil!", btnListele);
            // listBox1.Items.Add((new bolumService).bolumListele());
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


    }
}

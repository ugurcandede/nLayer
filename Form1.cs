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

        private void BtnListele_Click(object sender, EventArgs e)
        {
           // listBox1.Items.Add((new bolumService).bolumListele());
        }
    }
}

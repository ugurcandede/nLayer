using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nLayer.Service;
using nLayer.Domain;
using nLayer.DAL;

namespace nLayer.Domain
{
    class bolumler
    {
        string bolumID,bolumAd,bolumTel;

        public string BolumID { get => bolumID; set => bolumID = value; }
        public string BolumAd { get => bolumAd; set => bolumAd = value; }
        public string BolumTel { get => bolumTel; set => bolumTel = value; }

        public bolumler(string gBolumID, string gBolumAd, string gBolumTel)
        {
            this.BolumID = gBolumID;
            this.BolumAd = gBolumAd;
            this.BolumTel = gBolumTel;
        }
        public override string ToString()
        {
            return this.BolumAd + " " + this.BolumTel;
        }
    }
}


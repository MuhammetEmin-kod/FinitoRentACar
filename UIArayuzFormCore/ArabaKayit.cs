using Bussinies.Concreate;
using DataAcces.Concreate.EntityFramework;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIArayuzFormCore
{
    public partial class ArabaKayit : Form
    {
        public ArabaKayit()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            AracManager arb = new AracManager(new EFAracDAL());

            Arac a1 = new Arac();
            a1.AracPlaka = txt_ArbKyt.Text;
            a1.Marka = txt_Mrk.Text;
            a1.KM = txt_Km.Text;
            a1.YakitTuru = txt_YktTr.Text;
            a1.Model = Convert.ToInt32(txt_Mdl.Text);
            a1.Renk = txt_Rnk.Text;
            a1.Ucret = Convert.ToInt32(txt_Ucrt.Text);
            a1.Durum = true;
            arb.add(a1);
            ControlTemizlik.temizle(this);
        }

        private void btn_Iptl_Click(object sender, EventArgs e)
        {

            ControlTemizlik.temizle(this);
            this.Close();
        }
    }
}

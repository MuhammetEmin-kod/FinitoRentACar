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
    public partial class MusterEkle : Form
    {
        public MusterEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriManager mm = new MusteriManager(new EFMusteriDAL());
            Musteri m1 = new    ();
            m1.Tc = txt_Tc.Text;
            m1.Adres = txt_Adr.Text;
            m1.MusteriAd = txt_MusAd.Text;
            m1.MusteriSoyad = txt_MusSoy.Text;
            m1.Mail = txt_Mail.Text;
            m1.Telefon = txt_Tel.Text;
            m1.Durum = true;
            mm.add(m1);
            ControlTemizlik.temizle(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControlTemizlik.temizle(this);

        }
    }
}

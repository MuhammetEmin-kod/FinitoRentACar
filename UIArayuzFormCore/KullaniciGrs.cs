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
    public partial class KullaniciGrs : Form
    {
        public KullaniciGrs()
        {
            InitializeComponent();
        }
        KullaniciGirisManager kgm = new KullaniciGirisManager(new EFKullaniciGirisDAL());
        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciGiris kg = new KullaniciGiris();

            kg.ID = Convert.ToInt32(txt_ID.Text);
            kg.KullaniciAdi = txt_KulAd.Text;
            kg.KullaniciSifre = txt_Kulsif.Text;
            kg.Durum = true;
            kgm.update(kg);
            ControlTemizlik.temizle(this);
            dataGridView1.DataSource = kgm.GetAllOf();

        }


        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            KullaniciGiris kg = new KullaniciGiris();
            kg.KullaniciAdi = txt_KulAd.Text;
            kg.KullaniciSifre = txt_Kulsif.Text;
            kg.Durum = true;
            kgm.add(kg);
            ControlTemizlik.temizle(this);
            dataGridView1.DataSource = kgm.GetAllOf();


        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            KullaniciGiris kg = new KullaniciGiris();
            kg.ID = Convert.ToInt32(txt_ID.Text);
            kg.KullaniciAdi = txt_KulAd.Text;
            kg.KullaniciSifre = txt_Kulsif.Text;
            kg.Durum = false;
            kgm.update(kg);
            ControlTemizlik.temizle(this);
            dataGridView1.DataSource = kgm.GetAllOf();

        }

        private void KullaniciGrs_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kgm.GetAllOf();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_KulAd.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_Kulsif.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            
        }
    }
}

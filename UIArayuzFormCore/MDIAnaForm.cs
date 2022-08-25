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
    public partial class MDIAnaForm : Form
    {
        public MDIAnaForm()
        {
            InitializeComponent();
        }

        private void btn_MusEkl_Click(object sender, EventArgs e)
        {
            MusterEkle me = new MusterEkle();
            me.StartPosition = FormStartPosition.CenterScreen;
            me.ShowDialog();
        }

        private void btn_MusLis_Click(object sender, EventArgs e)
        {
            MusListe ml = new MusListe();
            ml.StartPosition = FormStartPosition.CenterScreen;
            ml.ShowDialog();
        }

        private void btn_Arbkyt_Click(object sender, EventArgs e)
        {

            ArabaKayit ak = new ArabaKayit();
            ak.StartPosition = FormStartPosition.CenterScreen;
            ak.ShowDialog();
        }

        private void btn_ArbLis_Click(object sender, EventArgs e)
        {

            ArabaListele al = new ArabaListele();
            al.StartPosition = FormStartPosition.CenterScreen;
            al.ShowDialog();
        }

        private void btn_Sözl_Click(object sender, EventArgs e)
        {
            Sozles s1 = new Sozles();
            s1.StartPosition = FormStartPosition.CenterScreen;
            s1.ShowDialog();
        }

        private void btn_Sts_Click(object sender, EventArgs e)
        {
            Satislarr ss1 = new Satislarr();
            ss1.StartPosition = FormStartPosition.CenterScreen;
            ss1.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciGrs kg = new KullaniciGrs();
            kg.StartPosition = FormStartPosition.CenterScreen;
            kg.ShowDialog();
        }
    }
}

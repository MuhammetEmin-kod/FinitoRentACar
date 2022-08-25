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
    public partial class Sozles : Form
    {
        public Sozles()
        {
            InitializeComponent();
        }
        SozlesmeManager smg = new SozlesmeManager(new EFSozlesmeDAL());
        MusteriManager mng = new MusteriManager(new EFMusteriDAL());
        AracManager arc = new AracManager(new EFAracDAL());
        SatisManager stm = new SatisManager(new EFSatisDAL());
        private void Sozles_Load(object sender, EventArgs e)
        {
            foreach (var item in arc.GetAllOf())
            {
                cmb_Plaka.Items.Add(item.AracPlaka);

            }
            foreach (var item in mng.GetAllOf())
            {
                cmb_Tc.Items.Add(item.Tc);
            }
            dtg_Sozles.DataSource = smg.GetAllOf();
        }

        private void cmb_Tc_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in mng.GetAllOf())
            {
                if (cmb_Tc.Text == item.Tc)
                {
                    txt_MusAd.Text = item.MusteriAd;
                    txt_MusSoy.Text = item.MusteriSoyad;
                }
            }
        }

        private void cmb_Plaka_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in arc.GetAllOf())
            {
                txt_Ucrt.Text = item.Ucret.ToString();
            }
        }

        private void btn_hsp_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(txt_AlTar.Text) - DateTime.Parse(txt_VerTar.Text);
            txt_Ttr.Text = (Convert.ToInt32(txt_Ucrt.Text) * gun.Days).ToString();
        }

        private void btn_Sozlesm_Click(object sender, EventArgs e)
        {
            Sozlesme szl = new Sozlesme();
            //szl.ID = Convert.ToInt32(txt_Id.Text);
            szl.MusteriTC = cmb_Tc.Text;
            szl.MusteriAd = txt_MusAd.Text;
            szl.MusteriSoyad = txt_MusSoy.Text;
            szl.Plaka = cmb_Plaka.Text;
            szl.KiraUcreti = Convert.ToInt32(txt_Ucrt.Text);
            szl.Gun = Convert.ToInt32(txt_Gun.Text);
            szl.Tutar = Convert.ToInt32(txt_Ttr.Text);
            szl.VerilisTarih = txt_VerTar.Value;
            szl.AlinanTarih = txt_AlTar.Value;
            szl.Durum = true;
            smg.add(szl);
            ControlTemizlik.temizle(this);
            //dtg_Sozles.DataSource = smg.GetAllOf();



            Satis ss = new Satis();
            int a = 0;
            int toplamtutar = 0;
            foreach (var item in stm.GetAllOf())
            {
                if (item.Gun==DateTime.Now)
                {
                    ss.ID = item.ID;
                    ss.ToplamTutar += Convert.ToInt32(txt_Ttr.Text);
                    ss.Gun = DateTime.Now;
                    stm.update(ss);
                    a++;
                }
            }
            if (a!=0)
            {
                ss.ToplamTutar = Convert.ToInt32(txt_Ttr.Text);
                ss.Gun = DateTime.Now;
                stm.add(ss);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dtg_Sozles.SelectedRows[0].Cells[0].Value.ToString();
            cmb_Tc.Text = dtg_Sozles.SelectedRows[0].Cells[1].Value.ToString();
            txt_MusAd.Text = dtg_Sozles.SelectedRows[0].Cells[2].Value.ToString();
            txt_MusSoy.Text = dtg_Sozles.SelectedRows[0].Cells[3].Value.ToString();
            cmb_Plaka.Text = dtg_Sozles.SelectedRows[0].Cells[4].Value.ToString();
            txt_Ucrt.Text = dtg_Sozles.SelectedRows[0].Cells[5].Value.ToString();
            txt_Gun.Text = dtg_Sozles.SelectedRows[0].Cells[6].Value.ToString();
            txt_Ttr.Text = dtg_Sozles.SelectedRows[0].Cells[7].Value.ToString();
            txt_VerTar.Text = dtg_Sozles.SelectedRows[0].Cells[8].Value.ToString();
            txt_AlTar.Text = dtg_Sozles.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void btn_ArcTslm_Click(object sender, EventArgs e)
        {
            Sozlesme smc = new Sozlesme();
            smc.ID = Convert.ToInt32(txt_Id.Text);
            smc.MusteriTC = cmb_Tc.Text;
            smc.MusteriAd = txt_MusAd.Text;
            smc.Plaka = cmb_Plaka.Text;
            smc.KiraUcreti = Convert.ToInt32(txt_Ucrt.Text);
            smc.Gun = Convert.ToInt32(txt_Gun.Text);
            smc.Tutar = Convert.ToInt32(txt_Ttr.Text);
            smc.VerilisTarih = txt_VerTar.Value;
            smc.AlinanTarih = txt_AlTar.Value;
            smc.Durum = false;
            smg.update(smc);
            ControlTemizlik.temizle(this);
            MessageBox.Show("Araç teslim alınmıştır.");
            dtg_Sozles.DataSource = smg.GetAllOf();
        }
    }
}

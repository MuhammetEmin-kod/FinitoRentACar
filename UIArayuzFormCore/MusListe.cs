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
    public partial class MusListe : Form
    {
        public MusListe()
        {
            InitializeComponent();
        }
        MusteriManager mm = new MusteriManager(new EFMusteriDAL());

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            dtg_Mst.DataSource = mm.GetAllOf();
        }

        private void btn_Gcll_Click(object sender, EventArgs e)
        {
            Musteri ms = new Musteri();
            ms.ID = Convert.ToInt32(txt_Id.Text);
            ms.Tc =txt_Tc.Text;
            ms.MusteriAd = txt_MusAd.Text;
            ms.MusteriSoyad = txt_MusSoy.Text;
            ms.Mail = txt_Mail.Text;
            ms.Telefon = txt_Tel.Text;
            ms.Adres = txt_Adr.Text;
            ms.Durum = true;
            mm.update(ms);
            dtg_Mst.DataSource = mm.GetAllOf();
        }

        private void btn_Dlt_Click(object sender, EventArgs e)
        {
            Musteri ms = new Musteri();
            ms.ID = Convert.ToInt32(txt_Id.Text);
            ms.Tc = txt_Tc.Text;
            ms.MusteriAd = txt_MusAd.Text;
            ms.MusteriSoyad = txt_MusSoy.Text;
            ms.Mail = txt_Mail.Text;
            ms.Telefon = txt_Tel.Text;
            ms.Adres = txt_Adr.Text;
            ms.Durum = false;
            mm.update(ms);
            dtg_Mst.DataSource = mm.GetAllOf();
        }

        private void dtg_Mst_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dtg_Mst.SelectedRows[0].Cells[0].Value.ToString();
            txt_Tc.Text = dtg_Mst.SelectedRows[0].Cells[1].Value.ToString();
            txt_MusAd.Text = dtg_Mst.SelectedRows[0].Cells[2].Value.ToString();
            txt_MusSoy.Text = dtg_Mst.SelectedRows[0].Cells[3].Value.ToString();
            txt_Mail.Text = dtg_Mst.SelectedRows[0].Cells[4].Value.ToString();
            txt_Tel.Text = dtg_Mst.SelectedRows[0].Cells[5].Value.ToString();
            txt_Adr.Text = dtg_Mst.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}

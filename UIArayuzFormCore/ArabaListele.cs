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
    public partial class ArabaListele : Form
    {
        public ArabaListele()
        {
            InitializeComponent();
        }
        AracManager arm = new AracManager(new EFAracDAL());

        private void btn_List_Click(object sender, EventArgs e)
        {
            dtg_Arb.DataSource = arm.GetAllOf();

        }

        private void btn_Gncl_Click(object sender, EventArgs e)
        {
            Arac arc = new Arac();
            arc.ID = Convert.ToInt16(txt_ID.Text);
            arc.AracPlaka = txt_ArbPlk.Text;
            arc.Marka = txt_Mrk.Text;
            arc.YakitTuru = txt_YktTr.Text;
            arc.Model = Convert.ToInt16(txt_Mdl.Text);
            arc.Renk = txt_Rnk.Text;
            arc.Ucret = Convert.ToInt16(txt_Ucrt.Text);
            arc.Durum = true;
            arm.update(arc);
            dtg_Arb.DataSource = arm.GetAllOf();
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            Arac arc = new Arac();
            arc.ID = Convert.ToInt16(txt_ID.Text);
            arc.AracPlaka = txt_ArbPlk.Text;
            arc.Marka = txt_Mrk.Text;
            arc.YakitTuru = txt_YktTr.Text;
            arc.Model = Convert.ToInt16(txt_Mdl.Text);
            arc.Renk = txt_Rnk.Text;
            arc.Ucret = Convert.ToInt16(txt_Ucrt.Text);
            arc.Durum = false;
            arm.update(arc);
            dtg_Arb.DataSource = arm.GetAllOf();
        }

        private void dtg_Arb_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_ID.Text = dtg_Arb.SelectedRows[0].Cells[0].Value.ToString();
            txt_ArbPlk.Text = dtg_Arb.SelectedRows[0].Cells[1].Value.ToString();
            txt_Mrk.Text = dtg_Arb.SelectedRows[0].Cells[2].Value.ToString();
            txt_Km.Text = dtg_Arb.SelectedRows[0].Cells[3].Value.ToString();
            txt_YktTr.Text = dtg_Arb.SelectedRows[0].Cells[4].Value.ToString();
            txt_Mdl.Text = dtg_Arb.SelectedRows[0].Cells[5].Value.ToString();
            txt_Rnk.Text = dtg_Arb.SelectedRows[0].Cells[6].Value.ToString();
            txt_Ucrt.Text = dtg_Arb.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}

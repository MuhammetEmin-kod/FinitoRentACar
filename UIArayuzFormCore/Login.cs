using Bussinies.Concreate;
using DataAcces.Concreate.EntityFramework;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            bool dogrugiris = false;
            KullaniciGirisManager kgm = new KullaniciGirisManager(new EFKullaniciGirisDAL());
            foreach (var item in kgm.GetAllOf())
            {
                if (txt_KulAd.Text == item.KullaniciAdi && txt_KulSif.Text == item.KullaniciSifre)
                {
                    using (MDIAnaForm md = new MDIAnaForm())
                    {
                        this.Hide();
                        md.ShowDialog();
                        dogrugiris = true;
                    }
                }

            }
            if (!dogrugiris) MessageBox.Show("Hatali giriş");

            /*  II:Yöntem
             
             SqlConnection cs = new SqlConnection(@"Data Source=DESKTOP-CHM2CA4;Initial Catalog=Northwind;Integrated Security=True");
       
            cs.Open();
            SqlCommand komut = new SqlCommand("select * from KullaniciGirisleri where UserName='" + txt_KulAd.Text + "'and Password='" + txt_KulSif.Text + "'", cs);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MDIAnaForm md = new MDIAnaForm();
                md.Show();
                this.Hide();


                //Login lg = new Login();
                //lg.Hide();
                //Form1 frm = new Form1();
                //frm.Close();

            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }
            cs.Close();
            */
        }
    }
}

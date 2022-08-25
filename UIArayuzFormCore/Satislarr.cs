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
    public partial class Satislarr : Form
    {
        public Satislarr()
        {
            InitializeComponent();
        }

        private void Satislarr_Load(object sender, EventArgs e)
        {
            SatisManager ss = new SatisManager(new EFSatisDAL());
            dataGridView1.DataSource = ss.GetAllOf();
        }
    }
}

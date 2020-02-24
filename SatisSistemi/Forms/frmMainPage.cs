using SatisSistemi.Forms.MusteriIslemleri;
using SatisSistemi.Forms.SatısIslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisSistemi.Forms
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {

        }

        private void ödemeAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void müşteriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriKayit frm =
                new frmMusteriKayit();
            frm.ShowDialog();

        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSatis frm = new frmSatis();
            frm.ShowDialog();
        }
    }
}

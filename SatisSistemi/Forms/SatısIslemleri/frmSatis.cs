using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisSistemi.Forms.SatısIslemleri
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbmusteriDataSet.tblsatis' table. You can move, or remove it, as needed.
            this.tblsatisTableAdapter.Fill(this.dbmusteriDataSet.tblsatis);

        }
    }
}

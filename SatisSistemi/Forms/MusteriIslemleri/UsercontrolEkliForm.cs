using SatisSistemi.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisSistemi.Forms.MusteriIslemleri
{
    public partial class UsercontrolEkliForm : Form
    {
        private MusteriListGrid _liste;
        public UsercontrolEkliForm()
        {
            InitializeComponent();
        }

        private void UsercontrolEkliForm_Load(object sender, EventArgs e)
        {
         
        }

        private void listeekle() {
            _liste = new MusteriListGrid();
            _liste.Top = 255;
            _liste.Left = 10;
           
            this.Controls.Add(_liste);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _liste.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listeekle();
        }
    }
}

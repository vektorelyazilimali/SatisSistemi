using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SatisSistemi.Entity;

namespace SatisSistemi.UserControls
{
    public partial class MusteriListGrid : UserControl
    {
        public List<tblmusteri> musteriListesi;
        private int startTopPosition=2;
        public MusteriListGrid()
        {
            InitializeComponent();
            musteriListesi = new List<tblmusteri>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MusteriListGrid_Load(object sender, EventArgs e)
        {
            MusteriBilgisi Usermst;


            for (int i = 0; i < 15; i++)
            {
                Usermst = new MusteriBilgisi();
                Usermst.Top = startTopPosition+ (i*25);
                this.panel2.Controls.Add(Usermst);
            }
              

        }
    }
}

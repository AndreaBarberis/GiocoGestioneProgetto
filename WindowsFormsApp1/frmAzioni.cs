using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAzioni : Form
    {
        string az;
        int ptn =0;
        public frmAzioni()
        {
            InitializeComponent();
        }
        public frmAzioni(int punti)
        {
            InitializeComponent();
            ptn += punti;
            switch (ptn)
            {
                case 1:
                    btnDisc.Enabled = true;
                    btnSpia.Enabled = false;
                    btnTre.Enabled = false;
                    break;
                case 2:
                    btnDisc.Enabled = true;
                    btnSpia.Enabled = true;
                    btnTre.Enabled = false;
                    break;
                case 3:
                    btnDisc.Enabled = true;
                    btnSpia.Enabled = true;
                    btnTre.Enabled = true;
                    break;
                default:
                    break;
            }
        }
        public string azione()
        {
            return az;
        }
        private void btnDisc_Click(object sender, EventArgs e)
        {
            az = "disc";
            ptn -= 1;
            this.Close();
        }

        private void btnTre_Click(object sender, EventArgs e)
        {
            az = "treno";
            ptn -= 2;
            this.Close();
        }

        private void btnSpia_Click(object sender, EventArgs e)
        {
            az = "spia";
            ptn -= 3;
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LetsBlood_2
{
    public partial class frm_sobre : Form
    {
        public frm_sobre()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

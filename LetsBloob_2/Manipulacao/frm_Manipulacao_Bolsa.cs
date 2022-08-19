using LetsBlood_2.Banco_de_Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsBlood_2.Editar
{
    public partial class frm_Manipulacao_Bolsa : Form
    {
        public frm_Manipulacao_Bolsa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Bolsa x in Dados.listaBolsas)
            {
                listBox1.Items.Add(x);
            }
        }
    }
}

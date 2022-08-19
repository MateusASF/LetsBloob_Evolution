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
    public partial class frm_Manipulacao_Doador : Form
    {
        public frm_Manipulacao_Doador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Doador x in Dados.listaDoadores)
            {
                listBox1.Items.Add(x);
            }
        }
    }
}

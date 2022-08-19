using LetsBloob_2.Banco_de_Dados;
using LetsBlood_2.Editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsBloob_2
{
    public partial class frm_Consultas : Form
    {
        public frm_Consultas()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Consultas_Load(object sender, EventArgs e)
        {

        }

        private void bt_consultar_doador_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Manipulacao_Doador form = new frm_Manipulacao_Doador();
            form.ShowDialog();
            this.Show();
        }

        private void bt_consultar_bolsa_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Manipulacao_Bolsa form = new frm_Manipulacao_Bolsa();
            form.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProtegerSaida();
        }

        private void lb_sair_Click(object sender, EventArgs e)
        {
            ProtegerSaida();
        }

        private void ProtegerSaida()
        {
            const string message = "Tem certeza que deseja fechar o programa?";
            const string caption = "Fechar";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

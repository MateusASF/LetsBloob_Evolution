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

namespace LetsBlood_2.Cadastros_Forms
{

    public partial class frm_cadastrarDoador : Form
    {
        public frm_cadastrarDoador()
        {
            InitializeComponent();
        }
        private void frm_cadastrarDoador_Load(object sender, EventArgs e)
        {
            pb_resultado.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doador doa = new Doador();
            doa.NomeDoador = tb_Nome_Doador.Text;
            doa.CpfDoador = mTb_Cpf.Text;
            doa.Nascimento = dTp_Nascimento.Value;
            doa.Telefone = mTb_Telefone.Text;
            doa.Email = tb_Email.Text;
            doa.Observacao = tb_Obs.Text;
            pb_resultado.Visible = true;

            Dados.listaDoadores.Add(doa);

            limparCampos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void limparCampos()
        {
            Thread.Sleep(2000);
            tb_Nome_Doador.Clear();
            mTb_Cpf.Clear();
            //dTp_Nascimento
            mTb_Telefone.Clear();
            tb_Email.Clear();
            tb_Obs.Clear();
            //pb_resultado.Visible = false;
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

    }


}

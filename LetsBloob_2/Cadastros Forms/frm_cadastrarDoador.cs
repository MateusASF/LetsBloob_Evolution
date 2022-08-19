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

            Dados.listaDoadores.Add(doa);

            lb_Resultado.Text = "Doador Cadastrado";
        }
    }
}

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
    public partial class frm_cadastrarBolsa : Form
    {
        public frm_cadastrarBolsa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bolsa bolsa = new Bolsa();

            var checkedButton = gb_TipoSanguineo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            bolsa.DataColeta = dTp_DataColeta.Value;
            bolsa.NomeMedico = tb_NomeMedico.Text;
            bolsa.CpfDoador = mTb_CpfDoador.Text;
            bolsa.HospitalDestino = tb_HospitalDestino.Text;
            bolsa.ObservacaoBolsa = tb_Observacao.Text;
            bolsa.TipoSanguineo = checkedButton.Text;

            Dados.listaBolsas.Add(bolsa);

            pb_resultado.Visible = true;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_cadastrarBolsa_Load(object sender, EventArgs e)
        {
            pb_resultado.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            Bolsa bolsa = new Bolsa();

            var checkedButton = gb_TipoSanguineo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            bolsa.DataColeta = dTp_DataColeta.Value;
            bolsa.NomeMedico = tb_NomeMedico.Text;
            bolsa.CpfDoador = mTb_CpfDoador.Text;
            bolsa.HospitalDestino = tb_HospitalDestino.Text;
            bolsa.ObservacaoBolsa = tb_Observacao.Text;
            bolsa.TipoSanguineo = checkedButton.Text;


            Dados.listaBolsas.Add(bolsa);

            pb_resultado.Visible = true;
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            //dTp_DataColeta.Clear();
            tb_NomeMedico.Clear();
            mTb_CpfDoador.Clear();
            tb_HospitalDestino.Clear();
            tb_Observacao.Clear();
            pb_resultado.Visible = false;
        }


    }
}

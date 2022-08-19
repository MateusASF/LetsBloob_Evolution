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

            lb_Resultado.Text = "Bolsa Cadastrada";
        }
    }
}

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

            string tipo = "";
            if (radioButton1.Checked)
            {
                tipo = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                tipo = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                tipo = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                tipo = radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                tipo = radioButton5.Text;
            }
            else if (radioButton6.Checked)
            {
                tipo = radioButton6.Text;
            }
            else if (radioButton7.Checked)
            {
                tipo = radioButton7.Text;
            }
            else 
            {
                tipo = radioButton8.Text;
            }

            bolsa.DataColeta = dTp_DataColeta.Value;
            bolsa.NomeMedico = tb_NomeMedico.Text;
            bolsa.CpfDoador = mTb_CpfDoador.Text;
            bolsa.HospitalDestino = tb_HospitalDestino.Text;
            bolsa.ObservacaoBolsa = tb_Observacao.Text;
            bolsa.TipoSanguineo = tipo;


            Dados.listaBolsas.Add(bolsa);

            lb_Resultado.Text = "Bolsa Cadastrada";
        }
    }
}

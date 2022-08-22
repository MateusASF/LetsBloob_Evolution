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

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            //BOTAO CADASTRAR/ALTERAR

            int index = -1;
            foreach (Bolsa item in Dados.listaBolsas)
            {
                if (item.NomeMedico == tb_NomeMedico.Text)
                {
                    index = Dados.listaBolsas.IndexOf(item);
                }
            }                    

            if (mTb_CpfDoador.Text == "   -   -   -")
            {
                MessageBox.Show("Preencha o campo CPF.");
                mTb_CpfDoador.Focus();
                return;
            }

            if (tb_HospitalDestino.Text == "")
            {
                MessageBox.Show("Preencha o campo Hospital de Destino.");
                tb_HospitalDestino.Focus();
                return;
            }
            
            var checkedButton = gb_TipoSanguineo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            Bolsa bolsa = new Bolsa();

            bolsa.DataColeta = dTp_DataColeta.Text;
            bolsa.NomeMedico = tb_NomeMedico.Text;
            bolsa.CpfDoador = mTb_CpfDoador.Text;
            bolsa.HospitalDestino = tb_HospitalDestino.Text;
            bolsa.ObservacaoBolsa = tb_Observacao.Text;
            bolsa.TipoSanguineo = checkedButton.Text;

            Dados.listaBolsas.Add(bolsa);  

            Listar();

            //limparCampos();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            tb_NomeMedico.Focus();
        }

        private void limparCampos()
        {
            ltbResultado.Items.Clear();
            dTp_DataColeta.Text = "";
            tb_NomeMedico.Clear();
            mTb_CpfDoador.Clear();
            tb_HospitalDestino.Clear();
            tb_Observacao.Clear();
            pb_resultado.Visible = false;
            var checkedButton = gb_TipoSanguineo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {
                checkedButton.Checked = false;
            }
            
            Listar();
        }
        private void Listar()
        {
            ltbResultado.Items.Clear();

            foreach (Bolsa p in Dados.listaBolsas)
            {
                ltbResultado.Items.Add(p);
                Console.WriteLine();
            }
        }

        private void ltbResultado_DoubleClick(object sender, EventArgs e)
        {           
            var index = ltbResultado.SelectedIndex;
            Bolsa bolsa = Dados.listaBolsas[index];
            dTp_DataColeta.Text = bolsa.DataColeta;
            tb_NomeMedico.Text = bolsa.NomeMedico;
            mTb_CpfDoador.Text = bolsa.CpfDoador;
            tb_HospitalDestino.Text = bolsa.HospitalDestino;
            tb_Observacao.Text = bolsa.ObservacaoBolsa;           
            var checkedButton = gb_TipoSanguineo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Text == bolsa.TipoSanguineo);
            if (checkedButton != null)
            {
                checkedButton.Checked = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int index = ltbResultado.SelectedIndex;
            DialogResult resp = MessageBox.Show("Você deseja mesmo excluir a bolsa?", "Exluir", MessageBoxButtons.YesNo);
            if(resp == DialogResult.Yes)
            {
                Dados.listaBolsas.RemoveAt(index);
                Console.WriteLine("Bolsa excluida com sucesso!");
                Listar();
            }                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Bolsa p in Dados.listaBolsas)
            {
                ltbResultado.Items.Add(p);
                Console.WriteLine();
            }
        }

        private void lupa_consultaMedico_Click(object sender, EventArgs e)
        {
            ltbResultado.Items.Clear();
            var bolsas = Dados.listaBolsas.Where(bolsa => bolsa.NomeMedico == tb_NomeMedico.Text);
            ltbResultado.Items.AddRange(bolsas.ToArray());
        }

        private void lupa_consultaCPF_Click(object sender, EventArgs e)
        {
            ltbResultado.Items.Clear();
            var bolsas = Dados.listaBolsas.Where(bolsa => bolsa.CpfDoador == mTb_CpfDoador.Text);
            ltbResultado.Items.AddRange(bolsas.ToArray());
        }

        private void lupa_consultaHospital_Click(object sender, EventArgs e)
        {
            ltbResultado.Items.Clear();
            var bolsas = Dados.listaBolsas.Where(bolsa => bolsa.HospitalDestino == tb_HospitalDestino.Text);
            ltbResultado.Items.AddRange(bolsas.ToArray());
        }

        private void lupa_consultaTipoSanguineo_Click(object sender, EventArgs e)
        {
            ltbResultado.Items.Clear();
            var checkedButton = gb_TipoSanguineo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var bolsas = Dados.listaBolsas.Where(bolsa => bolsa.TipoSanguineo == checkedButton.Text);
            ltbResultado.Items.AddRange(bolsas.ToArray());
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

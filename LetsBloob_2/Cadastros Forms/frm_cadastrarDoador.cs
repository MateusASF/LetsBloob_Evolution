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

            int index = -1;
            foreach (Doador item in Dados.listaDoadores)
            {
                if (item.NomeDoador == tb_Nome_Doador.Text)
                {
                    index = Dados.listaDoadores.IndexOf(item);
                }
            }

            if (mTb_Cpf.Text == "   -   -   -")
            {
                MessageBox.Show("Preencha o campo CPF.");
                mTb_Cpf.Focus();
                return;
            }

            if (mTb_Telefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo telefone.");
                mTb_Telefone.Focus();
                return;
            }
            Doador doa = new Doador();
            doa.NomeDoador = tb_Nome_Doador.Text;
            doa.CpfDoador = mTb_Cpf.Text;
            doa.Nascimento = dTp_Nascimento.Text;
            doa.Telefone = mTb_Telefone.Text;
            doa.Email = tb_Email.Text;
            doa.Observacao = tb_Obs.Text;
            pb_resultado.Visible = true;

            Dados.listaDoadores.Add(doa);

            Listar();

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


        private async Task limparCampos()
        {
            Listar();
            tb_Nome_Doador.Clear();
            mTb_Cpf.Clear();
            //dTp_Nascimento
            mTb_Telefone.Clear();
            tb_Email.Clear();
            tb_Obs.Clear();
            await Task.Delay(800);
            pb_resultado.Visible = false;
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void Listar()
        {
            listBox1.Items.Clear();

            foreach (Doador p in Dados.listaDoadores)
            {
                listBox1.Items.Add(p);
                Console.WriteLine();
            }
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            DialogResult resp = MessageBox.Show("Você deseja mesmo excluir o doador?", "Exluir", MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes)
            {
                Dados.listaDoadores.RemoveAt(index);
                Console.WriteLine("Doador excluido com sucesso!");
                Listar();
            }
        }

        private void bt_ListaCompleta_Click(object sender, EventArgs e)
        {
            foreach (Doador p in Dados.listaDoadores)
            {
                listBox1.Items.Add(p);
                Console.WriteLine();
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex;
            Doador doador = Dados.listaDoadores[index];
            dTp_Nascimento.Text = doador.Nascimento;
            tb_Nome_Doador.Text = doador.NomeDoador;
            mTb_Cpf.Text = doador.CpfDoador;
            mTb_Telefone.Text = doador.Telefone;
            tb_Obs.Text = doador.Observacao;
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

        private void lupa_consultaCpf_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var doa = Dados.listaDoadores.Where(doa => doa.CpfDoador == mTb_Cpf.Text);
            listBox1.Items.AddRange(doa.ToArray());
        }

        private void lupa_consultaTelefone_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var doa = Dados.listaDoadores.Where(doa => doa.Telefone == mTb_Telefone.Text);
            listBox1.Items.AddRange(doa.ToArray());
        }

        private void lupa_consultaNome_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var doa = Dados.listaDoadores.Where(doa => doa.NomeDoador == tb_Nome_Doador.Text);
            listBox1.Items.AddRange(doa.ToArray());
        }

    }


}

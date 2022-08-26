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
// ? espera um nulo
// ! confirma que não será nulo


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
            pb_exc.Visible = false;
            pb_alt.Visible = false;
            bt_excluir.Enabled = false;
            bt_alterar.Enabled = false;
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
            mTb_Telefone.Clear();
            tb_Email.Clear();
            tb_Obs.Clear();
            await Task.Delay(1200);
            pb_exc.Visible = false;
            pb_alt.Visible = false;
            pb_resultado.Visible = false;
            if (bt_alterar.Enabled == true)
            {
                bt_alterar.Enabled = false;
                bt_excluir.Enabled = false;
                bt_cadastrar.Enabled = true;
                mTb_Cpf.Enabled = true;
            }
        }

        private async void bt_limpar_Click(object sender, EventArgs e)
        {
            await limparCampos();
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

        private async void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Você deseja mesmo excluir o doador(a)?", "Exluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resp == DialogResult.Yes)
            {
                var doador = Dados.listaDoadores.Find(doador => doador.CpfDoador == mTb_Cpf.Text.Replace("-", "").Replace(".", ""));
                Dados.listaDoadores.Remove(doador!);
                pb_exc.Visible = true;
                Listar();
                await limparCampos();
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
            mTb_Cpf.Enabled = false;
            bt_excluir.Enabled = true;
            bt_alterar.Enabled = true;
            bt_cadastrar.Enabled = false;

            string ? linhaSelecionada = listBox1.SelectedItem.ToString();

            foreach (var doador in Dados.listaDoadores)
            {
                if (linhaSelecionada!.Contains(doador.CpfDoador))
                {
                    dTp_Nascimento.Text = doador.Nascimento;
                    tb_Nome_Doador.Text = doador.NomeDoador;
                    mTb_Cpf.Text = doador.CpfDoador;
                    tb_Email.Text = doador.Email;
                    mTb_Telefone.Text = doador.Telefone;
                    tb_Obs.Text = doador.Observacao;
                    break;
                }
            }
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
            var doa = Dados.listaDoadores.Where(doa => doa.CpfDoador == mTb_Cpf.Text.Replace("-", "").Replace(".", ""));
            listBox1.Items.AddRange(doa.ToArray());
        }

        private void lupa_consultaTelefone_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var doa = Dados.listaDoadores.Where(doa => doa.Telefone == mTb_Telefone.Text.Replace(" ","").Replace("(", "").Replace(")", "").Replace("-", ""));
            listBox1.Items.AddRange(doa.ToArray());
        }

        private void lupa_consultaNome_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var doa = Dados.listaDoadores.Where(doa => doa.NomeDoador == tb_Nome_Doador.Text);
            listBox1.Items.AddRange(doa.ToArray());
        }

        private async void bt_alterar_Click(object sender, EventArgs e)
        {
            if (tb_Nome_Doador.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome do Doador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_Nome_Doador.Focus();
                return;
            }

            if (mTb_Cpf.Text == "   -   -   -")
            {
                MessageBox.Show("Preencha o campo CPF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mTb_Cpf.Focus();
                return;
            }

            if (mTb_Telefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo telefone.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mTb_Telefone.Focus();
                return;
            }
            var doa = Dados.listaDoadores.Find(doa => doa.CpfDoador == mTb_Cpf.Text.Replace("-", "").Replace(".", ""));

            doa!.NomeDoador = tb_Nome_Doador.Text;
            doa.CpfDoador = mTb_Cpf.Text.Replace("-", "").Replace(".", "");
            doa.Nascimento = dTp_Nascimento.Text;
            doa.Telefone = mTb_Telefone.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "");
            doa.Email = tb_Email.Text;
            doa.Observacao = tb_Obs.Text;
            pb_alt.Visible = true;

            Listar();

            await limparCampos();
        }

        private async void bt_cadastrar_Click(object sender, EventArgs e)
        {
            if (tb_Nome_Doador.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome do Doador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_Nome_Doador.Focus();
                return;
            }

            if (mTb_Cpf.Text == "   -   -   -")
            {
                MessageBox.Show("Preencha o campo CPF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mTb_Cpf.Focus();
                return;
            }

            if (mTb_Telefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo telefone." ,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mTb_Telefone.Focus();
                return;
            }

            Doador doa = new Doador();
            doa.NomeDoador = tb_Nome_Doador.Text;
            doa.CpfDoador = mTb_Cpf.Text.Replace("-", "").Replace(".", "");
            doa.Nascimento = dTp_Nascimento.Text;
            doa.Telefone = mTb_Telefone.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "");
            doa.Email = tb_Email.Text;
            doa.Observacao = tb_Obs.Text;

            if (Dados.listaDoadores.Any(l => l.CpfDoador == doa.CpfDoador))
            {
                MessageBox.Show($"O CPF {mTb_Cpf.Text} já está cadastrado.","Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mTb_Cpf.Focus();
                return;
            }
            else
            {
                Dados.listaDoadores.Add(doa);
                pb_resultado.Visible = true;
            }

            Listar();

            await limparCampos();
        }

        private void bt_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
Guia para uso do Programa:

* Para cadastrar uma nova informação, será necessário preeencher todos os campos obrigatórios, mas não se preocupe pois caso esqueça algum o programa vai lhe avisar.

* Ao abrir o programa os botões 'Editar' e 'Excluir' são desabilitados, para que possa habilitá-los é necessário dar um duplo clique no item desejado dentro da box de resultados.

* Quando os botões 'Editar' e 'Excluir' são habilitados o botão 'Cadastrar' é desabilitado por segurança.

* O CPF não pode ser editado, caso haja um erro ao cadastrar deverá excluir e recadastrar a informação desajada, por isso o campo sempre é bloqueado para edições.

* Para realizar uma pesquisa basta preencher algum dos campos que possuem uma lupa ao lado, e em seguida clicar na lupa para pesquisar.

* O botão 'Limpar' limpa somente os campos para digitação.

", "Instruções", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


}

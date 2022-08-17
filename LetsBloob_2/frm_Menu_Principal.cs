using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LetsBloob_2
{
    public partial class frm_Menu_Principal : Form
    {
        public frm_Menu_Principal()
        {
            InitializeComponent();
        }

        private void frm_Menu_Principal_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.TabStop = false;
                }
            }
        }

        private void bt_cadastros_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Cadastros form = new frm_Cadastros();
            form.ShowDialog();
            this.Show();
        }

        private void bt_consultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Consultas form = new frm_Consultas();
            form.ShowDialog();
            this.Show();
        }

        private void bt_deletes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Deletes form = new frm_Deletes();
            form.ShowDialog();
            this.Show();
        }

        private void bt_informacoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Informacoes form = new frm_Informacoes();
            form.ShowDialog();
            this.Show();
        }
    }
}

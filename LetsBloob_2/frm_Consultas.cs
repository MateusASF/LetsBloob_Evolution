using LetsBloob_2.Banco_de_Dados;
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

        private void frm_Consultas_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
        }

        private void CarregarDataGridView()
        {
            ComandosBD contatoDao = new ComandosBD();
            DataSet ds = contatoDao.GetDoadores();
            dataGridView1.DataSource = ds.Tables["medico"];
            dataGridView1.Refresh();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

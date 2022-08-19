namespace LetsBlood_2.Cadastros_Forms
{
    partial class frm_cadastrarDoador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Nome_Doador = new System.Windows.Forms.TextBox();
            this.dTp_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mTb_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mTb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Obs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Nome_Doador
            // 
            this.tb_Nome_Doador.Location = new System.Drawing.Point(43, 48);
            this.tb_Nome_Doador.Name = "tb_Nome_Doador";
            this.tb_Nome_Doador.Size = new System.Drawing.Size(479, 27);
            this.tb_Nome_Doador.TabIndex = 0;
            // 
            // dTp_Nascimento
            // 
            this.dTp_Nascimento.Location = new System.Drawing.Point(43, 175);
            this.dTp_Nascimento.Name = "dTp_Nascimento";
            this.dTp_Nascimento.Size = new System.Drawing.Size(313, 27);
            this.dTp_Nascimento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF";
            // 
            // mTb_Cpf
            // 
            this.mTb_Cpf.Location = new System.Drawing.Point(43, 111);
            this.mTb_Cpf.Mask = "000-000-000-00";
            this.mTb_Cpf.Name = "mTb_Cpf";
            this.mTb_Cpf.Size = new System.Drawing.Size(111, 27);
            this.mTb_Cpf.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nascimento";
            // 
            // mTb_Telefone
            // 
            this.mTb_Telefone.Location = new System.Drawing.Point(204, 111);
            this.mTb_Telefone.Mask = "(00) 00000-0000";
            this.mTb_Telefone.Name = "mTb_Telefone";
            this.mTb_Telefone.Size = new System.Drawing.Size(111, 27);
            this.mTb_Telefone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefone";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(43, 244);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(479, 27);
            this.tb_Email.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "OBS";
            // 
            // tb_Obs
            // 
            this.tb_Obs.Location = new System.Drawing.Point(43, 312);
            this.tb_Obs.Multiline = true;
            this.tb_Obs.Name = "tb_Obs";
            this.tb_Obs.Size = new System.Drawing.Size(479, 55);
            this.tb_Obs.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(566, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 319);
            this.button1.TabIndex = 15;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.AutoSize = true;
            this.lb_Resultado.BackColor = System.Drawing.Color.Transparent;
            this.lb_Resultado.Location = new System.Drawing.Point(278, 414);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(0, 20);
            this.lb_Resultado.TabIndex = 16;
            // 
            // frm_cadastrarDoador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.lb_Resultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Obs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mTb_Telefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mTb_Cpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTp_Nascimento);
            this.Controls.Add(this.tb_Nome_Doador);
            this.Name = "frm_cadastrarDoador";
            this.Text = "frm_cadastrarDoador";
            this.Load += new System.EventHandler(this.frm_cadastrarDoador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_Nome_Doador;
        private DateTimePicker dTp_Nascimento;
        private Label label1;
        private Label label2;
        private MaskedTextBox mTb_Cpf;
        private Label label4;
        private MaskedTextBox mTb_Telefone;
        private Label label5;
        private TextBox tb_Email;
        private Label label6;
        private Label label3;
        private TextBox tb_Obs;
        private Button button1;
        private Label lb_Resultado;
    }
}
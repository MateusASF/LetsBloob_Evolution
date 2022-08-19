namespace LetsBlood_2.Cadastros_Forms
{
    partial class frm_cadastrarBolsa
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
            this.dTp_DataColeta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Observacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_TipoSanguineo = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NomeMedico = new System.Windows.Forms.TextBox();
            this.mTb_CpfDoador = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_HospitalDestino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_Resultado = new System.Windows.Forms.Label();
            this.gb_TipoSanguineo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTp_DataColeta
            // 
            this.dTp_DataColeta.Location = new System.Drawing.Point(65, 37);
            this.dTp_DataColeta.Name = "dTp_DataColeta";
            this.dTp_DataColeta.Size = new System.Drawing.Size(250, 27);
            this.dTp_DataColeta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data da Coleta";
            // 
            // tb_Observacao
            // 
            this.tb_Observacao.Location = new System.Drawing.Point(66, 294);
            this.tb_Observacao.Multiline = true;
            this.tb_Observacao.Name = "tb_Observacao";
            this.tb_Observacao.Size = new System.Drawing.Size(250, 56);
            this.tb_Observacao.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Obs";
            // 
            // gb_TipoSanguineo
            // 
            this.gb_TipoSanguineo.Controls.Add(this.radioButton8);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton7);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton6);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton5);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton4);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton3);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton2);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton1);
            this.gb_TipoSanguineo.Location = new System.Drawing.Point(367, 27);
            this.gb_TipoSanguineo.Name = "gb_TipoSanguineo";
            this.gb_TipoSanguineo.Size = new System.Drawing.Size(144, 264);
            this.gb_TipoSanguineo.TabIndex = 8;
            this.gb_TipoSanguineo.TabStop = false;
            this.gb_TipoSanguineo.Text = "Tipo Sanguíneo";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(27, 234);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(47, 24);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "O-";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(27, 202);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(51, 24);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "O+";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(27, 172);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(55, 24);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "AB-";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(27, 146);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(59, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "AB+";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(27, 116);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(45, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "B-";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 86);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(49, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "B+";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "A-";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A+";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome do Médico";
            // 
            // tb_NomeMedico
            // 
            this.tb_NomeMedico.Location = new System.Drawing.Point(66, 103);
            this.tb_NomeMedico.Name = "tb_NomeMedico";
            this.tb_NomeMedico.Size = new System.Drawing.Size(249, 27);
            this.tb_NomeMedico.TabIndex = 10;
            // 
            // mTb_CpfDoador
            // 
            this.mTb_CpfDoador.Location = new System.Drawing.Point(66, 165);
            this.mTb_CpfDoador.Mask = "000-000-000-00";
            this.mTb_CpfDoador.Name = "mTb_CpfDoador";
            this.mTb_CpfDoador.Size = new System.Drawing.Size(250, 27);
            this.mTb_CpfDoador.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "CPF do Doador";
            // 
            // tb_HospitalDestino
            // 
            this.tb_HospitalDestino.Location = new System.Drawing.Point(66, 236);
            this.tb_HospitalDestino.Name = "tb_HospitalDestino";
            this.tb_HospitalDestino.Size = new System.Drawing.Size(249, 27);
            this.tb_HospitalDestino.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hospital de Destino";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.AutoSize = true;
            this.lb_Resultado.Location = new System.Drawing.Point(266, 380);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(0, 20);
            this.lb_Resultado.TabIndex = 16;
            // 
            // frm_cadastrarBolsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 447);
            this.Controls.Add(this.lb_Resultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_HospitalDestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mTb_CpfDoador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_NomeMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gb_TipoSanguineo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Observacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTp_DataColeta);
            this.Name = "frm_cadastrarBolsa";
            this.Text = "frm_cadastrarBolsa";
            this.gb_TipoSanguineo.ResumeLayout(false);
            this.gb_TipoSanguineo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dTp_DataColeta;
        private Label label1;
        private TextBox tb_Observacao;
        private Label label2;
        private GroupBox gb_TipoSanguineo;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private TextBox tb_NomeMedico;
        private MaskedTextBox mTb_CpfDoador;
        private Label label4;
        private TextBox tb_HospitalDestino;
        private Label label5;
        private Button button1;
        private Label lb_Resultado;
    }
}
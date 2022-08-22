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
            this.lb_voltar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_resultado = new System.Windows.Forms.PictureBox();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.ltbResultado = new System.Windows.Forms.ListBox();
            this.btnConsultaCPF = new System.Windows.Forms.Button();
            this.btnConsultaHospital = new System.Windows.Forms.Button();
            this.btnConsultaMedico = new System.Windows.Forms.Button();
            this.btnPesquisarTipo = new System.Windows.Forms.Button();
            this.gb_TipoSanguineo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dTp_DataColeta
            // 
            this.dTp_DataColeta.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dTp_DataColeta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTp_DataColeta.Location = new System.Drawing.Point(25, 39);
            this.dTp_DataColeta.Name = "dTp_DataColeta";
            this.dTp_DataColeta.Size = new System.Drawing.Size(317, 23);
            this.dTp_DataColeta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data da Coleta";
            // 
            // tb_Observacao
            // 
            this.tb_Observacao.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Observacao.Location = new System.Drawing.Point(26, 309);
            this.tb_Observacao.Multiline = true;
            this.tb_Observacao.Name = "tb_Observacao";
            this.tb_Observacao.Size = new System.Drawing.Size(316, 59);
            this.tb_Observacao.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Observação";
            // 
            // gb_TipoSanguineo
            // 
            this.gb_TipoSanguineo.BackColor = System.Drawing.Color.Transparent;
            this.gb_TipoSanguineo.Controls.Add(this.radioButton8);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton7);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton6);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton5);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton4);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton3);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton2);
            this.gb_TipoSanguineo.Controls.Add(this.radioButton1);
            this.gb_TipoSanguineo.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_TipoSanguineo.Location = new System.Drawing.Point(506, 45);
            this.gb_TipoSanguineo.Name = "gb_TipoSanguineo";
            this.gb_TipoSanguineo.Size = new System.Drawing.Size(144, 277);
            this.gb_TipoSanguineo.TabIndex = 8;
            this.gb_TipoSanguineo.TabStop = false;
            this.gb_TipoSanguineo.Text = "Tipo Sanguíneo";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(27, 246);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(38, 22);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "O-";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(27, 212);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(41, 22);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "O+";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(27, 181);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(44, 22);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "AB-";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(27, 153);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(47, 22);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "AB+";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(27, 122);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 22);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "B-";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 90);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(40, 22);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "B+";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "A-";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A+";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome do Médico";
            // 
            // tb_NomeMedico
            // 
            this.tb_NomeMedico.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_NomeMedico.Location = new System.Drawing.Point(26, 108);
            this.tb_NomeMedico.Name = "tb_NomeMedico";
            this.tb_NomeMedico.Size = new System.Drawing.Size(316, 23);
            this.tb_NomeMedico.TabIndex = 10;
            // 
            // mTb_CpfDoador
            // 
            this.mTb_CpfDoador.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mTb_CpfDoador.Location = new System.Drawing.Point(26, 173);
            this.mTb_CpfDoador.Mask = "000-000-000-00";
            this.mTb_CpfDoador.Name = "mTb_CpfDoador";
            this.mTb_CpfDoador.Size = new System.Drawing.Size(316, 23);
            this.mTb_CpfDoador.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "CPF do Doador";
            // 
            // tb_HospitalDestino
            // 
            this.tb_HospitalDestino.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_HospitalDestino.Location = new System.Drawing.Point(25, 240);
            this.tb_HospitalDestino.Name = "tb_HospitalDestino";
            this.tb_HospitalDestino.Size = new System.Drawing.Size(317, 23);
            this.tb_HospitalDestino.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hospital de Destino";
            // 
            // lb_voltar
            // 
            this.lb_voltar.AutoSize = true;
            this.lb_voltar.BackColor = System.Drawing.Color.Transparent;
            this.lb_voltar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_voltar.Location = new System.Drawing.Point(69, 452);
            this.lb_voltar.Name = "lb_voltar";
            this.lb_voltar.Size = new System.Drawing.Size(51, 15);
            this.lb_voltar.TabIndex = 18;
            this.lb_voltar.Text = "VOLTAR";
            this.lb_voltar.Click += new System.EventHandler(this.lb_voltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LetsBlood_2.Properties.Resources.voltar;
            this.pictureBox1.Location = new System.Drawing.Point(38, 394);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_resultado
            // 
            this.pb_resultado.BackColor = System.Drawing.Color.Transparent;
            this.pb_resultado.Image = global::LetsBlood_2.Properties.Resources.bolsaCadastrada;
            this.pb_resultado.Location = new System.Drawing.Point(566, 377);
            this.pb_resultado.Name = "pb_resultado";
            this.pb_resultado.Size = new System.Drawing.Size(231, 82);
            this.pb_resultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_resultado.TabIndex = 19;
            this.pb_resultado.TabStop = false;
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bt_limpar.Font = new System.Drawing.Font("Sitka Banner", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_limpar.Location = new System.Drawing.Point(694, 267);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(203, 49);
            this.bt_limpar.TabIndex = 28;
            this.bt_limpar.Text = "LIMPAR";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnExcluir.Font = new System.Drawing.Font("Sitka Banner", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Location = new System.Drawing.Point(694, 181);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(203, 49);
            this.btnExcluir.TabIndex = 27;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bt_cadastrar.Font = new System.Drawing.Font("Sitka Banner", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_cadastrar.Location = new System.Drawing.Point(694, 59);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(203, 98);
            this.bt_cadastrar.TabIndex = 25;
            this.bt_cadastrar.Text = "CADASTRAR / ALTERAR";
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // ltbResultado
            // 
            this.ltbResultado.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ltbResultado.FormattingEnabled = true;
            this.ltbResultado.ItemHeight = 18;
            this.ltbResultado.Location = new System.Drawing.Point(12, 474);
            this.ltbResultado.Name = "ltbResultado";
            this.ltbResultado.Size = new System.Drawing.Size(936, 148);
            this.ltbResultado.TabIndex = 29;
            this.ltbResultado.SelectedIndexChanged += new System.EventHandler(this.ltbResultado_SelectedIndexChanged);
            this.ltbResultado.DoubleClick += new System.EventHandler(this.ltbResultado_DoubleClick);
            // 
            // btnConsultaCPF
            // 
            this.btnConsultaCPF.Location = new System.Drawing.Point(348, 173);
            this.btnConsultaCPF.Name = "btnConsultaCPF";
            this.btnConsultaCPF.Size = new System.Drawing.Size(75, 32);
            this.btnConsultaCPF.TabIndex = 30;
            this.btnConsultaCPF.Text = "pesquisar";
            this.btnConsultaCPF.UseVisualStyleBackColor = true;
            this.btnConsultaCPF.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnConsultaHospital
            // 
            this.btnConsultaHospital.Location = new System.Drawing.Point(348, 240);
            this.btnConsultaHospital.Name = "btnConsultaHospital";
            this.btnConsultaHospital.Size = new System.Drawing.Size(75, 26);
            this.btnConsultaHospital.TabIndex = 31;
            this.btnConsultaHospital.Text = "pesquisar";
            this.btnConsultaHospital.UseVisualStyleBackColor = true;
            this.btnConsultaHospital.Click += new System.EventHandler(this.btnConsultaHospital_Click);
            // 
            // btnConsultaMedico
            // 
            this.btnConsultaMedico.Location = new System.Drawing.Point(348, 106);
            this.btnConsultaMedico.Name = "btnConsultaMedico";
            this.btnConsultaMedico.Size = new System.Drawing.Size(75, 38);
            this.btnConsultaMedico.TabIndex = 32;
            this.btnConsultaMedico.Text = "pesquisar";
            this.btnConsultaMedico.UseVisualStyleBackColor = true;
            this.btnConsultaMedico.Click += new System.EventHandler(this.btnConsultaMedico_Click);
            // 
            // btnPesquisarTipo
            // 
            this.btnPesquisarTipo.Location = new System.Drawing.Point(533, 328);
            this.btnPesquisarTipo.Name = "btnPesquisarTipo";
            this.btnPesquisarTipo.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarTipo.TabIndex = 33;
            this.btnPesquisarTipo.Text = "pesquisar";
            this.btnPesquisarTipo.UseVisualStyleBackColor = true;
            this.btnPesquisarTipo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frm_cadastrarBolsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LetsBlood_2.Properties.Resources.istockphoto_1004961356_170667a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 668);
            this.ControlBox = false;
            this.Controls.Add(this.btnPesquisarTipo);
            this.Controls.Add(this.btnConsultaMedico);
            this.Controls.Add(this.btnConsultaHospital);
            this.Controls.Add(this.btnConsultaCPF);
            this.Controls.Add(this.ltbResultado);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.pb_resultado);
            this.Controls.Add(this.lb_voltar);
            this.Controls.Add(this.pictureBox1);
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
            this.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "frm_cadastrarBolsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Bolsa";
            this.Load += new System.EventHandler(this.frm_cadastrarBolsa_Load);
            this.gb_TipoSanguineo.ResumeLayout(false);
            this.gb_TipoSanguineo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resultado)).EndInit();
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
        private Label lb_voltar;
        private PictureBox pictureBox1;
        private PictureBox pb_resultado;
        private Button bt_limpar;
        private Button btnExcluir;
        private Button bt_cadastrar;
        private ListBox ltbResultado;
        private Button btnConsultaCPF;
        private Button btnConsultaHospital;
        private Button btnConsultaMedico;
        private Button btnPesquisarTipo;
    }
}
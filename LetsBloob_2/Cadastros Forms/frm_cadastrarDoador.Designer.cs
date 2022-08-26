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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastrarDoador));
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
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.lb_Resultado = new System.Windows.Forms.Label();
            this.lb_voltar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_resultado = new System.Windows.Forms.PictureBox();
            this.bt_ListaCompleta = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lb_sair = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lupa_consultaCpf = new System.Windows.Forms.PictureBox();
            this.lupa_consultaTelefone = new System.Windows.Forms.PictureBox();
            this.lupa_consultaNome = new System.Windows.Forms.PictureBox();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.pb_alt = new System.Windows.Forms.PictureBox();
            this.pb_exc = new System.Windows.Forms.PictureBox();
            this.bt_info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupa_consultaCpf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupa_consultaTelefone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupa_consultaNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_alt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exc)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Nome_Doador
            // 
            this.tb_Nome_Doador.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Nome_Doador.Location = new System.Drawing.Point(53, 26);
            this.tb_Nome_Doador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Nome_Doador.Name = "tb_Nome_Doador";
            this.tb_Nome_Doador.Size = new System.Drawing.Size(364, 23);
            this.tb_Nome_Doador.TabIndex = 0;
            // 
            // dTp_Nascimento
            // 
            this.dTp_Nascimento.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dTp_Nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTp_Nascimento.Location = new System.Drawing.Point(53, 127);
            this.dTp_Nascimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTp_Nascimento.Name = "dTp_Nascimento";
            this.dTp_Nascimento.Size = new System.Drawing.Size(396, 23);
            this.dTp_Nascimento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "CPF";
            // 
            // mTb_Cpf
            // 
            this.mTb_Cpf.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mTb_Cpf.Location = new System.Drawing.Point(53, 74);
            this.mTb_Cpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mTb_Cpf.Mask = "000-000-000-00";
            this.mTb_Cpf.Name = "mTb_Cpf";
            this.mTb_Cpf.Size = new System.Drawing.Size(112, 23);
            this.mTb_Cpf.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(53, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nascimento";
            // 
            // mTb_Telefone
            // 
            this.mTb_Telefone.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mTb_Telefone.Location = new System.Drawing.Point(298, 78);
            this.mTb_Telefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mTb_Telefone.Mask = "(00) 00000-0000";
            this.mTb_Telefone.Name = "mTb_Telefone";
            this.mTb_Telefone.Size = new System.Drawing.Size(120, 23);
            this.mTb_Telefone.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(298, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefone";
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Email.Location = new System.Drawing.Point(53, 179);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(396, 23);
            this.tb_Email.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(53, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Observação";
            // 
            // tb_Obs
            // 
            this.tb_Obs.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Obs.Location = new System.Drawing.Point(53, 228);
            this.tb_Obs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Obs.Multiline = true;
            this.tb_Obs.Name = "tb_Obs";
            this.tb_Obs.Size = new System.Drawing.Size(396, 48);
            this.tb_Obs.TabIndex = 5;
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bt_cadastrar.BackgroundImage = global::LetsBlood_2.Properties.Resources.fundo_branco_abstrato_23_2148810353;
            this.bt_cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cadastrar.Font = new System.Drawing.Font("Sitka Banner", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_cadastrar.Location = new System.Drawing.Point(520, 80);
            this.bt_cadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(178, 35);
            this.bt_cadastrar.TabIndex = 6;
            this.bt_cadastrar.Text = "CADASTRAR\r";
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.AutoSize = true;
            this.lb_Resultado.BackColor = System.Drawing.Color.Transparent;
            this.lb_Resultado.Location = new System.Drawing.Point(258, 334);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(0, 15);
            this.lb_Resultado.TabIndex = 18;
            // 
            // lb_voltar
            // 
            this.lb_voltar.AutoSize = true;
            this.lb_voltar.BackColor = System.Drawing.Color.Transparent;
            this.lb_voltar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_voltar.Location = new System.Drawing.Point(62, 349);
            this.lb_voltar.Name = "lb_voltar";
            this.lb_voltar.Size = new System.Drawing.Size(51, 15);
            this.lb_voltar.TabIndex = 10;
            this.lb_voltar.Text = "VOLTAR";
            this.lb_voltar.Click += new System.EventHandler(this.lb_voltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LetsBlood_2.Properties.Resources.voltar;
            this.pictureBox1.Location = new System.Drawing.Point(35, 305);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_resultado
            // 
            this.pb_resultado.BackColor = System.Drawing.Color.Transparent;
            this.pb_resultado.Image = global::LetsBlood_2.Properties.Resources.Let_s_Bl_od__1__removebg_preview__1_;
            this.pb_resultado.Location = new System.Drawing.Point(289, 302);
            this.pb_resultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_resultado.Name = "pb_resultado";
            this.pb_resultado.Size = new System.Drawing.Size(176, 49);
            this.pb_resultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_resultado.TabIndex = 21;
            this.pb_resultado.TabStop = false;
            // 
            // bt_ListaCompleta
            // 
            this.bt_ListaCompleta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_ListaCompleta.BackgroundImage = global::LetsBlood_2.Properties.Resources.fundo_branco_abstrato_23_2148810353;
            this.bt_ListaCompleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ListaCompleta.Font = new System.Drawing.Font("Sitka Banner", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_ListaCompleta.Location = new System.Drawing.Point(520, 275);
            this.bt_ListaCompleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_ListaCompleta.Name = "bt_ListaCompleta";
            this.bt_ListaCompleta.Size = new System.Drawing.Size(178, 77);
            this.bt_ListaCompleta.TabIndex = 9;
            this.bt_ListaCompleta.Text = "MOSTRAR \r\nBASE DE DADOS";
            this.bt_ListaCompleta.UseVisualStyleBackColor = false;
            this.bt_ListaCompleta.Click += new System.EventHandler(this.bt_ListaCompleta_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bt_excluir.BackgroundImage = global::LetsBlood_2.Properties.Resources.fundo_branco_abstrato_23_2148810353;
            this.bt_excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_excluir.Font = new System.Drawing.Font("Sitka Banner", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_excluir.Location = new System.Drawing.Point(520, 176);
            this.bt_excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(178, 35);
            this.bt_excluir.TabIndex = 7;
            this.bt_excluir.Text = "EXCLUIR";
            this.bt_excluir.UseVisualStyleBackColor = false;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_limpar.BackgroundImage = global::LetsBlood_2.Properties.Resources.fundo_branco_abstrato_23_2148810353;
            this.bt_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_limpar.Font = new System.Drawing.Font("Sitka Banner", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_limpar.Location = new System.Drawing.Point(520, 224);
            this.bt_limpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(178, 35);
            this.bt_limpar.TabIndex = 8;
            this.bt_limpar.Text = "LIMPAR";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(40, 380);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(700, 130);
            this.listBox1.TabIndex = 19;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // lb_sair
            // 
            this.lb_sair.AutoSize = true;
            this.lb_sair.BackColor = System.Drawing.Color.Transparent;
            this.lb_sair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_sair.Location = new System.Drawing.Point(189, 349);
            this.lb_sair.Name = "lb_sair";
            this.lb_sair.Size = new System.Drawing.Size(34, 15);
            this.lb_sair.TabIndex = 11;
            this.lb_sair.Text = "SAIR";
            this.lb_sair.Click += new System.EventHandler(this.lb_sair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LetsBlood_2.Properties.Resources.tl__1__removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(158, 302);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lupa_consultaCpf
            // 
            this.lupa_consultaCpf.BackColor = System.Drawing.Color.Transparent;
            this.lupa_consultaCpf.Image = global::LetsBlood_2.Properties.Resources.lupa;
            this.lupa_consultaCpf.Location = new System.Drawing.Point(169, 74);
            this.lupa_consultaCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lupa_consultaCpf.Name = "lupa_consultaCpf";
            this.lupa_consultaCpf.Size = new System.Drawing.Size(26, 23);
            this.lupa_consultaCpf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lupa_consultaCpf.TabIndex = 38;
            this.lupa_consultaCpf.TabStop = false;
            this.lupa_consultaCpf.Click += new System.EventHandler(this.lupa_consultaCpf_Click);
            // 
            // lupa_consultaTelefone
            // 
            this.lupa_consultaTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lupa_consultaTelefone.Image = global::LetsBlood_2.Properties.Resources.lupa;
            this.lupa_consultaTelefone.Location = new System.Drawing.Point(422, 78);
            this.lupa_consultaTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lupa_consultaTelefone.Name = "lupa_consultaTelefone";
            this.lupa_consultaTelefone.Size = new System.Drawing.Size(26, 23);
            this.lupa_consultaTelefone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lupa_consultaTelefone.TabIndex = 39;
            this.lupa_consultaTelefone.TabStop = false;
            this.lupa_consultaTelefone.Click += new System.EventHandler(this.lupa_consultaTelefone_Click);
            // 
            // lupa_consultaNome
            // 
            this.lupa_consultaNome.BackColor = System.Drawing.Color.Transparent;
            this.lupa_consultaNome.Image = global::LetsBlood_2.Properties.Resources.lupa;
            this.lupa_consultaNome.Location = new System.Drawing.Point(422, 24);
            this.lupa_consultaNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lupa_consultaNome.Name = "lupa_consultaNome";
            this.lupa_consultaNome.Size = new System.Drawing.Size(26, 23);
            this.lupa_consultaNome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lupa_consultaNome.TabIndex = 40;
            this.lupa_consultaNome.TabStop = false;
            this.lupa_consultaNome.Click += new System.EventHandler(this.lupa_consultaNome_Click);
            // 
            // bt_alterar
            // 
            this.bt_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.bt_alterar.BackgroundImage = global::LetsBlood_2.Properties.Resources.fundo_branco_abstrato_23_2148810353;
            this.bt_alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_alterar.Font = new System.Drawing.Font("Sitka Banner", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_alterar.Location = new System.Drawing.Point(520, 128);
            this.bt_alterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(178, 35);
            this.bt_alterar.TabIndex = 41;
            this.bt_alterar.Text = "ALTERAR";
            this.bt_alterar.UseVisualStyleBackColor = false;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // pb_alt
            // 
            this.pb_alt.BackColor = System.Drawing.Color.Transparent;
            this.pb_alt.Image = global::LetsBlood_2.Properties.Resources.doa_alt_removebg_preview;
            this.pb_alt.Location = new System.Drawing.Point(290, 302);
            this.pb_alt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_alt.Name = "pb_alt";
            this.pb_alt.Size = new System.Drawing.Size(175, 46);
            this.pb_alt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_alt.TabIndex = 43;
            this.pb_alt.TabStop = false;
            // 
            // pb_exc
            // 
            this.pb_exc.BackColor = System.Drawing.Color.Transparent;
            this.pb_exc.Image = global::LetsBlood_2.Properties.Resources.doa_exc_removebg_preview;
            this.pb_exc.Location = new System.Drawing.Point(290, 302);
            this.pb_exc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_exc.Name = "pb_exc";
            this.pb_exc.Size = new System.Drawing.Size(175, 49);
            this.pb_exc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_exc.TabIndex = 44;
            this.pb_exc.TabStop = false;
            // 
            // bt_info
            // 
            this.bt_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_info.Font = new System.Drawing.Font("Sitka Banner", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_info.Location = new System.Drawing.Point(520, 24);
            this.bt_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_info.Name = "bt_info";
            this.bt_info.Size = new System.Drawing.Size(178, 32);
            this.bt_info.TabIndex = 45;
            this.bt_info.Text = "Instruções de Uso";
            this.bt_info.UseVisualStyleBackColor = false;
            this.bt_info.Click += new System.EventHandler(this.bt_info_Click);
            // 
            // frm_cadastrarDoador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LetsBlood_2.Properties.Resources.ee18e8e53852cf399b3b52c022d31d6d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 541);
            this.ControlBox = false;
            this.Controls.Add(this.bt_info);
            this.Controls.Add(this.pb_exc);
            this.Controls.Add(this.pb_alt);
            this.Controls.Add(this.bt_alterar);
            this.Controls.Add(this.lupa_consultaNome);
            this.Controls.Add(this.lupa_consultaTelefone);
            this.Controls.Add(this.lupa_consultaCpf);
            this.Controls.Add(this.lb_sair);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_ListaCompleta);
            this.Controls.Add(this.pb_resultado);
            this.Controls.Add(this.lb_voltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_Resultado);
            this.Controls.Add(this.bt_cadastrar);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_cadastrarDoador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Doador";
            this.Load += new System.EventHandler(this.frm_cadastrarDoador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupa_consultaCpf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupa_consultaTelefone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupa_consultaNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_alt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exc)).EndInit();
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
        private Button bt_cadastrar;
        private Label lb_Resultado;
        private Label lb_voltar;
        private PictureBox pictureBox1;
        private PictureBox pb_resultado;
        private Button bt_ListaCompleta;
        private Button bt_excluir;
        private Button bt_limpar;
        private ListBox listBox1;
        private Label lb_sair;
        private PictureBox pictureBox2;
        private PictureBox lupa_consultaCpf;
        private PictureBox lupa_consultaTelefone;
        private PictureBox lupa_consultaNome;
        private Button bt_alterar;
        private PictureBox pb_alt;
        private PictureBox pb_exc;
        private Button bt_info;
    }
}
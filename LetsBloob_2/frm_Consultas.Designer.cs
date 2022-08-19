namespace LetsBloob_2
{
    partial class frm_Consultas
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
            this.lb_titulo_consulta = new System.Windows.Forms.Label();
            this.bt_consultar_bolsa = new System.Windows.Forms.Button();
            this.bt_consultar_doador = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_voltar = new System.Windows.Forms.Label();
            this.lb_sair = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titulo_consulta
            // 
            this.lb_titulo_consulta.AutoSize = true;
            this.lb_titulo_consulta.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo_consulta.Font = new System.Drawing.Font("Sitka Banner", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo_consulta.Location = new System.Drawing.Point(196, 26);
            this.lb_titulo_consulta.Name = "lb_titulo_consulta";
            this.lb_titulo_consulta.Size = new System.Drawing.Size(227, 72);
            this.lb_titulo_consulta.TabIndex = 4;
            this.lb_titulo_consulta.Text = "Consultas";
            // 
            // bt_consultar_bolsa
            // 
            this.bt_consultar_bolsa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_consultar_bolsa.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_consultar_bolsa.Location = new System.Drawing.Point(175, 222);
            this.bt_consultar_bolsa.Name = "bt_consultar_bolsa";
            this.bt_consultar_bolsa.Size = new System.Drawing.Size(270, 53);
            this.bt_consultar_bolsa.TabIndex = 8;
            this.bt_consultar_bolsa.Text = "Consultar Bolsa";
            this.bt_consultar_bolsa.UseVisualStyleBackColor = false;
            this.bt_consultar_bolsa.Click += new System.EventHandler(this.bt_consultar_bolsa_Click);
            // 
            // bt_consultar_doador
            // 
            this.bt_consultar_doador.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_consultar_doador.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_consultar_doador.Location = new System.Drawing.Point(175, 151);
            this.bt_consultar_doador.Name = "bt_consultar_doador";
            this.bt_consultar_doador.Size = new System.Drawing.Size(270, 53);
            this.bt_consultar_doador.TabIndex = 7;
            this.bt_consultar_doador.Text = "Consultar Doador";
            this.bt_consultar_doador.UseVisualStyleBackColor = false;
            this.bt_consultar_doador.Click += new System.EventHandler(this.bt_consultar_doador_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LetsBlood_2.Properties.Resources.voltar;
            this.pictureBox1.Location = new System.Drawing.Point(175, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_voltar
            // 
            this.lb_voltar.AutoSize = true;
            this.lb_voltar.BackColor = System.Drawing.Color.Transparent;
            this.lb_voltar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_voltar.Location = new System.Drawing.Point(207, 379);
            this.lb_voltar.Name = "lb_voltar";
            this.lb_voltar.Size = new System.Drawing.Size(66, 20);
            this.lb_voltar.TabIndex = 11;
            this.lb_voltar.Text = "VOLTAR";
            this.lb_voltar.Click += new System.EventHandler(this.lb_voltar_Click);
            // 
            // lb_sair
            // 
            this.lb_sair.AutoSize = true;
            this.lb_sair.BackColor = System.Drawing.Color.Transparent;
            this.lb_sair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_sair.Location = new System.Drawing.Point(350, 379);
            this.lb_sair.Name = "lb_sair";
            this.lb_sair.Size = new System.Drawing.Size(43, 20);
            this.lb_sair.TabIndex = 21;
            this.lb_sair.Text = "SAIR";
            this.lb_sair.Click += new System.EventHandler(this.lb_sair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LetsBlood_2.Properties.Resources.tl__1__removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(314, 316);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frm_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LetsBlood_2.Properties.Resources._2198948_verde_hortela_gradiente_aquarela_fundo_vetor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 438);
            this.ControlBox = false;
            this.Controls.Add(this.lb_sair);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lb_voltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_consultar_bolsa);
            this.Controls.Add(this.bt_consultar_doador);
            this.Controls.Add(this.lb_titulo_consulta);
            this.MaximizeBox = false;
            this.Name = "frm_Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Consultas";
            this.Load += new System.EventHandler(this.frm_Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_titulo_consulta;
        private Button bt_consultar_bolsa;
        private Button bt_consultar_doador;
        private PictureBox pictureBox1;
        private Label lb_voltar;
        private Label lb_sair;
        private PictureBox pictureBox2;
    }
}
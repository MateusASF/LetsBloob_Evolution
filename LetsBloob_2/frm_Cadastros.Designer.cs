namespace LetsBloob_2
{
    partial class frm_Cadastros
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
            this.bt_cadast_doador = new System.Windows.Forms.Button();
            this.bt_cadast_bolsa = new System.Windows.Forms.Button();
            this.lb_titulo_cadastro = new System.Windows.Forms.Label();
            this.lb_voltar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_sair = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cadast_doador
            // 
            this.bt_cadast_doador.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_cadast_doador.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_cadast_doador.Location = new System.Drawing.Point(175, 151);
            this.bt_cadast_doador.Name = "bt_cadast_doador";
            this.bt_cadast_doador.Size = new System.Drawing.Size(270, 53);
            this.bt_cadast_doador.TabIndex = 1;
            this.bt_cadast_doador.Text = "Cadastrar Doador";
            this.bt_cadast_doador.UseVisualStyleBackColor = false;
            this.bt_cadast_doador.Click += new System.EventHandler(this.bt_cadast_doador_Click);
            // 
            // bt_cadast_bolsa
            // 
            this.bt_cadast_bolsa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_cadast_bolsa.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_cadast_bolsa.Location = new System.Drawing.Point(175, 222);
            this.bt_cadast_bolsa.Name = "bt_cadast_bolsa";
            this.bt_cadast_bolsa.Size = new System.Drawing.Size(270, 53);
            this.bt_cadast_bolsa.TabIndex = 2;
            this.bt_cadast_bolsa.Text = "Cadastrar Bolsa";
            this.bt_cadast_bolsa.UseVisualStyleBackColor = false;
            this.bt_cadast_bolsa.Click += new System.EventHandler(this.bt_cadast_bolsa_Click);
            // 
            // lb_titulo_cadastro
            // 
            this.lb_titulo_cadastro.AutoSize = true;
            this.lb_titulo_cadastro.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo_cadastro.Font = new System.Drawing.Font("Sitka Banner", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo_cadastro.Location = new System.Drawing.Point(196, 26);
            this.lb_titulo_cadastro.Name = "lb_titulo_cadastro";
            this.lb_titulo_cadastro.Size = new System.Drawing.Size(228, 72);
            this.lb_titulo_cadastro.TabIndex = 3;
            this.lb_titulo_cadastro.Text = "Cadastros";
            this.lb_titulo_cadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_voltar
            // 
            this.lb_voltar.AutoSize = true;
            this.lb_voltar.BackColor = System.Drawing.Color.Transparent;
            this.lb_voltar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_voltar.Location = new System.Drawing.Point(207, 379);
            this.lb_voltar.Name = "lb_voltar";
            this.lb_voltar.Size = new System.Drawing.Size(66, 20);
            this.lb_voltar.TabIndex = 13;
            this.lb_voltar.Text = "VOLTAR";
            this.lb_voltar.Click += new System.EventHandler(this.lb_voltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LetsBlood_2.Properties.Resources.voltar;
            this.pictureBox1.Location = new System.Drawing.Point(175, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_sair
            // 
            this.lb_sair.AutoSize = true;
            this.lb_sair.BackColor = System.Drawing.Color.Transparent;
            this.lb_sair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_sair.Location = new System.Drawing.Point(350, 379);
            this.lb_sair.Name = "lb_sair";
            this.lb_sair.Size = new System.Drawing.Size(43, 20);
            this.lb_sair.TabIndex = 19;
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
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frm_Cadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LetsBlood_2.Properties.Resources.ee18e8e53852cf399b3b52c022d31d6d;
            this.ClientSize = new System.Drawing.Size(621, 438);
            this.ControlBox = false;
            this.Controls.Add(this.lb_sair);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lb_voltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_titulo_cadastro);
            this.Controls.Add(this.bt_cadast_bolsa);
            this.Controls.Add(this.bt_cadast_doador);
            this.MaximizeBox = false;
            this.Name = "frm_Cadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button bt_cadast_doador;
        private Button bt_cadast_bolsa;
        private Label lb_titulo_cadastro;
        private Label lb_voltar;
        private PictureBox pictureBox1;
        private Label lb_sair;
        private PictureBox pictureBox2;
    }
}
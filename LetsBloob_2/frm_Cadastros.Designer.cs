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
            this.bt_cadast_med = new System.Windows.Forms.Button();
            this.bt_cadast_doador = new System.Windows.Forms.Button();
            this.bt_cadast_bolsa = new System.Windows.Forms.Button();
            this.lb_titulo_cadastro = new System.Windows.Forms.Label();
            this.bt_cadast_hospital = new System.Windows.Forms.Button();
            this.lb_voltar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cadast_med
            // 
            this.bt_cadast_med.Location = new System.Drawing.Point(336, 135);
            this.bt_cadast_med.Name = "bt_cadast_med";
            this.bt_cadast_med.Size = new System.Drawing.Size(323, 73);
            this.bt_cadast_med.TabIndex = 0;
            this.bt_cadast_med.Text = "Cadastrar Médico";
            this.bt_cadast_med.UseVisualStyleBackColor = true;
            this.bt_cadast_med.Click += new System.EventHandler(this.bt_cadast_med_Click);
            // 
            // bt_cadast_doador
            // 
            this.bt_cadast_doador.Location = new System.Drawing.Point(335, 225);
            this.bt_cadast_doador.Name = "bt_cadast_doador";
            this.bt_cadast_doador.Size = new System.Drawing.Size(323, 73);
            this.bt_cadast_doador.TabIndex = 1;
            this.bt_cadast_doador.Text = "Cadastrar Doador";
            this.bt_cadast_doador.UseVisualStyleBackColor = true;
            this.bt_cadast_doador.Click += new System.EventHandler(this.bt_cadast_doador_Click);
            // 
            // bt_cadast_bolsa
            // 
            this.bt_cadast_bolsa.Location = new System.Drawing.Point(336, 320);
            this.bt_cadast_bolsa.Name = "bt_cadast_bolsa";
            this.bt_cadast_bolsa.Size = new System.Drawing.Size(323, 73);
            this.bt_cadast_bolsa.TabIndex = 2;
            this.bt_cadast_bolsa.Text = "Cadastrar Bolsa";
            this.bt_cadast_bolsa.UseVisualStyleBackColor = true;
            this.bt_cadast_bolsa.Click += new System.EventHandler(this.bt_cadast_bolsa_Click);
            // 
            // lb_titulo_cadastro
            // 
            this.lb_titulo_cadastro.AutoSize = true;
            this.lb_titulo_cadastro.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo_cadastro.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo_cadastro.Location = new System.Drawing.Point(377, 25);
            this.lb_titulo_cadastro.Name = "lb_titulo_cadastro";
            this.lb_titulo_cadastro.Size = new System.Drawing.Size(259, 67);
            this.lb_titulo_cadastro.TabIndex = 3;
            this.lb_titulo_cadastro.Text = "Cadastros";
            // 
            // bt_cadast_hospital
            // 
            this.bt_cadast_hospital.Location = new System.Drawing.Point(336, 415);
            this.bt_cadast_hospital.Name = "bt_cadast_hospital";
            this.bt_cadast_hospital.Size = new System.Drawing.Size(323, 73);
            this.bt_cadast_hospital.TabIndex = 4;
            this.bt_cadast_hospital.Text = "Cadastrar Hospital";
            this.bt_cadast_hospital.UseVisualStyleBackColor = true;
            this.bt_cadast_hospital.Click += new System.EventHandler(this.bt_cadast_hospital_Click);
            // 
            // lb_voltar
            // 
            this.lb_voltar.AutoSize = true;
            this.lb_voltar.BackColor = System.Drawing.Color.Transparent;
            this.lb_voltar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_voltar.Location = new System.Drawing.Point(868, 481);
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
            this.pictureBox1.Location = new System.Drawing.Point(837, 426);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_Cadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LetsBlood_2.Properties.Resources.fundo_brancos_forms;
            this.ClientSize = new System.Drawing.Size(1000, 515);
            this.ControlBox = false;
            this.Controls.Add(this.lb_voltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_cadast_hospital);
            this.Controls.Add(this.lb_titulo_cadastro);
            this.Controls.Add(this.bt_cadast_bolsa);
            this.Controls.Add(this.bt_cadast_doador);
            this.Controls.Add(this.bt_cadast_med);
            this.MaximizeBox = false;
            this.Name = "frm_Cadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_cadast_med;
        private Button bt_cadast_doador;
        private Button bt_cadast_bolsa;
        private Label lb_titulo_cadastro;
        private Button bt_cadast_hospital;
        private Label lb_voltar;
        private PictureBox pictureBox1;
    }
}
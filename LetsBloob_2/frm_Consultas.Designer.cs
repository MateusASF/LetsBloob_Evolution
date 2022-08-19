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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titulo_consulta
            // 
            this.lb_titulo_consulta.AutoSize = true;
            this.lb_titulo_consulta.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo_consulta.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo_consulta.Location = new System.Drawing.Point(373, 9);
            this.lb_titulo_consulta.Name = "lb_titulo_consulta";
            this.lb_titulo_consulta.Size = new System.Drawing.Size(255, 67);
            this.lb_titulo_consulta.TabIndex = 4;
            this.lb_titulo_consulta.Text = "Consultas";
            // 
            // bt_consultar_bolsa
            // 
            this.bt_consultar_bolsa.Location = new System.Drawing.Point(336, 296);
            this.bt_consultar_bolsa.Name = "bt_consultar_bolsa";
            this.bt_consultar_bolsa.Size = new System.Drawing.Size(323, 73);
            this.bt_consultar_bolsa.TabIndex = 8;
            this.bt_consultar_bolsa.Text = "Consultar Bolsa";
            this.bt_consultar_bolsa.UseVisualStyleBackColor = true;
            this.bt_consultar_bolsa.Click += new System.EventHandler(this.bt_consultar_bolsa_Click);
            // 
            // bt_consultar_doador
            // 
            this.bt_consultar_doador.Location = new System.Drawing.Point(335, 201);
            this.bt_consultar_doador.Name = "bt_consultar_doador";
            this.bt_consultar_doador.Size = new System.Drawing.Size(323, 73);
            this.bt_consultar_doador.TabIndex = 7;
            this.bt_consultar_doador.Text = "Consultar Doador";
            this.bt_consultar_doador.UseVisualStyleBackColor = true;
            this.bt_consultar_doador.Click += new System.EventHandler(this.bt_consultar_doador_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LetsBlood_2.Properties.Resources.voltar;
            this.pictureBox1.Location = new System.Drawing.Point(838, 402);
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
            this.lb_voltar.Location = new System.Drawing.Point(869, 457);
            this.lb_voltar.Name = "lb_voltar";
            this.lb_voltar.Size = new System.Drawing.Size(66, 20);
            this.lb_voltar.TabIndex = 11;
            this.lb_voltar.Text = "VOLTAR";
            this.lb_voltar.Click += new System.EventHandler(this.lb_voltar_Click);
            // 
            // frm_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LetsBlood_2.Properties.Resources.fundo_brancos_forms;
            this.ClientSize = new System.Drawing.Size(1000, 515);
            this.ControlBox = false;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_titulo_consulta;
        private Button bt_consultar_bolsa;
        private Button bt_consultar_doador;
        private PictureBox pictureBox1;
        private Label lb_voltar;
    }
}
namespace LetsBlood_2
{
    partial class frm_editarCadastros
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
            this.bt_editar_hospital = new System.Windows.Forms.Button();
            this.bt_editar_bolsa = new System.Windows.Forms.Button();
            this.bt_editar_doador = new System.Windows.Forms.Button();
            this.bt_editar_med = new System.Windows.Forms.Button();
            this.lb_titulo_editar = new System.Windows.Forms.Label();
            this.lb_voltar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_editar_hospital
            // 
            this.bt_editar_hospital.Location = new System.Drawing.Point(353, 401);
            this.bt_editar_hospital.Name = "bt_editar_hospital";
            this.bt_editar_hospital.Size = new System.Drawing.Size(323, 73);
            this.bt_editar_hospital.TabIndex = 13;
            this.bt_editar_hospital.Text = "Editar Hospital";
            this.bt_editar_hospital.UseVisualStyleBackColor = true;
            // 
            // bt_editar_bolsa
            // 
            this.bt_editar_bolsa.Location = new System.Drawing.Point(353, 306);
            this.bt_editar_bolsa.Name = "bt_editar_bolsa";
            this.bt_editar_bolsa.Size = new System.Drawing.Size(323, 73);
            this.bt_editar_bolsa.TabIndex = 12;
            this.bt_editar_bolsa.Text = "Editar Bolsa";
            this.bt_editar_bolsa.UseVisualStyleBackColor = true;
            // 
            // bt_editar_doador
            // 
            this.bt_editar_doador.Location = new System.Drawing.Point(352, 211);
            this.bt_editar_doador.Name = "bt_editar_doador";
            this.bt_editar_doador.Size = new System.Drawing.Size(323, 73);
            this.bt_editar_doador.TabIndex = 11;
            this.bt_editar_doador.Text = "Editar Doador";
            this.bt_editar_doador.UseVisualStyleBackColor = true;
            // 
            // bt_editar_med
            // 
            this.bt_editar_med.Location = new System.Drawing.Point(353, 121);
            this.bt_editar_med.Name = "bt_editar_med";
            this.bt_editar_med.Size = new System.Drawing.Size(323, 73);
            this.bt_editar_med.TabIndex = 10;
            this.bt_editar_med.Text = "Editar Médico";
            this.bt_editar_med.UseVisualStyleBackColor = true;
            // 
            // lb_titulo_editar
            // 
            this.lb_titulo_editar.AutoSize = true;
            this.lb_titulo_editar.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo_editar.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo_editar.Location = new System.Drawing.Point(428, 20);
            this.lb_titulo_editar.Name = "lb_titulo_editar";
            this.lb_titulo_editar.Size = new System.Drawing.Size(167, 67);
            this.lb_titulo_editar.TabIndex = 14;
            this.lb_titulo_editar.Text = "Editar";
            // 
            // lb_voltar
            // 
            this.lb_voltar.AutoSize = true;
            this.lb_voltar.BackColor = System.Drawing.Color.Transparent;
            this.lb_voltar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_voltar.Location = new System.Drawing.Point(885, 480);
            this.lb_voltar.Name = "lb_voltar";
            this.lb_voltar.Size = new System.Drawing.Size(66, 20);
            this.lb_voltar.TabIndex = 16;
            this.lb_voltar.Text = "VOLTAR";
            this.lb_voltar.Click += new System.EventHandler(this.lb_voltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LetsBlood_2.Properties.Resources.voltar;
            this.pictureBox1.Location = new System.Drawing.Point(854, 425);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_editarCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LetsBlood_2.Properties.Resources.fundo_brancos_forms;
            this.ClientSize = new System.Drawing.Size(1000, 515);
            this.ControlBox = false;
            this.Controls.Add(this.lb_voltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_titulo_editar);
            this.Controls.Add(this.bt_editar_hospital);
            this.Controls.Add(this.bt_editar_bolsa);
            this.Controls.Add(this.bt_editar_doador);
            this.Controls.Add(this.bt_editar_med);
            this.Name = "frm_editarCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cadastros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_editar_hospital;
        private Button bt_editar_bolsa;
        private Button bt_editar_doador;
        private Button bt_editar_med;
        private Label lb_titulo_editar;
        private Label lb_voltar;
        private PictureBox pictureBox1;
    }
}
namespace LetsBloob_2
{
    partial class frm_Deletes
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
            this.bt_deletar_hospital = new System.Windows.Forms.Button();
            this.bt_deletar_bolsa = new System.Windows.Forms.Button();
            this.bt_deletar_doador = new System.Windows.Forms.Button();
            this.bt_deletar_med = new System.Windows.Forms.Button();
            this.lb_voltar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titulo_consulta
            // 
            this.lb_titulo_consulta.AutoSize = true;
            this.lb_titulo_consulta.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo_consulta.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo_consulta.Location = new System.Drawing.Point(399, 21);
            this.lb_titulo_consulta.Name = "lb_titulo_consulta";
            this.lb_titulo_consulta.Size = new System.Drawing.Size(202, 67);
            this.lb_titulo_consulta.TabIndex = 5;
            this.lb_titulo_consulta.Text = "Deletes";
            // 
            // bt_deletar_hospital
            // 
            this.bt_deletar_hospital.Location = new System.Drawing.Point(338, 407);
            this.bt_deletar_hospital.Name = "bt_deletar_hospital";
            this.bt_deletar_hospital.Size = new System.Drawing.Size(323, 73);
            this.bt_deletar_hospital.TabIndex = 13;
            this.bt_deletar_hospital.Text = "Deletar Hospital";
            this.bt_deletar_hospital.UseVisualStyleBackColor = true;
            // 
            // bt_deletar_bolsa
            // 
            this.bt_deletar_bolsa.Location = new System.Drawing.Point(338, 312);
            this.bt_deletar_bolsa.Name = "bt_deletar_bolsa";
            this.bt_deletar_bolsa.Size = new System.Drawing.Size(323, 73);
            this.bt_deletar_bolsa.TabIndex = 12;
            this.bt_deletar_bolsa.Text = "Deletar Bolsa";
            this.bt_deletar_bolsa.UseVisualStyleBackColor = true;
            // 
            // bt_deletar_doador
            // 
            this.bt_deletar_doador.Location = new System.Drawing.Point(337, 217);
            this.bt_deletar_doador.Name = "bt_deletar_doador";
            this.bt_deletar_doador.Size = new System.Drawing.Size(323, 73);
            this.bt_deletar_doador.TabIndex = 11;
            this.bt_deletar_doador.Text = "Deletar Doador";
            this.bt_deletar_doador.UseVisualStyleBackColor = true;
            // 
            // bt_deletar_med
            // 
            this.bt_deletar_med.Location = new System.Drawing.Point(338, 127);
            this.bt_deletar_med.Name = "bt_deletar_med";
            this.bt_deletar_med.Size = new System.Drawing.Size(323, 73);
            this.bt_deletar_med.TabIndex = 10;
            this.bt_deletar_med.Text = "Deletar Médico";
            this.bt_deletar_med.UseVisualStyleBackColor = true;
            // 
            // lb_voltar
            // 
            this.lb_voltar.AutoSize = true;
            this.lb_voltar.BackColor = System.Drawing.Color.Transparent;
            this.lb_voltar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_voltar.Location = new System.Drawing.Point(881, 462);
            this.lb_voltar.Name = "lb_voltar";
            this.lb_voltar.Size = new System.Drawing.Size(66, 20);
            this.lb_voltar.TabIndex = 15;
            this.lb_voltar.Text = "VOLTAR";
            this.lb_voltar.Click += new System.EventHandler(this.lb_voltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LetsBlood_2.Properties.Resources.voltar;
            this.pictureBox1.Location = new System.Drawing.Point(850, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_Deletes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LetsBlood_2.Properties.Resources.fundo_brancos_forms;
            this.ClientSize = new System.Drawing.Size(1000, 515);
            this.ControlBox = false;
            this.Controls.Add(this.lb_voltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_deletar_hospital);
            this.Controls.Add(this.bt_deletar_bolsa);
            this.Controls.Add(this.bt_deletar_doador);
            this.Controls.Add(this.bt_deletar_med);
            this.Controls.Add(this.lb_titulo_consulta);
            this.MaximizeBox = false;
            this.Name = "frm_Deletes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Deletes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_titulo_consulta;
        private Button bt_deletar_hospital;
        private Button bt_deletar_bolsa;
        private Button bt_deletar_doador;
        private Button bt_deletar_med;
        private Label lb_voltar;
        private PictureBox pictureBox1;
    }
}
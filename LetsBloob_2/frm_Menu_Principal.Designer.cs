namespace LetsBloob_2
{
    partial class frm_Menu_Principal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_cadastros = new System.Windows.Forms.Button();
            this.bt_consultas = new System.Windows.Forms.Button();
            this.bt_deletes = new System.Windows.Forms.Button();
            this.bt_informacoes = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LetsBlood_2.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(257, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_cadastros
            // 
            this.bt_cadastros.BackColor = System.Drawing.Color.IndianRed;
            this.bt_cadastros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_cadastros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_cadastros.Location = new System.Drawing.Point(302, 228);
            this.bt_cadastros.Name = "bt_cadastros";
            this.bt_cadastros.Size = new System.Drawing.Size(236, 60);
            this.bt_cadastros.TabIndex = 1;
            this.bt_cadastros.Text = "Cadastros";
            this.bt_cadastros.UseVisualStyleBackColor = false;
            this.bt_cadastros.Click += new System.EventHandler(this.bt_cadastros_Click);
            // 
            // bt_consultas
            // 
            this.bt_consultas.BackColor = System.Drawing.Color.IndianRed;
            this.bt_consultas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_consultas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_consultas.Location = new System.Drawing.Point(302, 297);
            this.bt_consultas.Name = "bt_consultas";
            this.bt_consultas.Size = new System.Drawing.Size(236, 60);
            this.bt_consultas.TabIndex = 2;
            this.bt_consultas.Text = "Consultas";
            this.bt_consultas.UseVisualStyleBackColor = false;
            this.bt_consultas.Click += new System.EventHandler(this.bt_consultas_Click);
            // 
            // bt_deletes
            // 
            this.bt_deletes.BackColor = System.Drawing.Color.IndianRed;
            this.bt_deletes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_deletes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_deletes.Location = new System.Drawing.Point(302, 369);
            this.bt_deletes.Name = "bt_deletes";
            this.bt_deletes.Size = new System.Drawing.Size(236, 60);
            this.bt_deletes.TabIndex = 3;
            this.bt_deletes.Text = "Deletes?";
            this.bt_deletes.UseVisualStyleBackColor = false;
            this.bt_deletes.Click += new System.EventHandler(this.bt_deletes_Click);
            // 
            // bt_informacoes
            // 
            this.bt_informacoes.BackColor = System.Drawing.Color.IndianRed;
            this.bt_informacoes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_informacoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_informacoes.Location = new System.Drawing.Point(302, 440);
            this.bt_informacoes.Name = "bt_informacoes";
            this.bt_informacoes.Size = new System.Drawing.Size(236, 60);
            this.bt_informacoes.TabIndex = 4;
            this.bt_informacoes.Text = "Informações";
            this.bt_informacoes.UseVisualStyleBackColor = false;
            this.bt_informacoes.Click += new System.EventHandler(this.bt_informacoes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frm_Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LetsBlood_2.Properties.Resources.fundo_branco_abstrato_23_2148810353;
            this.ClientSize = new System.Drawing.Size(841, 533);
            this.Controls.Add(this.bt_informacoes);
            this.Controls.Add(this.bt_deletes);
            this.Controls.Add(this.bt_consultas);
            this.Controls.Add(this.bt_cadastros);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frm_Menu_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button bt_cadastros;
        private Button bt_consultas;
        private Button bt_deletes;
        private Button bt_informacoes;
        private MenuStrip menuStrip1;
    }
}
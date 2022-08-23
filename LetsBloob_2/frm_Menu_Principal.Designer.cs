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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu_Principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_cadastros = new System.Windows.Forms.Button();
            this.bt_doador = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesDeDoaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesDoProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_sair = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LetsBlood_2.Properties.Resources.LOGO2;
            this.pictureBox1.Location = new System.Drawing.Point(315, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_cadastros
            // 
            this.bt_cadastros.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_cadastros.Font = new System.Drawing.Font("Sitka Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_cadastros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_cadastros.Location = new System.Drawing.Point(282, 277);
            this.bt_cadastros.Name = "bt_cadastros";
            this.bt_cadastros.Size = new System.Drawing.Size(235, 52);
            this.bt_cadastros.TabIndex = 1;
            this.bt_cadastros.Text = "Bolsa";
            this.bt_cadastros.UseVisualStyleBackColor = false;
            this.bt_cadastros.Click += new System.EventHandler(this.bt_cadastros_Click);
            // 
            // bt_doador
            // 
            this.bt_doador.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_doador.Font = new System.Drawing.Font("Sitka Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_doador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_doador.Location = new System.Drawing.Point(283, 351);
            this.bt_doador.Name = "bt_doador";
            this.bt_doador.Size = new System.Drawing.Size(235, 52);
            this.bt_doador.TabIndex = 2;
            this.bt_doador.Text = "Doador";
            this.bt_doador.UseVisualStyleBackColor = false;
            this.bt_doador.Click += new System.EventHandler(this.bt_Doador_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Banner", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaçõesDeDoaçãoToolStripMenuItem,
            this.informaçõesDoProgramaToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // informaçõesDeDoaçãoToolStripMenuItem
            // 
            this.informaçõesDeDoaçãoToolStripMenuItem.Name = "informaçõesDeDoaçãoToolStripMenuItem";
            this.informaçõesDeDoaçãoToolStripMenuItem.Size = new System.Drawing.Size(265, 28);
            this.informaçõesDeDoaçãoToolStripMenuItem.Text = "Informações de Doação";
            this.informaçõesDeDoaçãoToolStripMenuItem.Click += new System.EventHandler(this.informaçõesDeDoaçãoToolStripMenuItem_Click);
            // 
            // informaçõesDoProgramaToolStripMenuItem
            // 
            this.informaçõesDoProgramaToolStripMenuItem.Name = "informaçõesDoProgramaToolStripMenuItem";
            this.informaçõesDoProgramaToolStripMenuItem.Size = new System.Drawing.Size(265, 28);
            this.informaçõesDoProgramaToolStripMenuItem.Text = "Informações do Programa";
            this.informaçõesDoProgramaToolStripMenuItem.Click += new System.EventHandler(this.informaçõesDoProgramaToolStripMenuItem_Click);
            // 
            // lb_sair
            // 
            this.lb_sair.AutoSize = true;
            this.lb_sair.BackColor = System.Drawing.Color.Transparent;
            this.lb_sair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_sair.Location = new System.Drawing.Point(374, 487);
            this.lb_sair.Name = "lb_sair";
            this.lb_sair.Size = new System.Drawing.Size(43, 20);
            this.lb_sair.TabIndex = 17;
            this.lb_sair.Text = "SAIR";
            this.lb_sair.Click += new System.EventHandler(this.lb_sair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LetsBlood_2.Properties.Resources.tl__1__removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(338, 424);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(283, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 49);
            this.label1.TabIndex = 18;
            this.label1.Text = "Menu Principal";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::LetsBlood_2.Properties.Resources.doacao_gif;
            this.pictureBox3.Location = new System.Drawing.Point(171, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 173);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // frm_Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LetsBlood_2.Properties.Resources._964fa0ed6eb25f231069df340aa2d46b;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_sair);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bt_doador);
            this.Controls.Add(this.bt_cadastros);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frm_Menu_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button bt_cadastros;
        private Button bt_doador;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem informaçõesDeDoaçãoToolStripMenuItem;
        private ToolStripMenuItem informaçõesDoProgramaToolStripMenuItem;
        private Label lb_sair;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
    }
}
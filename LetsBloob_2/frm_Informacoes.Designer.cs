namespace LetsBloob_2
{
    partial class frm_Informacoes
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_titulo_consulta
            // 
            this.lb_titulo_consulta.AutoSize = true;
            this.lb_titulo_consulta.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo_consulta.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo_consulta.Location = new System.Drawing.Point(339, 9);
            this.lb_titulo_consulta.Name = "lb_titulo_consulta";
            this.lb_titulo_consulta.Size = new System.Drawing.Size(322, 67);
            this.lb_titulo_consulta.TabIndex = 6;
            this.lb_titulo_consulta.Text = "Informações";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(373, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 70);
            this.button1.TabIndex = 7;
            this.button1.Text = "Informações sobre doações";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(373, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 70);
            this.button2.TabIndex = 8;
            this.button2.Text = "Informações sobre o programa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frm_Informacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LetsBlood_2.Properties.Resources.fundo_brancos_forms;
            this.ClientSize = new System.Drawing.Size(1000, 515);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_titulo_consulta);
            this.Name = "frm_Informacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Informações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_titulo_consulta;
        private Button button1;
        private Button button2;
    }
}
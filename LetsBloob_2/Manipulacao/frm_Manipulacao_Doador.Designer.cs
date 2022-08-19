namespace LetsBlood_2.Editar
{
    partial class frm_Manipulacao_Doador
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
            this.ltbResultado = new System.Windows.Forms.ListBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ltbResultado
            // 
            this.ltbResultado.FormattingEnabled = true;
            this.ltbResultado.ItemHeight = 15;
            this.ltbResultado.Location = new System.Drawing.Point(30, 26);
            this.ltbResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltbResultado.Name = "ltbResultado";
            this.ltbResultado.Size = new System.Drawing.Size(1007, 94);
            this.ltbResultado.TabIndex = 0;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(529, 171);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(82, 22);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.Location = new System.Drawing.Point(251, 198);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 18);
            this.lblTelefone.TabIndex = 12;
            this.lblTelefone.Text = "Telefone";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbTelefone.Location = new System.Drawing.Point(251, 215);
            this.mtbTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbTelefone.Mask = "(00) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(181, 23);
            this.mtbTelefone.TabIndex = 11;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbCpf.Location = new System.Drawing.Point(42, 214);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbCpf.Mask = "000-000-000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(177, 23);
            this.mtbCpf.TabIndex = 14;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.Location = new System.Drawing.Point(42, 197);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 18);
            this.lblCpf.TabIndex = 13;
            this.lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(42, 154);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(37, 18);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNome.Location = new System.Drawing.Point(42, 171);
            this.txbNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(420, 23);
            this.txbNome.TabIndex = 15;
            // 
            // frm_Manipulacao_Doador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 338);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.ltbResultado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Manipulacao_Doador";
            this.Text = "frm_Manipulacao_Doador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ltbResultado;
        private Button btnProcurar;
        private Label lblTelefone;
        private MaskedTextBox mtbTelefone;
        private MaskedTextBox mtbCpf;
        private Label lblCpf;
        private Label lblNome;
        private TextBox txbNome;
    }
}
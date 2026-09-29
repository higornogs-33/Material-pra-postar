namespace SisPadoca
{
    partial class FrmFornecedores
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
            LblCNPJ = new Label();
            TxtEmail = new TextBox();
            LblEmail = new Label();
            BtnNovo = new Button();
            BtnFechar = new Button();
            BtnLimpar = new Button();
            BtnExcluir = new Button();
            BtnEditar = new Button();
            MtxTelefone = new MaskedTextBox();
            MtxCNPJ = new MaskedTextBox();
            LblTelefone = new Label();
            PbxLogo = new PictureBox();
            LblLogo = new Label();
            LblEndereco = new Label();
            TxtEndereco = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PbxLogo).BeginInit();
            SuspendLayout();
            // 
            // LblCNPJ
            // 
            LblCNPJ.AutoSize = true;
            LblCNPJ.Location = new Point(58, 37);
            LblCNPJ.Name = "LblCNPJ";
            LblCNPJ.Size = new Size(51, 25);
            LblCNPJ.TabIndex = 0;
            LblCNPJ.Text = "CNPJ";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(120, 79);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(150, 31);
            TxtEmail.TabIndex = 3;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(58, 78);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(54, 25);
            LblEmail.TabIndex = 2;
            LblEmail.Text = "Email";
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(58, 339);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(112, 81);
            BtnNovo.TabIndex = 4;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(578, 339);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(92, 81);
            BtnFechar.TabIndex = 5;
            BtnFechar.Text = "Fechar";
            BtnFechar.TextAlign = ContentAlignment.MiddleLeft;
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(444, 339);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(112, 81);
            BtnLimpar.TabIndex = 6;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(317, 339);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(112, 81);
            BtnExcluir.TabIndex = 7;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(190, 339);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(112, 81);
            BtnEditar.TabIndex = 8;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // MtxTelefone
            // 
            MtxTelefone.Location = new Point(122, 126);
            MtxTelefone.Mask = "(00)00000-0000";
            MtxTelefone.Name = "MtxTelefone";
            MtxTelefone.Size = new Size(150, 31);
            MtxTelefone.TabIndex = 9;
            // 
            // MtxCNPJ
            // 
            MtxCNPJ.Location = new Point(120, 34);
            MtxCNPJ.Mask = "00.000.000/0000-00";
            MtxCNPJ.Name = "MtxCNPJ";
            MtxCNPJ.Size = new Size(150, 31);
            MtxCNPJ.TabIndex = 10;
            // 
            // LblTelefone
            // 
            LblTelefone.AutoSize = true;
            LblTelefone.Location = new Point(35, 129);
            LblTelefone.Name = "LblTelefone";
            LblTelefone.Size = new Size(77, 25);
            LblTelefone.TabIndex = 11;
            LblTelefone.Text = "Telefone";
            // 
            // PbxLogo
            // 
            PbxLogo.Image = Properties.Resources.images;
            PbxLogo.Location = new Point(317, 61);
            PbxLogo.Name = "PbxLogo";
            PbxLogo.Size = new Size(194, 177);
            PbxLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            PbxLogo.TabIndex = 12;
            PbxLogo.TabStop = false;
            // 
            // LblLogo
            // 
            LblLogo.AutoSize = true;
            LblLogo.Location = new Point(317, 24);
            LblLogo.Name = "LblLogo";
            LblLogo.Size = new Size(53, 25);
            LblLogo.TabIndex = 13;
            LblLogo.Text = "Logo";
            // 
            // LblEndereco
            // 
            LblEndereco.AutoSize = true;
            LblEndereco.Location = new Point(24, 185);
            LblEndereco.Name = "LblEndereco";
            LblEndereco.Size = new Size(85, 25);
            LblEndereco.TabIndex = 14;
            LblEndereco.Text = "Endereço";
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(122, 185);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(150, 31);
            TxtEndereco.TabIndex = 15;
            // 
            // FrmFornecedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtEndereco);
            Controls.Add(LblEndereco);
            Controls.Add(LblLogo);
            Controls.Add(PbxLogo);
            Controls.Add(LblTelefone);
            Controls.Add(MtxCNPJ);
            Controls.Add(MtxTelefone);
            Controls.Add(BtnEditar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnFechar);
            Controls.Add(BtnNovo);
            Controls.Add(TxtEmail);
            Controls.Add(LblEmail);
            Controls.Add(LblCNPJ);
            Name = "FrmFornecedores";
            Text = "FrmFornecedores";
            ((System.ComponentModel.ISupportInitialize)PbxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCNPJ;
        private TextBox TxtEmail;
        private Label LblEmail;
        private Button BtnNovo;
        private Button BtnFechar;
        private Button BtnLimpar;
        private Button BtnExcluir;
        private Button BtnEditar;
        private MaskedTextBox MtxTelefone;
        private MaskedTextBox MtxCNPJ;
        private Label LblTelefone;
        private PictureBox PbxLogo;
        private Label LblLogo;
        private Label LblEndereco;
        private TextBox TxtEndereco;
    }
}
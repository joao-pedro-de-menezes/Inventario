namespace Inventario
{
    partial class frmCadastroUsuario
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
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.lblCodig = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.mtxtCracha = new MaterialSkin.Controls.MaterialTextBox();
            this.mcmbTipo = new MaterialSkin.Controls.MaterialComboBox();
            this.mtxtConfirmaSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.mtxtSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.mtxtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.mtxtNome = new MaterialSkin.Controls.MaterialTextBox();
            this.mradioInativo = new MaterialSkin.Controls.MaterialRadioButton();
            this.mradioAtivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.mbtnCadastrar_Atualizar = new MaterialSkin.Controls.MaterialButton();
            this.mbtnPesquisar = new MaterialSkin.Controls.MaterialButton();
            this.mbtnVoltar = new MaterialSkin.Controls.MaterialButton();
            this.iconeFundoFoto = new FontAwesome.Sharp.IconPictureBox();
            this.grbBtns = new System.Windows.Forms.GroupBox();
            this.grbAtivo = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.grbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeFundoFoto)).BeginInit();
            this.grbBtns.SuspendLayout();
            this.grbAtivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grbDados.Controls.Add(this.lblCodig);
            this.grbDados.Controls.Add(this.txtCodigo);
            this.grbDados.Controls.Add(this.mtxtCracha);
            this.grbDados.Controls.Add(this.mcmbTipo);
            this.grbDados.Controls.Add(this.mtxtConfirmaSenha);
            this.grbDados.Controls.Add(this.mtxtSenha);
            this.grbDados.Controls.Add(this.mtxtEmail);
            this.grbDados.Controls.Add(this.mtxtNome);
            this.grbDados.Location = new System.Drawing.Point(61, 117);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(380, 466);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // lblCodig
            // 
            this.lblCodig.AutoSize = true;
            this.lblCodig.Depth = 0;
            this.lblCodig.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCodig.Location = new System.Drawing.Point(27, 41);
            this.lblCodig.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodig.Name = "lblCodig";
            this.lblCodig.Size = new System.Drawing.Size(108, 19);
            this.lblCodig.TabIndex = 8;
            this.lblCodig.Text = "Código usuário";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(30, 63);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(74, 36);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.Text = "";
            this.txtCodigo.TrailingIcon = null;
            this.txtCodigo.UseTallSize = false;
            // 
            // mtxtCracha
            // 
            this.mtxtCracha.AnimateReadOnly = false;
            this.mtxtCracha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtCracha.Depth = 0;
            this.mtxtCracha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtCracha.LeadingIcon = null;
            this.mtxtCracha.Location = new System.Drawing.Point(30, 201);
            this.mtxtCracha.MaxLength = 50;
            this.mtxtCracha.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtCracha.Multiline = false;
            this.mtxtCracha.Name = "mtxtCracha";
            this.mtxtCracha.Size = new System.Drawing.Size(320, 36);
            this.mtxtCracha.TabIndex = 3;
            this.mtxtCracha.Text = "";
            this.mtxtCracha.TrailingIcon = null;
            this.mtxtCracha.UseTallSize = false;
            this.mtxtCracha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCracha_KeyPress);
            // 
            // mcmbTipo
            // 
            this.mcmbTipo.AutoResize = false;
            this.mcmbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcmbTipo.Depth = 0;
            this.mcmbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcmbTipo.DropDownHeight = 292;
            this.mcmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcmbTipo.DropDownWidth = 100;
            this.mcmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcmbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcmbTipo.FormattingEnabled = true;
            this.mcmbTipo.IntegralHeight = false;
            this.mcmbTipo.ItemHeight = 29;
            this.mcmbTipo.Location = new System.Drawing.Point(30, 345);
            this.mcmbTipo.MaxDropDownItems = 10;
            this.mcmbTipo.MouseState = MaterialSkin.MouseState.OUT;
            this.mcmbTipo.Name = "mcmbTipo";
            this.mcmbTipo.Size = new System.Drawing.Size(320, 35);
            this.mcmbTipo.StartIndex = 0;
            this.mcmbTipo.TabIndex = 6;
            this.mcmbTipo.UseTallSize = false;
            // 
            // mtxtConfirmaSenha
            // 
            this.mtxtConfirmaSenha.AnimateReadOnly = false;
            this.mtxtConfirmaSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtConfirmaSenha.Depth = 0;
            this.mtxtConfirmaSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtConfirmaSenha.LeadingIcon = null;
            this.mtxtConfirmaSenha.Location = new System.Drawing.Point(30, 297);
            this.mtxtConfirmaSenha.MaxLength = 50;
            this.mtxtConfirmaSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtConfirmaSenha.Multiline = false;
            this.mtxtConfirmaSenha.Name = "mtxtConfirmaSenha";
            this.mtxtConfirmaSenha.Size = new System.Drawing.Size(320, 36);
            this.mtxtConfirmaSenha.TabIndex = 5;
            this.mtxtConfirmaSenha.Text = "";
            this.mtxtConfirmaSenha.TrailingIcon = null;
            this.mtxtConfirmaSenha.UseTallSize = false;
            // 
            // mtxtSenha
            // 
            this.mtxtSenha.AnimateReadOnly = false;
            this.mtxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtSenha.Depth = 0;
            this.mtxtSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtSenha.LeadingIcon = null;
            this.mtxtSenha.Location = new System.Drawing.Point(30, 249);
            this.mtxtSenha.MaxLength = 50;
            this.mtxtSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtSenha.Multiline = false;
            this.mtxtSenha.Name = "mtxtSenha";
            this.mtxtSenha.Size = new System.Drawing.Size(320, 36);
            this.mtxtSenha.TabIndex = 4;
            this.mtxtSenha.Text = "";
            this.mtxtSenha.TrailingIcon = null;
            this.mtxtSenha.UseTallSize = false;
            // 
            // mtxtEmail
            // 
            this.mtxtEmail.AnimateReadOnly = false;
            this.mtxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtEmail.Depth = 0;
            this.mtxtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtEmail.LeadingIcon = null;
            this.mtxtEmail.Location = new System.Drawing.Point(30, 153);
            this.mtxtEmail.MaxLength = 50;
            this.mtxtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtEmail.Multiline = false;
            this.mtxtEmail.Name = "mtxtEmail";
            this.mtxtEmail.Size = new System.Drawing.Size(320, 36);
            this.mtxtEmail.TabIndex = 2;
            this.mtxtEmail.Text = "";
            this.mtxtEmail.TrailingIcon = null;
            this.mtxtEmail.UseTallSize = false;
            // 
            // mtxtNome
            // 
            this.mtxtNome.AnimateReadOnly = false;
            this.mtxtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtNome.Depth = 0;
            this.mtxtNome.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtNome.LeadingIcon = null;
            this.mtxtNome.Location = new System.Drawing.Point(30, 105);
            this.mtxtNome.MaxLength = 50;
            this.mtxtNome.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtNome.Multiline = false;
            this.mtxtNome.Name = "mtxtNome";
            this.mtxtNome.Size = new System.Drawing.Size(320, 36);
            this.mtxtNome.TabIndex = 1;
            this.mtxtNome.Text = "";
            this.mtxtNome.TrailingIcon = null;
            this.mtxtNome.UseTallSize = false;
            // 
            // mradioInativo
            // 
            this.mradioInativo.Depth = 0;
            this.mradioInativo.Location = new System.Drawing.Point(266, 16);
            this.mradioInativo.Margin = new System.Windows.Forms.Padding(0);
            this.mradioInativo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mradioInativo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mradioInativo.Name = "mradioInativo";
            this.mradioInativo.Ripple = true;
            this.mradioInativo.Size = new System.Drawing.Size(84, 27);
            this.mradioInativo.TabIndex = 8;
            this.mradioInativo.TabStop = true;
            this.mradioInativo.Text = "Inativo";
            this.mradioInativo.UseVisualStyleBackColor = true;
            // 
            // mradioAtivo
            // 
            this.mradioAtivo.Depth = 0;
            this.mradioAtivo.Location = new System.Drawing.Point(30, 16);
            this.mradioAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.mradioAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mradioAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mradioAtivo.Name = "mradioAtivo";
            this.mradioAtivo.Ripple = true;
            this.mradioAtivo.Size = new System.Drawing.Size(74, 27);
            this.mradioAtivo.TabIndex = 7;
            this.mradioAtivo.TabStop = true;
            this.mradioAtivo.Text = "Ativo";
            this.mradioAtivo.UseVisualStyleBackColor = true;
            // 
            // mbtnCadastrar_Atualizar
            // 
            this.mbtnCadastrar_Atualizar.AutoSize = false;
            this.mbtnCadastrar_Atualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCadastrar_Atualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnCadastrar_Atualizar.Depth = 0;
            this.mbtnCadastrar_Atualizar.HighEmphasis = true;
            this.mbtnCadastrar_Atualizar.Icon = null;
            this.mbtnCadastrar_Atualizar.Location = new System.Drawing.Point(7, 22);
            this.mbtnCadastrar_Atualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCadastrar_Atualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCadastrar_Atualizar.Name = "mbtnCadastrar_Atualizar";
            this.mbtnCadastrar_Atualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnCadastrar_Atualizar.Size = new System.Drawing.Size(109, 24);
            this.mbtnCadastrar_Atualizar.TabIndex = 9;
            this.mbtnCadastrar_Atualizar.Text = "Cadastrar";
            this.mbtnCadastrar_Atualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnCadastrar_Atualizar.UseAccentColor = false;
            this.mbtnCadastrar_Atualizar.UseVisualStyleBackColor = true;
            this.mbtnCadastrar_Atualizar.Click += new System.EventHandler(this.mbtnCadastrar_Atualizar_Click);
            // 
            // mbtnPesquisar
            // 
            this.mbtnPesquisar.AutoSize = false;
            this.mbtnPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnPesquisar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnPesquisar.Depth = 0;
            this.mbtnPesquisar.HighEmphasis = true;
            this.mbtnPesquisar.Icon = null;
            this.mbtnPesquisar.Location = new System.Drawing.Point(241, 22);
            this.mbtnPesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnPesquisar.Name = "mbtnPesquisar";
            this.mbtnPesquisar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnPesquisar.Size = new System.Drawing.Size(109, 24);
            this.mbtnPesquisar.TabIndex = 10;
            this.mbtnPesquisar.Text = "Pesquisar";
            this.mbtnPesquisar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnPesquisar.UseAccentColor = false;
            this.mbtnPesquisar.UseVisualStyleBackColor = true;
            this.mbtnPesquisar.Click += new System.EventHandler(this.mbtnPesquisar_Click);
            // 
            // mbtnVoltar
            // 
            this.mbtnVoltar.AutoSize = false;
            this.mbtnVoltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnVoltar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnVoltar.Depth = 0;
            this.mbtnVoltar.HighEmphasis = true;
            this.mbtnVoltar.Icon = null;
            this.mbtnVoltar.Location = new System.Drawing.Point(7, 84);
            this.mbtnVoltar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnVoltar.Name = "mbtnVoltar";
            this.mbtnVoltar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnVoltar.Size = new System.Drawing.Size(109, 24);
            this.mbtnVoltar.TabIndex = 11;
            this.mbtnVoltar.Text = "Voltar";
            this.mbtnVoltar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnVoltar.UseAccentColor = false;
            this.mbtnVoltar.UseVisualStyleBackColor = true;
            this.mbtnVoltar.Click += new System.EventHandler(this.mbtnVoltar_Click);
            // 
            // iconeFundoFoto
            // 
            this.iconeFundoFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeFundoFoto.BackColor = System.Drawing.SystemColors.Control;
            this.iconeFundoFoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconeFundoFoto.IconChar = FontAwesome.Sharp.IconChar.CameraAlt;
            this.iconeFundoFoto.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconeFundoFoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconeFundoFoto.IconSize = 112;
            this.iconeFundoFoto.Location = new System.Drawing.Point(182, 65);
            this.iconeFundoFoto.Name = "iconeFundoFoto";
            this.iconeFundoFoto.Size = new System.Drawing.Size(145, 112);
            this.iconeFundoFoto.TabIndex = 1;
            this.iconeFundoFoto.TabStop = false;
            // 
            // grbBtns
            // 
            this.grbBtns.Controls.Add(this.mbtnCadastrar_Atualizar);
            this.grbBtns.Controls.Add(this.mbtnPesquisar);
            this.grbBtns.Location = new System.Drawing.Point(61, 650);
            this.grbBtns.Name = "grbBtns";
            this.grbBtns.Size = new System.Drawing.Size(380, 58);
            this.grbBtns.TabIndex = 0;
            this.grbBtns.TabStop = false;
            this.grbBtns.Text = "Botões";
            // 
            // grbAtivo
            // 
            this.grbAtivo.Controls.Add(this.mradioInativo);
            this.grbAtivo.Controls.Add(this.mradioAtivo);
            this.grbAtivo.Location = new System.Drawing.Point(61, 589);
            this.grbAtivo.Name = "grbAtivo";
            this.grbAtivo.Size = new System.Drawing.Size(380, 55);
            this.grbAtivo.TabIndex = 0;
            this.grbAtivo.TabStop = false;
            this.grbAtivo.Text = "Usuário Ativo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Depth = 0;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.Location = new System.Drawing.Point(109, 31);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(332, 24);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Cadastro De Usuários";
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 745);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbAtivo);
            this.Controls.Add(this.grbBtns);
            this.Controls.Add(this.mbtnVoltar);
            this.Controls.Add(this.grbDados);
            this.MaximizeBox = false;
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Usuários";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastroUsuario_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeFundoFoto)).EndInit();
            this.grbBtns.ResumeLayout(false);
            this.grbAtivo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
        private MaterialSkin.Controls.MaterialTextBox mtxtEmail;
        private MaterialSkin.Controls.MaterialTextBox mtxtNome;
        private MaterialSkin.Controls.MaterialTextBox mtxtSenha;
        private MaterialSkin.Controls.MaterialRadioButton mradioAtivo;
        private MaterialSkin.Controls.MaterialComboBox mcmbTipo;
        private MaterialSkin.Controls.MaterialRadioButton mradioInativo;
        private MaterialSkin.Controls.MaterialTextBox mtxtConfirmaSenha;
        private MaterialSkin.Controls.MaterialButton mbtnPesquisar;
        private MaterialSkin.Controls.MaterialButton mbtnCadastrar_Atualizar;
        private MaterialSkin.Controls.MaterialButton mbtnVoltar;
        private FontAwesome.Sharp.IconPictureBox iconeFundoFoto;
        private System.Windows.Forms.GroupBox grbBtns;
        private MaterialSkin.Controls.MaterialTextBox mtxtCracha;
        private System.Windows.Forms.GroupBox grbAtivo;
        private MaterialSkin.Controls.MaterialLabel lblCodig;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
    }
}
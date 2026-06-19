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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tbControlUsu = new MaterialSkin.Controls.MaterialTabControl();
            this.tbSelecao = new System.Windows.Forms.TabPage();
            this.tbCadastro = new System.Windows.Forms.TabPage();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.grbUsu = new System.Windows.Forms.GroupBox();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.grbOpcoesP = new System.Windows.Forms.GroupBox();
            this.mbPesquisar = new MaterialSkin.Controls.MaterialButton();
            this.mbVoltar = new MaterialSkin.Controls.MaterialButton();
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.lblCodigoP = new System.Windows.Forms.Label();
            this.lblSituacaoP = new System.Windows.Forms.Label();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtemailP = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mbtnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.grbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeFundoFoto)).BeginInit();
            this.grbBtns.SuspendLayout();
            this.grbAtivo.SuspendLayout();
            this.tbControlUsu.SuspendLayout();
            this.tbSelecao.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.grbUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.grbOpcoesP.SuspendLayout();
            this.grbPesquisa.SuspendLayout();
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
            this.grbDados.Location = new System.Drawing.Point(261, 17);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(395, 463);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // lblCodig
            // 
            this.lblCodig.AutoSize = true;
            this.lblCodig.Depth = 0;
            this.lblCodig.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCodig.Location = new System.Drawing.Point(32, 41);
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
            this.txtCodigo.Location = new System.Drawing.Point(35, 63);
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
            this.mtxtCracha.Location = new System.Drawing.Point(35, 201);
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
            this.mcmbTipo.Location = new System.Drawing.Point(35, 345);
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
            this.mtxtConfirmaSenha.Location = new System.Drawing.Point(35, 297);
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
            this.mtxtSenha.Location = new System.Drawing.Point(35, 249);
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
            this.mtxtEmail.Location = new System.Drawing.Point(35, 153);
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
            this.mtxtNome.Location = new System.Drawing.Point(35, 105);
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
            this.mradioInativo.Location = new System.Drawing.Point(274, 16);
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
            this.mbtnPesquisar.Location = new System.Drawing.Point(286, 22);
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
            this.grbBtns.Controls.Add(this.mbtnCancelar);
            this.grbBtns.Controls.Add(this.mbtnCadastrar_Atualizar);
            this.grbBtns.Controls.Add(this.mbtnPesquisar);
            this.grbBtns.Location = new System.Drawing.Point(261, 547);
            this.grbBtns.Name = "grbBtns";
            this.grbBtns.Size = new System.Drawing.Size(402, 58);
            this.grbBtns.TabIndex = 0;
            this.grbBtns.TabStop = false;
            this.grbBtns.Text = "Botões";
            // 
            // grbAtivo
            // 
            this.grbAtivo.Controls.Add(this.mradioInativo);
            this.grbAtivo.Controls.Add(this.mradioAtivo);
            this.grbAtivo.Location = new System.Drawing.Point(261, 486);
            this.grbAtivo.Name = "grbAtivo";
            this.grbAtivo.Size = new System.Drawing.Size(395, 55);
            this.grbAtivo.TabIndex = 0;
            this.grbAtivo.TabStop = false;
            this.grbAtivo.Text = "Usuário Ativo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Depth = 0;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.Location = new System.Drawing.Point(298, 25);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(332, 24);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Cadastro De Usuários";
            // 
            // tbControlUsu
            // 
            this.tbControlUsu.Controls.Add(this.tbSelecao);
            this.tbControlUsu.Controls.Add(this.tbCadastro);
            this.tbControlUsu.Depth = 0;
            this.tbControlUsu.Location = new System.Drawing.Point(6, 112);
            this.tbControlUsu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbControlUsu.Multiline = true;
            this.tbControlUsu.Name = "tbControlUsu";
            this.tbControlUsu.SelectedIndex = 0;
            this.tbControlUsu.Size = new System.Drawing.Size(881, 657);
            this.tbControlUsu.TabIndex = 13;
            // 
            // tbSelecao
            // 
            this.tbSelecao.Controls.Add(this.grbUsu);
            this.tbSelecao.Controls.Add(this.grbOpcoesP);
            this.tbSelecao.Controls.Add(this.grbPesquisa);
            this.tbSelecao.Location = new System.Drawing.Point(4, 22);
            this.tbSelecao.Name = "tbSelecao";
            this.tbSelecao.Padding = new System.Windows.Forms.Padding(3);
            this.tbSelecao.Size = new System.Drawing.Size(873, 631);
            this.tbSelecao.TabIndex = 0;
            this.tbSelecao.Text = "Seleção";
            this.tbSelecao.UseVisualStyleBackColor = true;
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.grbDados);
            this.tbCadastro.Controls.Add(this.grbBtns);
            this.tbCadastro.Controls.Add(this.grbAtivo);
            this.tbCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastro.Size = new System.Drawing.Size(873, 631);
            this.tbCadastro.TabIndex = 1;
            this.tbCadastro.Text = "Cadastro";
            this.tbCadastro.UseVisualStyleBackColor = true;
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = this.tbControlUsu;
            this.tabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelector.Depth = 0;
            this.tabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelector.Location = new System.Drawing.Point(280, 67);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(371, 48);
            this.tabSelector.TabIndex = 14;
            this.tabSelector.Text = "materialTabSelector1";
            // 
            // grbUsu
            // 
            this.grbUsu.Controls.Add(this.dgvUsuario);
            this.grbUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUsu.Location = new System.Drawing.Point(7, 130);
            this.grbUsu.Name = "grbUsu";
            this.grbUsu.Size = new System.Drawing.Size(863, 498);
            this.grbUsu.TabIndex = 8;
            this.grbUsu.TabStop = false;
            this.grbUsu.Text = "Usuarios";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuario.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvUsuario.Location = new System.Drawing.Point(5, 16);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvUsuario.Size = new System.Drawing.Size(852, 476);
            this.dgvUsuario.TabIndex = 0;
            this.dgvUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellDoubleClick);
            // 
            // grbOpcoesP
            // 
            this.grbOpcoesP.Controls.Add(this.mbPesquisar);
            this.grbOpcoesP.Controls.Add(this.mbVoltar);
            this.grbOpcoesP.Location = new System.Drawing.Point(528, 30);
            this.grbOpcoesP.Name = "grbOpcoesP";
            this.grbOpcoesP.Size = new System.Drawing.Size(223, 71);
            this.grbOpcoesP.TabIndex = 7;
            this.grbOpcoesP.TabStop = false;
            this.grbOpcoesP.Text = "Opções";
            // 
            // mbPesquisar
            // 
            this.mbPesquisar.AutoSize = false;
            this.mbPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbPesquisar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbPesquisar.Depth = 0;
            this.mbPesquisar.HighEmphasis = true;
            this.mbPesquisar.Icon = null;
            this.mbPesquisar.Location = new System.Drawing.Point(7, 19);
            this.mbPesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbPesquisar.Name = "mbPesquisar";
            this.mbPesquisar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbPesquisar.Size = new System.Drawing.Size(100, 36);
            this.mbPesquisar.TabIndex = 6;
            this.mbPesquisar.Text = "Pesquisar";
            this.mbPesquisar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbPesquisar.UseAccentColor = false;
            this.mbPesquisar.UseVisualStyleBackColor = true;
            this.mbPesquisar.Click += new System.EventHandler(this.mbPesquisar_Click);
            // 
            // mbVoltar
            // 
            this.mbVoltar.AutoSize = false;
            this.mbVoltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbVoltar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbVoltar.Depth = 0;
            this.mbVoltar.HighEmphasis = true;
            this.mbVoltar.Icon = null;
            this.mbVoltar.Location = new System.Drawing.Point(115, 19);
            this.mbVoltar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbVoltar.Name = "mbVoltar";
            this.mbVoltar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbVoltar.Size = new System.Drawing.Size(100, 36);
            this.mbVoltar.TabIndex = 7;
            this.mbVoltar.Text = "Voltar";
            this.mbVoltar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbVoltar.UseAccentColor = false;
            this.mbVoltar.UseVisualStyleBackColor = true;
            // 
            // grbPesquisa
            // 
            this.grbPesquisa.Controls.Add(this.txtemailP);
            this.grbPesquisa.Controls.Add(this.lblEmail);
            this.grbPesquisa.Controls.Add(this.txtNomeP);
            this.grbPesquisa.Controls.Add(this.lblNome);
            this.grbPesquisa.Controls.Add(this.rdbInativo);
            this.grbPesquisa.Controls.Add(this.rdbAtivo);
            this.grbPesquisa.Controls.Add(this.lblSituacaoP);
            this.grbPesquisa.Controls.Add(this.txtCodigoP);
            this.grbPesquisa.Controls.Add(this.lblCodigoP);
            this.grbPesquisa.Location = new System.Drawing.Point(7, 14);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.Size = new System.Drawing.Size(503, 110);
            this.grbPesquisa.TabIndex = 6;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "Perquisar por:";
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Location = new System.Drawing.Point(420, 78);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(79, 17);
            this.rdbInativo.TabIndex = 6;
            this.rdbInativo.TabStop = true;
            this.rdbInativo.Text = "Desativado";
            this.rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Location = new System.Drawing.Point(353, 78);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(61, 17);
            this.rdbAtivo.TabIndex = 12;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativado";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Location = new System.Drawing.Point(9, 32);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(79, 20);
            this.txtCodigoP.TabIndex = 1;
            // 
            // lblCodigoP
            // 
            this.lblCodigoP.AutoSize = true;
            this.lblCodigoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoP.Location = new System.Drawing.Point(9, 16);
            this.lblCodigoP.Name = "lblCodigoP";
            this.lblCodigoP.Size = new System.Drawing.Size(50, 13);
            this.lblCodigoP.TabIndex = 0;
            this.lblCodigoP.Text = "Código:";
            // 
            // lblSituacaoP
            // 
            this.lblSituacaoP.AutoSize = true;
            this.lblSituacaoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacaoP.Location = new System.Drawing.Point(384, 62);
            this.lblSituacaoP.Name = "lblSituacaoP";
            this.lblSituacaoP.Size = new System.Drawing.Size(61, 13);
            this.lblSituacaoP.TabIndex = 6;
            this.lblSituacaoP.Text = "Situação:";
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(94, 32);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(403, 20);
            this.txtNomeP.TabIndex = 14;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(91, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome:";
            // 
            // txtemailP
            // 
            this.txtemailP.Location = new System.Drawing.Point(12, 78);
            this.txtemailP.Name = "txtemailP";
            this.txtemailP.Size = new System.Drawing.Size(332, 20);
            this.txtemailP.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 13);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "E-mail:";
            // 
            // mbtnCancelar
            // 
            this.mbtnCancelar.AutoSize = false;
            this.mbtnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnCancelar.Depth = 0;
            this.mbtnCancelar.HighEmphasis = true;
            this.mbtnCancelar.Icon = null;
            this.mbtnCancelar.Location = new System.Drawing.Point(146, 22);
            this.mbtnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCancelar.Name = "mbtnCancelar";
            this.mbtnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnCancelar.Size = new System.Drawing.Size(109, 24);
            this.mbtnCancelar.TabIndex = 11;
            this.mbtnCancelar.Text = "Cancelar";
            this.mbtnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnCancelar.UseAccentColor = false;
            this.mbtnCancelar.UseVisualStyleBackColor = true;
            this.mbtnCancelar.Click += new System.EventHandler(this.mbtnCancelar_Click);
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 776);
            this.Controls.Add(this.tabSelector);
            this.Controls.Add(this.tbControlUsu);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mbtnVoltar);
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
            this.tbControlUsu.ResumeLayout(false);
            this.tbSelecao.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.grbUsu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.grbOpcoesP.ResumeLayout(false);
            this.grbPesquisa.ResumeLayout(false);
            this.grbPesquisa.PerformLayout();
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
        private MaterialSkin.Controls.MaterialTabControl tbControlUsu;
        private System.Windows.Forms.TabPage tbSelecao;
        private System.Windows.Forms.TabPage tbCadastro;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private System.Windows.Forms.GroupBox grbUsu;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.GroupBox grbOpcoesP;
        private MaterialSkin.Controls.MaterialButton mbPesquisar;
        private MaterialSkin.Controls.MaterialButton mbVoltar;
        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.TextBox txtNomeP;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.Label lblSituacaoP;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.Label lblCodigoP;
        private System.Windows.Forms.TextBox txtemailP;
        private System.Windows.Forms.Label lblEmail;
        private MaterialSkin.Controls.MaterialButton mbtnCancelar;
    }
}
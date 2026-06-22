namespace Inventario
{
    partial class frmCadastroMa
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
            this.tabCntrCadastro = new MaterialSkin.Controls.MaterialTabControl();
            this.tbSelecao = new System.Windows.Forms.TabPage();
            this.grbGridMaquinas = new System.Windows.Forms.GroupBox();
            this.dgvMaquinas = new System.Windows.Forms.DataGridView();
            this.grbOpcoesP = new System.Windows.Forms.GroupBox();
            this.mbtnPesquisarP = new MaterialSkin.Controls.MaterialButton();
            this.mbVoltar = new MaterialSkin.Controls.MaterialButton();
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.txtFrenteP = new System.Windows.Forms.TextBox();
            this.txtFrotaP = new System.Windows.Forms.TextBox();
            this.lblFrente = new System.Windows.Forms.Label();
            this.lblFrota = new System.Windows.Forms.Label();
            this.txtTipoMaquinaP = new System.Windows.Forms.TextBox();
            this.lblTipoMaquinaP = new System.Windows.Forms.Label();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.lblCodigoP = new System.Windows.Forms.Label();
            this.tbCadastro = new System.Windows.Forms.TabPage();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.mbtnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.mbtnPesquisar = new MaterialSkin.Controls.MaterialButton();
            this.mbtnCadastrar_Atualizar = new MaterialSkin.Controls.MaterialButton();
            this.grbSituacao = new System.Windows.Forms.GroupBox();
            this.mRadioAtivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.mRadioInativo = new MaterialSkin.Controls.MaterialRadioButton();
            this.grbCampos = new System.Windows.Forms.GroupBox();
            this.mtxtFrente = new MaterialSkin.Controls.MaterialTextBox();
            this.mtxtFrota = new MaterialSkin.Controls.MaterialTextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.mcmbTipo = new MaterialSkin.Controls.MaterialComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.tbSelecionar = new MaterialSkin.Controls.MaterialTabSelector();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCntrCadastro.SuspendLayout();
            this.tbSelecao.SuspendLayout();
            this.grbGridMaquinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).BeginInit();
            this.grbOpcoesP.SuspendLayout();
            this.grbPesquisa.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.grbOpcoes.SuspendLayout();
            this.grbSituacao.SuspendLayout();
            this.grbCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCntrCadastro
            // 
            this.tabCntrCadastro.Controls.Add(this.tbSelecao);
            this.tabCntrCadastro.Controls.Add(this.tbCadastro);
            this.tabCntrCadastro.Depth = 0;
            this.tabCntrCadastro.Location = new System.Drawing.Point(6, 109);
            this.tabCntrCadastro.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabCntrCadastro.Multiline = true;
            this.tabCntrCadastro.Name = "tabCntrCadastro";
            this.tabCntrCadastro.SelectedIndex = 0;
            this.tabCntrCadastro.Size = new System.Drawing.Size(835, 567);
            this.tabCntrCadastro.TabIndex = 2;
            // 
            // tbSelecao
            // 
            this.tbSelecao.Controls.Add(this.grbGridMaquinas);
            this.tbSelecao.Controls.Add(this.grbOpcoesP);
            this.tbSelecao.Controls.Add(this.grbPesquisa);
            this.tbSelecao.Location = new System.Drawing.Point(4, 22);
            this.tbSelecao.Name = "tbSelecao";
            this.tbSelecao.Padding = new System.Windows.Forms.Padding(3);
            this.tbSelecao.Size = new System.Drawing.Size(827, 541);
            this.tbSelecao.TabIndex = 0;
            this.tbSelecao.Text = "Seleção";
            this.tbSelecao.UseVisualStyleBackColor = true;
            // 
            // grbGridMaquinas
            // 
            this.grbGridMaquinas.Controls.Add(this.dgvMaquinas);
            this.grbGridMaquinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGridMaquinas.Location = new System.Drawing.Point(6, 122);
            this.grbGridMaquinas.Name = "grbGridMaquinas";
            this.grbGridMaquinas.Size = new System.Drawing.Size(809, 416);
            this.grbGridMaquinas.TabIndex = 5;
            this.grbGridMaquinas.TabStop = false;
            this.grbGridMaquinas.Text = "Máquinas";
            // 
            // dgvMaquinas
            // 
            this.dgvMaquinas.AllowUserToAddRows = false;
            this.dgvMaquinas.AllowUserToDeleteRows = false;
            this.dgvMaquinas.AllowUserToOrderColumns = true;
            this.dgvMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinas.Location = new System.Drawing.Point(6, 19);
            this.dgvMaquinas.Name = "dgvMaquinas";
            this.dgvMaquinas.ReadOnly = true;
            this.dgvMaquinas.Size = new System.Drawing.Size(798, 394);
            this.dgvMaquinas.TabIndex = 0;
            // 
            // grbOpcoesP
            // 
            this.grbOpcoesP.Controls.Add(this.mbtnPesquisarP);
            this.grbOpcoesP.Controls.Add(this.mbVoltar);
            this.grbOpcoesP.Location = new System.Drawing.Point(527, 22);
            this.grbOpcoesP.Name = "grbOpcoesP";
            this.grbOpcoesP.Size = new System.Drawing.Size(223, 71);
            this.grbOpcoesP.TabIndex = 4;
            this.grbOpcoesP.TabStop = false;
            this.grbOpcoesP.Text = "Opções";
            // 
            // mbtnPesquisarP
            // 
            this.mbtnPesquisarP.AutoSize = false;
            this.mbtnPesquisarP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnPesquisarP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnPesquisarP.Depth = 0;
            this.mbtnPesquisarP.HighEmphasis = true;
            this.mbtnPesquisarP.Icon = null;
            this.mbtnPesquisarP.Location = new System.Drawing.Point(7, 19);
            this.mbtnPesquisarP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnPesquisarP.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnPesquisarP.Name = "mbtnPesquisarP";
            this.mbtnPesquisarP.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnPesquisarP.Size = new System.Drawing.Size(100, 36);
            this.mbtnPesquisarP.TabIndex = 6;
            this.mbtnPesquisarP.Text = "Pesquisar";
            this.mbtnPesquisarP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnPesquisarP.UseAccentColor = false;
            this.mbtnPesquisarP.UseVisualStyleBackColor = true;
            this.mbtnPesquisarP.Click += new System.EventHandler(this.mbPesquisar_Click);
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
            this.mbVoltar.Click += new System.EventHandler(this.mbVoltar_Click);
            // 
            // grbPesquisa
            // 
            this.grbPesquisa.Controls.Add(this.rdbInativo);
            this.grbPesquisa.Controls.Add(this.rdbAtivo);
            this.grbPesquisa.Controls.Add(this.label1);
            this.grbPesquisa.Controls.Add(this.txtFrenteP);
            this.grbPesquisa.Controls.Add(this.txtFrotaP);
            this.grbPesquisa.Controls.Add(this.lblFrente);
            this.grbPesquisa.Controls.Add(this.lblFrota);
            this.grbPesquisa.Controls.Add(this.txtTipoMaquinaP);
            this.grbPesquisa.Controls.Add(this.lblTipoMaquinaP);
            this.grbPesquisa.Controls.Add(this.txtCodigoP);
            this.grbPesquisa.Controls.Add(this.lblCodigoP);
            this.grbPesquisa.Location = new System.Drawing.Point(6, 6);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.Size = new System.Drawing.Size(306, 110);
            this.grbPesquisa.TabIndex = 0;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "Perquisar por:";
            // 
            // txtFrenteP
            // 
            this.txtFrenteP.Location = new System.Drawing.Point(199, 32);
            this.txtFrenteP.Name = "txtFrenteP";
            this.txtFrenteP.Size = new System.Drawing.Size(52, 20);
            this.txtFrenteP.TabIndex = 13;
            this.txtFrenteP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrenteP_KeyPress);
            // 
            // txtFrotaP
            // 
            this.txtFrotaP.Location = new System.Drawing.Point(119, 32);
            this.txtFrotaP.Name = "txtFrotaP";
            this.txtFrotaP.Size = new System.Drawing.Size(52, 20);
            this.txtFrotaP.TabIndex = 13;
            this.txtFrotaP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrotaP_KeyPress);
            // 
            // lblFrente
            // 
            this.lblFrente.AutoSize = true;
            this.lblFrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrente.Location = new System.Drawing.Point(196, 16);
            this.lblFrente.Name = "lblFrente";
            this.lblFrente.Size = new System.Drawing.Size(47, 13);
            this.lblFrente.TabIndex = 12;
            this.lblFrente.Text = "Frente:";
            // 
            // lblFrota
            // 
            this.lblFrota.AutoSize = true;
            this.lblFrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrota.Location = new System.Drawing.Point(116, 16);
            this.lblFrota.Name = "lblFrota";
            this.lblFrota.Size = new System.Drawing.Size(40, 13);
            this.lblFrota.TabIndex = 9;
            this.lblFrota.Text = "Frota:";
            // 
            // txtTipoMaquinaP
            // 
            this.txtTipoMaquinaP.Location = new System.Drawing.Point(6, 84);
            this.txtTipoMaquinaP.Name = "txtTipoMaquinaP";
            this.txtTipoMaquinaP.Size = new System.Drawing.Size(126, 20);
            this.txtTipoMaquinaP.TabIndex = 4;
            // 
            // lblTipoMaquinaP
            // 
            this.lblTipoMaquinaP.AutoSize = true;
            this.lblTipoMaquinaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMaquinaP.Location = new System.Drawing.Point(6, 68);
            this.lblTipoMaquinaP.Name = "lblTipoMaquinaP";
            this.lblTipoMaquinaP.Size = new System.Drawing.Size(88, 13);
            this.lblTipoMaquinaP.TabIndex = 3;
            this.lblTipoMaquinaP.Text = "Tipo Máquina:";
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Location = new System.Drawing.Point(6, 32);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(79, 20);
            this.txtCodigoP.TabIndex = 1;
            // 
            // lblCodigoP
            // 
            this.lblCodigoP.AutoSize = true;
            this.lblCodigoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoP.Location = new System.Drawing.Point(6, 16);
            this.lblCodigoP.Name = "lblCodigoP";
            this.lblCodigoP.Size = new System.Drawing.Size(50, 13);
            this.lblCodigoP.TabIndex = 0;
            this.lblCodigoP.Text = "Código:";
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.grbOpcoes);
            this.tbCadastro.Controls.Add(this.grbSituacao);
            this.tbCadastro.Controls.Add(this.grbCampos);
            this.tbCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastro.Size = new System.Drawing.Size(827, 541);
            this.tbCadastro.TabIndex = 1;
            this.tbCadastro.Text = "Cadastro";
            this.tbCadastro.UseVisualStyleBackColor = true;
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.mbtnCancelar);
            this.grbOpcoes.Controls.Add(this.mbtnPesquisar);
            this.grbOpcoes.Controls.Add(this.mbtnCadastrar_Atualizar);
            this.grbOpcoes.Location = new System.Drawing.Point(223, 473);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(398, 69);
            this.grbOpcoes.TabIndex = 14;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // mbtnCancelar
            // 
            this.mbtnCancelar.AutoSize = false;
            this.mbtnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnCancelar.Depth = 0;
            this.mbtnCancelar.HighEmphasis = true;
            this.mbtnCancelar.Icon = null;
            this.mbtnCancelar.Location = new System.Drawing.Point(140, 22);
            this.mbtnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCancelar.Name = "mbtnCancelar";
            this.mbtnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnCancelar.Size = new System.Drawing.Size(114, 36);
            this.mbtnCancelar.TabIndex = 9;
            this.mbtnCancelar.Text = "Cancelar";
            this.mbtnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnCancelar.UseAccentColor = false;
            this.mbtnCancelar.UseVisualStyleBackColor = true;
            // 
            // mbtnPesquisar
            // 
            this.mbtnPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnPesquisar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnPesquisar.Depth = 0;
            this.mbtnPesquisar.HighEmphasis = true;
            this.mbtnPesquisar.Icon = null;
            this.mbtnPesquisar.Location = new System.Drawing.Point(271, 22);
            this.mbtnPesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnPesquisar.Name = "mbtnPesquisar";
            this.mbtnPesquisar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnPesquisar.Size = new System.Drawing.Size(100, 36);
            this.mbtnPesquisar.TabIndex = 10;
            this.mbtnPesquisar.Text = "Pesquisar";
            this.mbtnPesquisar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnPesquisar.UseAccentColor = false;
            this.mbtnPesquisar.UseVisualStyleBackColor = true;
            this.mbtnPesquisar.Click += new System.EventHandler(this.mbtnPesquisar_Click);
            // 
            // mbtnCadastrar_Atualizar
            // 
            this.mbtnCadastrar_Atualizar.AutoSize = false;
            this.mbtnCadastrar_Atualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCadastrar_Atualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnCadastrar_Atualizar.Depth = 0;
            this.mbtnCadastrar_Atualizar.HighEmphasis = true;
            this.mbtnCadastrar_Atualizar.Icon = null;
            this.mbtnCadastrar_Atualizar.Location = new System.Drawing.Point(9, 22);
            this.mbtnCadastrar_Atualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCadastrar_Atualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCadastrar_Atualizar.Name = "mbtnCadastrar_Atualizar";
            this.mbtnCadastrar_Atualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnCadastrar_Atualizar.Size = new System.Drawing.Size(114, 36);
            this.mbtnCadastrar_Atualizar.TabIndex = 8;
            this.mbtnCadastrar_Atualizar.Text = "Cadastrar";
            this.mbtnCadastrar_Atualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnCadastrar_Atualizar.UseAccentColor = false;
            this.mbtnCadastrar_Atualizar.UseVisualStyleBackColor = true;
            this.mbtnCadastrar_Atualizar.Click += new System.EventHandler(this.mbtnCadastrar_Click);
            // 
            // grbSituacao
            // 
            this.grbSituacao.Controls.Add(this.mRadioAtivo);
            this.grbSituacao.Controls.Add(this.mRadioInativo);
            this.grbSituacao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbSituacao.Location = new System.Drawing.Point(312, 409);
            this.grbSituacao.Name = "grbSituacao";
            this.grbSituacao.Size = new System.Drawing.Size(237, 58);
            this.grbSituacao.TabIndex = 13;
            this.grbSituacao.TabStop = false;
            this.grbSituacao.Text = "Situação";
            // 
            // mRadioAtivo
            // 
            this.mRadioAtivo.AutoSize = true;
            this.mRadioAtivo.Depth = 0;
            this.mRadioAtivo.Location = new System.Drawing.Point(16, 16);
            this.mRadioAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioAtivo.Name = "mRadioAtivo";
            this.mRadioAtivo.Ripple = true;
            this.mRadioAtivo.Size = new System.Drawing.Size(71, 37);
            this.mRadioAtivo.TabIndex = 6;
            this.mRadioAtivo.TabStop = true;
            this.mRadioAtivo.Text = "Ativo";
            this.mRadioAtivo.UseVisualStyleBackColor = true;
            // 
            // mRadioInativo
            // 
            this.mRadioInativo.AutoSize = true;
            this.mRadioInativo.Depth = 0;
            this.mRadioInativo.Location = new System.Drawing.Point(140, 16);
            this.mRadioInativo.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioInativo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioInativo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioInativo.Name = "mRadioInativo";
            this.mRadioInativo.Ripple = true;
            this.mRadioInativo.Size = new System.Drawing.Size(83, 37);
            this.mRadioInativo.TabIndex = 7;
            this.mRadioInativo.TabStop = true;
            this.mRadioInativo.Text = "Inativo";
            this.mRadioInativo.UseVisualStyleBackColor = true;
            // 
            // grbCampos
            // 
            this.grbCampos.Controls.Add(this.mtxtFrente);
            this.grbCampos.Controls.Add(this.mtxtFrota);
            this.grbCampos.Controls.Add(this.txtObservacao);
            this.grbCampos.Controls.Add(this.mcmbTipo);
            this.grbCampos.Controls.Add(this.lblCodigo);
            this.grbCampos.Controls.Add(this.txtCodigo);
            this.grbCampos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbCampos.Location = new System.Drawing.Point(223, 9);
            this.grbCampos.Name = "grbCampos";
            this.grbCampos.Size = new System.Drawing.Size(398, 393);
            this.grbCampos.TabIndex = 1;
            this.grbCampos.TabStop = false;
            // 
            // mtxtFrente
            // 
            this.mtxtFrente.AnimateReadOnly = false;
            this.mtxtFrente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtFrente.Depth = 0;
            this.mtxtFrente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtFrente.LeadingIcon = null;
            this.mtxtFrente.Location = new System.Drawing.Point(201, 103);
            this.mtxtFrente.MaxLength = 50;
            this.mtxtFrente.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtFrente.Multiline = false;
            this.mtxtFrente.Name = "mtxtFrente";
            this.mtxtFrente.Size = new System.Drawing.Size(189, 50);
            this.mtxtFrente.TabIndex = 18;
            this.mtxtFrente.Text = "";
            this.mtxtFrente.TrailingIcon = null;
            this.mtxtFrente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtFrente_KeyPress);
            // 
            // mtxtFrota
            // 
            this.mtxtFrota.AnimateReadOnly = false;
            this.mtxtFrota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtFrota.Depth = 0;
            this.mtxtFrota.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtFrota.LeadingIcon = null;
            this.mtxtFrota.Location = new System.Drawing.Point(9, 103);
            this.mtxtFrota.MaxLength = 50;
            this.mtxtFrota.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtFrota.Multiline = false;
            this.mtxtFrota.Name = "mtxtFrota";
            this.mtxtFrota.Size = new System.Drawing.Size(186, 50);
            this.mtxtFrota.TabIndex = 16;
            this.mtxtFrota.Text = "";
            this.mtxtFrota.TrailingIcon = null;
            this.mtxtFrota.TextChanged += new System.EventHandler(this.mtxtFrota_TextChanged);
            this.mtxtFrota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtFrota_KeyPress);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(23, 229);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(348, 134);
            this.txtObservacao.TabIndex = 15;
            // 
            // mcmbTipo
            // 
            this.mcmbTipo.AutoResize = false;
            this.mcmbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcmbTipo.Depth = 0;
            this.mcmbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcmbTipo.DropDownHeight = 174;
            this.mcmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcmbTipo.DropDownWidth = 121;
            this.mcmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcmbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcmbTipo.FormattingEnabled = true;
            this.mcmbTipo.IntegralHeight = false;
            this.mcmbTipo.ItemHeight = 43;
            this.mcmbTipo.Location = new System.Drawing.Point(6, 159);
            this.mcmbTipo.MaxDropDownItems = 4;
            this.mcmbTipo.MouseState = MaterialSkin.MouseState.OUT;
            this.mcmbTipo.Name = "mcmbTipo";
            this.mcmbTipo.Size = new System.Drawing.Size(384, 49);
            this.mcmbTipo.StartIndex = 0;
            this.mcmbTipo.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(6, 46);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 50);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Text = "";
            this.txtCodigo.TrailingIcon = null;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // tbSelecionar
            // 
            this.tbSelecionar.BaseTabControl = this.tabCntrCadastro;
            this.tbSelecionar.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tbSelecionar.Depth = 0;
            this.tbSelecionar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSelecionar.Location = new System.Drawing.Point(232, 67);
            this.tbSelecionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSelecionar.Name = "tbSelecionar";
            this.tbSelecionar.Size = new System.Drawing.Size(398, 48);
            this.tbSelecionar.TabIndex = 11;
            this.tbSelecionar.Text = "materialTabSelector1";
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Location = new System.Drawing.Point(204, 87);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(79, 17);
            this.rdbInativo.TabIndex = 14;
            this.rdbInativo.TabStop = true;
            this.rdbInativo.Text = "Desativado";
            this.rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Location = new System.Drawing.Point(137, 87);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(61, 17);
            this.rdbAtivo.TabIndex = 16;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativado";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Situação:";
            // 
            // frmCadastroMa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 682);
            this.Controls.Add(this.tbSelecionar);
            this.Controls.Add(this.tabCntrCadastro);
            this.MaximizeBox = false;
            this.Name = "frmCadastroMa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Maquinas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastroMa_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastroMa_Load);
            this.tabCntrCadastro.ResumeLayout(false);
            this.tbSelecao.ResumeLayout(false);
            this.grbGridMaquinas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).EndInit();
            this.grbOpcoesP.ResumeLayout(false);
            this.grbPesquisa.ResumeLayout(false);
            this.grbPesquisa.PerformLayout();
            this.tbCadastro.ResumeLayout(false);
            this.grbOpcoes.ResumeLayout(false);
            this.grbOpcoes.PerformLayout();
            this.grbSituacao.ResumeLayout(false);
            this.grbSituacao.PerformLayout();
            this.grbCampos.ResumeLayout(false);
            this.grbCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabCntrCadastro;
        private System.Windows.Forms.TabPage tbSelecao;
        private System.Windows.Forms.GroupBox grbGridMaquinas;
        private System.Windows.Forms.DataGridView dgvMaquinas;
        private System.Windows.Forms.GroupBox grbOpcoesP;
        private MaterialSkin.Controls.MaterialButton mbtnPesquisarP;
        private MaterialSkin.Controls.MaterialButton mbVoltar;
        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.TextBox txtTipoMaquinaP;
        private System.Windows.Forms.Label lblTipoMaquinaP;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.Label lblCodigoP;
        private System.Windows.Forms.TabPage tbCadastro;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private MaterialSkin.Controls.MaterialButton mbtnCancelar;
        private MaterialSkin.Controls.MaterialButton mbtnPesquisar;
        private MaterialSkin.Controls.MaterialButton mbtnCadastrar_Atualizar;
        private System.Windows.Forms.GroupBox grbSituacao;
        private MaterialSkin.Controls.MaterialRadioButton mRadioAtivo;
        private MaterialSkin.Controls.MaterialRadioButton mRadioInativo;
        private System.Windows.Forms.GroupBox grbCampos;
        private System.Windows.Forms.Label lblCodigo;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialTabSelector tbSelecionar;
        private System.Windows.Forms.Label lblFrota;
        private System.Windows.Forms.Label lblFrente;
        private MaterialSkin.Controls.MaterialComboBox mcmbTipo;
        private System.Windows.Forms.TextBox txtFrenteP;
        private System.Windows.Forms.TextBox txtFrotaP;
        private System.Windows.Forms.TextBox txtObservacao;
        private MaterialSkin.Controls.MaterialTextBox mtxtFrota;
        private MaterialSkin.Controls.MaterialTextBox mtxtFrente;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.Label label1;
    }
}
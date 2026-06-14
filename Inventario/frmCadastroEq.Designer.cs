namespace Inventario
{
    partial class frmCadastroEq
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbSelecionar = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabCntrCadastro = new MaterialSkin.Controls.MaterialTabControl();
            this.tbSelecao = new System.Windows.Forms.TabPage();
            this.grbGridEquipamentos = new System.Windows.Forms.GroupBox();
            this.dgvEquipamentos = new System.Windows.Forms.DataGridView();
            this.grbOpcoesP = new System.Windows.Forms.GroupBox();
            this.mbPesquisar = new MaterialSkin.Controls.MaterialButton();
            this.mbVoltar = new MaterialSkin.Controls.MaterialButton();
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.txtNSerieP = new System.Windows.Forms.TextBox();
            this.lblNSerieP = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLocali = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cmbTipoP = new System.Windows.Forms.ComboBox();
            this.mskVencimentoP = new System.Windows.Forms.MaskedTextBox();
            this.lblSituacaoP = new System.Windows.Forms.Label();
            this.mskAtivacaoP = new System.Windows.Forms.MaskedTextBox();
            this.lblTipoEquipamentoP = new System.Windows.Forms.Label();
            this.lblVencimentoP = new System.Windows.Forms.Label();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.lblCodigoP = new System.Windows.Forms.Label();
            this.lblAtivacaoP = new System.Windows.Forms.Label();
            this.tbCadastro = new System.Windows.Forms.TabPage();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.mbtnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.mbtnPesquisar = new MaterialSkin.Controls.MaterialButton();
            this.mbtnCadastrar = new MaterialSkin.Controls.MaterialButton();
            this.grbSituacao = new System.Windows.Forms.GroupBox();
            this.mRadioAtivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.mRadioInativo = new MaterialSkin.Controls.MaterialRadioButton();
            this.grbCampos = new System.Windows.Forms.GroupBox();
            this.lblAtivacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskVencimento = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mskAtivacao = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtNumeroLicenca = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTipoLicenca = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.dgvLi = new System.Windows.Forms.DataGridView();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.mTxtPesquisa = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabCntrCadastro.SuspendLayout();
            this.tbSelecao.SuspendLayout();
            this.grbGridEquipamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).BeginInit();
            this.grbOpcoesP.SuspendLayout();
            this.grbPesquisa.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.grbOpcoes.SuspendLayout();
            this.grbSituacao.SuspendLayout();
            this.grbCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLi)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSelecionar
            // 
            this.tbSelecionar.BaseTabControl = this.tabCntrCadastro;
            this.tbSelecionar.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tbSelecionar.Depth = 0;
            this.tbSelecionar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSelecionar.Location = new System.Drawing.Point(231, 67);
            this.tbSelecionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSelecionar.Name = "tbSelecionar";
            this.tbSelecionar.Size = new System.Drawing.Size(398, 48);
            this.tbSelecionar.TabIndex = 13;
            this.tbSelecionar.Text = "materialTabSelector1";
            // 
            // tabCntrCadastro
            // 
            this.tabCntrCadastro.Controls.Add(this.tbSelecao);
            this.tabCntrCadastro.Controls.Add(this.tbCadastro);
            this.tabCntrCadastro.Depth = 0;
            this.tabCntrCadastro.Location = new System.Drawing.Point(5, 109);
            this.tabCntrCadastro.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabCntrCadastro.Multiline = true;
            this.tabCntrCadastro.Name = "tabCntrCadastro";
            this.tabCntrCadastro.SelectedIndex = 0;
            this.tabCntrCadastro.Size = new System.Drawing.Size(1015, 641);
            this.tabCntrCadastro.TabIndex = 12;
            // 
            // tbSelecao
            // 
            this.tbSelecao.Controls.Add(this.grbGridEquipamentos);
            this.tbSelecao.Controls.Add(this.grbOpcoesP);
            this.tbSelecao.Controls.Add(this.grbPesquisa);
            this.tbSelecao.Location = new System.Drawing.Point(4, 22);
            this.tbSelecao.Name = "tbSelecao";
            this.tbSelecao.Padding = new System.Windows.Forms.Padding(3);
            this.tbSelecao.Size = new System.Drawing.Size(819, 541);
            this.tbSelecao.TabIndex = 0;
            this.tbSelecao.Text = "Seleção";
            this.tbSelecao.UseVisualStyleBackColor = true;
            // 
            // grbGridEquipamentos
            // 
            this.grbGridEquipamentos.Controls.Add(this.dgvEquipamentos);
            this.grbGridEquipamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGridEquipamentos.Location = new System.Drawing.Point(6, 122);
            this.grbGridEquipamentos.Name = "grbGridEquipamentos";
            this.grbGridEquipamentos.Size = new System.Drawing.Size(809, 416);
            this.grbGridEquipamentos.TabIndex = 5;
            this.grbGridEquipamentos.TabStop = false;
            this.grbGridEquipamentos.Text = "Equipamentos";
            // 
            // dgvEquipamentos
            // 
            this.dgvEquipamentos.AllowUserToAddRows = false;
            this.dgvEquipamentos.AllowUserToDeleteRows = false;
            this.dgvEquipamentos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEquipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquipamentos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEquipamentos.Location = new System.Drawing.Point(5, 16);
            this.dgvEquipamentos.Name = "dgvEquipamentos";
            this.dgvEquipamentos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEquipamentos.Size = new System.Drawing.Size(798, 394);
            this.dgvEquipamentos.TabIndex = 0;
            // 
            // grbOpcoesP
            // 
            this.grbOpcoesP.Controls.Add(this.mbPesquisar);
            this.grbOpcoesP.Controls.Add(this.mbVoltar);
            this.grbOpcoesP.Location = new System.Drawing.Point(527, 22);
            this.grbOpcoesP.Name = "grbOpcoesP";
            this.grbOpcoesP.Size = new System.Drawing.Size(223, 71);
            this.grbOpcoesP.TabIndex = 4;
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
            this.grbPesquisa.Controls.Add(this.txtNSerieP);
            this.grbPesquisa.Controls.Add(this.lblNSerieP);
            this.grbPesquisa.Controls.Add(this.textBox1);
            this.grbPesquisa.Controls.Add(this.lblLocali);
            this.grbPesquisa.Controls.Add(this.radioButton2);
            this.grbPesquisa.Controls.Add(this.radioButton1);
            this.grbPesquisa.Controls.Add(this.cmbTipoP);
            this.grbPesquisa.Controls.Add(this.mskVencimentoP);
            this.grbPesquisa.Controls.Add(this.lblSituacaoP);
            this.grbPesquisa.Controls.Add(this.mskAtivacaoP);
            this.grbPesquisa.Controls.Add(this.lblTipoEquipamentoP);
            this.grbPesquisa.Controls.Add(this.lblVencimentoP);
            this.grbPesquisa.Controls.Add(this.txtCodigoP);
            this.grbPesquisa.Controls.Add(this.lblCodigoP);
            this.grbPesquisa.Controls.Add(this.lblAtivacaoP);
            this.grbPesquisa.Location = new System.Drawing.Point(6, 6);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.Size = new System.Drawing.Size(503, 110);
            this.grbPesquisa.TabIndex = 0;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "Perquisar por:";
            // 
            // txtNSerieP
            // 
            this.txtNSerieP.Location = new System.Drawing.Point(240, 32);
            this.txtNSerieP.Name = "txtNSerieP";
            this.txtNSerieP.Size = new System.Drawing.Size(134, 20);
            this.txtNSerieP.TabIndex = 16;
            // 
            // lblNSerieP
            // 
            this.lblNSerieP.AutoSize = true;
            this.lblNSerieP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNSerieP.Location = new System.Drawing.Point(237, 17);
            this.lblNSerieP.Name = "lblNSerieP";
            this.lblNSerieP.Size = new System.Drawing.Size(58, 13);
            this.lblNSerieP.TabIndex = 15;
            this.lblNSerieP.Text = "N° Série:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 14;
            // 
            // lblLocali
            // 
            this.lblLocali.AutoSize = true;
            this.lblLocali.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocali.Location = new System.Drawing.Point(213, 66);
            this.lblLocali.Name = "lblLocali";
            this.lblLocali.Size = new System.Drawing.Size(79, 13);
            this.lblLocali.TabIndex = 13;
            this.lblLocali.Text = "Localização:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(75, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Desativado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 82);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ativado";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // cmbTipoP
            // 
            this.cmbTipoP.FormattingEnabled = true;
            this.cmbTipoP.Location = new System.Drawing.Point(103, 32);
            this.cmbTipoP.Name = "cmbTipoP";
            this.cmbTipoP.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoP.TabIndex = 11;
            // 
            // mskVencimentoP
            // 
            this.mskVencimentoP.Location = new System.Drawing.Point(399, 81);
            this.mskVencimentoP.Mask = "00/00/0000";
            this.mskVencimentoP.Name = "mskVencimentoP";
            this.mskVencimentoP.Size = new System.Drawing.Size(75, 20);
            this.mskVencimentoP.TabIndex = 9;
            this.mskVencimentoP.ValidatingType = typeof(System.DateTime);
            // 
            // lblSituacaoP
            // 
            this.lblSituacaoP.AutoSize = true;
            this.lblSituacaoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacaoP.Location = new System.Drawing.Point(61, 63);
            this.lblSituacaoP.Name = "lblSituacaoP";
            this.lblSituacaoP.Size = new System.Drawing.Size(61, 13);
            this.lblSituacaoP.TabIndex = 6;
            this.lblSituacaoP.Text = "Situação:";
            // 
            // mskAtivacaoP
            // 
            this.mskAtivacaoP.Location = new System.Drawing.Point(399, 29);
            this.mskAtivacaoP.Mask = "00/00/0000";
            this.mskAtivacaoP.Name = "mskAtivacaoP";
            this.mskAtivacaoP.Size = new System.Drawing.Size(75, 20);
            this.mskAtivacaoP.TabIndex = 8;
            this.mskAtivacaoP.ValidatingType = typeof(System.DateTime);
            // 
            // lblTipoEquipamentoP
            // 
            this.lblTipoEquipamentoP.AutoSize = true;
            this.lblTipoEquipamentoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEquipamentoP.Location = new System.Drawing.Point(100, 17);
            this.lblTipoEquipamentoP.Name = "lblTipoEquipamentoP";
            this.lblTipoEquipamentoP.Size = new System.Drawing.Size(113, 13);
            this.lblTipoEquipamentoP.TabIndex = 3;
            this.lblTipoEquipamentoP.Text = "Tipo Equipamento:";
            // 
            // lblVencimentoP
            // 
            this.lblVencimentoP.AutoSize = true;
            this.lblVencimentoP.Location = new System.Drawing.Point(396, 65);
            this.lblVencimentoP.Name = "lblVencimentoP";
            this.lblVencimentoP.Size = new System.Drawing.Size(92, 13);
            this.lblVencimentoP.TabIndex = 10;
            this.lblVencimentoP.Text = "Data Vencimento:";
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
            // lblAtivacaoP
            // 
            this.lblAtivacaoP.AutoSize = true;
            this.lblAtivacaoP.Location = new System.Drawing.Point(396, 16);
            this.lblAtivacaoP.Name = "lblAtivacaoP";
            this.lblAtivacaoP.Size = new System.Drawing.Size(78, 13);
            this.lblAtivacaoP.TabIndex = 7;
            this.lblAtivacaoP.Text = "Data Ativação:";
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.mTxtPesquisa);
            this.tbCadastro.Controls.Add(this.lblPesquisar);
            this.tbCadastro.Controls.Add(this.materialButton1);
            this.tbCadastro.Controls.Add(this.dgvLi);
            this.tbCadastro.Controls.Add(this.grbOpcoes);
            this.tbCadastro.Controls.Add(this.grbSituacao);
            this.tbCadastro.Controls.Add(this.grbCampos);
            this.tbCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastro.Size = new System.Drawing.Size(1007, 615);
            this.tbCadastro.TabIndex = 1;
            this.tbCadastro.Text = "Cadastro";
            this.tbCadastro.UseVisualStyleBackColor = true;
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.mbtnCancelar);
            this.grbOpcoes.Controls.Add(this.mbtnPesquisar);
            this.grbOpcoes.Controls.Add(this.mbtnCadastrar);
            this.grbOpcoes.Location = new System.Drawing.Point(30, 470);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(398, 69);
            this.grbOpcoes.TabIndex = 17;
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
            this.mbtnCancelar.TabIndex = 4;
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
            this.mbtnPesquisar.TabIndex = 3;
            this.mbtnPesquisar.Text = "Pesquisar";
            this.mbtnPesquisar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnPesquisar.UseAccentColor = false;
            this.mbtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // mbtnCadastrar
            // 
            this.mbtnCadastrar.AutoSize = false;
            this.mbtnCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCadastrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnCadastrar.Depth = 0;
            this.mbtnCadastrar.HighEmphasis = true;
            this.mbtnCadastrar.Icon = null;
            this.mbtnCadastrar.Location = new System.Drawing.Point(9, 22);
            this.mbtnCadastrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCadastrar.Name = "mbtnCadastrar";
            this.mbtnCadastrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnCadastrar.Size = new System.Drawing.Size(114, 36);
            this.mbtnCadastrar.TabIndex = 2;
            this.mbtnCadastrar.Text = "Cadastrar";
            this.mbtnCadastrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnCadastrar.UseAccentColor = false;
            this.mbtnCadastrar.UseVisualStyleBackColor = true;
            // 
            // grbSituacao
            // 
            this.grbSituacao.Controls.Add(this.mRadioAtivo);
            this.grbSituacao.Controls.Add(this.mRadioInativo);
            this.grbSituacao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbSituacao.Location = new System.Drawing.Point(30, 406);
            this.grbSituacao.Name = "grbSituacao";
            this.grbSituacao.Size = new System.Drawing.Size(398, 58);
            this.grbSituacao.TabIndex = 16;
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
            this.mRadioAtivo.TabIndex = 12;
            this.mRadioAtivo.TabStop = true;
            this.mRadioAtivo.Text = "Ativo";
            this.mRadioAtivo.UseVisualStyleBackColor = true;
            // 
            // mRadioInativo
            // 
            this.mRadioInativo.AutoSize = true;
            this.mRadioInativo.Depth = 0;
            this.mRadioInativo.Location = new System.Drawing.Point(294, 16);
            this.mRadioInativo.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioInativo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioInativo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioInativo.Name = "mRadioInativo";
            this.mRadioInativo.Ripple = true;
            this.mRadioInativo.Size = new System.Drawing.Size(83, 37);
            this.mRadioInativo.TabIndex = 11;
            this.mRadioInativo.TabStop = true;
            this.mRadioInativo.Text = "Inativo";
            this.mRadioInativo.UseVisualStyleBackColor = true;
            // 
            // grbCampos
            // 
            this.grbCampos.Controls.Add(this.lblAtivacao);
            this.grbCampos.Controls.Add(this.label1);
            this.grbCampos.Controls.Add(this.mskVencimento);
            this.grbCampos.Controls.Add(this.mskAtivacao);
            this.grbCampos.Controls.Add(this.txtNumeroLicenca);
            this.grbCampos.Controls.Add(this.txtTipoLicenca);
            this.grbCampos.Controls.Add(this.lblCodigo);
            this.grbCampos.Controls.Add(this.txtCodigo);
            this.grbCampos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbCampos.Location = new System.Drawing.Point(30, 6);
            this.grbCampos.Name = "grbCampos";
            this.grbCampos.Size = new System.Drawing.Size(398, 394);
            this.grbCampos.TabIndex = 15;
            this.grbCampos.TabStop = false;
            // 
            // lblAtivacao
            // 
            this.lblAtivacao.AutoSize = true;
            this.lblAtivacao.Location = new System.Drawing.Point(9, 229);
            this.lblAtivacao.Name = "lblAtivacao";
            this.lblAtivacao.Size = new System.Drawing.Size(52, 13);
            this.lblAtivacao.TabIndex = 9;
            this.lblAtivacao.Text = "Ativação:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vencimento:";
            // 
            // mskVencimento
            // 
            this.mskVencimento.AllowPromptAsInput = true;
            this.mskVencimento.AnimateReadOnly = false;
            this.mskVencimento.AsciiOnly = false;
            this.mskVencimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mskVencimento.BeepOnError = false;
            this.mskVencimento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskVencimento.Depth = 0;
            this.mskVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mskVencimento.HidePromptOnLeave = false;
            this.mskVencimento.HideSelection = true;
            this.mskVencimento.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mskVencimento.LeadingIcon = null;
            this.mskVencimento.Location = new System.Drawing.Point(9, 325);
            this.mskVencimento.Mask = "00/00/0000";
            this.mskVencimento.MaxLength = 32767;
            this.mskVencimento.MouseState = MaterialSkin.MouseState.OUT;
            this.mskVencimento.Name = "mskVencimento";
            this.mskVencimento.PasswordChar = '\0';
            this.mskVencimento.PrefixSuffixText = null;
            this.mskVencimento.PromptChar = '_';
            this.mskVencimento.ReadOnly = false;
            this.mskVencimento.RejectInputOnFirstFailure = false;
            this.mskVencimento.ResetOnPrompt = true;
            this.mskVencimento.ResetOnSpace = true;
            this.mskVencimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskVencimento.SelectedText = "";
            this.mskVencimento.SelectionLength = 0;
            this.mskVencimento.SelectionStart = 0;
            this.mskVencimento.ShortcutsEnabled = true;
            this.mskVencimento.Size = new System.Drawing.Size(382, 48);
            this.mskVencimento.SkipLiterals = true;
            this.mskVencimento.TabIndex = 7;
            this.mskVencimento.TabStop = false;
            this.mskVencimento.Text = "  /  /";
            this.mskVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mskVencimento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskVencimento.TrailingIcon = null;
            this.mskVencimento.UseSystemPasswordChar = false;
            this.mskVencimento.ValidatingType = null;
            // 
            // mskAtivacao
            // 
            this.mskAtivacao.AllowPromptAsInput = true;
            this.mskAtivacao.AnimateReadOnly = false;
            this.mskAtivacao.AsciiOnly = false;
            this.mskAtivacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mskAtivacao.BeepOnError = false;
            this.mskAtivacao.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskAtivacao.Depth = 0;
            this.mskAtivacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mskAtivacao.HidePromptOnLeave = false;
            this.mskAtivacao.HideSelection = true;
            this.mskAtivacao.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mskAtivacao.LeadingIcon = null;
            this.mskAtivacao.Location = new System.Drawing.Point(6, 245);
            this.mskAtivacao.Mask = "00/00/0000";
            this.mskAtivacao.MaxLength = 32767;
            this.mskAtivacao.MouseState = MaterialSkin.MouseState.OUT;
            this.mskAtivacao.Name = "mskAtivacao";
            this.mskAtivacao.PasswordChar = '\0';
            this.mskAtivacao.PrefixSuffixText = null;
            this.mskAtivacao.PromptChar = '_';
            this.mskAtivacao.ReadOnly = false;
            this.mskAtivacao.RejectInputOnFirstFailure = false;
            this.mskAtivacao.ResetOnPrompt = true;
            this.mskAtivacao.ResetOnSpace = true;
            this.mskAtivacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskAtivacao.SelectedText = "";
            this.mskAtivacao.SelectionLength = 0;
            this.mskAtivacao.SelectionStart = 0;
            this.mskAtivacao.ShortcutsEnabled = true;
            this.mskAtivacao.Size = new System.Drawing.Size(385, 48);
            this.mskAtivacao.SkipLiterals = true;
            this.mskAtivacao.TabIndex = 6;
            this.mskAtivacao.TabStop = false;
            this.mskAtivacao.Text = "  /  /";
            this.mskAtivacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mskAtivacao.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskAtivacao.TrailingIcon = null;
            this.mskAtivacao.UseSystemPasswordChar = false;
            this.mskAtivacao.ValidatingType = null;
            // 
            // txtNumeroLicenca
            // 
            this.txtNumeroLicenca.AnimateReadOnly = false;
            this.txtNumeroLicenca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroLicenca.Depth = 0;
            this.txtNumeroLicenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumeroLicenca.LeadingIcon = null;
            this.txtNumeroLicenca.Location = new System.Drawing.Point(8, 172);
            this.txtNumeroLicenca.MaxLength = 50;
            this.txtNumeroLicenca.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumeroLicenca.Multiline = false;
            this.txtNumeroLicenca.Name = "txtNumeroLicenca";
            this.txtNumeroLicenca.Size = new System.Drawing.Size(383, 50);
            this.txtNumeroLicenca.TabIndex = 5;
            this.txtNumeroLicenca.Text = "";
            this.txtNumeroLicenca.TrailingIcon = null;
            // 
            // txtTipoLicenca
            // 
            this.txtTipoLicenca.AnimateReadOnly = false;
            this.txtTipoLicenca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoLicenca.Depth = 0;
            this.txtTipoLicenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTipoLicenca.LeadingIcon = null;
            this.txtTipoLicenca.Location = new System.Drawing.Point(8, 112);
            this.txtTipoLicenca.MaxLength = 50;
            this.txtTipoLicenca.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTipoLicenca.Multiline = false;
            this.txtTipoLicenca.Name = "txtTipoLicenca";
            this.txtTipoLicenca.Size = new System.Drawing.Size(383, 50);
            this.txtTipoLicenca.TabIndex = 4;
            this.txtTipoLicenca.Text = "";
            this.txtTipoLicenca.TrailingIcon = null;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(81, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código Licença";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(6, 46);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 50);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.Text = "";
            this.txtCodigo.TrailingIcon = null;
            // 
            // dgvLi
            // 
            this.dgvLi.AllowUserToAddRows = false;
            this.dgvLi.AllowUserToDeleteRows = false;
            this.dgvLi.AllowUserToOrderColumns = true;
            this.dgvLi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLi.Location = new System.Drawing.Point(442, 92);
            this.dgvLi.Name = "dgvLi";
            this.dgvLi.ReadOnly = true;
            this.dgvLi.Size = new System.Drawing.Size(559, 517);
            this.dgvLi.TabIndex = 18;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(900, 52);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(100, 36);
            this.materialButton1.TabIndex = 19;
            this.materialButton1.Text = "Pesquisar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(439, 17);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(97, 13);
            this.lblPesquisar.TabIndex = 20;
            this.lblPesquisar.Text = "Pesquisar Licença:";
            // 
            // mTxtPesquisa
            // 
            this.mTxtPesquisa.AnimateReadOnly = false;
            this.mTxtPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mTxtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mTxtPesquisa.Depth = 0;
            this.mTxtPesquisa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mTxtPesquisa.HideSelection = true;
            this.mTxtPesquisa.LeadingIcon = null;
            this.mTxtPesquisa.Location = new System.Drawing.Point(442, 40);
            this.mTxtPesquisa.MaxLength = 32767;
            this.mTxtPesquisa.MouseState = MaterialSkin.MouseState.OUT;
            this.mTxtPesquisa.Name = "mTxtPesquisa";
            this.mTxtPesquisa.PasswordChar = '\0';
            this.mTxtPesquisa.PrefixSuffixText = null;
            this.mTxtPesquisa.ReadOnly = false;
            this.mTxtPesquisa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTxtPesquisa.SelectedText = "";
            this.mTxtPesquisa.SelectionLength = 0;
            this.mTxtPesquisa.SelectionStart = 0;
            this.mTxtPesquisa.ShortcutsEnabled = true;
            this.mTxtPesquisa.Size = new System.Drawing.Size(451, 48);
            this.mTxtPesquisa.TabIndex = 21;
            this.mTxtPesquisa.TabStop = false;
            this.mTxtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mTxtPesquisa.TrailingIcon = null;
            this.mTxtPesquisa.UseSystemPasswordChar = false;
            // 
            // frmCadastroEq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 756);
            this.Controls.Add(this.tbSelecionar);
            this.Controls.Add(this.tabCntrCadastro);
            this.Name = "frmCadastroEq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Equipamentos";
            this.Load += new System.EventHandler(this.frmCadastroEq_Load);
            this.tabCntrCadastro.ResumeLayout(false);
            this.tbSelecao.ResumeLayout(false);
            this.grbGridEquipamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).EndInit();
            this.grbOpcoesP.ResumeLayout(false);
            this.grbPesquisa.ResumeLayout(false);
            this.grbPesquisa.PerformLayout();
            this.tbCadastro.ResumeLayout(false);
            this.tbCadastro.PerformLayout();
            this.grbOpcoes.ResumeLayout(false);
            this.grbOpcoes.PerformLayout();
            this.grbSituacao.ResumeLayout(false);
            this.grbSituacao.PerformLayout();
            this.grbCampos.ResumeLayout(false);
            this.grbCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tbSelecionar;
        private MaterialSkin.Controls.MaterialTabControl tabCntrCadastro;
        private System.Windows.Forms.TabPage tbSelecao;
        private System.Windows.Forms.GroupBox grbGridEquipamentos;
        private System.Windows.Forms.DataGridView dgvEquipamentos;
        private System.Windows.Forms.GroupBox grbOpcoesP;
        private MaterialSkin.Controls.MaterialButton mbPesquisar;
        private MaterialSkin.Controls.MaterialButton mbVoltar;
        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.Label lblSituacaoP;
        private System.Windows.Forms.Label lblTipoEquipamentoP;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.Label lblCodigoP;
        private System.Windows.Forms.TabPage tbCadastro;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cmbTipoP;
        private System.Windows.Forms.MaskedTextBox mskVencimentoP;
        private System.Windows.Forms.MaskedTextBox mskAtivacaoP;
        private System.Windows.Forms.Label lblVencimentoP;
        private System.Windows.Forms.Label lblAtivacaoP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLocali;
        private System.Windows.Forms.TextBox txtNSerieP;
        private System.Windows.Forms.Label lblNSerieP;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private MaterialSkin.Controls.MaterialButton mbtnCancelar;
        private MaterialSkin.Controls.MaterialButton mbtnPesquisar;
        private MaterialSkin.Controls.MaterialButton mbtnCadastrar;
        private System.Windows.Forms.GroupBox grbSituacao;
        private MaterialSkin.Controls.MaterialRadioButton mRadioAtivo;
        private MaterialSkin.Controls.MaterialRadioButton mRadioInativo;
        private System.Windows.Forms.GroupBox grbCampos;
        private System.Windows.Forms.Label lblAtivacao;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialMaskedTextBox mskVencimento;
        private MaterialSkin.Controls.MaterialMaskedTextBox mskAtivacao;
        private MaterialSkin.Controls.MaterialTextBox txtNumeroLicenca;
        private MaterialSkin.Controls.MaterialTextBox txtTipoLicenca;
        private System.Windows.Forms.Label lblCodigo;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialTextBox2 mTxtPesquisa;
        private System.Windows.Forms.Label lblPesquisar;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridView dgvLi;
    }
}
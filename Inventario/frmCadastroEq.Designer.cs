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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.grbOpcoesCadastro = new System.Windows.Forms.GroupBox();
            this.mbtnMonitor = new MaterialSkin.Controls.MaterialButton();
            this.mbtnNav900 = new MaterialSkin.Controls.MaterialButton();
            this.mbtnNav2e3 = new MaterialSkin.Controls.MaterialButton();
            this.mbtnTm200 = new MaterialSkin.Controls.MaterialButton();
            this.mbtnAntenaAg25 = new MaterialSkin.Controls.MaterialButton();
            this.mbtnControladorTaxa = new MaterialSkin.Controls.MaterialButton();
            this.mbtnBotoeira = new MaterialSkin.Controls.MaterialButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.tabCntrCadastro.SuspendLayout();
            this.tbSelecao.SuspendLayout();
            this.grbGridEquipamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).BeginInit();
            this.grbOpcoesP.SuspendLayout();
            this.grbPesquisa.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.grbOpcoes.SuspendLayout();
            this.grbOpcoesCadastro.SuspendLayout();
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
            this.tabCntrCadastro.Size = new System.Drawing.Size(827, 567);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEquipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquipamentos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEquipamentos.Location = new System.Drawing.Point(5, 16);
            this.dgvEquipamentos.Name = "dgvEquipamentos";
            this.dgvEquipamentos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.tbCadastro.Controls.Add(this.pnlContainer);
            this.tbCadastro.Controls.Add(this.grbOpcoesCadastro);
            this.tbCadastro.Controls.Add(this.grbOpcoes);
            this.tbCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastro.Size = new System.Drawing.Size(819, 541);
            this.tbCadastro.TabIndex = 1;
            this.tbCadastro.Text = "Cadastro";
            this.tbCadastro.UseVisualStyleBackColor = true;
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.mbtnCancelar);
            this.grbOpcoes.Controls.Add(this.mbtnPesquisar);
            this.grbOpcoes.Controls.Add(this.mbtnCadastrar);
            this.grbOpcoes.Location = new System.Drawing.Point(274, 472);
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
            this.mbtnCadastrar.TabIndex = 8;
            this.mbtnCadastrar.Text = "Cadastrar";
            this.mbtnCadastrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnCadastrar.UseAccentColor = false;
            this.mbtnCadastrar.UseVisualStyleBackColor = true;
            // 
            // grbOpcoesCadastro
            // 
            this.grbOpcoesCadastro.Controls.Add(this.mbtnBotoeira);
            this.grbOpcoesCadastro.Controls.Add(this.mbtnControladorTaxa);
            this.grbOpcoesCadastro.Controls.Add(this.mbtnAntenaAg25);
            this.grbOpcoesCadastro.Controls.Add(this.mbtnTm200);
            this.grbOpcoesCadastro.Controls.Add(this.mbtnNav2e3);
            this.grbOpcoesCadastro.Controls.Add(this.mbtnNav900);
            this.grbOpcoesCadastro.Controls.Add(this.mbtnMonitor);
            this.grbOpcoesCadastro.Location = new System.Drawing.Point(10, 26);
            this.grbOpcoesCadastro.Name = "grbOpcoesCadastro";
            this.grbOpcoesCadastro.Size = new System.Drawing.Size(156, 383);
            this.grbOpcoesCadastro.TabIndex = 15;
            this.grbOpcoesCadastro.TabStop = false;
            this.grbOpcoesCadastro.Text = "Opções de Cadastro";
            // 
            // mbtnMonitor
            // 
            this.mbtnMonitor.AutoSize = false;
            this.mbtnMonitor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnMonitor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnMonitor.Depth = 0;
            this.mbtnMonitor.HighEmphasis = true;
            this.mbtnMonitor.Icon = null;
            this.mbtnMonitor.Location = new System.Drawing.Point(5, 40);
            this.mbtnMonitor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnMonitor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnMonitor.Name = "mbtnMonitor";
            this.mbtnMonitor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnMonitor.Size = new System.Drawing.Size(143, 36);
            this.mbtnMonitor.TabIndex = 0;
            this.mbtnMonitor.Text = "Monitor";
            this.mbtnMonitor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnMonitor.UseAccentColor = false;
            this.mbtnMonitor.UseVisualStyleBackColor = true;
            this.mbtnMonitor.Click += new System.EventHandler(this.mbtnMonitor_Click);
            // 
            // mbtnNav900
            // 
            this.mbtnNav900.AutoSize = false;
            this.mbtnNav900.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnNav900.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnNav900.Depth = 0;
            this.mbtnNav900.HighEmphasis = true;
            this.mbtnNav900.Icon = null;
            this.mbtnNav900.Location = new System.Drawing.Point(5, 88);
            this.mbtnNav900.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnNav900.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnNav900.Name = "mbtnNav900";
            this.mbtnNav900.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnNav900.Size = new System.Drawing.Size(143, 36);
            this.mbtnNav900.TabIndex = 0;
            this.mbtnNav900.Text = "Nav 900";
            this.mbtnNav900.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnNav900.UseAccentColor = false;
            this.mbtnNav900.UseVisualStyleBackColor = true;
            // 
            // mbtnNav2e3
            // 
            this.mbtnNav2e3.AutoSize = false;
            this.mbtnNav2e3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnNav2e3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnNav2e3.Depth = 0;
            this.mbtnNav2e3.HighEmphasis = true;
            this.mbtnNav2e3.Icon = null;
            this.mbtnNav2e3.Location = new System.Drawing.Point(5, 136);
            this.mbtnNav2e3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnNav2e3.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnNav2e3.Name = "mbtnNav2e3";
            this.mbtnNav2e3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnNav2e3.Size = new System.Drawing.Size(143, 36);
            this.mbtnNav2e3.TabIndex = 0;
            this.mbtnNav2e3.Text = "Nav 2 e 3";
            this.mbtnNav2e3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnNav2e3.UseAccentColor = false;
            this.mbtnNav2e3.UseVisualStyleBackColor = true;
            // 
            // mbtnTm200
            // 
            this.mbtnTm200.AutoSize = false;
            this.mbtnTm200.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnTm200.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnTm200.Depth = 0;
            this.mbtnTm200.HighEmphasis = true;
            this.mbtnTm200.Icon = null;
            this.mbtnTm200.Location = new System.Drawing.Point(5, 184);
            this.mbtnTm200.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnTm200.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnTm200.Name = "mbtnTm200";
            this.mbtnTm200.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnTm200.Size = new System.Drawing.Size(143, 36);
            this.mbtnTm200.TabIndex = 0;
            this.mbtnTm200.Text = "Tm 200";
            this.mbtnTm200.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnTm200.UseAccentColor = false;
            this.mbtnTm200.UseVisualStyleBackColor = true;
            // 
            // mbtnAntenaAg25
            // 
            this.mbtnAntenaAg25.AutoSize = false;
            this.mbtnAntenaAg25.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAntenaAg25.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnAntenaAg25.Depth = 0;
            this.mbtnAntenaAg25.HighEmphasis = true;
            this.mbtnAntenaAg25.Icon = null;
            this.mbtnAntenaAg25.Location = new System.Drawing.Point(5, 232);
            this.mbtnAntenaAg25.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAntenaAg25.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAntenaAg25.Name = "mbtnAntenaAg25";
            this.mbtnAntenaAg25.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnAntenaAg25.Size = new System.Drawing.Size(143, 36);
            this.mbtnAntenaAg25.TabIndex = 0;
            this.mbtnAntenaAg25.Text = "Antena ag25";
            this.mbtnAntenaAg25.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnAntenaAg25.UseAccentColor = false;
            this.mbtnAntenaAg25.UseVisualStyleBackColor = true;
            // 
            // mbtnControladorTaxa
            // 
            this.mbtnControladorTaxa.AutoSize = false;
            this.mbtnControladorTaxa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnControladorTaxa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnControladorTaxa.Depth = 0;
            this.mbtnControladorTaxa.HighEmphasis = true;
            this.mbtnControladorTaxa.Icon = null;
            this.mbtnControladorTaxa.Location = new System.Drawing.Point(5, 280);
            this.mbtnControladorTaxa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnControladorTaxa.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnControladorTaxa.Name = "mbtnControladorTaxa";
            this.mbtnControladorTaxa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnControladorTaxa.Size = new System.Drawing.Size(143, 36);
            this.mbtnControladorTaxa.TabIndex = 0;
            this.mbtnControladorTaxa.Text = "Controlador de Taxa";
            this.mbtnControladorTaxa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnControladorTaxa.UseAccentColor = false;
            this.mbtnControladorTaxa.UseVisualStyleBackColor = true;
            // 
            // mbtnBotoeira
            // 
            this.mbtnBotoeira.AutoSize = false;
            this.mbtnBotoeira.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnBotoeira.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnBotoeira.Depth = 0;
            this.mbtnBotoeira.HighEmphasis = true;
            this.mbtnBotoeira.Icon = null;
            this.mbtnBotoeira.Location = new System.Drawing.Point(5, 328);
            this.mbtnBotoeira.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnBotoeira.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnBotoeira.Name = "mbtnBotoeira";
            this.mbtnBotoeira.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnBotoeira.Size = new System.Drawing.Size(143, 36);
            this.mbtnBotoeira.TabIndex = 0;
            this.mbtnBotoeira.Text = "Botoeira";
            this.mbtnBotoeira.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnBotoeira.UseAccentColor = false;
            this.mbtnBotoeira.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(246, 36);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(460, 431);
            this.pnlContainer.TabIndex = 16;
            // 
            // frmCadastroEq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 679);
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
            this.grbOpcoes.ResumeLayout(false);
            this.grbOpcoes.PerformLayout();
            this.grbOpcoesCadastro.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grbOpcoes;
        private MaterialSkin.Controls.MaterialButton mbtnCancelar;
        private MaterialSkin.Controls.MaterialButton mbtnPesquisar;
        private MaterialSkin.Controls.MaterialButton mbtnCadastrar;
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
        private System.Windows.Forms.GroupBox grbOpcoesCadastro;
        private MaterialSkin.Controls.MaterialButton mbtnControladorTaxa;
        private MaterialSkin.Controls.MaterialButton mbtnAntenaAg25;
        private MaterialSkin.Controls.MaterialButton mbtnTm200;
        private MaterialSkin.Controls.MaterialButton mbtnNav2e3;
        private MaterialSkin.Controls.MaterialButton mbtnNav900;
        private MaterialSkin.Controls.MaterialButton mbtnMonitor;
        private System.Windows.Forms.Panel pnlContainer;
        private MaterialSkin.Controls.MaterialButton mbtnBotoeira;
    }
}
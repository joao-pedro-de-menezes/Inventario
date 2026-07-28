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
            this.txtValorP = new System.Windows.Forms.TextBox();
            this.lblValorP = new System.Windows.Forms.Label();
            this.txtMarcaP = new System.Windows.Forms.TextBox();
            this.lblMarcaP = new System.Windows.Forms.Label();
            this.txtNSerieP = new System.Windows.Forms.TextBox();
            this.lblNSerieP = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLocali = new System.Windows.Forms.Label();
            this.cmbSituacaoP = new System.Windows.Forms.ComboBox();
            this.cmbTipoP = new System.Windows.Forms.ComboBox();
            this.lblSituacaoP = new System.Windows.Forms.Label();
            this.lblTipoEquipamentoP = new System.Windows.Forms.Label();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.lblCodigoP = new System.Windows.Forms.Label();
            this.tbCadastro = new System.Windows.Forms.TabPage();
            this.mTxtPesquisa = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.mbtnPesquisarLi = new MaterialSkin.Controls.MaterialButton();
            this.dgvLi = new System.Windows.Forms.DataGridView();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.mbtnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.mbtnPesquisar = new MaterialSkin.Controls.MaterialButton();
            this.mbtnCadastrar = new MaterialSkin.Controls.MaterialButton();
            this.grbSituacao = new System.Windows.Forms.GroupBox();
            this.cmbSituacao = new MaterialSkin.Controls.MaterialComboBox();
            this.grbCampos = new System.Windows.Forms.GroupBox();
            this.mSwithLi = new MaterialSkin.Controls.MaterialSwitch();
            this.txtNumeroLicenca = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMarca = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNumeroSerie = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTipoEquipamento = new MaterialSkin.Controls.MaterialTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtValor = new MaterialSkin.Controls.MaterialTextBox();
            this.tabCntrCadastro.SuspendLayout();
            this.tbSelecao.SuspendLayout();
            this.grbGridEquipamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).BeginInit();
            this.grbOpcoesP.SuspendLayout();
            this.grbPesquisa.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLi)).BeginInit();
            this.grbOpcoes.SuspendLayout();
            this.grbSituacao.SuspendLayout();
            this.grbCampos.SuspendLayout();
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
            this.tbSelecao.Size = new System.Drawing.Size(1007, 615);
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
            this.grbGridEquipamentos.Size = new System.Drawing.Size(995, 487);
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
            this.dgvEquipamentos.Size = new System.Drawing.Size(984, 465);
            this.dgvEquipamentos.TabIndex = 0;
            // 
            // grbOpcoesP
            // 
            this.grbOpcoesP.Controls.Add(this.mbPesquisar);
            this.grbOpcoesP.Controls.Add(this.mbVoltar);
            this.grbOpcoesP.Location = new System.Drawing.Point(647, 34);
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
            this.grbPesquisa.Controls.Add(this.txtValorP);
            this.grbPesquisa.Controls.Add(this.lblValorP);
            this.grbPesquisa.Controls.Add(this.txtMarcaP);
            this.grbPesquisa.Controls.Add(this.lblMarcaP);
            this.grbPesquisa.Controls.Add(this.txtNSerieP);
            this.grbPesquisa.Controls.Add(this.lblNSerieP);
            this.grbPesquisa.Controls.Add(this.textBox1);
            this.grbPesquisa.Controls.Add(this.lblLocali);
            this.grbPesquisa.Controls.Add(this.cmbSituacaoP);
            this.grbPesquisa.Controls.Add(this.cmbTipoP);
            this.grbPesquisa.Controls.Add(this.lblSituacaoP);
            this.grbPesquisa.Controls.Add(this.lblTipoEquipamentoP);
            this.grbPesquisa.Controls.Add(this.txtCodigoP);
            this.grbPesquisa.Controls.Add(this.lblCodigoP);
            this.grbPesquisa.Location = new System.Drawing.Point(6, 6);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.Size = new System.Drawing.Size(587, 110);
            this.grbPesquisa.TabIndex = 0;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "Perquisar por:";
            // 
            // txtValorP
            // 
            this.txtValorP.Location = new System.Drawing.Point(340, 79);
            this.txtValorP.Name = "txtValorP";
            this.txtValorP.Size = new System.Drawing.Size(134, 20);
            this.txtValorP.TabIndex = 16;
            // 
            // lblValorP
            // 
            this.lblValorP.AutoSize = true;
            this.lblValorP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorP.Location = new System.Drawing.Point(337, 64);
            this.lblValorP.Name = "lblValorP";
            this.lblValorP.Size = new System.Drawing.Size(40, 13);
            this.lblValorP.TabIndex = 15;
            this.lblValorP.Text = "Valor:";
            // 
            // txtMarcaP
            // 
            this.txtMarcaP.Location = new System.Drawing.Point(393, 32);
            this.txtMarcaP.Name = "txtMarcaP";
            this.txtMarcaP.Size = new System.Drawing.Size(134, 20);
            this.txtMarcaP.TabIndex = 16;
            // 
            // lblMarcaP
            // 
            this.lblMarcaP.AutoSize = true;
            this.lblMarcaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaP.Location = new System.Drawing.Point(390, 17);
            this.lblMarcaP.Name = "lblMarcaP";
            this.lblMarcaP.Size = new System.Drawing.Size(42, 13);
            this.lblMarcaP.TabIndex = 15;
            this.lblMarcaP.Text = "Marca";
            // 
            // txtNSerieP
            // 
            this.txtNSerieP.Location = new System.Drawing.Point(243, 32);
            this.txtNSerieP.Name = "txtNSerieP";
            this.txtNSerieP.Size = new System.Drawing.Size(134, 20);
            this.txtNSerieP.TabIndex = 16;
            // 
            // lblNSerieP
            // 
            this.lblNSerieP.AutoSize = true;
            this.lblNSerieP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNSerieP.Location = new System.Drawing.Point(240, 17);
            this.lblNSerieP.Name = "lblNSerieP";
            this.lblNSerieP.Size = new System.Drawing.Size(58, 13);
            this.lblNSerieP.TabIndex = 15;
            this.lblNSerieP.Text = "N° Série:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 14;
            // 
            // lblLocali
            // 
            this.lblLocali.AutoSize = true;
            this.lblLocali.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocali.Location = new System.Drawing.Point(157, 64);
            this.lblLocali.Name = "lblLocali";
            this.lblLocali.Size = new System.Drawing.Size(79, 13);
            this.lblLocali.TabIndex = 13;
            this.lblLocali.Text = "Localização:";
            // 
            // cmbSituacaoP
            // 
            this.cmbSituacaoP.FormattingEnabled = true;
            this.cmbSituacaoP.Location = new System.Drawing.Point(12, 78);
            this.cmbSituacaoP.Name = "cmbSituacaoP";
            this.cmbSituacaoP.Size = new System.Drawing.Size(121, 21);
            this.cmbSituacaoP.TabIndex = 11;
            // 
            // cmbTipoP
            // 
            this.cmbTipoP.FormattingEnabled = true;
            this.cmbTipoP.Location = new System.Drawing.Point(106, 31);
            this.cmbTipoP.Name = "cmbTipoP";
            this.cmbTipoP.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoP.TabIndex = 11;
            // 
            // lblSituacaoP
            // 
            this.lblSituacaoP.AutoSize = true;
            this.lblSituacaoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacaoP.Location = new System.Drawing.Point(9, 64);
            this.lblSituacaoP.Name = "lblSituacaoP";
            this.lblSituacaoP.Size = new System.Drawing.Size(61, 13);
            this.lblSituacaoP.TabIndex = 6;
            this.lblSituacaoP.Text = "Situação:";
            // 
            // lblTipoEquipamentoP
            // 
            this.lblTipoEquipamentoP.AutoSize = true;
            this.lblTipoEquipamentoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEquipamentoP.Location = new System.Drawing.Point(103, 16);
            this.lblTipoEquipamentoP.Name = "lblTipoEquipamentoP";
            this.lblTipoEquipamentoP.Size = new System.Drawing.Size(113, 13);
            this.lblTipoEquipamentoP.TabIndex = 3;
            this.lblTipoEquipamentoP.Text = "Tipo Equipamento:";
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
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.mTxtPesquisa);
            this.tbCadastro.Controls.Add(this.lblPesquisar);
            this.tbCadastro.Controls.Add(this.mbtnPesquisarLi);
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
            // mTxtPesquisa
            // 
            this.mTxtPesquisa.AnimateReadOnly = false;
            this.mTxtPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mTxtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mTxtPesquisa.Depth = 0;
            this.mTxtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(439, 17);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(97, 13);
            this.lblPesquisar.TabIndex = 20;
            this.lblPesquisar.Text = "Pesquisar Licença:";
            // 
            // mbtnPesquisarLi
            // 
            this.mbtnPesquisarLi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnPesquisarLi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnPesquisarLi.Depth = 0;
            this.mbtnPesquisarLi.HighEmphasis = true;
            this.mbtnPesquisarLi.Icon = null;
            this.mbtnPesquisarLi.Location = new System.Drawing.Point(900, 52);
            this.mbtnPesquisarLi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnPesquisarLi.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnPesquisarLi.Name = "mbtnPesquisarLi";
            this.mbtnPesquisarLi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnPesquisarLi.Size = new System.Drawing.Size(100, 36);
            this.mbtnPesquisarLi.TabIndex = 19;
            this.mbtnPesquisarLi.Text = "Pesquisar";
            this.mbtnPesquisarLi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnPesquisarLi.UseAccentColor = false;
            this.mbtnPesquisarLi.UseVisualStyleBackColor = true;
            this.mbtnPesquisarLi.Click += new System.EventHandler(this.mbtnPesquisarLi_Click);
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
            this.dgvLi.DoubleClick += new System.EventHandler(this.dgvLi_DoubleClick);
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.mbtnCancelar);
            this.grbOpcoes.Controls.Add(this.mbtnPesquisar);
            this.grbOpcoes.Controls.Add(this.mbtnCadastrar);
            this.grbOpcoes.Location = new System.Drawing.Point(30, 528);
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
            this.mbtnCadastrar.Click += new System.EventHandler(this.mbtnCadastrar_Click);
            // 
            // grbSituacao
            // 
            this.grbSituacao.Controls.Add(this.cmbSituacao);
            this.grbSituacao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbSituacao.Location = new System.Drawing.Point(30, 417);
            this.grbSituacao.Name = "grbSituacao";
            this.grbSituacao.Size = new System.Drawing.Size(398, 93);
            this.grbSituacao.TabIndex = 16;
            this.grbSituacao.TabStop = false;
            this.grbSituacao.Text = "Situação";
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.AutoResize = false;
            this.cmbSituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSituacao.Depth = 0;
            this.cmbSituacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSituacao.DropDownHeight = 174;
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.DropDownWidth = 121;
            this.cmbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.IntegralHeight = false;
            this.cmbSituacao.ItemHeight = 43;
            this.cmbSituacao.Location = new System.Drawing.Point(9, 28);
            this.cmbSituacao.MaxDropDownItems = 4;
            this.cmbSituacao.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(380, 49);
            this.cmbSituacao.StartIndex = 0;
            this.cmbSituacao.TabIndex = 0;
            // 
            // grbCampos
            // 
            this.grbCampos.Controls.Add(this.mSwithLi);
            this.grbCampos.Controls.Add(this.txtNumeroLicenca);
            this.grbCampos.Controls.Add(this.txtMarca);
            this.grbCampos.Controls.Add(this.txtNumeroSerie);
            this.grbCampos.Controls.Add(this.txtValor);
            this.grbCampos.Controls.Add(this.txtTipoEquipamento);
            this.grbCampos.Controls.Add(this.lblValor);
            this.grbCampos.Controls.Add(this.lblCodigo);
            this.grbCampos.Controls.Add(this.txtCodigo);
            this.grbCampos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbCampos.Location = new System.Drawing.Point(30, 6);
            this.grbCampos.Name = "grbCampos";
            this.grbCampos.Size = new System.Drawing.Size(398, 405);
            this.grbCampos.TabIndex = 15;
            this.grbCampos.TabStop = false;
            // 
            // mSwithLi
            // 
            this.mSwithLi.AutoSize = true;
            this.mSwithLi.Depth = 0;
            this.mSwithLi.Location = new System.Drawing.Point(6, 363);
            this.mSwithLi.Margin = new System.Windows.Forms.Padding(0);
            this.mSwithLi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mSwithLi.MouseState = MaterialSkin.MouseState.HOVER;
            this.mSwithLi.Name = "mSwithLi";
            this.mSwithLi.Ripple = true;
            this.mSwithLi.Size = new System.Drawing.Size(221, 37);
            this.mSwithLi.TabIndex = 6;
            this.mSwithLi.Text = "Cadastrar com Licença";
            this.mSwithLi.UseVisualStyleBackColor = true;
            this.mSwithLi.CheckedChanged += new System.EventHandler(this.mSwithLi_CheckedChanged);
            // 
            // txtNumeroLicenca
            // 
            this.txtNumeroLicenca.AnimateReadOnly = false;
            this.txtNumeroLicenca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroLicenca.Depth = 0;
            this.txtNumeroLicenca.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumeroLicenca.LeadingIcon = null;
            this.txtNumeroLicenca.Location = new System.Drawing.Point(6, 310);
            this.txtNumeroLicenca.MaxLength = 50;
            this.txtNumeroLicenca.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumeroLicenca.Multiline = false;
            this.txtNumeroLicenca.Name = "txtNumeroLicenca";
            this.txtNumeroLicenca.Size = new System.Drawing.Size(383, 50);
            this.txtNumeroLicenca.TabIndex = 5;
            this.txtNumeroLicenca.Text = "";
            this.txtNumeroLicenca.TrailingIcon = null;
            // 
            // txtMarca
            // 
            this.txtMarca.AnimateReadOnly = false;
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.Depth = 0;
            this.txtMarca.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMarca.LeadingIcon = null;
            this.txtMarca.Location = new System.Drawing.Point(6, 232);
            this.txtMarca.MaxLength = 50;
            this.txtMarca.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMarca.Multiline = false;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(383, 50);
            this.txtMarca.TabIndex = 4;
            this.txtMarca.Text = "";
            this.txtMarca.TrailingIcon = null;
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.AnimateReadOnly = false;
            this.txtNumeroSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroSerie.Depth = 0;
            this.txtNumeroSerie.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumeroSerie.LeadingIcon = null;
            this.txtNumeroSerie.Location = new System.Drawing.Point(6, 176);
            this.txtNumeroSerie.MaxLength = 50;
            this.txtNumeroSerie.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumeroSerie.Multiline = false;
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(383, 50);
            this.txtNumeroSerie.TabIndex = 4;
            this.txtNumeroSerie.Text = "";
            this.txtNumeroSerie.TrailingIcon = null;
            // 
            // txtTipoEquipamento
            // 
            this.txtTipoEquipamento.AnimateReadOnly = false;
            this.txtTipoEquipamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoEquipamento.Depth = 0;
            this.txtTipoEquipamento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTipoEquipamento.LeadingIcon = null;
            this.txtTipoEquipamento.Location = new System.Drawing.Point(6, 120);
            this.txtTipoEquipamento.MaxLength = 50;
            this.txtTipoEquipamento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTipoEquipamento.Multiline = false;
            this.txtTipoEquipamento.Name = "txtTipoEquipamento";
            this.txtTipoEquipamento.Size = new System.Drawing.Size(383, 50);
            this.txtTipoEquipamento.TabIndex = 4;
            this.txtTipoEquipamento.Text = "";
            this.txtTipoEquipamento.TrailingIcon = null;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(201, 30);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(111, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor do Equipamento";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
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
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.Text = "";
            this.txtCodigo.TrailingIcon = null;
            // 
            // txtValor
            // 
            this.txtValor.AnimateReadOnly = false;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Depth = 0;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValor.LeadingIcon = null;
            this.txtValor.Location = new System.Drawing.Point(204, 46);
            this.txtValor.MaxLength = 50;
            this.txtValor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(185, 50);
            this.txtValor.TabIndex = 4;
            this.txtValor.Text = "";
            this.txtValor.TrailingIcon = null;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLi)).EndInit();
            this.grbOpcoes.ResumeLayout(false);
            this.grbOpcoes.PerformLayout();
            this.grbSituacao.ResumeLayout(false);
            this.grbCampos.ResumeLayout(false);
            this.grbCampos.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbTipoP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLocali;
        private System.Windows.Forms.TextBox txtNSerieP;
        private System.Windows.Forms.Label lblNSerieP;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private MaterialSkin.Controls.MaterialButton mbtnCancelar;
        private MaterialSkin.Controls.MaterialButton mbtnPesquisar;
        private MaterialSkin.Controls.MaterialButton mbtnCadastrar;
        private System.Windows.Forms.GroupBox grbSituacao;
        private System.Windows.Forms.GroupBox grbCampos;
        private MaterialSkin.Controls.MaterialTextBox txtNumeroLicenca;
        private MaterialSkin.Controls.MaterialTextBox txtTipoEquipamento;
        private System.Windows.Forms.Label lblCodigo;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialTextBox2 mTxtPesquisa;
        private System.Windows.Forms.Label lblPesquisar;
        private MaterialSkin.Controls.MaterialButton mbtnPesquisarLi;
        private System.Windows.Forms.DataGridView dgvLi;
        private System.Windows.Forms.TextBox txtValorP;
        private System.Windows.Forms.Label lblValorP;
        private System.Windows.Forms.Label lblValor;
        private MaterialSkin.Controls.MaterialTextBox txtNumeroSerie;
        private MaterialSkin.Controls.MaterialSwitch mSwithLi;
        private System.Windows.Forms.ComboBox cmbSituacaoP;
        private MaterialSkin.Controls.MaterialComboBox cmbSituacao;
        private MaterialSkin.Controls.MaterialTextBox txtMarca;
        private System.Windows.Forms.TextBox txtMarcaP;
        private System.Windows.Forms.Label lblMarcaP;
        private MaterialSkin.Controls.MaterialTextBox txtValor;
    }
}
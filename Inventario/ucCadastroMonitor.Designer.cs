namespace Inventario
{
    partial class ucCadastroMonitor
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbSituacao = new System.Windows.Forms.GroupBox();
            this.mRadioCampo = new MaterialSkin.Controls.MaterialRadioButton();
            this.mRadioEstoque = new MaterialSkin.Controls.MaterialRadioButton();
            this.grbCampos = new System.Windows.Forms.GroupBox();
            this.lblLicenca = new System.Windows.Forms.Label();
            this.mtxtLicenca = new MaterialSkin.Controls.MaterialTextBox();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.mtxtNumeroSerie = new MaterialSkin.Controls.MaterialTextBox();
            this.lblAtivacao = new System.Windows.Forms.Label();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.mskVencimento = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mskAtivacao = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.mRadioManutencao = new MaterialSkin.Controls.MaterialRadioButton();
            this.mRadioQuebrado = new MaterialSkin.Controls.MaterialRadioButton();
            this.mRadio3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.grbSituacao.SuspendLayout();
            this.grbCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSituacao
            // 
            this.grbSituacao.Controls.Add(this.mRadio3);
            this.grbSituacao.Controls.Add(this.mRadioQuebrado);
            this.grbSituacao.Controls.Add(this.mRadioManutencao);
            this.grbSituacao.Controls.Add(this.mRadioCampo);
            this.grbSituacao.Controls.Add(this.mRadioEstoque);
            this.grbSituacao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbSituacao.Location = new System.Drawing.Point(9, 353);
            this.grbSituacao.Name = "grbSituacao";
            this.grbSituacao.Size = new System.Drawing.Size(316, 103);
            this.grbSituacao.TabIndex = 15;
            this.grbSituacao.TabStop = false;
            this.grbSituacao.Text = "Estado Atual";
            // 
            // mRadioCampo
            // 
            this.mRadioCampo.AutoSize = true;
            this.mRadioCampo.Depth = 0;
            this.mRadioCampo.Location = new System.Drawing.Point(103, 36);
            this.mRadioCampo.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioCampo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioCampo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioCampo.Name = "mRadioCampo";
            this.mRadioCampo.Ripple = true;
            this.mRadioCampo.Size = new System.Drawing.Size(86, 37);
            this.mRadioCampo.TabIndex = 6;
            this.mRadioCampo.TabStop = true;
            this.mRadioCampo.Text = "Campo";
            this.mRadioCampo.UseVisualStyleBackColor = true;
            // 
            // mRadioEstoque
            // 
            this.mRadioEstoque.AutoSize = true;
            this.mRadioEstoque.Depth = 0;
            this.mRadioEstoque.Location = new System.Drawing.Point(3, 53);
            this.mRadioEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioEstoque.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioEstoque.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioEstoque.Name = "mRadioEstoque";
            this.mRadioEstoque.Ripple = true;
            this.mRadioEstoque.Size = new System.Drawing.Size(92, 37);
            this.mRadioEstoque.TabIndex = 7;
            this.mRadioEstoque.TabStop = true;
            this.mRadioEstoque.Text = "Estoque";
            this.mRadioEstoque.UseVisualStyleBackColor = true;
            // 
            // grbCampos
            // 
            this.grbCampos.Controls.Add(this.lblLicenca);
            this.grbCampos.Controls.Add(this.mtxtLicenca);
            this.grbCampos.Controls.Add(this.lblNumeroSerie);
            this.grbCampos.Controls.Add(this.mtxtNumeroSerie);
            this.grbCampos.Controls.Add(this.lblAtivacao);
            this.grbCampos.Controls.Add(this.lblVencimento);
            this.grbCampos.Controls.Add(this.mskVencimento);
            this.grbCampos.Controls.Add(this.mskAtivacao);
            this.grbCampos.Controls.Add(this.lblCodigo);
            this.grbCampos.Controls.Add(this.txtCodigo);
            this.grbCampos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbCampos.Location = new System.Drawing.Point(3, 3);
            this.grbCampos.Name = "grbCampos";
            this.grbCampos.Size = new System.Drawing.Size(322, 344);
            this.grbCampos.TabIndex = 14;
            this.grbCampos.TabStop = false;
            // 
            // lblLicenca
            // 
            this.lblLicenca.AutoSize = true;
            this.lblLicenca.Location = new System.Drawing.Point(6, 174);
            this.lblLicenca.Name = "lblLicenca";
            this.lblLicenca.Size = new System.Drawing.Size(108, 13);
            this.lblLicenca.TabIndex = 15;
            this.lblLicenca.Text = "Licença de Ativação:";
            // 
            // mtxtLicenca
            // 
            this.mtxtLicenca.AnimateReadOnly = false;
            this.mtxtLicenca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtLicenca.Depth = 0;
            this.mtxtLicenca.Enabled = false;
            this.mtxtLicenca.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtLicenca.LeadingIcon = null;
            this.mtxtLicenca.Location = new System.Drawing.Point(6, 190);
            this.mtxtLicenca.MaxLength = 50;
            this.mtxtLicenca.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtLicenca.Multiline = false;
            this.mtxtLicenca.Name = "mtxtLicenca";
            this.mtxtLicenca.Size = new System.Drawing.Size(282, 50);
            this.mtxtLicenca.TabIndex = 14;
            this.mtxtLicenca.Text = "";
            this.mtxtLicenca.TrailingIcon = null;
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Location = new System.Drawing.Point(9, 87);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(102, 13);
            this.lblNumeroSerie.TabIndex = 13;
            this.lblNumeroSerie.Text = "N° Série do Monitor:";
            // 
            // mtxtNumeroSerie
            // 
            this.mtxtNumeroSerie.AnimateReadOnly = false;
            this.mtxtNumeroSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtNumeroSerie.Depth = 0;
            this.mtxtNumeroSerie.Enabled = false;
            this.mtxtNumeroSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtNumeroSerie.LeadingIcon = null;
            this.mtxtNumeroSerie.Location = new System.Drawing.Point(6, 103);
            this.mtxtNumeroSerie.MaxLength = 50;
            this.mtxtNumeroSerie.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtNumeroSerie.Multiline = false;
            this.mtxtNumeroSerie.Name = "mtxtNumeroSerie";
            this.mtxtNumeroSerie.Size = new System.Drawing.Size(282, 50);
            this.mtxtNumeroSerie.TabIndex = 12;
            this.mtxtNumeroSerie.Text = "";
            this.mtxtNumeroSerie.TrailingIcon = null;
            // 
            // lblAtivacao
            // 
            this.lblAtivacao.AutoSize = true;
            this.lblAtivacao.Location = new System.Drawing.Point(12, 257);
            this.lblAtivacao.Name = "lblAtivacao";
            this.lblAtivacao.Size = new System.Drawing.Size(52, 13);
            this.lblAtivacao.TabIndex = 11;
            this.lblAtivacao.Text = "Ativação:";
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Location = new System.Drawing.Point(167, 257);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(66, 13);
            this.lblVencimento.TabIndex = 10;
            this.lblVencimento.Text = "Vencimento:";
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
            this.mskVencimento.Location = new System.Drawing.Point(167, 273);
            this.mskVencimento.Mask = "00/00/0000";
            this.mskVencimento.MaxLength = 32767;
            this.mskVencimento.MouseState = MaterialSkin.MouseState.OUT;
            this.mskVencimento.Name = "mskVencimento";
            this.mskVencimento.PasswordChar = '\0';
            this.mskVencimento.PrefixSuffixText = null;
            this.mskVencimento.PromptChar = '_';
            this.mskVencimento.ReadOnly = true;
            this.mskVencimento.RejectInputOnFirstFailure = false;
            this.mskVencimento.ResetOnPrompt = true;
            this.mskVencimento.ResetOnSpace = true;
            this.mskVencimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskVencimento.SelectedText = "";
            this.mskVencimento.SelectionLength = 0;
            this.mskVencimento.SelectionStart = 0;
            this.mskVencimento.ShortcutsEnabled = true;
            this.mskVencimento.Size = new System.Drawing.Size(107, 48);
            this.mskVencimento.SkipLiterals = true;
            this.mskVencimento.TabIndex = 9;
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
            this.mskAtivacao.Location = new System.Drawing.Point(12, 273);
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
            this.mskAtivacao.Size = new System.Drawing.Size(105, 48);
            this.mskAtivacao.SkipLiterals = true;
            this.mskAtivacao.TabIndex = 7;
            this.mskAtivacao.TabStop = false;
            this.mskAtivacao.Text = "  /  /";
            this.mskAtivacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mskAtivacao.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskAtivacao.TrailingIcon = null;
            this.mskAtivacao.UseSystemPasswordChar = false;
            this.mskAtivacao.ValidatingType = null;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 15);
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
            this.txtCodigo.Location = new System.Drawing.Point(6, 31);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 50);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Text = "";
            this.txtCodigo.TrailingIcon = null;
            // 
            // mRadioManutencao
            // 
            this.mRadioManutencao.AutoSize = true;
            this.mRadioManutencao.Depth = 0;
            this.mRadioManutencao.Location = new System.Drawing.Point(189, 16);
            this.mRadioManutencao.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioManutencao.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioManutencao.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioManutencao.Name = "mRadioManutencao";
            this.mRadioManutencao.Ripple = true;
            this.mRadioManutencao.Size = new System.Drawing.Size(124, 37);
            this.mRadioManutencao.TabIndex = 6;
            this.mRadioManutencao.TabStop = true;
            this.mRadioManutencao.Text = "Manutenção";
            this.mRadioManutencao.UseVisualStyleBackColor = true;
            // 
            // mRadioQuebrado
            // 
            this.mRadioQuebrado.AutoSize = true;
            this.mRadioQuebrado.Depth = 0;
            this.mRadioQuebrado.Location = new System.Drawing.Point(189, 53);
            this.mRadioQuebrado.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioQuebrado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioQuebrado.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioQuebrado.Name = "mRadioQuebrado";
            this.mRadioQuebrado.Ripple = true;
            this.mRadioQuebrado.Size = new System.Drawing.Size(104, 37);
            this.mRadioQuebrado.TabIndex = 6;
            this.mRadioQuebrado.TabStop = true;
            this.mRadioQuebrado.Text = "Quebrado";
            this.mRadioQuebrado.UseVisualStyleBackColor = true;
            // 
            // mRadio3
            // 
            this.mRadio3.AutoSize = true;
            this.mRadio3.Depth = 0;
            this.mRadio3.Location = new System.Drawing.Point(5, 16);
            this.mRadio3.Margin = new System.Windows.Forms.Padding(0);
            this.mRadio3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadio3.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadio3.Name = "mRadio3";
            this.mRadio3.Ripple = true;
            this.mRadio3.Size = new System.Drawing.Size(100, 37);
            this.mRadio3.TabIndex = 8;
            this.mRadio3.TabStop = true;
            this.mRadio3.Text = "Terceiros";
            this.mRadio3.UseVisualStyleBackColor = true;
            // 
            // ucCadastroMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbSituacao);
            this.Controls.Add(this.grbCampos);
            this.Name = "ucCadastroMonitor";
            this.Size = new System.Drawing.Size(328, 459);
            this.grbSituacao.ResumeLayout(false);
            this.grbSituacao.PerformLayout();
            this.grbCampos.ResumeLayout(false);
            this.grbCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSituacao;
        private MaterialSkin.Controls.MaterialRadioButton mRadioCampo;
        private MaterialSkin.Controls.MaterialRadioButton mRadioEstoque;
        private System.Windows.Forms.GroupBox grbCampos;
        private System.Windows.Forms.Label lblLicenca;
        private MaterialSkin.Controls.MaterialTextBox mtxtLicenca;
        private System.Windows.Forms.Label lblNumeroSerie;
        private MaterialSkin.Controls.MaterialTextBox mtxtNumeroSerie;
        private System.Windows.Forms.Label lblAtivacao;
        private System.Windows.Forms.Label lblVencimento;
        private MaterialSkin.Controls.MaterialMaskedTextBox mskVencimento;
        private MaterialSkin.Controls.MaterialMaskedTextBox mskAtivacao;
        private System.Windows.Forms.Label lblCodigo;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialRadioButton mRadioQuebrado;
        private MaterialSkin.Controls.MaterialRadioButton mRadioManutencao;
        private MaterialSkin.Controls.MaterialRadioButton mRadio3;
    }
}

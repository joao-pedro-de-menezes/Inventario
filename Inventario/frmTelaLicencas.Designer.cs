namespace Inventario
{
    partial class frmTelaLicencas
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
            this.mbVoltar = new MaterialSkin.Controls.MaterialButton();
            this.GridLicencas = new System.Windows.Forms.DataGridView();
            this.grbGridLicencas = new System.Windows.Forms.GroupBox();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.mbPesquisar = new MaterialSkin.Controls.MaterialButton();
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblAtivacao = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtLicenca = new System.Windows.Forms.TextBox();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.mskAtivacao = new System.Windows.Forms.MaskedTextBox();
            this.mskVencimento = new System.Windows.Forms.MaskedTextBox();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridLicencas)).BeginInit();
            this.grbGridLicencas.SuspendLayout();
            this.grbOpcoes.SuspendLayout();
            this.grbPesquisa.SuspendLayout();
            this.SuspendLayout();
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
            this.mbVoltar.TabIndex = 6;
            this.mbVoltar.Text = "Voltar";
            this.mbVoltar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbVoltar.UseAccentColor = false;
            this.mbVoltar.UseVisualStyleBackColor = true;
            this.mbVoltar.Click += new System.EventHandler(this.mbVoltar_Click);
            // 
            // GridLicencas
            // 
            this.GridLicencas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLicencas.Location = new System.Drawing.Point(6, 19);
            this.GridLicencas.Name = "GridLicencas";
            this.GridLicencas.ReadOnly = true;
            this.GridLicencas.Size = new System.Drawing.Size(775, 481);
            this.GridLicencas.TabIndex = 1;
            // 
            // grbGridLicencas
            // 
            this.grbGridLicencas.Controls.Add(this.GridLicencas);
            this.grbGridLicencas.Location = new System.Drawing.Point(6, 195);
            this.grbGridLicencas.Name = "grbGridLicencas";
            this.grbGridLicencas.Size = new System.Drawing.Size(787, 506);
            this.grbGridLicencas.TabIndex = 0;
            this.grbGridLicencas.TabStop = false;
            this.grbGridLicencas.Text = "Licenças";
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.mbPesquisar);
            this.grbOpcoes.Controls.Add(this.mbVoltar);
            this.grbOpcoes.Location = new System.Drawing.Point(570, 83);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(223, 71);
            this.grbOpcoes.TabIndex = 3;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
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
            this.mbPesquisar.TabIndex = 5;
            this.mbPesquisar.Text = "Pesquisar";
            this.mbPesquisar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbPesquisar.UseAccentColor = false;
            this.mbPesquisar.UseVisualStyleBackColor = true;
            this.mbPesquisar.Click += new System.EventHandler(this.mbPesquisar_Click);
            // 
            // grbPesquisa
            // 
            this.grbPesquisa.Controls.Add(this.txtNumeroSerie);
            this.grbPesquisa.Controls.Add(this.lblNumeroSerie);
            this.grbPesquisa.Controls.Add(this.mskVencimento);
            this.grbPesquisa.Controls.Add(this.mskAtivacao);
            this.grbPesquisa.Controls.Add(this.lblVencimento);
            this.grbPesquisa.Controls.Add(this.txtLicenca);
            this.grbPesquisa.Controls.Add(this.lblTipo);
            this.grbPesquisa.Controls.Add(this.lblAtivacao);
            this.grbPesquisa.Controls.Add(this.txtCodigo);
            this.grbPesquisa.Controls.Add(this.lblCodigo);
            this.grbPesquisa.Location = new System.Drawing.Point(12, 67);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.Size = new System.Drawing.Size(344, 110);
            this.grbPesquisa.TabIndex = 2;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "Perquisar por:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(79, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblAtivacao
            // 
            this.lblAtivacao.AutoSize = true;
            this.lblAtivacao.Location = new System.Drawing.Point(242, 16);
            this.lblAtivacao.Name = "lblAtivacao";
            this.lblAtivacao.Size = new System.Drawing.Size(78, 13);
            this.lblAtivacao.TabIndex = 2;
            this.lblAtivacao.Text = "Data Ativação:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 68);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(69, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo Licença";
            // 
            // txtLicenca
            // 
            this.txtLicenca.Location = new System.Drawing.Point(6, 84);
            this.txtLicenca.Name = "txtLicenca";
            this.txtLicenca.Size = new System.Drawing.Size(210, 20);
            this.txtLicenca.TabIndex = 2;
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Location = new System.Drawing.Point(242, 68);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(92, 13);
            this.lblVencimento.TabIndex = 5;
            this.lblVencimento.Text = "Data Vencimento:";
            // 
            // mskAtivacao
            // 
            this.mskAtivacao.Location = new System.Drawing.Point(245, 32);
            this.mskAtivacao.Mask = "00/00/0000";
            this.mskAtivacao.Name = "mskAtivacao";
            this.mskAtivacao.Size = new System.Drawing.Size(75, 20);
            this.mskAtivacao.TabIndex = 3;
            this.mskAtivacao.ValidatingType = typeof(System.DateTime);
            // 
            // mskVencimento
            // 
            this.mskVencimento.Location = new System.Drawing.Point(245, 84);
            this.mskVencimento.Mask = "00/00/0000";
            this.mskVencimento.Name = "mskVencimento";
            this.mskVencimento.Size = new System.Drawing.Size(75, 20);
            this.mskVencimento.TabIndex = 4;
            this.mskVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Location = new System.Drawing.Point(113, 13);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(74, 13);
            this.lblNumeroSerie.TabIndex = 6;
            this.lblNumeroSerie.Text = "Número Série:";
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.Location = new System.Drawing.Point(116, 32);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroSerie.TabIndex = 7;
            // 
            // frmTelaLicencas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 707);
            this.Controls.Add(this.grbPesquisa);
            this.Controls.Add(this.grbOpcoes);
            this.Controls.Add(this.grbGridLicencas);
            this.MaximizeBox = false;
            this.Name = "frmTelaLicencas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Licença";
            this.Load += new System.EventHandler(this.frmTelaLicencas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLicencas)).EndInit();
            this.grbGridLicencas.ResumeLayout(false);
            this.grbOpcoes.ResumeLayout(false);
            this.grbPesquisa.ResumeLayout(false);
            this.grbPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton mbVoltar;
        private System.Windows.Forms.DataGridView GridLicencas;
        private System.Windows.Forms.GroupBox grbGridLicencas;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private MaterialSkin.Controls.MaterialButton mbPesquisar;
        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblAtivacao;
        private System.Windows.Forms.TextBox txtLicenca;
        private System.Windows.Forms.MaskedTextBox mskVencimento;
        private System.Windows.Forms.MaskedTextBox mskAtivacao;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.Label lblNumeroSerie;
    }
}
namespace Inventario
{
    partial class frmPesquisaU
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
            this.grbGridUsu = new System.Windows.Forms.GroupBox();
            this.dgvUsu = new System.Windows.Forms.DataGridView();
            this.mbtnPesquisar = new MaterialSkin.Controls.MaterialButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.mskDataIni = new System.Windows.Forms.MaskedTextBox();
            this.mskDataFim = new System.Windows.Forms.MaskedTextBox();
            this.lblDataIn = new System.Windows.Forms.Label();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbnfechar = new MaterialSkin.Controls.MaterialButton();
            this.grbGridUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsu)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGridUsu
            // 
            this.grbGridUsu.Controls.Add(this.dgvUsu);
            this.grbGridUsu.Location = new System.Drawing.Point(6, 252);
            this.grbGridUsu.Name = "grbGridUsu";
            this.grbGridUsu.Size = new System.Drawing.Size(788, 450);
            this.grbGridUsu.TabIndex = 0;
            this.grbGridUsu.TabStop = false;
            this.grbGridUsu.Text = "Usuários";
            // 
            // dgvUsu
            // 
            this.dgvUsu.AllowUserToAddRows = false;
            this.dgvUsu.AllowUserToDeleteRows = false;
            this.dgvUsu.AllowUserToOrderColumns = true;
            this.dgvUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsu.Location = new System.Drawing.Point(6, 19);
            this.dgvUsu.Name = "dgvUsu";
            this.dgvUsu.ReadOnly = true;
            this.dgvUsu.Size = new System.Drawing.Size(776, 543);
            this.dgvUsu.TabIndex = 0;
            // 
            // mbtnPesquisar
            // 
            this.mbtnPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnPesquisar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnPesquisar.Depth = 0;
            this.mbtnPesquisar.HighEmphasis = true;
            this.mbtnPesquisar.Icon = null;
            this.mbtnPesquisar.Location = new System.Drawing.Point(7, 32);
            this.mbtnPesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnPesquisar.Name = "mbtnPesquisar";
            this.mbtnPesquisar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnPesquisar.Size = new System.Drawing.Size(100, 36);
            this.mbtnPesquisar.TabIndex = 1;
            this.mbtnPesquisar.Text = "Pesquisar";
            this.mbtnPesquisar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnPesquisar.UseAccentColor = false;
            this.mbtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(9, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(123, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(147, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.lblDataFim);
            this.grpPesquisa.Controls.Add(this.lblDataIn);
            this.grpPesquisa.Controls.Add(this.mskDataFim);
            this.grpPesquisa.Controls.Add(this.mskDataIni);
            this.grpPesquisa.Controls.Add(this.textBox1);
            this.grpPesquisa.Controls.Add(this.lblCodigo);
            this.grpPesquisa.Controls.Add(this.txtCodigo);
            this.grpPesquisa.Controls.Add(this.lblNome);
            this.grpPesquisa.Location = new System.Drawing.Point(300, 86);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(279, 138);
            this.grpPesquisa.TabIndex = 5;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisar por:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 6;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Código:";
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Location = new System.Drawing.Point(12, 86);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(250, 138);
            this.grbOpcoes.TabIndex = 6;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // mskDataIni
            // 
            this.mskDataIni.Location = new System.Drawing.Point(9, 81);
            this.mskDataIni.Mask = "00/00/0000";
            this.mskDataIni.Name = "mskDataIni";
            this.mskDataIni.Size = new System.Drawing.Size(123, 20);
            this.mskDataIni.TabIndex = 7;
            this.mskDataIni.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataFim
            // 
            this.mskDataFim.Location = new System.Drawing.Point(150, 81);
            this.mskDataFim.Mask = "00/00/0000";
            this.mskDataFim.Name = "mskDataFim";
            this.mskDataFim.Size = new System.Drawing.Size(123, 20);
            this.mskDataFim.TabIndex = 8;
            this.mskDataFim.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataIn
            // 
            this.lblDataIn.AutoSize = true;
            this.lblDataIn.Location = new System.Drawing.Point(14, 65);
            this.lblDataIn.Name = "lblDataIn";
            this.lblDataIn.Size = new System.Drawing.Size(53, 13);
            this.lblDataIn.TabIndex = 9;
            this.lblDataIn.Text = "Data Inic.";
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(147, 65);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(52, 13);
            this.lblDataFim.TabIndex = 10;
            this.lblDataFim.Text = "Data final";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbnfechar);
            this.groupBox1.Controls.Add(this.mbtnPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(647, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 138);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // mtbnfechar
            // 
            this.mtbnfechar.AutoSize = false;
            this.mtbnfechar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtbnfechar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mtbnfechar.Depth = 0;
            this.mtbnfechar.HighEmphasis = true;
            this.mtbnfechar.Icon = null;
            this.mtbnfechar.Location = new System.Drawing.Point(7, 80);
            this.mtbnfechar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mtbnfechar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbnfechar.Name = "mtbnfechar";
            this.mtbnfechar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mtbnfechar.Size = new System.Drawing.Size(100, 36);
            this.mtbnfechar.TabIndex = 2;
            this.mtbnfechar.Text = "Fechar";
            this.mtbnfechar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mtbnfechar.UseAccentColor = false;
            this.mtbnfechar.UseVisualStyleBackColor = true;
            // 
            // frmPesquisaU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 708);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbOpcoes);
            this.Controls.Add(this.grpPesquisa);
            this.Controls.Add(this.grbGridUsu);
            this.Name = "frmPesquisaU";
            this.Text = "frmPesquisaU";
            this.Load += new System.EventHandler(this.frmPesquisaU_Load);
            this.grbGridUsu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsu)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGridUsu;
        private System.Windows.Forms.DataGridView dgvUsu;
        private MaterialSkin.Controls.MaterialButton mbtnPesquisar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Label lblDataIn;
        private System.Windows.Forms.MaskedTextBox mskDataFim;
        private System.Windows.Forms.MaskedTextBox mskDataIni;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton mtbnfechar;
    }
}
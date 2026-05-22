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
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
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
            this.grbGridUsu.Location = new System.Drawing.Point(6, 160);
            this.grbGridUsu.Name = "grbGridUsu";
            this.grbGridUsu.Size = new System.Drawing.Size(788, 542);
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
            this.dgvUsu.Size = new System.Drawing.Size(776, 517);
            this.dgvUsu.TabIndex = 0;
            this.dgvUsu.DoubleClick += new System.EventHandler(this.dgvUsu_DoubleClick);
            // 
            // mbtnPesquisar
            // 
            this.mbtnPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnPesquisar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnPesquisar.Depth = 0;
            this.mbtnPesquisar.HighEmphasis = true;
            this.mbtnPesquisar.Icon = null;
            this.mbtnPesquisar.Location = new System.Drawing.Point(7, 22);
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
            this.mbtnPesquisar.Click += new System.EventHandler(this.mbtnPesquisar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(9, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(123, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.txtNome);
            this.grpPesquisa.Controls.Add(this.lblCodigo);
            this.grpPesquisa.Controls.Add(this.txtCodigo);
            this.grpPesquisa.Controls.Add(this.lblNome);
            this.grpPesquisa.Location = new System.Drawing.Point(6, 86);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(543, 68);
            this.grpPesquisa.TabIndex = 5;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisar por:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(150, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(387, 20);
            this.txtNome.TabIndex = 6;
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
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(147, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbnfechar);
            this.groupBox1.Controls.Add(this.mbtnPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(568, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 68);
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
            this.mtbnfechar.Location = new System.Drawing.Point(115, 22);
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
            this.mtbnfechar.Click += new System.EventHandler(this.mtbnfechar_Click);
            // 
            // frmPesquisaU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 708);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPesquisa);
            this.Controls.Add(this.grbGridUsu);
            this.MaximizeBox = false;
            this.Name = "frmPesquisaU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Usuário";
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
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton mtbnfechar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}
namespace Inventario
{
    partial class frmDashboard
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
            this.lblFoto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.mlblTotalMaquinas = new MaterialSkin.Controls.MaterialLabel();
            this.mlblNTotalMquinas = new MaterialSkin.Controls.MaterialLabel();
            this.iconeTotalMaquinas = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonConfiguracoes = new FontAwesome.Sharp.IconButton();
            this.iconButtonMaquinas = new FontAwesome.Sharp.IconButton();
            this.iconButtonLicencas = new FontAwesome.Sharp.IconButton();
            this.iconButtonEquipamento = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeTotalMaquinas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFoto
            // 
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(544, 9);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(165, 29);
            this.lblFoto.TabIndex = 0;
            this.lblFoto.Text = "Foto do Usuario";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(715, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "logOff";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButtonConfiguracoes);
            this.panel1.Controls.Add(this.iconButtonMaquinas);
            this.panel1.Controls.Add(this.iconButtonLicencas);
            this.panel1.Controls.Add(this.iconButtonEquipamento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 475);
            this.panel1.TabIndex = 1;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.iconeTotalMaquinas);
            this.materialCard1.Controls.Add(this.mlblNTotalMquinas);
            this.materialCard1.Controls.Add(this.mlblTotalMaquinas);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(183, 103);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(200, 100);
            this.materialCard1.TabIndex = 2;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(411, 103);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(200, 100);
            this.materialCard2.TabIndex = 2;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(639, 103);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(200, 100);
            this.materialCard3.TabIndex = 2;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(867, 103);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(200, 100);
            this.materialCard4.TabIndex = 2;
            // 
            // mlblTotalMaquinas
            // 
            this.mlblTotalMaquinas.AutoSize = true;
            this.mlblTotalMaquinas.Depth = 0;
            this.mlblTotalMaquinas.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblTotalMaquinas.Location = new System.Drawing.Point(18, 18);
            this.mlblTotalMaquinas.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblTotalMaquinas.Name = "mlblTotalMaquinas";
            this.mlblTotalMaquinas.Size = new System.Drawing.Size(124, 19);
            this.mlblTotalMaquinas.TabIndex = 0;
            this.mlblTotalMaquinas.Text = "Total Máquinas: \r\n";
            // 
            // mlblNTotalMquinas
            // 
            this.mlblNTotalMquinas.AutoSize = true;
            this.mlblNTotalMquinas.Depth = 0;
            this.mlblNTotalMquinas.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mlblNTotalMquinas.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.mlblNTotalMquinas.Location = new System.Drawing.Point(79, 45);
            this.mlblNTotalMquinas.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblNTotalMquinas.Name = "mlblNTotalMquinas";
            this.mlblNTotalMquinas.Size = new System.Drawing.Size(39, 41);
            this.mlblNTotalMquinas.TabIndex = 0;
            this.mlblNTotalMquinas.Text = "47";
            // 
            // iconeTotalMaquinas
            // 
            this.iconeTotalMaquinas.BackColor = System.Drawing.Color.White;
            this.iconeTotalMaquinas.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconeTotalMaquinas.IconChar = FontAwesome.Sharp.IconChar.Tractor;
            this.iconeTotalMaquinas.IconColor = System.Drawing.Color.DarkGreen;
            this.iconeTotalMaquinas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconeTotalMaquinas.IconSize = 38;
            this.iconeTotalMaquinas.InitialImage = null;
            this.iconeTotalMaquinas.Location = new System.Drawing.Point(21, 45);
            this.iconeTotalMaquinas.Name = "iconeTotalMaquinas";
            this.iconeTotalMaquinas.Size = new System.Drawing.Size(43, 38);
            this.iconeTotalMaquinas.TabIndex = 1;
            this.iconeTotalMaquinas.TabStop = false;
            // 
            // iconButtonConfiguracoes
            // 
            this.iconButtonConfiguracoes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonConfiguracoes.IconColor = System.Drawing.Color.Black;
            this.iconButtonConfiguracoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonConfiguracoes.Location = new System.Drawing.Point(26, 239);
            this.iconButtonConfiguracoes.Name = "iconButtonConfiguracoes";
            this.iconButtonConfiguracoes.Size = new System.Drawing.Size(104, 32);
            this.iconButtonConfiguracoes.TabIndex = 0;
            this.iconButtonConfiguracoes.Text = "Configurações";
            this.iconButtonConfiguracoes.UseVisualStyleBackColor = true;
            // 
            // iconButtonMaquinas
            // 
            this.iconButtonMaquinas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonMaquinas.IconColor = System.Drawing.Color.Black;
            this.iconButtonMaquinas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMaquinas.Location = new System.Drawing.Point(26, 195);
            this.iconButtonMaquinas.Name = "iconButtonMaquinas";
            this.iconButtonMaquinas.Size = new System.Drawing.Size(104, 32);
            this.iconButtonMaquinas.TabIndex = 0;
            this.iconButtonMaquinas.Text = "Maquinas";
            this.iconButtonMaquinas.UseVisualStyleBackColor = true;
            // 
            // iconButtonLicencas
            // 
            this.iconButtonLicencas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonLicencas.IconColor = System.Drawing.Color.Black;
            this.iconButtonLicencas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLicencas.Location = new System.Drawing.Point(26, 151);
            this.iconButtonLicencas.Name = "iconButtonLicencas";
            this.iconButtonLicencas.Size = new System.Drawing.Size(104, 32);
            this.iconButtonLicencas.TabIndex = 0;
            this.iconButtonLicencas.Text = "Licenças";
            this.iconButtonLicencas.UseVisualStyleBackColor = true;
            // 
            // iconButtonEquipamento
            // 
            this.iconButtonEquipamento.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonEquipamento.IconColor = System.Drawing.Color.Black;
            this.iconButtonEquipamento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEquipamento.Location = new System.Drawing.Point(26, 107);
            this.iconButtonEquipamento.Name = "iconButtonEquipamento";
            this.iconButtonEquipamento.Size = new System.Drawing.Size(104, 32);
            this.iconButtonEquipamento.TabIndex = 0;
            this.iconButtonEquipamento.Text = "Equipamentos";
            this.iconButtonEquipamento.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1081, 542);
            this.Controls.Add(this.materialCard4);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFoto);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeTotalMaquinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonEquipamento;
        private FontAwesome.Sharp.IconButton iconButtonConfiguracoes;
        private FontAwesome.Sharp.IconButton iconButtonMaquinas;
        private FontAwesome.Sharp.IconButton iconButtonLicencas;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel mlblTotalMaquinas;
        private MaterialSkin.Controls.MaterialLabel mlblNTotalMquinas;
        private FontAwesome.Sharp.IconPictureBox iconeTotalMaquinas;
    }
}
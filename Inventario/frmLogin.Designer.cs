namespace Inventario
{
    partial class frmLogin
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
            this.txtSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.mbtnLogar = new MaterialSkin.Controls.MaterialButton();
            this.grbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.AnimateReadOnly = false;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Depth = 0;
            this.txtSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.LeadingIcon = null;
            this.txtSenha.Location = new System.Drawing.Point(89, 127);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(283, 50);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "";
            this.txtSenha.TrailingIcon = null;
            this.txtSenha.Click += new System.EventHandler(this.txtSenha_Click);
            this.txtSenha.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtSenha_PreviewKeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(89, 60);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(283, 50);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            this.txtEmail.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtEmail_PreviewKeyDown);
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.txtEmail);
            this.grbDados.Controls.Add(this.txtSenha);
            this.grbDados.Location = new System.Drawing.Point(31, 67);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(460, 208);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // mbtnLogar
            // 
            this.mbtnLogar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnLogar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnLogar.Depth = 0;
            this.mbtnLogar.HighEmphasis = true;
            this.mbtnLogar.Icon = null;
            this.mbtnLogar.Location = new System.Drawing.Point(169, 298);
            this.mbtnLogar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnLogar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnLogar.Name = "mbtnLogar";
            this.mbtnLogar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnLogar.Size = new System.Drawing.Size(64, 36);
            this.mbtnLogar.TabIndex = 3;
            this.mbtnLogar.Text = "Login";
            this.mbtnLogar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnLogar.UseAccentColor = false;
            this.mbtnLogar.UseVisualStyleBackColor = true;
            this.mbtnLogar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.mbtnLogar_PreviewKeyDown);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(520, 400);
            this.Controls.Add(this.mbtnLogar);
            this.Controls.Add(this.grbDados);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grbDados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtSenha;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private System.Windows.Forms.GroupBox grbDados;
        private MaterialSkin.Controls.MaterialButton mbtnLogar;
    }
}
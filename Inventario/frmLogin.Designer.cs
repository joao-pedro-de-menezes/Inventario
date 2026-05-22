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
            this.btnTestCadas = new System.Windows.Forms.Button();
            this.mbtnRegistrar = new MaterialSkin.Controls.MaterialButton();
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
            this.txtSenha.Location = new System.Drawing.Point(6, 75);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(283, 50);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "";
            this.txtSenha.TrailingIcon = null;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(6, 19);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(283, 50);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.txtEmail);
            this.grbDados.Controls.Add(this.txtSenha);
            this.grbDados.Location = new System.Drawing.Point(132, 116);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(298, 134);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // mbtnLogar
            // 
            this.mbtnLogar.AutoSize = false;
            this.mbtnLogar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnLogar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnLogar.Depth = 0;
            this.mbtnLogar.HighEmphasis = true;
            this.mbtnLogar.Icon = null;
            this.mbtnLogar.Location = new System.Drawing.Point(206, 282);
            this.mbtnLogar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnLogar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnLogar.Name = "mbtnLogar";
            this.mbtnLogar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnLogar.Size = new System.Drawing.Size(151, 36);
            this.mbtnLogar.TabIndex = 3;
            this.mbtnLogar.Text = "Login";
            this.mbtnLogar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnLogar.UseAccentColor = false;
            this.mbtnLogar.UseVisualStyleBackColor = true;
            this.mbtnLogar.Click += new System.EventHandler(this.mbtnLogar_Click);
            // 
            // btnTestCadas
            // 
            this.btnTestCadas.Location = new System.Drawing.Point(439, 371);
            this.btnTestCadas.Name = "btnTestCadas";
            this.btnTestCadas.Size = new System.Drawing.Size(75, 23);
            this.btnTestCadas.TabIndex = 4;
            this.btnTestCadas.Text = "Tela Cadas";
            this.btnTestCadas.UseVisualStyleBackColor = true;
            // 
            // mbtnRegistrar
            // 
            this.mbtnRegistrar.AutoSize = false;
            this.mbtnRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnRegistrar.Depth = 0;
            this.mbtnRegistrar.HighEmphasis = true;
            this.mbtnRegistrar.Icon = null;
            this.mbtnRegistrar.Location = new System.Drawing.Point(206, 330);
            this.mbtnRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnRegistrar.Name = "mbtnRegistrar";
            this.mbtnRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnRegistrar.Size = new System.Drawing.Size(151, 43);
            this.mbtnRegistrar.TabIndex = 4;
            this.mbtnRegistrar.Text = "Registrar";
            this.mbtnRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnRegistrar.UseAccentColor = false;
            this.mbtnRegistrar.UseVisualStyleBackColor = true;
            this.mbtnRegistrar.Visible = false;
            this.mbtnRegistrar.Click += new System.EventHandler(this.mbtnRegistrar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(545, 427);
            this.Controls.Add(this.mbtnRegistrar);
            this.Controls.Add(this.mbtnLogar);
            this.Controls.Add(this.grbDados);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grbDados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtSenha;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private System.Windows.Forms.GroupBox grbDados;
        private MaterialSkin.Controls.MaterialButton mbtnLogar;
        private System.Windows.Forms.Button btnTestCadas;
        private MaterialSkin.Controls.MaterialButton mbtnRegistrar;
    }
}
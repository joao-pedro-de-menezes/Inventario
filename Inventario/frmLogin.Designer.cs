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
            this.btnLogar = new System.Windows.Forms.Button();
            this.mlblBemVindo = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.White;
            this.btnLogar.Location = new System.Drawing.Point(135, 122);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(125, 43);
            this.btnLogar.TabIndex = 0;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = false;
            // 
            // mlblBemVindo
            // 
            this.mlblBemVindo.AutoSize = true;
            this.mlblBemVindo.Depth = 0;
            this.mlblBemVindo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblBemVindo.Location = new System.Drawing.Point(142, 25);
            this.mlblBemVindo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblBemVindo.Name = "mlblBemVindo";
            this.mlblBemVindo.Size = new System.Drawing.Size(78, 19);
            this.mlblBemVindo.TabIndex = 1;
            this.mlblBemVindo.Text = "Bem-Vindo";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(430, 297);
            this.Controls.Add(this.mlblBemVindo);
            this.Controls.Add(this.btnLogar);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogar;
        private MaterialSkin.Controls.MaterialLabel mlblBemVindo;
    }
}
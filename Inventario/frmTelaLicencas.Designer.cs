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
            this.mbFechar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // mbFechar
            // 
            this.mbFechar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbFechar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbFechar.Depth = 0;
            this.mbFechar.HighEmphasis = true;
            this.mbFechar.Icon = null;
            this.mbFechar.Location = new System.Drawing.Point(197, 91);
            this.mbFechar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbFechar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbFechar.Name = "mbFechar";
            this.mbFechar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbFechar.Size = new System.Drawing.Size(77, 36);
            this.mbFechar.TabIndex = 0;
            this.mbFechar.Text = "Fechar";
            this.mbFechar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbFechar.UseAccentColor = false;
            this.mbFechar.UseVisualStyleBackColor = true;
            this.mbFechar.Click += new System.EventHandler(this.mbFechar_Click);
            // 
            // frmTelaLicencas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mbFechar);
            this.MaximizeBox = false;
            this.Name = "frmTelaLicencas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTelaLicencas";
            this.Load += new System.EventHandler(this.frmTelaLicencas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton mbFechar;
    }
}
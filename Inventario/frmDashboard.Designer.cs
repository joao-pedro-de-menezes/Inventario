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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.mbtnConfig = new MaterialSkin.Controls.MaterialButton();
            this.mbtnEquipamentos = new MaterialSkin.Controls.MaterialButton();
            this.mbtnLicenca = new MaterialSkin.Controls.MaterialButton();
            this.mbtnMaquinas = new MaterialSkin.Controls.MaterialButton();
            this.mbtnAdmin = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.iconeTotalMaquinas = new FontAwesome.Sharp.IconPictureBox();
            this.mlblNTotalMquinas = new MaterialSkin.Controls.MaterialLabel();
            this.mlblTotalMaquinas = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.iconeInstaladas = new FontAwesome.Sharp.IconPictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mlblTotalInstaladas = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.mlblEquipamentoReserva = new MaterialSkin.Controls.MaterialLabel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.lblUsuarioLogado = new MaterialSkin.Controls.MaterialLabel();
            this.pnlSubLicencas = new System.Windows.Forms.Panel();
            this.iconButtonExibirLicencas = new FontAwesome.Sharp.IconButton();
            this.iconButtonCadastrarLicencas = new FontAwesome.Sharp.IconButton();
            this.pnlSubEquipamentos = new System.Windows.Forms.Panel();
            this.iconButtonExibirEquipamentos = new FontAwesome.Sharp.IconButton();
            this.iconButtonCadastrarEquipamentos = new FontAwesome.Sharp.IconButton();
            this.pnlSubMaquinas = new System.Windows.Forms.Panel();
            this.iconButtonExibirMaquinas = new FontAwesome.Sharp.IconButton();
            this.iconButtonCadastrarMaquinas = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.pnlMenu.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeTotalMaquinas)).BeginInit();
            this.materialCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeInstaladas)).BeginInit();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.pnlSubLicencas.SuspendLayout();
            this.pnlSubEquipamentos.SuspendLayout();
            this.pnlSubMaquinas.SuspendLayout();
            this.grbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlMenu.Controls.Add(this.mbtnConfig);
            this.pnlMenu.Controls.Add(this.mbtnEquipamentos);
            this.pnlMenu.Controls.Add(this.mbtnLicenca);
            this.pnlMenu.Controls.Add(this.mbtnMaquinas);
            this.pnlMenu.Controls.Add(this.mbtnAdmin);
            this.pnlMenu.Location = new System.Drawing.Point(-5, 64);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(167, 609);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // mbtnConfig
            // 
            this.mbtnConfig.AutoSize = false;
            this.mbtnConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnConfig.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnConfig.Depth = 0;
            this.mbtnConfig.HighEmphasis = true;
            this.mbtnConfig.Icon = null;
            this.mbtnConfig.Location = new System.Drawing.Point(26, 225);
            this.mbtnConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnConfig.Name = "mbtnConfig";
            this.mbtnConfig.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnConfig.Size = new System.Drawing.Size(121, 32);
            this.mbtnConfig.TabIndex = 5;
            this.mbtnConfig.Text = "Configurações";
            this.mbtnConfig.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnConfig.UseAccentColor = false;
            this.mbtnConfig.UseVisualStyleBackColor = true;
            // 
            // mbtnEquipamentos
            // 
            this.mbtnEquipamentos.AutoSize = false;
            this.mbtnEquipamentos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnEquipamentos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnEquipamentos.Depth = 0;
            this.mbtnEquipamentos.HighEmphasis = true;
            this.mbtnEquipamentos.Icon = null;
            this.mbtnEquipamentos.Location = new System.Drawing.Point(26, 93);
            this.mbtnEquipamentos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnEquipamentos.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnEquipamentos.Name = "mbtnEquipamentos";
            this.mbtnEquipamentos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnEquipamentos.Size = new System.Drawing.Size(121, 32);
            this.mbtnEquipamentos.TabIndex = 4;
            this.mbtnEquipamentos.Text = "Equipamentos";
            this.mbtnEquipamentos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnEquipamentos.UseAccentColor = false;
            this.mbtnEquipamentos.UseVisualStyleBackColor = true;
            this.mbtnEquipamentos.Click += new System.EventHandler(this.mbtnEquipamentos_Click);
            // 
            // mbtnLicenca
            // 
            this.mbtnLicenca.AutoSize = false;
            this.mbtnLicenca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnLicenca.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnLicenca.Depth = 0;
            this.mbtnLicenca.HighEmphasis = true;
            this.mbtnLicenca.Icon = null;
            this.mbtnLicenca.Location = new System.Drawing.Point(26, 137);
            this.mbtnLicenca.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnLicenca.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnLicenca.Name = "mbtnLicenca";
            this.mbtnLicenca.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnLicenca.Size = new System.Drawing.Size(121, 32);
            this.mbtnLicenca.TabIndex = 3;
            this.mbtnLicenca.Text = "Licenças";
            this.mbtnLicenca.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnLicenca.UseAccentColor = false;
            this.mbtnLicenca.UseVisualStyleBackColor = true;
            this.mbtnLicenca.Click += new System.EventHandler(this.mbtnLicenca_Click);
            // 
            // mbtnMaquinas
            // 
            this.mbtnMaquinas.AutoSize = false;
            this.mbtnMaquinas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnMaquinas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnMaquinas.Depth = 0;
            this.mbtnMaquinas.HighEmphasis = true;
            this.mbtnMaquinas.Icon = null;
            this.mbtnMaquinas.Location = new System.Drawing.Point(26, 181);
            this.mbtnMaquinas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnMaquinas.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnMaquinas.Name = "mbtnMaquinas";
            this.mbtnMaquinas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnMaquinas.Size = new System.Drawing.Size(121, 32);
            this.mbtnMaquinas.TabIndex = 2;
            this.mbtnMaquinas.Text = "maquinas";
            this.mbtnMaquinas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnMaquinas.UseAccentColor = false;
            this.mbtnMaquinas.UseVisualStyleBackColor = true;
            this.mbtnMaquinas.Click += new System.EventHandler(this.mbtnMaquinas_Click);
            // 
            // mbtnAdmin
            // 
            this.mbtnAdmin.AutoSize = false;
            this.mbtnAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAdmin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnAdmin.Depth = 0;
            this.mbtnAdmin.HighEmphasis = true;
            this.mbtnAdmin.Icon = null;
            this.mbtnAdmin.Location = new System.Drawing.Point(26, 367);
            this.mbtnAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAdmin.Name = "mbtnAdmin";
            this.mbtnAdmin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnAdmin.Size = new System.Drawing.Size(121, 32);
            this.mbtnAdmin.TabIndex = 1;
            this.mbtnAdmin.Text = "admin";
            this.mbtnAdmin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnAdmin.UseAccentColor = false;
            this.mbtnAdmin.UseVisualStyleBackColor = true;
            this.mbtnAdmin.Visible = false;
            this.mbtnAdmin.Click += new System.EventHandler(this.mbtnAdmin_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.iconeTotalMaquinas);
            this.materialCard1.Controls.Add(this.mlblNTotalMquinas);
            this.materialCard1.Controls.Add(this.mlblTotalMaquinas);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(8, 37);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(135, 100);
            this.materialCard1.TabIndex = 2;
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
            this.iconeTotalMaquinas.Location = new System.Drawing.Point(11, 45);
            this.iconeTotalMaquinas.Name = "iconeTotalMaquinas";
            this.iconeTotalMaquinas.Size = new System.Drawing.Size(43, 38);
            this.iconeTotalMaquinas.TabIndex = 1;
            this.iconeTotalMaquinas.TabStop = false;
            // 
            // mlblNTotalMquinas
            // 
            this.mlblNTotalMquinas.AutoSize = true;
            this.mlblNTotalMquinas.Depth = 0;
            this.mlblNTotalMquinas.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mlblNTotalMquinas.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.mlblNTotalMquinas.Location = new System.Drawing.Point(69, 45);
            this.mlblNTotalMquinas.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblNTotalMquinas.Name = "mlblNTotalMquinas";
            this.mlblNTotalMquinas.Size = new System.Drawing.Size(39, 41);
            this.mlblNTotalMquinas.TabIndex = 0;
            this.mlblNTotalMquinas.Text = "47";
            // 
            // mlblTotalMaquinas
            // 
            this.mlblTotalMaquinas.AutoSize = true;
            this.mlblTotalMaquinas.Depth = 0;
            this.mlblTotalMaquinas.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblTotalMaquinas.Location = new System.Drawing.Point(6, 18);
            this.mlblTotalMaquinas.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblTotalMaquinas.Name = "mlblTotalMaquinas";
            this.mlblTotalMaquinas.Size = new System.Drawing.Size(124, 19);
            this.mlblTotalMaquinas.TabIndex = 0;
            this.mlblTotalMaquinas.Text = "Total Máquinas: \r\n";
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.iconeInstaladas);
            this.materialCard5.Controls.Add(this.materialLabel1);
            this.materialCard5.Controls.Add(this.mlblTotalInstaladas);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(163, 51);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(135, 100);
            this.materialCard5.TabIndex = 2;
            // 
            // iconeInstaladas
            // 
            this.iconeInstaladas.BackColor = System.Drawing.Color.White;
            this.iconeInstaladas.ForeColor = System.Drawing.Color.Black;
            this.iconeInstaladas.IconChar = FontAwesome.Sharp.IconChar.Ubuntu;
            this.iconeInstaladas.IconColor = System.Drawing.Color.Black;
            this.iconeInstaladas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconeInstaladas.IconSize = 38;
            this.iconeInstaladas.InitialImage = null;
            this.iconeInstaladas.Location = new System.Drawing.Point(12, 45);
            this.iconeInstaladas.Name = "iconeInstaladas";
            this.iconeInstaladas.Size = new System.Drawing.Size(43, 38);
            this.iconeInstaladas.TabIndex = 1;
            this.iconeInstaladas.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(70, 45);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 41);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "23";
            // 
            // mlblTotalInstaladas
            // 
            this.mlblTotalInstaladas.AutoSize = true;
            this.mlblTotalInstaladas.Depth = 0;
            this.mlblTotalInstaladas.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblTotalInstaladas.Location = new System.Drawing.Point(9, 14);
            this.mlblTotalInstaladas.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblTotalInstaladas.Name = "mlblTotalInstaladas";
            this.mlblTotalInstaladas.Size = new System.Drawing.Size(120, 19);
            this.mlblTotalInstaladas.TabIndex = 0;
            this.mlblTotalInstaladas.Text = "Total Instaladas:";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.iconPictureBox2);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Controls.Add(this.mlblEquipamentoReserva);
            this.materialCard2.Controls.Add(this.iconButton1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(11, 207);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(212, 101);
            this.materialCard2.TabIndex = 2;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Tractor;
            this.iconPictureBox2.IconColor = System.Drawing.Color.DarkGreen;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 38;
            this.iconPictureBox2.InitialImage = null;
            this.iconPictureBox2.Location = new System.Drawing.Point(21, 45);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(43, 38);
            this.iconPictureBox2.TabIndex = 1;
            this.iconPictureBox2.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.Location = new System.Drawing.Point(79, 45);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(39, 41);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "47";
            // 
            // mlblEquipamentoReserva
            // 
            this.mlblEquipamentoReserva.AutoSize = true;
            this.mlblEquipamentoReserva.Depth = 0;
            this.mlblEquipamentoReserva.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblEquipamentoReserva.Location = new System.Drawing.Point(5, 18);
            this.mlblEquipamentoReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblEquipamentoReserva.Name = "mlblEquipamentoReserva";
            this.mlblEquipamentoReserva.Size = new System.Drawing.Size(199, 19);
            this.mlblEquipamentoReserva.TabIndex = 0;
            this.mlblEquipamentoReserva.Text = "Equipamentos danificados: ";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(124, 51);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(74, 32);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Ver Mais";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.iconPictureBox3);
            this.materialCard3.Controls.Add(this.materialLabel4);
            this.materialCard3.Controls.Add(this.materialLabel5);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(326, 51);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(214, 100);
            this.materialCard3.TabIndex = 2;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Tractor;
            this.iconPictureBox3.IconColor = System.Drawing.Color.DarkGreen;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 38;
            this.iconPictureBox3.InitialImage = null;
            this.iconPictureBox3.Location = new System.Drawing.Point(49, 45);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(43, 38);
            this.iconPictureBox3.TabIndex = 1;
            this.iconPictureBox3.TabStop = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel4.Location = new System.Drawing.Point(107, 45);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(39, 41);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "47";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(8, 13);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(203, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Alerta de Licenças Vencidas:";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.iconPictureBox1);
            this.materialCard4.Controls.Add(this.materialLabel3);
            this.materialCard4.Controls.Add(this.materialLabel6);
            this.materialCard4.Controls.Add(this.iconButton2);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(240, 207);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(291, 101);
            this.materialCard4.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Tractor;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DarkGreen;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 38;
            this.iconPictureBox1.InitialImage = null;
            this.iconPictureBox1.Location = new System.Drawing.Point(45, 46);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 38);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel3.Location = new System.Drawing.Point(103, 46);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(39, 41);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "47";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(5, 18);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(282, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Equipamentos em manutenção externa:";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(167, 51);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(74, 32);
            this.iconButton2.TabIndex = 0;
            this.iconButton2.Text = "Ver Mais";
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioLogado.Depth = 0;
            this.lblUsuarioLogado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsuarioLogado.ForeColor = System.Drawing.Color.Black;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(615, 39);
            this.lblUsuarioLogado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(121, 19);
            this.lblUsuarioLogado.TabIndex = 4;
            this.lblUsuarioLogado.Text = "Carregando...";
            // 
            // pnlSubLicencas
            // 
            this.pnlSubLicencas.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlSubLicencas.Controls.Add(this.iconButtonExibirLicencas);
            this.pnlSubLicencas.Controls.Add(this.iconButtonCadastrarLicencas);
            this.pnlSubLicencas.Location = new System.Drawing.Point(291, 393);
            this.pnlSubLicencas.Name = "pnlSubLicencas";
            this.pnlSubLicencas.Size = new System.Drawing.Size(110, 73);
            this.pnlSubLicencas.TabIndex = 5;
            this.pnlSubLicencas.Visible = false;
            // 
            // iconButtonExibirLicencas
            // 
            this.iconButtonExibirLicencas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonExibirLicencas.IconColor = System.Drawing.Color.Black;
            this.iconButtonExibirLicencas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExibirLicencas.Location = new System.Drawing.Point(3, 3);
            this.iconButtonExibirLicencas.Name = "iconButtonExibirLicencas";
            this.iconButtonExibirLicencas.Size = new System.Drawing.Size(103, 32);
            this.iconButtonExibirLicencas.TabIndex = 8;
            this.iconButtonExibirLicencas.Text = "Exibir Tudo";
            this.iconButtonExibirLicencas.UseVisualStyleBackColor = true;
            this.iconButtonExibirLicencas.Click += new System.EventHandler(this.iconButtonExibirLicencas_Click);
            // 
            // iconButtonCadastrarLicencas
            // 
            this.iconButtonCadastrarLicencas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCadastrarLicencas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonCadastrarLicencas.IconColor = System.Drawing.Color.Black;
            this.iconButtonCadastrarLicencas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCadastrarLicencas.Location = new System.Drawing.Point(3, 38);
            this.iconButtonCadastrarLicencas.Name = "iconButtonCadastrarLicencas";
            this.iconButtonCadastrarLicencas.Size = new System.Drawing.Size(104, 31);
            this.iconButtonCadastrarLicencas.TabIndex = 0;
            this.iconButtonCadastrarLicencas.Text = "Cadastrar";
            this.iconButtonCadastrarLicencas.UseVisualStyleBackColor = true;
            this.iconButtonCadastrarLicencas.Click += new System.EventHandler(this.iconButtonCadastrarLicencas_Click);
            // 
            // pnlSubEquipamentos
            // 
            this.pnlSubEquipamentos.Controls.Add(this.iconButtonExibirEquipamentos);
            this.pnlSubEquipamentos.Controls.Add(this.iconButtonCadastrarEquipamentos);
            this.pnlSubEquipamentos.Location = new System.Drawing.Point(168, 393);
            this.pnlSubEquipamentos.Name = "pnlSubEquipamentos";
            this.pnlSubEquipamentos.Size = new System.Drawing.Size(110, 73);
            this.pnlSubEquipamentos.TabIndex = 6;
            this.pnlSubEquipamentos.Visible = false;
            // 
            // iconButtonExibirEquipamentos
            // 
            this.iconButtonExibirEquipamentos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonExibirEquipamentos.IconColor = System.Drawing.Color.Black;
            this.iconButtonExibirEquipamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExibirEquipamentos.Location = new System.Drawing.Point(3, 3);
            this.iconButtonExibirEquipamentos.Name = "iconButtonExibirEquipamentos";
            this.iconButtonExibirEquipamentos.Size = new System.Drawing.Size(104, 32);
            this.iconButtonExibirEquipamentos.TabIndex = 7;
            this.iconButtonExibirEquipamentos.Text = "Exibir Tudo";
            this.iconButtonExibirEquipamentos.UseVisualStyleBackColor = true;
            this.iconButtonExibirEquipamentos.Click += new System.EventHandler(this.iconButtonExibirEquipamentos_Click);
            // 
            // iconButtonCadastrarEquipamentos
            // 
            this.iconButtonCadastrarEquipamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCadastrarEquipamentos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonCadastrarEquipamentos.IconColor = System.Drawing.Color.Black;
            this.iconButtonCadastrarEquipamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCadastrarEquipamentos.Location = new System.Drawing.Point(3, 39);
            this.iconButtonCadastrarEquipamentos.Name = "iconButtonCadastrarEquipamentos";
            this.iconButtonCadastrarEquipamentos.Size = new System.Drawing.Size(104, 31);
            this.iconButtonCadastrarEquipamentos.TabIndex = 0;
            this.iconButtonCadastrarEquipamentos.Text = "Cadastrar";
            this.iconButtonCadastrarEquipamentos.UseVisualStyleBackColor = true;
            this.iconButtonCadastrarEquipamentos.Click += new System.EventHandler(this.iconButtonCadastrarEquipamentos_Click);
            // 
            // pnlSubMaquinas
            // 
            this.pnlSubMaquinas.Controls.Add(this.iconButtonExibirMaquinas);
            this.pnlSubMaquinas.Controls.Add(this.iconButtonCadastrarMaquinas);
            this.pnlSubMaquinas.Location = new System.Drawing.Point(407, 393);
            this.pnlSubMaquinas.Name = "pnlSubMaquinas";
            this.pnlSubMaquinas.Size = new System.Drawing.Size(110, 73);
            this.pnlSubMaquinas.TabIndex = 2;
            this.pnlSubMaquinas.Visible = false;
            // 
            // iconButtonExibirMaquinas
            // 
            this.iconButtonExibirMaquinas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonExibirMaquinas.IconColor = System.Drawing.Color.Black;
            this.iconButtonExibirMaquinas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExibirMaquinas.Location = new System.Drawing.Point(3, 4);
            this.iconButtonExibirMaquinas.Name = "iconButtonExibirMaquinas";
            this.iconButtonExibirMaquinas.Size = new System.Drawing.Size(103, 31);
            this.iconButtonExibirMaquinas.TabIndex = 9;
            this.iconButtonExibirMaquinas.Text = "Exibir Tudo";
            this.iconButtonExibirMaquinas.UseVisualStyleBackColor = true;
            this.iconButtonExibirMaquinas.Click += new System.EventHandler(this.iconButtonExibirMaquinas_Click);
            // 
            // iconButtonCadastrarMaquinas
            // 
            this.iconButtonCadastrarMaquinas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCadastrarMaquinas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonCadastrarMaquinas.IconColor = System.Drawing.Color.Black;
            this.iconButtonCadastrarMaquinas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCadastrarMaquinas.Location = new System.Drawing.Point(3, 38);
            this.iconButtonCadastrarMaquinas.Name = "iconButtonCadastrarMaquinas";
            this.iconButtonCadastrarMaquinas.Size = new System.Drawing.Size(104, 31);
            this.iconButtonCadastrarMaquinas.TabIndex = 0;
            this.iconButtonCadastrarMaquinas.Text = "Cadastrar";
            this.iconButtonCadastrarMaquinas.UseVisualStyleBackColor = true;
            this.iconButtonCadastrarMaquinas.Click += new System.EventHandler(this.iconButtonCadastrarMaquinas_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.Location = new System.Drawing.Point(343, 28);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 32);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "DashBoard";
            // 
            // grbDados
            // 
            this.grbDados.BackColor = System.Drawing.Color.Transparent;
            this.grbDados.Controls.Add(this.materialCard1);
            this.grbDados.Controls.Add(this.materialCard5);
            this.grbDados.Controls.Add(this.materialCard3);
            this.grbDados.Controls.Add(this.materialCard4);
            this.grbDados.Controls.Add(this.materialCard2);
            this.grbDados.Location = new System.Drawing.Point(168, 68);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(568, 322);
            this.grbDados.TabIndex = 10;
            this.grbDados.TabStop = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1238, 667);
            this.Controls.Add(this.grbDados);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlSubMaquinas);
            this.Controls.Add(this.pnlSubEquipamentos);
            this.Controls.Add(this.pnlSubLicencas);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.pnlMenu);
            this.IsMdiContainer = true;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDashboard_FormClosed);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlMenu.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeTotalMaquinas)).EndInit();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeInstaladas)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.pnlSubLicencas.ResumeLayout(false);
            this.pnlSubEquipamentos.ResumeLayout(false);
            this.pnlSubMaquinas.ResumeLayout(false);
            this.grbDados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel mlblTotalMaquinas;
        private MaterialSkin.Controls.MaterialLabel mlblNTotalMquinas;
        private FontAwesome.Sharp.IconPictureBox iconeTotalMaquinas;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel mlblTotalInstaladas;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel mlblEquipamentoReserva;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private FontAwesome.Sharp.IconButton iconButton2;
        private MaterialSkin.Controls.MaterialLabel lblUsuarioLogado;
        private FontAwesome.Sharp.IconPictureBox iconeInstaladas;
        private MaterialSkin.Controls.MaterialButton mbtnAdmin;
        private System.Windows.Forms.Panel pnlSubLicencas;
        private FontAwesome.Sharp.IconButton iconButtonCadastrarLicencas;
        private System.Windows.Forms.Panel pnlSubEquipamentos;
        private FontAwesome.Sharp.IconButton iconButtonCadastrarEquipamentos;
        private System.Windows.Forms.Panel pnlSubMaquinas;
        private FontAwesome.Sharp.IconButton iconButtonCadastrarMaquinas;
        private FontAwesome.Sharp.IconButton iconButtonExibirLicencas;
        private FontAwesome.Sharp.IconButton iconButtonExibirEquipamentos;
        private FontAwesome.Sharp.IconButton iconButtonExibirMaquinas;
        private MaterialSkin.Controls.MaterialButton mbtnEquipamentos;
        private MaterialSkin.Controls.MaterialButton mbtnLicenca;
        private MaterialSkin.Controls.MaterialButton mbtnMaquinas;
        private MaterialSkin.Controls.MaterialButton mbtnConfig;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.GroupBox grbDados;
    }
}
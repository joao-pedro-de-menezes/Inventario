using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class frmCadastroEq : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public frmCadastroEq()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Green800,       // Cor principal (Barra de título e abas superiores)
                Primary.Green900,       // Cor principal mais escura (usada em detalhes e sombras)
                Primary.Green500,       // Cor principal mais clara
                Accent.Green400,        // Cor de destaque (linhas de seleção, inputs focados)
                TextShade.WHITE         // Cor do texto que fica em cima das cores escuras (Branco)
                );
        }

        private void frmCadastroEq_Load(object sender, EventArgs e)
        {

        }

        private void AbrirTelaCadastro(UserControl tela)
        {
            pnlContainer.Controls.Clear(); // Limpa a tela de cadastro anterior
            tela.Dock = DockStyle.None;    // Faz a nova tela preencher o espaço definido no forms
            pnlContainer.Controls.Add(tela); // "Gruda" a nova tela no formulário
        }

        private void mbtnMonitor_Click(object sender, EventArgs e)
        {
            AbrirTelaCadastro(new ucCadastroMonitor());
        }
    }
}

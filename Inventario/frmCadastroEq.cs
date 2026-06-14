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

        private void mbtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void mbtnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void mbtnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroLicenca_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mTxtPesquisa.Text))
            {
                if (MessageBox.Show("Nenhum parâmetro foi passado, deseja fazer buscar geral?", "Pesquisa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    clsLicenca licenca = new clsLicenca();
                    dgvLi.DataSource = licenca.PesquisaTodos();
                }
            }
        }
    }
}

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
    public partial class frmCadastroMa : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public frmCadastroMa()
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

        private void frmCadastroMa_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxtFrota_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
                MessageBox.Show("A Frota deve ter apenas numeros inteiros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mtxtFrente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Frente deve ter apenas numeros inteiros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFrotaP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Frota deve ter apenas numeros inteiros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFrenteP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Frente deve ter apenas numeros inteiros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mbVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmDashboard dashboard = new frmDashboard();
            dashboard.ShowDialog();
        
        }

        private void frmCadastroMa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmDashboard dashboard = new frmDashboard();
            dashboard.ShowDialog();
            this.Dispose();
        }
    }
}

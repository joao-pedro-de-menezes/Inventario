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
    public partial class frmTelaLicencas : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public frmTelaLicencas()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE
                );
        }

        private void frmTelaLicencas_Load(object sender, EventArgs e)
        {

        }

        private void mbVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbPesquisar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

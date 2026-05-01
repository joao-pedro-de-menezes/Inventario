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
    public partial class frmCadastroUsuario : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public frmCadastroUsuario()
        {
        
            // Configuração do Gerenciador de Temas
            materialSkinManager = MaterialSkinManager.Instance;

            // Avisa ao Gerenciador para cuidar DESTE formulário, caso haja mais de um formulário, ele pode gerenciar todos viu EDHIN
            materialSkinManager.AddFormToManage(this);

        // Define o Tema (claro ou escuro) oque eu n achei nessessario, mas adicionei para caso queira futuramente
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Define a paleta de cores (Baseado no exempo da nossa imagem dashboard azul marinho)
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,   // Cor principal (Barra de título)
                Primary.BlueGrey900,   // Cor principal escura
                Primary.BlueGrey500,   // Cor principal clara
                Accent.LightBlue200,   // Cor de destaque (botões, etc)
                TextShade.WHITE        // Cor do texto na barra de título
                );
        
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

      
    }
}

// 
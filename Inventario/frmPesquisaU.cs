using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin; // Biblioteca para temas Material Design
using MaterialSkin.Controls; // Bilioteca para controles Material Design
namespace Inventario
{
    public partial class frmPesquisaU : MaterialForm
    {

        // variável para o gerenciador de temas
        private readonly MaterialSkinManager materialSkinManager;
        public frmPesquisaU()
        {
            InitializeComponent();
            // Configuração do Gerenciador de Temas
            materialSkinManager = MaterialSkinManager.Instance;

            // Avisa ao Gerenciador para cuidar DESTE formulário, caso haja mais de um formulário, ele pode gerenciar todos viu EDHIN
            materialSkinManager.AddFormToManage(this);

            // Define o Tema (claro ou escuro) oque eu n achei nessessario, mas adicionei para caso queira futuramente
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Define a paleta de cores (Baseado no exempo da nossa imagem dashboard azul marinho)
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,   // Cor principal (Barra de título)
                Primary.Blue900,   // Cor principal escura
                Primary.Blue500,   // Cor principal clara
                Accent.LightBlue200,   // Cor de destaque (botões, etc)
                TextShade.WHITE        // Cor do texto na barra de título
            );
        }
   
        private void frmPesquisaU_Load(object sender, EventArgs e)
        {

        }

        private void mbtnPesquisar_Click(object sender, EventArgs e)
        {
            clsUsuario clsUsu = new clsUsuario();
            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty((txtNome.Text)))
            {
                if (MessageBox.Show("Seus campos estão vazios deseja fazer uma busca geral?", "Pesquisa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dgvUsu.DataSource = clsUsu.PesquisaTodos();
                }
            } else if (!string.IsNullOrEmpty(txtCodigo.Text)){
                dgvUsu.DataSource = clsUsu.PesquisaCodigo(Convert.ToInt16(txtCodigo.Text));
            }else
            {
                dgvUsu.DataSource = clsUsu.PesquisaNome(txtNome.Text);
            }
          
        
        }

        private void mtbnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}

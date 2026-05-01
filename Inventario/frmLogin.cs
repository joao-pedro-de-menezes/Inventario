using MaterialSkin;
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
    public partial class frmLogin : MaterialForm // Herdando de MaterialForm para usar os temas do Material Design
    {
        string email = "Digite aqui seu E-mail";
        string senha = "Digite aqui sua Senha";
        // variável para o gerenciador de temas
        private readonly MaterialSkinManager materialSkinManager;
        public frmLogin()
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
                Primary.BlueGrey800,   // Cor principal (Barra de título)
                Primary.BlueGrey900,   // Cor principal escura
                Primary.BlueGrey500,   // Cor principal clara
                Accent.LightBlue200,   // Cor de destaque (botões, etc)
                TextShade.WHITE        // Cor do texto na barra de título
            );
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            frmDashboard dash = new frmDashboard();
            dash.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
          
           txtEmail.Text = email;
           txtSenha.Text = senha;
            

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                txtSenha.Text = senha;
            }
            if (txtEmail.Text == email)
            {
                txtEmail.Text = "";
            }
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Text = email;
            }
            if (txtSenha.Text == senha)
            {
                txtSenha.Text = "";
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
        
                
        }

    

        private void txtEmail_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (txtSenha.Text == senha)
            {

                if (e.KeyCode == Keys.Tab)
                {
                    if (txtSenha.Text == senha)
                    {
                        txtSenha.Clear();
                    }

                }

            }
        }

        private void mbtnLogar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtEmail.Text == email)
            {
           
                if (e.KeyCode == Keys.Tab)
                {
                    txtEmail.Clear();
                    txtSenha.Text = senha;
                }
            }
        }

        private void txtSenha_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (txtEmail.Text == "")
                    txtEmail.Text = email;
            }
        }
    }
}
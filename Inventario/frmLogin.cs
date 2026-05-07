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
        //Aqui to salvando as variáveis com a clsGuardaUsu porque vou usar essas informações mais pra frente
        
        int contador = 0;

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
                Primary.Blue800,   // Cor principal (Barra de título)
                Primary.Blue900,   // Cor principal escura
                Primary.Blue500,   // Cor principal clara
                Accent.LightBlue200,   // Cor de destaque (botões, etc)
                TextShade.WHITE        // Cor do texto na barra de título
            );
        }

    

        private void frmLogin_Load(object sender, EventArgs e)
        {
          
           txtEmail.Text = email;
           txtSenha.Text = senha;
            

        }

         /*Fazer isso na tela do cadastro, para cada campo 1 event click e um preview key dps te explico isso direito */
        //Começo de deixar vazio
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
        //Final de deixar vazio



     

        private void mbtnLogar_Click(object sender, EventArgs e)
        {
            //Aqui guarda o email escrito na variável
            clsGuardarUsu.EmailGuardado = txtEmail.Text;
            clsUsuario clsUsu = new clsUsuario();
            frmDashboard dash = new frmDashboard();

            //Verificação das coisas

            if (contador > 2)
            {
                MessageBox.Show("Não foi possível acessar o sistema, você ultrapassou o limite de tentativas", "Login", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                Application.Exit();
            }
            if (string.IsNullOrEmpty(txtEmail.Text) || txtEmail.Text == email)
            {
                MessageBox.Show("O email não pode ser vazio ou a mensagem padrão", "Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text) || txtSenha.Text == senha)
            {
                MessageBox.Show("A senha não pode ser vazia ou a mensagem padrão", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }
            contador += 1; //Se errar as proximas validações fecha o sistema
            if (!clsUsu.ValidarLogin(txtEmail.Text, txtSenha.Text))
            {
                MessageBox.Show("Email e senha incorretos", "Validar ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear();
                txtSenha.Clear();
                return;
            }
            else
            {
             //Se tudo der certo dale
                MessageBox.Show("Login feito com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
                dash.ShowDialog();
                this.Close();
                txtEmail.Clear();
                txtSenha.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario cadastro = new frmCadastroUsuario();
            this.Hide();
            cadastro.ShowDialog();
            this.Close();
        }
    }
}
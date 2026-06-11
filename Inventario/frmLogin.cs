using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin; // Biblioteca para temas Material Design
using MaterialSkin.Controls; // Bilioteca para controles Material Design


namespace Inventario
{
    public partial class frmLogin : MaterialForm // Herdando de MaterialForm para usar os temas do Material Design
    {
        //Contador de erro
        int contador = 0;

        //Armazenar variáveis para o método LimparBtns
        string email = "E-mail";
        string senha = "Senha";

        // variável para o gerenciador de temas
        private readonly MaterialSkinManager materialSkinManager;
        public frmLogin()
        {
        
            InitializeComponent();
            
            //Usar método LimparBtns
            txtEmail.LimparBtns(email); 
            txtSenha.LimparBtns(senha);

            // Configuração do Gerenciador de Temas
            materialSkinManager = MaterialSkinManager.Instance;

            // Avisa ao Gerenciador para cuidar DESTE formulário, caso haja mais de um formulário, ele pode gerenciar todos viu EDHIN
            materialSkinManager.AddFormToManage(this);

            // Define o Tema (claro ou escuro) oque eu n achei nessessario, mas adicionei para caso queira futuramente
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Define a paleta de cores (Baseado no exempo da nossa imagem dashboard azul marinho)
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Green800,       // Cor principal (Barra de título e abas superiores)
                Primary.Green900,       // Cor principal mais escura (usada em detalhes e sombras)
                Primary.Green500,       // Cor principal mais clara
                Accent.Green400,        // Cor de destaque (linhas de seleção, inputs focados)
                TextShade.WHITE      // Cor do texto que fica em cima das cores escuras (Branco)
            
            );
        }

    

        private void frmLogin_Load(object sender, EventArgs e)
        {
            carregar();
            titulo();
        }

        /* Método antigo
         Fazer isso na tela do cadastro, para cada campo 1 event click e um preview key dps te explico isso direito 
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



        //Método para limpar as paradas automático

       
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
    */


     

        private void mbtnLogar_Click(object sender, EventArgs e)
        {
            //Aqui guarda o email escrito na variável
            clsGuardarUsu.EmailGuardado = txtEmail.Text;
            clsUsuario clsUsu = new clsUsuario();
            frmDashboard dash = new frmDashboard();

            //Verificação das coisas

            if (contador > 2)
            {
                titulo();
                MessageBox.Show("Não foi possível acessar o sistema, você ultrapassou o limite de tentativas", "Login", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                Application.Exit();
            }
            if (string.IsNullOrEmpty(txtEmail.Text) || txtEmail.Text == email)
            {
                titulo();
                MessageBox.Show("O email não pode ser vazio ou a mensagem padrão", "Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text) || txtSenha.Text == senha)
            {
                titulo();
                MessageBox.Show("A senha não pode ser vazia ou a mensagem padrão", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }
            contador += 1; //Se errar as proximas validações fecha o sistema
            if (!clsUsu.ValidarLogin(txtEmail.Text, txtSenha.Text))
            {
                titulo();
                MessageBox.Show("Email e senha incorretos", "Validar ", MessageBoxButtons.OK, MessageBoxIcon.Error);
     
                return;
            }
            else
            {
                titulo();   
                //Se tudo der certo dale
                MessageBox.Show("Login feito com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
                dash.ShowDialog();
                this.Close();
                txtEmail.Clear();
                txtSenha.Clear();
                
            }

        }

        
        private void carregar()
        {
            string email = "E-mail";
            txtEmail.Text = email;
            string senha = "Senha";
            txtSenha.Text = senha;
           

        }

        private void mbtnRegistrar_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario cadastro = new frmCadastroUsuario();
            this.Hide();
            cadastro.ShowDialog();
            this.Close();
        }

        private void titulo()
        {
            // 1. Remove o texto padrão que o Material Skin joga na esquerda
            this.Text = "";

            // 2. Força o fundo do label a ser o Verde 800 exato da barra
            lblLogin.BackColor = Color.FromArgb(46, 125, 50);

            // 3. Garante que a letra fique branca e por cima de tudo
            lblLogin.ForeColor = Color.White;
            lblLogin.BringToFront();
            lblLogin.FontType = MaterialSkinManager.fontType.H5;
        }
    }
  
}

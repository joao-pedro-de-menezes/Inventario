using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin; // Biblioteca para temas Material Design
using MaterialSkin.Controls; // Bilioteca para controles Material Design

namespace Inventario
{
    public partial class frmDashboard : MaterialForm // Herdando de MaterialForm para usar os temas do Material Design
    {
        //Aqui é o seguinte, pra ficar mais organizado cria 2 variável uma string e uma int, porque uma guarda o número para o banco de dados e a outra guarda o nome de acordo com o número para o log
        public int tipoSelecao
        {
            get; private set;
        }

        public string tipoUsuSelecao
        {
            get; private set;
        }

        public string emailSelecao
        {
            get; private set;
        }

        // variável para o gerenciador de temas
        private readonly MaterialSkinManager materialSkinManager;

        public frmDashboard()
        {
            //Carregando o email para o dash
            this.emailSelecao = clsGuardarUsu.EmailGuardado;

            InitializeComponent();

            // Configuração do Gerenciador de Temas
            materialSkinManager = MaterialSkinManager.Instance;

            // Avisa ao Gerenciador para cuidar DESTE formulário, caso haja mais de um formulário, ele pode gerenciar todos viu EDHIN
            materialSkinManager.AddFormToManage(this);

            // Define o Tema (claro ou escuro) oque eu n achei nessessario, mas adicionei para caso queira futuramente
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Define a paleta de cores 
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Green800,       // Cor principal (Barra de título e abas superiores)
                Primary.Green900,       // Cor principal mais escura (usada em detalhes e sombras)
                Primary.Green500,       // Cor principal mais clara
                Accent.Green400,        // Cor de destaque (linhas de seleção, inputs focados)
                TextShade.WHITE         // Cor do texto que fica em cima das cores escuras (Branco)
            );

            // Configurações adicionais para o painel de menu para deixar certinho
            pnlMenu.BackColor = Color.FromArgb(27, 94, 32);
            pnlMenu.BringToFront();
      
        }

        private void frmDashboard_Load(object sender, EventArgs e) // Ajeitar pra ficar paralelo com os botões do menu !!!!!!!!
        {
            titulo();
            pnlSubEquipamentos.Location = new Point(168, 150); // Define a posição do submenu de equipamentos
            pnlSubLicencas.Location = new Point(168, 203); 
            pnlSubMaquinas.Location = new Point(168, 242);

            TipoUsu();
            //Log aqui é o log fazendo a magia negra
            clsLog.EscreverLog($"O usuário {tipoUsuSelecao} iniciou o sistema cujo email é {emailSelecao} ");

            //Aqui manda o email pro label la de cima da dash
            lblUsuarioLogado.Text = emailSelecao;

            // Garante que o texto do usuário fique por cima de tudo
            lblUsuarioLogado.BringToFront();
            carregarBtn();
      

        }

        //Aqui verifica o tipo do usuário pelo email ou seja ele puxa la
        //da tabela os valores que está lá e define aqui, tipo 0 é adm, 1 é n sei oq e bla bla
        private void TipoUsu()
        {
            clsUsuario usu = new clsUsuario();
            usu.Verifica_Tipo(emailSelecao);
            switch (tipoSelecao)
            {
                case 0:
                    tipoUsuSelecao = "Administrador";
                    mbtnAdmin.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mbtnAdmin_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario cadastro = new frmCadastroUsuario();
            this.Hide();
            cadastro.ShowDialog();
            this.Show();
        }

        

        private void EsconderSubMenus()
        {
            pnlSubEquipamentos.Visible = false;
            pnlSubLicencas.Visible = false;
            pnlSubMaquinas.Visible = false;
           // pnlSubConfig.Visible = false;
        }

        private void iconButtonCadastrarEquipamentos_Click(object sender, EventArgs e)
        {
      
        }

        private void iconButtonCadastrarLicencas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastroLi cadastroli = new frmCadastroLi();
            cadastroli.ShowDialog();
            this.Close();
        }

        private void iconButtonCadastrarMaquinas_Click(object sender, EventArgs e)
        {
            frmCadastroMa maq = new frmCadastroMa();
            maq.ShowDialog();
        }

        private void iconButtonExibirEquipamentos_Click(object sender, EventArgs e)
        {
            frmTelaEquipamentos telaEquipamentos = new frmTelaEquipamentos();
            this.Hide();
            telaEquipamentos.ShowDialog();
            this.Show();
        }

        private void iconButtonExibirLicencas_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButtonExibirMaquinas_Click(object sender, EventArgs e)
        {
            frmTelaMaquinas telaMaquinas = new frmTelaMaquinas();
            this.Hide();
            telaMaquinas.ShowDialog();
            this.Show();
        }

       

        private void mbtnLicenca_Click(object sender, EventArgs e)
        {
            bool EstavaAberto = pnlSubLicencas.Visible; // Verifica se o submenu já estava aberto
            EsconderSubMenus();

            if (EstavaAberto == false)
            {
                pnlSubLicencas.Visible = true;
                pnlSubLicencas.BringToFront(); // Trase o painel para a frente para garantir que ele fique visível
            }
            /* frmTelaLicencas telaLicencas = new frmTelaLicencas();
             this.Hide();
             telaLicencas.ShowDialog();
             this.Show();? */
        }

        private void mbtnMaquinas_Click(object sender, EventArgs e)
        {
            bool EstavaAberto = pnlSubMaquinas.Visible;
            EsconderSubMenus();

            if (EstavaAberto == false)
            {
                pnlSubMaquinas.Visible = true;
                pnlSubMaquinas.BringToFront();
            }
        }

        private void carregarBtn()
        {
            // Força os botões a irem para a frente do painel verde
            mbtnEquipamentos.BringToFront();
            mbtnLicenca.BringToFront();
            mbtnMaquinas.BringToFront();
            mbtnConfig.BringToFront();
            mbtnAdmin.BringToFront(); // O botão que já está aparecendo
        }

        private void mbtnEquipamentos_Click(object sender, EventArgs e)
        {
            bool EstavaAberto = pnlSubEquipamentos.Visible;
            EsconderSubMenus();

            if (EstavaAberto == false)
            {
                pnlSubEquipamentos.Visible = true;
                pnlSubEquipamentos.BringToFront();
            }
        }


        private void titulo()
        {
            // 1. Remove o texto padrão que o Material Skin joga na esquerda
            this.Text = "";

            // 2. Força o fundo do label a ser o Verde 800 exato da barra
            lblTitulo.BackColor = Color.FromArgb(46, 125, 50);
            lblUsuarioLogado.BackColor = Color.FromArgb(46, 125, 50);


            // 3. Garante que a letra fique branca e por cima de tudo
            lblUsuarioLogado.ForeColor = Color.White;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.BringToFront();
            lblTitulo.FontType = MaterialSkinManager.fontType.H5;
            lblUsuarioLogado.FontType = MaterialSkinManager.fontType.H6;
        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
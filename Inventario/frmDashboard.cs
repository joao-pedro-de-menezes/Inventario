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
               Primary.Indigo800,      // Cor principal (Barra de título) -> Azul um pouco mais claro para dar a divisória
               Primary.Indigo900,      // Cor principal escura
               Primary.Indigo500,      // Cor principal clara
               Accent.LightBlue200,    // Cor de destaque (botões, etc)
               TextShade.WHITE
            );

            // Configurações adicionais para o painel de menu para deixar certinho
            pnlMenu.BackColor = Color.FromArgb(26, 35, 126);
            pnlMenu.BringToFront();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            TipoUsu();
            //Log aqui é o log fazendo a magia negra
            clsLog.EscreverLog($"O usuário {tipoUsuSelecao} iniciou o sistema cujo email é {emailSelecao} ");

            //Aqui manda o email pro label la de cima da dash
            lblUsuarioLogado.Text = emailSelecao;

            // Garante que o texto do usuário fique por cima de tudo
            lblUsuarioLogado.BringToFront();
        }

        //Aqui verifica o tipo do usuário pelo email ou seja ele puxa la da tabela os valores que está lá e define aqui, tipo 0 é adm, 1 é n sei oq e bla bla
        private void TipoUsu()
        {
            clsUsuario usu = new clsUsuario();
            usu.Verifica_Tipo(emailSelecao);
            switch (tipoSelecao)
            {
                case 0:
                    tipoUsuSelecao = "Administrador";
                    break;

                default:
                    break;
            }
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonEquipamento_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButtonMaquinas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTelaMaquinas telaMaquinas = new frmTelaMaquinas();
            telaMaquinas.ShowDialog();
        }

        private void iconButtonLicencas_Click(object sender, EventArgs e)
        {
            frmTelaLicencas telaLicencas = new frmTelaLicencas();
            telaLicencas.ShowDialog();
            this.Hide(); 
        }
    }
}
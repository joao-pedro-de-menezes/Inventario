using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

            // Define a paleta de cores (Baseado no exempo da nossa imagem dashboard azul marinho)
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,   // Cor principal (Barra de título)
                Primary.BlueGrey900,   // Cor principal escura
                Primary.BlueGrey500,   // Cor principal clara
                Accent.LightBlue200,   // Cor de destaque (botões, etc)
                TextShade.WHITE      // Cor do texto na barra de título
            );
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            TipoUsu();
            //Log aqui é o log fazendo a magia negra
            clsLog.EscreverLog($"O usuário {tipoUsuSelecao} iniciou o sistema cujo email é {emailSelecao} ");
            //Aqui manda o email pro label la de cima da dash
            lblUsuarioLogado.Text = emailSelecao;
          
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
    }
}
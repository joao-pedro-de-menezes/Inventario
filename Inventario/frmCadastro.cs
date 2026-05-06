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
using System.Web.UI.Design.Directives;
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
                Primary.Orange800,   // Cor principal (Barra de título)
                Primary.Orange900,   // Cor principal escura
                Primary.Orange500,   // Cor principal clara
                Accent.Orange700,   // Cor de destaque (botões, etc)
                TextShade.WHITE        // Cor do texto na barra de título
                );

            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            //tag para iniciar ja o botão como novo
            mbtnCadastrar_Atualizar.Tag = "Novo";
            mcmbTipo.Items.Add("ADMIN");
            mcmbTipo.Items.Add("CEO");
            mcmbTipo.Items.Add("PRESITENTE");
            mcmbTipo.Items.Add("DIRETOR");
            mcmbTipo.Items.Add("SUPERVISOR");
            mcmbTipo.Items.Add("ANALISTA");
            mcmbTipo.Items.Add("ASSISTENTE");
            mcmbTipo.Items.Add("AUXILIAR");
            mcmbTipo.Items.Add("APRENDIZ");
            mcmbTipo.Items.Add("");
            mcmbTipo.SelectedIndex = 9;


        }

        private void mbtnCadastrar_Atualizar_Click(object sender, EventArgs e)
        {
            //Definindo os valores das variáveis



            //btn cadastrar verificações
            if (string.IsNullOrEmpty(mtxtNome.Text))
            {
                MessageBox.Show("O nome do usuário deve ser preenchido", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtxtNome.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(mtxtEmail.Text))
            {
                MessageBox.Show("O Email do usuário deve ser preenchido", "Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtxtEmail.Focus();
                return;


            }
            else if (string.IsNullOrEmpty(mtxtCracha.Text) || mtxtCracha.Text == "0")
            {
                MessageBox.Show("O crachá do usuário deve ser preenchido ou maior que 0", "Cracha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtxtCracha.Focus();
                return;

            }
            else if (string.IsNullOrEmpty(mtxtSenha.Text))
            {
                MessageBox.Show("A senha do usuário deve ser preenchida", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtxtSenha.Focus();
                return;

            }
            else if (mtxtSenha.Text != mtxtConfirmaSenha.Text)
            {
                MessageBox.Show("As senhas devem ser iguais", "Senhas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtxtConfirmaSenha.Focus();
                return;
            }
            // Se tudo estiver certo vai pra cá
            if (MessageBox.Show("Deseja realmente salvar este usuário?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    clsUsuario usuario = new clsUsuario();
                    usuario.SalvarUsu(mtxtNome.Text, mtxtEmail.Text, Convert.ToInt32(mtxtCracha.Text), mtxtSenha.Text, Convert.ToInt16(mcmbTipo.SelectedIndex));
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK);
                    resetar();
                    mtxtNome.Focus();
                    

                }
              
               catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar usuário {ex}", "SalvarUsu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw;
                }

            }






        }
          
        private void mtxtCracha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aqui é pra toda vez que o usuário tentar colocar letras no trem ele da erro porque o crachá tem q ser números
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Bloqueia a tecla (isso impede vírgula, ponto, letras e símbolos)
                e.Handled = true;

                // Exibe o aviso para o usuário
                MessageBox.Show("O crachá deve conter apenas números.", "Crachá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void resetar()
        {
            //Método resetar
            foreach (Control ctl in grbDados.Controls)
            {
                if (ctl is MaterialTextBox) ctl.Text = "";
            }
            mcmbTipo.SelectedIndex = 9;
        }

        private void mbtnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}

// 
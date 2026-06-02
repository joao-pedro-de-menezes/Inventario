using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.Directives;
using System.Windows.Forms;

namespace Inventario
{
    public partial class frmCadastroUsuario : MaterialForm
    {
        //Variáveis de texto
        string Temail = "Digite o Email";
        string Tnome = "Digite o Nome";
        string Tcracha = "Digite o Crachá";
        string Tsenha = "Digite a Senha";
        string TconfirmS = "Confirme a Senha";


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

            //Agora usar aqui os método clsLimparCampos
            carregar();
           


        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            //tag para iniciar ja o botão como novo
            mbtnCadastrar_Atualizar.Tag = "Novo";
            mradioInativo.Enabled = false;
            txtCodigo.Visible = false;
            carregarCmb();

            // ehdin é gay, mas é o melhor programador do mundo, então ele tem que ser mencionado aqui
        }

        private void mbtnCadastrar_Atualizar_Click(object sender, EventArgs e)
        {

            //btn cadastrar verificações
            if (string.IsNullOrEmpty(mtxtNome.Text) || mtxtNome.Text == Tnome)
            {
                MessageBox.Show("O nome do usuário deve ser preenchido", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtxtNome.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(mtxtEmail.Text) || mtxtEmail.Text == Temail)
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
            else if (string.IsNullOrEmpty(mtxtSenha.Text) || mtxtSenha.Text == Tsenha)
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

            //tag NOVO
            if (Convert.ToString(mbtnCadastrar_Atualizar.Tag) == "Novo")
            {
                if (MessageBox.Show("Deseja realmente salvar este usuário?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                    try
                    {
                        clsUsuario usuario = new clsUsuario();
                        usuario.SalvarUsu(mtxtNome.Text, mtxtEmail.Text, Convert.ToInt32(mtxtCracha.Text), mtxtSenha.Text, Convert.ToInt16(mcmbTipo.SelectedIndex));
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK);
                        resetar();
                        mtxtNome.Focus();
                        carregar();
                        carregarCmb();


                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao salvar usuário {ex}", "SalvarUsu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        throw;
                    }
                }
            } //tag Editar
            else
            {
                if(Convert.ToString(mbtnCadastrar_Atualizar.Tag) == "Editar"){

                    if (MessageBox.Show("Deseja realmente editar este usuário?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        //Aqui define se ele vai ser A ou I
                        string situacao = "";
                        if (mradioAtivo.Checked)
                        {
                            situacao = "A";
                        } else if (mradioInativo.Checked)
                        {
                            situacao = "I";
                        }

                        try
                        {
                            //Método padrão para editar
                            clsUsuario usuario = new clsUsuario();
                            usuario.EditarUsu( Convert.ToInt32(txtCodigo.Text), mtxtNome.Text, mtxtEmail.Text, Convert.ToInt32(mtxtCracha.Text), mtxtSenha.Text, situacao, Convert.ToInt16(mcmbTipo.SelectedIndex));
                            MessageBox.Show("Usuário Editado com sucesso!", "Editar", MessageBoxButtons.OK);
                            resetar();

                            //Aqui é se tudo der certo ele carrega os txt tudo denovo e limpa os campos
                            mtxtNome.Focus();
                            carregar();
                            carregarCmb();

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao editar usuário {ex}", "EditarUsu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            throw;
                        }
                    }
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
            frmDashboard dash = new frmDashboard();
            this.Hide();
            dash.ShowDialog();
            this.Close();
        }

        

        private void mbtnPesquisar_Click(object sender, EventArgs e)
        {
           
            // O unico jeito que eu achei pra arrumar o bug de cores é fazer a tela anterior esconder quando a nova tela abrir
            this.Hide();
         
            using (frmPesquisaU pesquisa = new frmPesquisaU())
            {
                string situacao = "";
                if (mradioAtivo.Checked)
                {
                    situacao = "A";
                }
                else if (mradioInativo.Checked)
                {
                    situacao = "I";
                }

                if (pesquisa.ShowDialog() == DialogResult.OK)
                {
                   
                    mradioInativo.Enabled = true;
                    txtCodigo.Text = Convert.ToInt16(pesquisa.codigoSelecao).ToString();
                    mtxtNome.Text = pesquisa.nomeSelecao.ToString();
                    mtxtEmail.Text = pesquisa.emailSelecao.ToString();
                    mtxtCracha.Text = Convert.ToInt32(pesquisa.crachaSelecao).ToString();
                    situacao = pesquisa.situacaoSelecao.ToString();
                    mcmbTipo.SelectedIndex = Convert.ToInt16(pesquisa.tipoSelecao);
                    mtxtConfirmaSenha.Text = pesquisa.senhaSelecao.ToString();
                    mtxtSenha.Text = pesquisa.senhaSelecao.ToString();

                    txtCodigo.Visible = true;
                    mbtnCadastrar_Atualizar.Text = "Editar";
                    mbtnCadastrar_Atualizar.Tag = "Editar";

                }
            }
            // Porem assim que a tela for voltar temos que devolver os valores de cor para dar tudo certo
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Orange800,
                Primary.Orange900,
                Primary.Orange500,
                Accent.Orange700,
                TextShade.WHITE
            );

            this.Show(); // e mostramos a tela de cadastro novamente


            



        }
        public void carregar()
        {
            //Método para reutilizar a bagaça
            if (string.IsNullOrEmpty(mtxtNome.Text))
            {
                nomes();
                mtxtNome.LimparBtns(Tnome);
                mtxtEmail.LimparBtns(Temail);
                mtxtCracha.LimparBtns(Tcracha);
                mtxtSenha.LimparBtns(Tsenha);
                mtxtConfirmaSenha.LimparBtns(TconfirmS);
                lblCodig.Visible = false;
                txtCodigo.Visible = false;
                mbtnCadastrar_Atualizar.Text = "Cadastrar";
                mradioAtivo.Checked = true;
                mradioInativo.Enabled = false;

            }
        }


        private void nomes()
        {
            string Temail = "Digite o Email";
            mtxtEmail.Text = Temail;
            string Tnome = "Digite o Nome";
            mtxtNome.Text = Tnome;
            string Tcracha = "Digite o Crachá";
            mtxtCracha.Text = Tcracha;
            string Tsenha = "Digite a Senha";
            mtxtSenha.Text = Tsenha;
            string TconfirmS = "Confirme a senha";
            mtxtConfirmaSenha.Text = TconfirmS;
            string Selecione = "Selecione o tipo do Usuário";
            mcmbTipo.Text = Selecione;
        }
        private void carregarCmb()
        {
            mcmbTipo.Text = "Teste";
            mcmbTipo.Items.Add("ADMIN");
            mcmbTipo.Items.Add("CEO");
            mcmbTipo.Items.Add("PRESITENTE");
            mcmbTipo.Items.Add("DIRETOR");
            mcmbTipo.Items.Add("SUPERVISOR");
            mcmbTipo.Items.Add("LIDER");
            mcmbTipo.Items.Add("ANALISTA");
            mcmbTipo.Items.Add("ASSISTENTE");
            mcmbTipo.Items.Add("AUXILIAR");
            mcmbTipo.Items.Add("APRENDIZ");
            mcmbTipo.Items.Add("");
            mcmbTipo.SelectedIndex = 10;
        }
    }
}

// João <-- Fazer a tela cadastro ficar com o visual laranja, deixar a tela de login com uma cor diferente e criar uma tela de Cadastro pra cada cadastro
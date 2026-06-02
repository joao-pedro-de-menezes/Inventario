using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class frmCadastroLi : MaterialForm
    {
        //Variaveis nomes
        string Tlicenca = "Tipo Licença";
        string Tnumero = "Número Licença";

        private readonly MaterialSkinManager materialSkinManager;
        public frmCadastroLi()
        {
            

            materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE
                );
            InitializeComponent();
            carregar();
        }

        private void frmCadastroLi_Load(object sender, EventArgs e)
        {
            // 1. Diz que o tamanho das abas será fixo
            tabCntrCadastro.SizeMode = TabSizeMode.Fixed;
            // 2. Define a largura e a altura das abas para ZERO (0, 1) Isso faz com que os cabeçalhos fiquem invisíveis/escondidos na 
            tabCntrCadastro.ItemSize = new Size(0, 1);
            mbtnCadastrar.Tag = "Novo";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mbtnPesquisar_Click(object sender, EventArgs e)
        {
            tabCntrCadastro.SelectedIndex = 0;
        }


        //Metodo para os campos do cadastro
        public void carregar()
        {
            if (string.IsNullOrEmpty(txtNumeroLicenca.Text))
            {
                txtTipoLicenca.LimparBtns(Tlicenca);
                txtNumeroLicenca.LimparBtns(Tnumero);
                mbtnCadastrar.Text = "Cadastrar";
                mRadioAtivo.Checked = true;
                mRadioInativo.Enabled = false;
                lblCodigo.Visible = false;
                txtCodigo.Visible = false;
            }
        }

        private void mbtnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipoLicenca.Text) || txtTipoLicenca.Text == Tlicenca)
            {
                MessageBox.Show("O tipo da licença deve ser preenchido", "Tipo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTipoLicenca.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtNumeroLicenca.Text) || txtNumeroLicenca.Text == Tnumero)
            {
                MessageBox.Show("O número da Licença deve ser preenchido", "Numero", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumeroLicenca.Focus();
                return;
            }
            else if (mskAtivacao.Text == "  /  /")
            {
                MessageBox.Show("A data da ativação deve ser preenchida", "ativação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskAtivacao.Focus();
            }
            else if (!DateTime.TryParse(mskAtivacao.Text, out DateTime dataAtivacao))
            {
                MessageBox.Show("A data da ativação deve ser válida, verifique as datas", "ativação válida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskVencimento.Focus();
            }
            else if (mskVencimento.Text == "  /  /")
            {
                MessageBox.Show("A data da vencimento deve ser preenchida", "vencimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskVencimento.Focus();
            }
            else if (!DateTime.TryParse(mskVencimento.Text, out DateTime dataVencimento))
            {
                MessageBox.Show("A data de vencimento deve ser válida, verifique as datas", "ativação válida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskVencimento.Focus();
            }
            else if (dataVencimento <= dataAtivacao)
            {
                MessageBox.Show("A data de vencimento deve ser maior que a data de ativação, verifique as datas", "maior válida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskVencimento.Focus();
            }



            //Cadastrar se a tag for novo
            if (Convert.ToString(mbtnCadastrar.Tag) == "Novo")
            {
                if ((MessageBox.Show("Deseja realmente salvar esta licença?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                {
                    try
                    {
                        clsLicenca licenca = new clsLicenca();
                        licenca.SalvarLicenca(txtTipoLicenca.Text, Convert.ToInt32(txtNumeroLicenca.Text), Convert.ToDateTime(mskAtivacao.Text), Convert.ToDateTime(mskVencimento.Text));
                        resetar();
                        MessageBox.Show("Licença Cadastrado com sucesso!", "SalvLicença", MessageBoxButtons.OK);
                        carregar();
                        txtLicencaP.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao salvar Licença {ex}", "SalvarLi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        throw;
                    }

                }
                
            }
          
        }

        private void resetar()
        {
            //Método resetar
            foreach (Control ctl in grbCampos.Controls)
            {
                if (ctl is MaterialTextBox)
                    ctl.Text = "";
                if (ctl is MaterialMaskedTextBox)
                    ctl.Text = "  /  /";
            }
        }

        private void txtNumeroLicenca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Bloqueia a tecla (isso impede vírgula, ponto, letras e símbolos)
                e.Handled = true;

                // Exibe o aviso para o usuário
                MessageBox.Show("O Numero da licença não pode conter letras.", "NumeroLi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void mbPesquisar_Click(object sender, EventArgs e)
        {
            //ACABAR DE FAZER
            clsLicenca licenca = new clsLicenca();
            dgvLicenca.DataSource = licenca.PesquisaTodos();

        }
    }
}

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
using System.Windows.Forms.VisualStyles;

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
                Primary.Green800,       // Cor principal (Barra de título e abas superiores)
                Primary.Green900,       // Cor principal mais escura (usada em detalhes e sombras)
                Primary.Green500,       // Cor principal mais clara
                Accent.Green400,        // Cor de destaque (linhas de seleção, inputs focados)
                TextShade.WHITE         // Cor do texto que fica em cima das cores escuras (Branco)
                );
            InitializeComponent();
            carregar();
        }

        private void frmCadastroLi_Load(object sender, EventArgs e)
        {
            // 1. Diz que o tamanho das abas será fixo
            tabCntrCadastro.SizeMode = TabSizeMode.Fixed;
            // 2. Define a largura e a altura das abas para ZERO (0, 1) Isso faz com que os cabeçalhos fiquem invisíveis/escondidos na interface
            tabCntrCadastro.ItemSize = new Size(0, 1);
            mbtnCadastrar.Tag = "Novo";

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
                        licenca.SalvarLicenca(txtTipoLicenca.Text, (txtNumeroLicenca.Text), Convert.ToDateTime(mskAtivacao.Text), Convert.ToDateTime(mskVencimento.Text), "A");
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
            else if(Convert.ToString(mbtnCadastrar.Tag) == "Editar")
            {

                string situacao = "";
                if (mRadioAtivo.Checked)
                {
                    situacao = "A";
                }
                else if (mRadioInativo.Checked)
                {
                    situacao = "I";
                }
                try
                {
                    if (MessageBox.Show("Deseja realmente editar esta licença?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        clsLicenca licenca = new clsLicenca();
                        licenca.EditarLicenca(Convert.ToInt32(txtCodigo.Text), txtTipoLicenca.Text.ToString(), (txtNumeroLicenca.Text), Convert.ToDateTime(mskAtivacao.Text), Convert.ToDateTime(mskVencimento.Text), Convert.ToString(situacao));
                        MessageBox.Show("Licença Alterada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        resetar();
                        carregar();
                        dgvLicenca.DataSource = null;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar Licença {ex}", "EditarLi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw;
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

            mRadioInativo.Enabled = false;
            txtCodigo.Visible = false;
            txtCodigo.Visible = false;
            mbtnCadastrar.Tag = "Novo";
            mbtnCadastrar.Text = "Cadastrar";
        }

        private void txtNumeroLicenca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // devemos utilizar o IsLetterOrDigit para permitir letras e números, a licença pode ter os dois
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-') 
            {
                // Bloqueia a tecla (isso impede tudo aquilo que não colocamos no if acima)
                e.Handled = true;

                // Exibe o aviso para o usuário
                MessageBox.Show("A licença deve conter apenas letras, números e traços (-).", "NumeroLi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void mbPesquisar_Click(object sender, EventArgs e)
        {
            //ACABAR DE FAZER
            clsLicenca licenca = new clsLicenca();
            if (!string.IsNullOrEmpty(txtCodigoP.Text))
            {
                dgvLicenca.DataSource = licenca.PesquisaCodigo(Convert.ToInt16(txtCodigoP.Text));
                txtCodigoP.Focus();
                return;
             
            }
            else if (!string.IsNullOrEmpty(txtNumeroSerieP.Text))
            {
                dgvLicenca.DataSource = licenca.PesquisaNumero(txtNumeroSerieP.Text);
                
            }
            else if (!string.IsNullOrEmpty(txtLicencaP.Text))
            {
                dgvLicenca.DataSource = licenca.PesquisaTipo(txtLicencaP.Text);
            }
            else if (mskAtivacaoP.MaskCompleted && !mskVencimentoP.MaskCompleted)
            {
                MessageBox.Show("Para fazer a pesquisa de data, a ativação e o vencimento devem ser preenchidas");
            }
            else if (mskAtivacaoP.MaskCompleted && mskVencimentoP.MaskCompleted)
            {
                dgvLicenca.DataSource = licenca.PesquisaData(Convert.ToDateTime(mskAtivacaoP.Text), Convert.ToDateTime(mskVencimentoP.Text));
            }
            else
            {
                if (MessageBox.Show("Nenhum parâmetro foi colocado deseja fazer uma pesquisa geral?", "Parametro", MessageBoxButtons.YesNo , MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dgvLicenca.DataSource = licenca.PesquisaTodos();
                }
            }
           
                

        }

        private void txtNumeroSerieP_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("O Número da licença deve conter apenas letras, números e traços (-).", "NumeroLi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    
        private void txtCodigoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Bloqueia a tecla (isso impede vírgula, ponto, letras e símbolos)
                e.Handled = true;

                // Exibe o aviso para o usuário
                MessageBox.Show("O código não pode conter letras.", "NumeroLi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dgvLicenca_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(dgvLicenca.CurrentRow.Cells[0].Value) > 0)
                {
                    mRadioInativo.Enabled = true;
                    tabCntrCadastro.SelectedIndex = 1;

                    txtCodigo.Text = Convert.ToString(dgvLicenca.CurrentRow.Cells[0].Value);
                    txtTipoLicenca.Text = Convert.ToString(dgvLicenca.CurrentRow.Cells[1].Value);
                    txtNumeroLicenca.Text = Convert.ToString(dgvLicenca.CurrentRow.Cells[2].Value);
                    mskAtivacao.Text = Convert.ToString(dgvLicenca.CurrentRow.Cells[3].Value);
                    mskVencimento.Text = Convert.ToString(dgvLicenca.CurrentRow.Cells[4].Value);

                
                    string situacao = dgvLicenca.CurrentRow.Cells[5].Value.ToString();
                    if (situacao == "A")
                    {
                        mRadioAtivo.Checked = true;
                    }
                    
                    else if (situacao == "I")
                    {
                        mRadioInativo.Checked = true;
                    }

                    mbtnCadastrar.Text = "Editar";
                    mbtnCadastrar.Tag = "Editar";
                    txtCodigo.Visible = true;

                }
               

            }
            catch (Exception ex )
            {
                MessageBox.Show($"ERRO, {ex}");
                throw;
            }
        }

        private void mbtnCancelar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Cancelar? (Alterará todos os campos para o padrão)","Cancelar",  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                resetar();
                carregar();
                dgvLicenca.DataSource = null;
            }
           
        }

        private void mbVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastroLi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}

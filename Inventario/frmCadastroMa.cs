using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class frmCadastroMa : MaterialForm
    {

        string Tfrente = "Digite a Frente";
        string Tfrota = "Digite a Frota";
        string Tobs = "Digite a observação";


        private readonly MaterialSkinManager materialSkinManager;
        public frmCadastroMa()
        {
            InitializeComponent();

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
        }

        private void frmCadastroMa_Load(object sender, EventArgs e)
        {
            mbtnCadastrar_Atualizar.Tag = "Novo";
            mRadioInativo.Checked = false;
            txtCodigo.Visible = false;
            carregarCmb();
            carregar();

        }

        private void mbtnCadastrar_Click(object sender, EventArgs e)
        {
            //Validações da FROTA
            if (string.IsNullOrWhiteSpace(mtxtFrota.Text) || mtxtFrota.Text == Tfrota)
            {
                MessageBox.Show("O campo Frota é obrigatório.", "Frota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtFrota.Focus();
                return;
            }
            else if (!mtxtFrota.Text.All(char.IsDigit)) //Verifica se o usuario colou letras com o CTRL V 
            {
                MessageBox.Show("O campo Frota só aceita números inteiros (Ex: 102).", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtFrota.Focus();
                return;
            }

            //Validações da FRENTE 
            else if (string.IsNullOrWhiteSpace(mtxtFrente.Text) || mtxtFrente.Text == Tfrente)
            {
                MessageBox.Show("O campo Frente é obrigatório.", "Frente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtFrente.Focus();
                return;
            }
            else if (!mtxtFrente.Text.All(char.IsDigit))
            {
                MessageBox.Show("O campo Frente só aceita números inteiros.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtFrente.Focus();
                return;
            }

            //Validação do TIPO 
            else if (mcmbTipo.SelectedIndex == -1 || mcmbTipo.SelectedIndex == 5)
            {
                MessageBox.Show("Por favor, selecione uma opção válida no ComboBox.", "Opção Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mcmbTipo.Focus();
                return;
            }

            //tag Novo
            if (Convert.ToString(mbtnCadastrar_Atualizar.Tag) == "Novo")
            {
                if (MessageBox.Show("Deseja realmente salvar esta máquina?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        clsMaquina maquina = new clsMaquina();
                        maquina.SalvarMaquina(
                            Convert.ToInt32(mtxtFrota.Text),
                            mcmbTipo.SelectedIndex.ToString(),
                            "A",
                            Convert.ToInt32(mtxtFrente.Text),
                            txtObservacao.Text
                            );
                        resetar();
                        MessageBox.Show("Máquina cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        carregar();
                        mtxtFrota.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao salvar Máquina {ex}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        throw;
                    }
                }
            }
            else
            {
                if (Convert.ToString(mbtnCadastrar_Atualizar.Tag) == "Editar")
                {
                    if (MessageBox.Show($"Deseja realmente editar Máquina?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                            clsMaquina maquina = new clsMaquina();
                            
                            maquina.EditarMaquina(
                                Convert.ToInt32(txtCodigo.Text),
                                Convert.ToInt32(mtxtFrota.Text),
                                mcmbTipo.SelectedIndex.ToString(),
                                situacao,
                                Convert.ToInt32(mtxtFrente.Text),
                                txtObservacao.Text
                                );
                            resetar();
                            MessageBox.Show("Máquina editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            carregar();
                            mtxtFrota.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao editar Máquina {ex}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            throw;
                        }
                    }
                }
            }
        }




        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxtFrota_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
                MessageBox.Show("A Frota deve ter apenas numeros inteiros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mtxtFrente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Frente deve ter apenas numeros inteiros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFrotaP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Frota deve ter apenas numeros inteiros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFrenteP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Frente deve ter apenas numeros inteiros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mbVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastroMa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void resetar()
        {
            //Método resetar
            foreach (Control ctl in grbCampos.Controls)
            {
                if (ctl is MaterialTextBox)
                    ctl.Text = "";

            }

            mRadioInativo.Enabled = false;
            txtCodigo.Visible = false;
            txtCodigo.Visible = false;
            mbtnCadastrar_Atualizar.Tag = "Novo";
            mbtnCadastrar_Atualizar.Text = "Cadastrar";
        }

        public void carregar()
        {
            if (string.IsNullOrEmpty(mtxtFrota.Text))
            {
                mtxtFrente.LimparBtns(Tfrente);
                mtxtFrota.LimparBtns(Tfrota);
                txtObservacao.LimparBtns(Tobs);
                mbtnCadastrar_Atualizar.Text = "Cadastrar";
                mRadioAtivo.Checked = true;
                mRadioInativo.Enabled = false;
                lblCodigo.Visible = false;
                txtCodigo.Visible = false;
            }
        }

        private void carregarCmb()
        {
            mcmbTipo.Text = "Teste";
            mcmbTipo.Items.Add("BOMBEIRO");
            mcmbTipo.Items.Add("VINHAÇA");
            mcmbTipo.Items.Add("CAMINHÃO CANA");
            mcmbTipo.Items.Add("TRATOR");
            mcmbTipo.Items.Add("COLHEDORA");
            mcmbTipo.Items.Add("");
            mcmbTipo.SelectedIndex = 5;
        }

        private void mbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbtnPesquisar_Click(object sender, EventArgs e)
        {
            tabCntrCadastro.SelectedIndex = 0;
        }

        private void mbPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                string situacao = "";
                if (checkAtivo.Checked)
                {
                    situacao = "A";
                }
                else if (checkInativo.Checked)
                {
                    situacao = "I";
                }
                clsMaquina maquina = new clsMaquina();

                bool tudoVazio = string.IsNullOrEmpty(txtCodigoP.Text) &&
                         string.IsNullOrEmpty(txtFrotaP.Text) &&
                         string.IsNullOrEmpty(txtTipoMaquinaP.Text) &&
                         string.IsNullOrEmpty(txtFrenteP.Text) &&
                         !checkAtivo.Checked &&
                         !checkInativo.Checked;
                if (tudoVazio)
                {
                    // Se não digitou nada, pergunta se quer ver tudo
                    if (MessageBox.Show("Nenhum parâmetro foi colocado. Deseja fazer uma pesquisa geral?", "Pesquisa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dgvMaquinas.DataSource = maquina.PesquisaTodos();
                        FormatarGrid();
                    }
                    return; // O 'return' faz o código parar aqui se ele entrou neste IF
                }
                else
                {
                    dgvMaquinas.DataSource = maquina.PesquisaAvancada(txtCodigoP.Text, txtFrotaP.Text, txtTipoMaquinaP.Text, txtFrenteP.Text, situacao);
                }
                FormatarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao pesquisar máquina {ex}", "PesquisaMa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mtxtFrota_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMaquinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void FormatarGrid()
        {
            if (dgvMaquinas.Columns.Count > 0)
            {
                dgvMaquinas.Columns["ID"].HeaderText = "Código";
                dgvMaquinas.Columns["NumeroFrota"].HeaderText = "Nº da Frota";
                dgvMaquinas.Columns["TipoMaquina"].HeaderText = "Equipamento";
                dgvMaquinas.Columns["Situacao"].HeaderText = "Status";
                dgvMaquinas.Columns["Frente"].HeaderText = "Frente";
                dgvMaquinas.Columns["Observacao"].HeaderText = "Observações";

                // AllCells faz com que a coluna se ajuste ao tamanho do conteúdo.
                dgvMaquinas.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvMaquinas.Columns["Situacao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Fill faz todas as colunas pegarem um espaço igual.
                dgvMaquinas.Columns["NumeroFrota"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvMaquinas.Columns["TipoMaquina"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvMaquinas.Columns["Frente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvMaquinas.Columns["Observacao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dgvMaquinas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(dgvMaquinas.CurrentRow.Cells[0].Value) > 0)
                {
                    mRadioInativo.Enabled = true;
                    tabCntrCadastro.SelectedIndex = 1;

                    txtCodigo.Text = Convert.ToString(dgvMaquinas.CurrentRow.Cells[0].Value);
                    mtxtFrota.Text = Convert.ToString(dgvMaquinas.CurrentRow.Cells[1].Value);
                    mcmbTipo.Text = Convert.ToString(dgvMaquinas.CurrentRow.Cells[2].Value);
                    mtxtFrente.Text = Convert.ToString(dgvMaquinas.CurrentRow.Cells[4].Value);
                    txtObservacao.Text = Convert.ToString(dgvMaquinas.CurrentRow.Cells[5].Value);


                    string situacao = dgvMaquinas.CurrentRow.Cells[3].Value.ToString();
                    if (situacao == "A")
                    {
                        mRadioAtivo.Checked = true;
                    }

                    else if (situacao == "I")
                    {
                        mRadioInativo.Checked = true;
                    }

                    mbtnCadastrar_Atualizar.Text = "Editar";
                    mbtnCadastrar_Atualizar.Tag = "Editar";
                    txtCodigo.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERRO, {ex}");
                throw;
            }
        }
    }
}

    

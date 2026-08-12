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
using System.Windows.Forms;

namespace Inventario
{
    public partial class frmCadastroEq : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        string Ttipo = "Tipo Equipamento";
        string Tnumero = "Número de Serie";
        string Tmarca = "Marca do Equipamento";


        public frmCadastroEq()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE
            );
        }

        private void frmCadastroEq_Load(object sender, EventArgs e)
        {
            mbtnCadastrar.Tag = "Novo";
            txtCodigoLi.Visible = false;
            mtxtFrente.Visible = false;
            txtNumeroLicenca.Visible = false;

            mSwithLi.Checked = false;
            dgvLi.Enabled = false;
            mTxtPesquisa.Enabled = false;
            mbtnPesquisarLi.Enabled = false;
            carregarCmb();
            resetar();
            
        }

        private void mbtnCadastrar_Click(object sender, EventArgs e)
        {
            double valorEquipamento;
            // ==========================================
            // VALIDAÇÕES OBRIGATÓRIAS
            // ==========================================
            if (txtTipoEquipamento.Text == Ttipo)
            {
                MessageBox.Show("O campo Tipo de Equipamento é obrigatório.", "Tipo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoEquipamento.Focus();
                return;
            }

         if (txtNumeroSerie.Text == Tnumero)
            {
                MessageBox.Show("O Número de Série é obrigatório.", "N° Série", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroSerie.Focus();
                return; 
            }

            // Validação blindada do Valor
         if (!double.TryParse(txtValor.Text, out valorEquipamento))
            {
                MessageBox.Show("O campo Valor deve conter apenas números válidos.", "Valor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return;
            }
         if (cmbSituacao.SelectedIndex == 4)
            {
                MessageBox.Show("Você deve selecioanr a situação", "Situação Obrigatória", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSituacao.Focus();
                return; 
            }
         

            // Validação da Licença Obrigatória (Se a chavinha estiver ligada)
            if (mSwithLi.Checked == true)
            {
                // Verifica se a caixinha que recebe o clique do grid está vazia
                if (string.IsNullOrEmpty(txtNumeroLicenca.Text))
                {
                    MessageBox.Show("Você marcou que o equipamento tem licença. Por favor, pesquise e selecione uma licença no grid (dando um duplo clique) antes de salvar!", "Licença Obrigatória", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mTxtPesquisa.Focus();
                    return; // Para o código aqui e não deixa salvar
                }
            }

            // ==========================================
            // SALVAR / EDITAR
            // ==========================================
            if (Convert.ToString(mbtnCadastrar.Tag) == "Novo")
            {
                if (MessageBox.Show("Deseja realmente salvar este equipamento?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        clsEquipamentoGeral equipamento = new clsEquipamentoGeral();

                        equipamento.SalvarEquipamento(
                            txtTipoEquipamento.Text,
                            txtNumeroSerie.Text,
                            txtMarca.Text, // Deixando vazio por enquanto até você criar a caixinha de Marca
                            ObterLetraSituacao(cmbSituacao.Text),
                            valorEquipamento,
                            txtCodigoLi.Text,
                            txtNumeroLicenca.Text
                        );
                        

                        resetar();
                        MessageBox.Show("Equipamento cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao salvar Equipamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (Convert.ToString(mbtnCadastrar.Tag) == "Editar")
            {
                if (MessageBox.Show("Deseja realmente editar este equipamento?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    try
                    {
                        clsEquipamentoGeral equipamento = new clsEquipamentoGeral();
                        equipamento.EditarEquipamento(
                            Convert.ToInt32(mtxtCodigo.Text),
                            txtTipoEquipamento.Text,
                            txtNumeroSerie.Text,
                            txtMarca.Text,
                            ObterLetraSituacao(cmbSituacao.Text),
                            valorEquipamento,
                            txtCodigoLi.Text,
                            txtNumeroLicenca.Text
                            
                        );

                        resetar();
                        MessageBox.Show("Equipamento editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao editar Equipamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void resetar()
        {
            // Limpa as Caixas de Texto Normais
            foreach (Control ctl in grbCampos.Controls)
            {
                if (ctl is MaterialTextBox)
                    ctl.Text = "";
            }
            txtCodigoLi.Visible = false;
            lblCodigo.Visible = false;
            txtCodigoLi.Visible = false;
            mtxtFrente.Visible = false;
            txtNumeroLicenca.Visible = false;

            mbtnCadastrar.Tag = "Novo";
            mbtnCadastrar.Text = "Cadastrar";

            mSwithLi.Checked = false;
            dgvLi.Enabled = false;
            mTxtPesquisa.Enabled = false;
            mbtnPesquisarLi.Enabled = false;

            cmbSituacao.SelectedIndex = 4;
            cmbSituacaoP.SelectedIndex = 4;

            txtTipoEquipamento.LimparBtns(Ttipo);
            txtNumeroSerie.LimparBtns(Tnumero);
            txtMarca.LimparBtns(Tmarca);
            mtxtCodigo.Visible = false;

            dgvLi.DataSource = null;

        }

        private void mbtnCancelar_Click(object sender, EventArgs e)
        {
            resetar();
        }

        private void txtNumeroLicenca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Deixe em branco se a licença puder receber letras e números.
        }

        private void mbtnPesquisar_Click(object sender, EventArgs e)
        {
            // Botão "Pesquisar" da aba de Opções (Muda para a aba de Seleção)
            tabCntrCadastro.SelectedIndex = 0;
        }

        private void mbVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                clsEquipamentoGeral equipamento = new clsEquipamentoGeral();

                // Verificando os campos da aba de pesquisa de equipamentos
                bool tudoVazio = string.IsNullOrEmpty(txtCodigoP.Text) &&
                                 string.IsNullOrEmpty(txtNSerieP.Text) &&
                                 string.IsNullOrEmpty(cmbTipoP.Text) &&
                                 string.IsNullOrEmpty(txtValorP.Text) &&
                                 string.IsNullOrEmpty(cmbSituacaoP.Text) &&
                                 string.IsNullOrEmpty(txtMarca.Text);

                if (tudoVazio)
                {
                    // Se não digitou nada, pergunta se quer ver tudo
                    if (MessageBox.Show("Nenhum parâmetro foi colocado. Deseja fazer uma pesquisa geral?", "Pesquisa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dgvEquipamentos.DataSource = equipamento.PesquisaTodos();
                        FormatarGrid();
                    }
                    return; // O 'return' faz o código parar aqui se ele entrou neste IF
                }
                else
                {
                    // Transforma "Em Campo" na letra "C" para a pesquisa funcionar no banco
                    string letraSituacao = ObterLetraSituacao(cmbSituacaoP.Text);

                    // Chama a pesquisa avançada passando os 7 parâmetros na ordem certinha!
                    // (Onde não tem caixinha de texto na tela, passamos "" vazio)
                    dgvEquipamentos.DataSource = equipamento.PesquisaAvancada(
                        txtCodigoP.Text,
                        cmbTipoP.Text,
                        txtNSerieP.Text,
                        "", // Marca 
                        letraSituacao,
                        txtValorP.Text,
                        ""  // LicencaAti
                    );
                }

                FormatarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar equipamento: {ex.Message}", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mbtnPesquisarLi_Click(object sender, EventArgs e)
        {
            clsLicenca licenca = new clsLicenca();
            try
            {
                if (string.IsNullOrEmpty(mTxtPesquisa.Text))
                {
                    if (MessageBox.Show("Nenhum parâmetro foi passado, deseja fazer busca geral?", "Pesquisa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                            dgvLi.DataSource = licenca.PesquisaTodosA();
                        return;
                    }
                }
                else
                {
                    // Aqui vai ficar a pesquisa filtrada da licença depois
                     dgvLi.DataSource = licenca.PesquisaFiltrada(mTxtPesquisa.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar licença: {ex.Message}", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mSwithLi_CheckedChanged(object sender, EventArgs e)
        {
            if (mSwithLi.Checked == true)
            {
                dgvLi.Enabled = true;
                mTxtPesquisa.Enabled = true;
                mbtnPesquisarLi.Enabled = true;
            }
            else 
            {
                dgvLi.Enabled = false;
                mTxtPesquisa.Enabled = false;
                mbtnPesquisarLi.Enabled = false;

                txtNumeroLicenca.Text = "";
            }
        }

        private void FormatarGrid()
        {
            if (dgvEquipamentos.Columns.Count > 0)
            {
                // Mudando os títulos dos cabeçalhos para ficar amigável para o usuário
                dgvEquipamentos.Columns["ID"].HeaderText = "Código";
                dgvEquipamentos.Columns["TipoEquipamento"].HeaderText = "Tipo";
                dgvEquipamentos.Columns["NumeroSerie"].HeaderText = "Nº de Série";
                dgvEquipamentos.Columns["Marca"].HeaderText = "Marca";
                dgvEquipamentos.Columns["Situacao"].HeaderText = "Status";
                dgvEquipamentos.Columns["Valor"].HeaderText = "Valor";
                dgvEquipamentos.Columns["LicencaAti"].HeaderText = "Licença";

                // Formata a coluna Valor para mostrar como Moeda (Ex: R$ 1.500,00)
                dgvEquipamentos.Columns["Valor"].DefaultCellStyle.Format = "C2";

                // Ajustando as larguras das colunas
                // AllCells para colunas que têm dados curtos (fica bem justinho)
                dgvEquipamentos.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvEquipamentos.Columns["Situacao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvEquipamentos.Columns["Valor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Fill para as colunas que têm textos maiores (dividem o espaço que sobrar na tela)
                dgvEquipamentos.Columns["TipoEquipamento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEquipamentos.Columns["NumeroSerie"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEquipamentos.Columns["Marca"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEquipamentos.Columns["LicencaAti"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void carregarCmb()
        {
            // Parte de Cadastro
            cmbSituacao.Items.Clear();
           
            cmbSituacao.Items.Add("Em Estoque");
            cmbSituacao.Items.Add("Em Campo");
            cmbSituacao.Items.Add("Em Manutenção");
            cmbSituacao.Items.Add("Quebrado"); 
             cmbSituacao.Items.Add("");

            cmbSituacao.SelectedIndex = 4;

            // Parte de Pesquisa
            cmbSituacaoP.Items.Clear();
            cmbSituacaoP.Items.Add("Em Estoque");
            cmbSituacaoP.Items.Add("Em Campo");
            cmbSituacaoP.Items.Add("Em Manutenção");
            cmbSituacaoP.Items.Add("Quebrado");
            cmbSituacaoP.Items.Add("");

            cmbSituacaoP.SelectedIndex = 4;
        }       

        // Método para traduzir o texto do ComboBox para a letra que vai pro banco
        private string ObterLetraSituacao(string textoCombo)
        {
            if (textoCombo == "Em Estoque") return "E";
            else if (textoCombo == "Em Campo") return "C";
            else if (textoCombo == "Em Manutenção") return "M";
            else if (textoCombo == "Quebrado") return "Q";
            else return ""; // Se tiver vazio

        }

        private void dgvLi_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o usuário realmente clicou em uma linha válida
                if (dgvLi.CurrentRow != null && dgvLi.Rows.Count > 0)
                {
                    // Pega o ID da licença (Coluna 0) da linha selecionada
                    string CodigoSelecionado = dgvLi.CurrentRow.Cells[0].Value.ToString();
                    string licencaSelecionada = dgvLi.CurrentRow.Cells[2].Value.ToString();

                    // Joga o ID direto na caixinha de texto que a gente criou e bloqueia o usuário de digitar lá
                    txtNumeroLicenca.Text = licencaSelecionada;
                    txtCodigoLi.Text = CodigoSelecionado;
                    txtCodigoLi.Visible = true;
                    mtxtFrente.Visible = true;
                    txtNumeroLicenca.Visible = true;

                    MessageBox.Show($"Licença selecionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar a licença: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mbtnCancelar_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Você está redefinindo todos os campos deseja continuar? (Isso resetará todos os campos)", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FormatarGrid();
                resetar();
                if (mSwithLi.Checked)
                {
                    mSwithLi.Checked = false;
                }

            }
           
        }

        private void mbtnPesquisar_Click_1(object sender, EventArgs e)
        {
            tabCntrCadastro.SelectedIndex = 0;
        }

        private void dgvEquipamentos_DoubleClick(object sender, EventArgs e)
         {
            /*
            cmbSituacao.Items.Add("Em Estoque");
            cmbSituacao.Items.Add("Em Campo");
            cmbSituacao.Items.Add("Em Manutenção");
            cmbSituacao.Items.Add("Quebrado");
            cmbSituacao.Items.Add("");
            */
         

            string letraSituacao = ObterLetraSituacao(cmbSituacaoP.Text);
      



            try
            {
                if (Convert.ToInt16(dgvEquipamentos.CurrentRow.Cells[0].Value)>0)
                {
                    mtxtCodigo.Text = Convert.ToString(dgvEquipamentos.CurrentRow.Cells[0].Value);
                    txtTipoEquipamento.Text = Convert.ToString(dgvEquipamentos.CurrentRow.Cells[1].Value);
                    txtNumeroSerie.Text = Convert.ToString(dgvEquipamentos.CurrentRow.Cells[2].Value);
                    txtMarca.Text = Convert.ToString(dgvEquipamentos.CurrentRow.Cells[3].Value);
                    letraSituacao = Convert.ToString(dgvEquipamentos.CurrentRow.Cells[8].Value);
                    if (letraSituacao == "E")
                        cmbSituacao.SelectedIndex = 0;
                    else if (letraSituacao == "C")
                        cmbSituacao.SelectedIndex = 1;
                    else if (letraSituacao == "M")
                        cmbSituacao.SelectedIndex = 2;
                    else if (letraSituacao == "Q")
                        cmbSituacao.SelectedIndex = 3;
                    txtValor.Text = Convert.ToString(dgvEquipamentos.CurrentRow.Cells[6].Value);
                    

                }
                tabCntrCadastro.SelectedIndex = 1;
                lblCodigo.Visible = true;
                mtxtCodigo.Visible = true;
                mbtnCadastrar.Tag = "Editar";
                mbtnCadastrar.Text = "Editar";
                if (!string.IsNullOrEmpty(Convert.ToString(dgvEquipamentos.CurrentRow.Cells[7].Value)))
                {
                    txtCodigoLi.Text = Convert.ToString(dgvEquipamentos.CurrentRow.Cells[7].Value);
                    txtNumeroLicenca.Text = Convert.ToString(dgvEquipamentos.CurrentRow.Cells[9].Value);
                    txtCodigoLi.Visible = true;
                    mtxtFrente.Visible = true;
                    txtNumeroLicenca.Visible = true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Eerro ao puxar Equipamentos: {ex.Message}", "Puxar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void mbVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastroEq_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
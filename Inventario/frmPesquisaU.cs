using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class frmPesquisaU : MaterialForm
    {
        //Seguinte aqui é OBRIGATÓRIO carregar as variáveis pra mandar pro outro forms, da pra usar a cls guarda usu, mass é melhor deixar a guarda usuario para quando for manipular os dados quando ja for LOGADO
        public int codigoSelecao
        {
            get; private set;
        }
        public string nomeSelecao
        {
            get; private set;
        }
        public string emailSelecao
        {
            get; private set;
        }
        public int crachaSelecao
        {
            get; private set;
        }
        public string senhaSelecao
        {
            get; private set;
        }
        public int tipoSelecao
        {
            get; private set;
        }
        public string situacaoSelecao
        {
            get; private set;
        }

        // variável para o gerenciador de temas
        private readonly MaterialSkinManager materialSkinManager;
        public frmPesquisaU()
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
   
        private void frmPesquisaU_Load(object sender, EventArgs e)
        {

        }

        private void mbtnPesquisar_Click(object sender, EventArgs e)
        {
            clsUsuario clsUsu = new clsUsuario();
            if (string.IsNullOrEmpty(txtCodigo.Text) && string.IsNullOrEmpty((txtNome.Text)))
            {
                if (MessageBox.Show("Seus campos estão vazios deseja fazer uma busca geral?", "Pesquisa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dgvUsu.DataSource = clsUsu.PesquisaTodos();
              }
            } else if (!string.IsNullOrEmpty(txtCodigo.Text)){
                dgvUsu.DataSource = clsUsu.PesquisaCodigo(Convert.ToInt16(txtCodigo.Text));
            }else
            {
                dgvUsu.DataSource = clsUsu.PesquisaNome(txtNome.Text);
            }
          
        
        }

        private void mtbnfechar_Click(object sender, EventArgs e)
        {
            this.Dispose();  
        }

        private void dgvUsu_DoubleClick(object sender, EventArgs e)
        {
            try
            {

               
               
                codigoSelecao = Convert.ToInt32(dgvUsu.CurrentRow.Cells[0].Value);
                nomeSelecao = dgvUsu.CurrentRow.Cells[1].Value.ToString();
                emailSelecao = dgvUsu.CurrentRow.Cells[2].Value.ToString();
                crachaSelecao = Convert.ToInt32(dgvUsu.CurrentRow.Cells[3].Value);
                situacaoSelecao = dgvUsu.CurrentRow.Cells[4].Value.ToString();
                tipoSelecao = Convert.ToInt16(dgvUsu.CurrentRow.Cells[5].Value);
                senhaSelecao = dgvUsu.CurrentRow.Cells[6].Value.ToString();
                this.DialogResult = DialogResult.OK;
                frmCadastroUsuario cadastro = new frmCadastroUsuario();
                this.Hide();
              
                this.Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro{ex}");
            }
           
           
        }

        private void dgvUsu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPesquisaU_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}

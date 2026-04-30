using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventario
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsCriarBanco banco = new clsCriarBanco();
            clsUsuario usuario = new clsUsuario();
            banco.CriarBd();
            DataTable resultado = usuario.PesquisaNome("");
            if (resultado.Rows.Count == 0)
            {
                usuario.SalvarUsu("Admin", "admin", 0, "admin", 0);
            }
        }

        private void tmrSplash_Tick(object sender, EventArgs e) // alteração teste para fechar o splash após encerrar o programa
        {
            tmrSplash.Enabled = false;

            using (frmLogin login = new frmLogin())
            {
                this.Hide();
                login.ShowDialog();
            }

            this.Close();
        }
        
    }

}

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
            banco.CriarBd();
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

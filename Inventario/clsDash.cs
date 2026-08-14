using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

namespace Inventario
{
    internal class clsDash
    {
        //ESTÁ CLASSE SERVE PARA FAZER O BANCO CONVERSAR COM A DASH
        //Primeiro vamos fazer o método de contar as máquinas que estão no sistema
      
        public int ContarMaquinas()
        {
            //Variável que armazena qtdedsadsadsa
            int total = 0;
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
            {
                //Aqui tamo falando assimm, na tabela Maquina conte as linhas
                string sql = "SELECT COUNT(*) FROM tbMaquinas";
                //Executando
                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    conexao.Open();
                    //Aqui a variável que criamos recebe a contagem do comando do sql e executa
                    total = (int)cmd.ExecuteScalar(); 
                }
               
            }
            return total;
        }

        public int ContarEquipamentos()
        {
            int total = 0;
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
            {
                string sql = "SELECT COUNT(*) FROM tbEquipamentosL";
                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    conexao.Open();
                    total = (int)cmd.ExecuteScalar();
                }
            }
            return total;
        }

        public int ContarLicenasVenc()
        {
             //Este método conta as licenças vencidas é a mesma lógica do outro
             //Variável que vai receber o total
            int total = 0;
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
            {
                //Aqui ele pega o dia de hoje e verifica se o dia do vencimentos está menor ou igual a 3 dias
                string sql = "SELECT COUNT(*) FROM tbLicencas WHERE DATEDIFF(day, GETDATE(), DataVencimento) <= 3";
                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    conexao.Open();
                    total = (int)cmd.ExecuteScalar();
                }
            }
            return total;
        }
        /*
            if (textoCombo == "Em Estoque") return "E";
            else if (textoCombo == "Em Campo") return "C";
            else if (textoCombo == "Em Manutenção") return "M";
            else if (textoCombo == "Quebrado") return "Q";*/

        public int ContarEquiQue()
        {
            int total = 0;
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
            {
                string sql = "SELECT COUNT(*) FROM tbEquipamentosL WHERE Situacao = 'Q' ";
                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    conexao.Open();
                    total = (int)cmd.ExecuteScalar();
                }
            }
            return total;
        }
        



    }
}

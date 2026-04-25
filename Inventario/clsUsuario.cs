using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    internal class clsUsuario
    {
        //Classe Usuário
        SqlCommand cmd = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dt = new DataTable();

        public void SalvarUsu(string NomeUsuario, string Email, int Cracha, string Senha, int Tipo)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
            
                try
                {
                    //Limpando os dados 
                    sql.Clear(); 
                    cmd.Parameters.Clear();
                    //Abre conexão 
                    conexao.Open();
                    //Insert na tabela
                    sql.Append("INSERT INTO tbUsuario(NomeUsuario, Email, Cracha, Senha, Tipo");
                    sql.Append(" VALUES (@NomeUsuario, @Email, @Cracha, @Senha, @Tipo");

                    //Parâmetros
                    cmd.Parameters.Add(new SqlParameter("@NomeUsuario", NomeUsuario));
                    cmd.Parameters.Add(new SqlParameter("@Email", Email));
                    cmd.Parameters.Add(new SqlParameter("@Cracha", Cracha));
                    cmd.Parameters.Add(new SqlParameter("@Senha", Senha));
                    cmd.Parameters.Add(new SqlParameter("@Tipo", Tipo));

                    //Executando os comandos 
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar usuário {ex}");
                    throw;
                }finally { conexao.Close(); }
            
        }

        //Metodo Editar

        public void EditarUsu(int Codigo, string NomeUsuario, string Email, int Cracha, string Senha, string Situacao, int Tipo)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();
                }
                catch (Exception)
                {

                    throw;
                }
        }
    }
}

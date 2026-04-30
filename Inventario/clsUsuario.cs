using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

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
                    sql.Append("INSERT INTO tbUsuario(NomeUsuario, Email, Cracha, Senha, Tipo)");
                    sql.Append(" VALUES (@NomeUsuario, @Email, @Cracha, @Senha, @Tipo)");

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
                    MessageBox.Show($"Erro ao salvar usuário {ex}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }finally { conexao.Close(); }
            
        }

        //Método Editar

        public void EditarUsu(int Codigo, string NomeUsuario, string Email, int Cracha, string Senha, string Situacao, int Tipo)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();
                    sql.Append("UPDATE tbUsuario SET NomeUsuario = @NomeUsuario, Email = @Email, Cracha = @Cracha, Senha = @Senha, Situacao = @Situacao, Tipo = @Tipo");
                    sql.Append(" WHERE codigo = @codigo");

                    //Parâmetros
                    cmd.Parameters.Add(new SqlParameter("@Codigo", Codigo));
                    cmd.Parameters.Add(new SqlParameter("@NomeUsuario", NomeUsuario));
                    cmd.Parameters.Add(new SqlParameter("@Email", Email));
                    cmd.Parameters.Add(new SqlParameter("@Cracha", Cracha));
                    cmd.Parameters.Add(new SqlParameter("@Senha", Senha));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Tipo", Tipo));
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar usuario{ex}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally { conexao.Close(); }
        }

        //Para pesquisar usuários todos os selects serão feitos sem mostrar a senha para quem for consultar (proteção de dados)
        //SELECT com Nome
        public DataTable PesquisaNome(string NomeUsuario)
        {
            using(SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();
                    sql.Append("SELECT Codigo, NomeUsuario, Email, Cracha, Situacao, Tipo FROM tbUsuario");
                    sql.Append(" WHERE NomeUsuario LIKE '%' + @NomeUsuario + '%' ");
                    sql.Append(" ORDER BY NomeUsuario");
                    cmd.Parameters.Add(new SqlParameter("@NomeUsuario", NomeUsuario));
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    dt.Load(cmd.ExecuteReader());
                    return dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar Usuario pelo nome {ex}", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;

                }
                finally { conexao.Close();  }
        }
        //SELECT com Codigo
        public DataTable PesquisaCodigo(int Codigo)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();
                    sql.Append("SELECT Codigo, NomeUsuario, Email, Cracha, Situacao, Tipo FROM tbUsuario");
                    sql.Append(" WHERE Codigo = @Codigo ");
                    cmd.Parameters.Add(new SqlParameter("@Codigo", Codigo));
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    dt.Load(cmd.ExecuteReader());
                    return dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar Usuario pelo codigo {ex}", "Codigo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;

                }
                finally { conexao.Close(); }

        }

        //Vericficação do usuário existente
        public bool ValidarLogin(string Email, string Senha)
        {
        using(SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();
                    sql.Append("SELECT COUNT(1) FROM tbUsuario");
                    sql.Append(" WHERE Email = @Email AND Senha = @Senha");
                    cmd.Parameters.Add(new SqlParameter("@Email", Email));
                    cmd.Parameters.Add(new SqlParameter("@Senha", Senha));
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    //Aqui é oque vai enviar se o usuario existir
                    int resul = Convert.ToInt32(cmd.ExecuteScalar());
                    return resul == 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao entrar, {ex.Message}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
               
                }
        }

        public int Verifica_Tipo(string Email)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();
                    sql.Append("SELECT Tipo FROM tbUsuario");
                    sql.Append(" WHERE Email = @Email");
                    cmd.Parameters.Add(new SqlParameter("@Email", Email));
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;

                    object resul = Convert.ToInt32(cmd.ExecuteScalar());
                    if (resul != null && resul != DBNull.Value)
                    {
                        int tipo = Convert.ToInt32(resul);
                        return tipo;
                    }
                    //se cair no -1 quer dizer que o usuário não existe
                    return -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao validar o tipo do Usuario{ex}", "Tipo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return -1;
                }
        }

    }
}

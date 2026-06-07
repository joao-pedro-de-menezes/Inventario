using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    internal class clsMaquina
    {
        SqlCommand cmd = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dt = new DataTable();

        public void SalvarMaquina(int NumeroFrota, string TipoMaquina, string Situacao, int Frente, string Observacao)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("INSERT INTO tbMaquinas(NumeroFrota, TipoMaquina, Situacao, Frente, Observacao)");
                    sql.Append(" VALUES (@NumeroFrota, @TipoMaquina, @Situacao, @Frente, @Observacao)");

                    cmd.Parameters.Add(new SqlParameter("@NumeroFrota", NumeroFrota));
                    cmd.Parameters.Add(new SqlParameter("@TipoMaquina", TipoMaquina));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Frente", Frente));
                    cmd.Parameters.Add(new SqlParameter("@Observacao", Observacao));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar a maquina {ex.Message}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public void EditarMaquina(int ID, int NumeroFrota, string TipoMaquina, string Situacao, int Frente, string Observacao)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("UPDATE tbMaquinas SET NumeroFrota = @NumeroFrota, TipoMaquina = @TipoMaquina, Situacao = @Situacao, Frente = @Frente, Observacao = @Observacao");
                    sql.Append(" WHERE ID = @ID");

                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    cmd.Parameters.Add(new SqlParameter("@NumeroFrota", NumeroFrota));
                    cmd.Parameters.Add(new SqlParameter("@TipoMaquina", TipoMaquina));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Frente", Frente));
                    cmd.Parameters.Add(new SqlParameter("@Observacao", Observacao));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar maquina {ex.Message}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public DataTable PesquisaTodos()
        {
            DataTable dtLocal = new DataTable();

            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("SELECT * FROM tbMaquinas");
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    dtLocal.Load(cmd.ExecuteReader());
                    return dtLocal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar maquinas {ex.Message}", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public DataTable PesquisaCodigo(int Codigo)
        {
            DataTable dtLocal = new DataTable();

            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();

                    sql.Append("SELECT ID, NumeroFrota, TipoMaquina, Situacao, Frente, Observacao");
                    sql.Append(" WHERE ID = @Codigo");
                    cmd.Parameters.Add(new SqlParameter("@Codigo", Codigo));
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    dtLocal.Load(cmd.ExecuteReader());
                    return dtLocal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar licenças por Codigo {ex.Message}", "Codigo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public DataTable PesquisaFrota(int NumeroFrota)
        {
            DataTable dtLocal = new DataTable();

            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("SELECT ID, NumeroFrota, TipoMaquina, Situacao, Frente, Observacao FROM tbMaquinas");
                    sql.Append(" WHERE NumeroFrota LIKE = @NumeroFrota");
                    sql.Append(" ORDER BY NumeroFrota");
                    // Aqui a gente converte o número para string e gruda o '%' no final (pesquisa pelo número inicial)
                    cmd.Parameters.Add(new SqlParameter("@NumeroFrota", NumeroFrota.ToString() + "%"));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    dtLocal.Load(cmd.ExecuteReader());
                    return dtLocal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar pela frota {ex.Message}", "Numero Frota", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public DataTable PesquisaMaquina(string TipoMaquina)
        {
            DataTable dtLocal = new DataTable();

            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("SELECT ID, NumeroFrota, TipoMaquina, Situacao, Frente, Observacao FROM tbMaquinas");
                    sql.Append(" WHERE TipoMaquina LIKE '%' + @TipoMaquina + '%'");
                    sql.Append(" ORDER BY TipoMaquina");
                    cmd.Parameters.Add(new SqlParameter("@TipoMaquina", TipoMaquina));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    dtLocal.Load(cmd.ExecuteReader());
                    return dtLocal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar pelo tipo da maquina {ex.Message}", "Maquina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public DataTable PesquisaSituacao(string Situacao)
        {
            DataTable dtLocal = new DataTable();

            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("SELECT ID, NumeroFrota, TipoMaquina, Situacao, Frente, Observacao FROM tbMaquinas");
                    sql.Append(" WHERE Situacao LIKE = @Situacao");
                    sql.Append(" ORDER BY Situacao");
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    dtLocal.Load(cmd.ExecuteReader());
                    return dtLocal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar pela situação {ex.Message}", "Situação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public DataTable PesquisaFrente(int Frente)
        {
            DataTable dtLocal = new DataTable();

            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("SELECT ID, NumeroFrota, TipoMaquina, Situacao, Frente, Observacao FROM tbMaquinas");
                    sql.Append(" WHERE Frente LIKE @Frente");
                    sql.Append(" ORDER BY Frente");
                    cmd.Parameters.Add(new SqlParameter("@Frente", Frente.ToString() + "%"));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    dtLocal.Load(cmd.ExecuteReader());
                    return dtLocal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar pela frente {ex.Message}", "Frente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }
    }
}

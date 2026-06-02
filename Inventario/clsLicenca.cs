using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    internal class clsLicenca
    {
        SqlCommand cmd = new SqlCommand();
        StringBuilder sql = new StringBuilder();
       

        public void SalvarLicenca(string TipoLicenca, int NumeroSerie, DateTime DataAtivacao, DateTime DataVencimento)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))

                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("INSERT INTO tbLicencas(TipoLicenca, NumeroSerie, DataAtivacao, DataVencimento)");
                    sql.Append(" VALUES (@TipoLicenca, @NumeroSerie, @DataAtivacao, @DataVencimento)");

                    cmd.Parameters.Add(new SqlParameter("@TipoLicenca", TipoLicenca));
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@DataAtivacao", DataAtivacao));
                    cmd.Parameters.Add(new SqlParameter("@DataVencimento", DataVencimento));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar licença {ex}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally 
                { 
                    conexao.Close(); 
                }
        }

        public void EditarLicenca(int ID, string TipoLicenca, int NumeroSerie, DateTime DataAtivacao, DateTime DataVencimento, string Situacao)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();

                    sql.Append("UPDATE tbLicencas SET TipoLicenca = @TipoLicenca, NumeroSerie = @NumeroSerie, DataAtivacao = @DataAtivacao, DataVencimento = @DataVencimento, Situacao = @Situacao");
                    sql.Append(" WHERE ID = @ID");

                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    cmd.Parameters.Add(new SqlParameter("@TipoLicenca", TipoLicenca));
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@DataAtivacao", DataAtivacao));
                    cmd.Parameters.Add(new SqlParameter("@DataVencimento", DataVencimento));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar licença {ex}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    sql.Append("SELECT * FROM tbLicencas");
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;              
                    dtLocal.Load(cmd.ExecuteReader());
                    return dtLocal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar licenças {ex}", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public DataTable PesquisaTipo(string TipoLicenca)
        {
            DataTable dtLocal = new DataTable();

            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();

                    sql.Append("SELECT ID, TipoLicenca, NumeroSerie, DataAtivacao, DataVencimento FROM tbLicencas");
                    sql.Append(" WHERE TipoLicenca LIKE '%' + @TipoLicenca + '%' ");
                    sql.Append(" ORDER BY TipoLicenca");
                    cmd.Parameters.Add(new SqlParameter("@TipoLicenca", TipoLicenca));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    dtLocal.Load(cmd.ExecuteReader());
                    return dtLocal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar Licença pelo Tipo {ex}", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally 
                { 
                    conexao.Close(); 
                }
        }

        public DataTable PesquisaData(DateTime dataInicio, DateTime dataFim) 
        {
            DataTable dtLocal = new DataTable();

            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try 
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();

                    sql.Append("SELECT ID, TipoLicenca, NumeroSerie, DataAtivacao, DataVencimento FROM tbLicencas");
                    sql.Append(" WHERE DataVencimento BETWEEN @dataInicio AND @dataFim");
                    sql.Append(" ORDER BY DataVencimento ASC");

                    cmd.Parameters.Add(new SqlParameter("@dataInicio", dataInicio));
                    cmd.Parameters.Add(new SqlParameter("@dataFim", dataFim));

                    cmd.CommandText= sql.ToString();
                    cmd.Connection = conexao;

                    dtLocal.Load(cmd.ExecuteReader());
                    return dtLocal;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar licenças por data {ex}", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
        }
    }
}
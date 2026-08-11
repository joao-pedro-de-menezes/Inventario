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
        DataTable dt = new DataTable();

        public void SalvarLicenca(string TipoLicenca, string NumeroSerie, DateTime DataAtivacao, DateTime DataVencimento, string Situacao, double Valor)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))

                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("INSERT INTO tbLicencas(TipoLicenca, NumeroSerie, DataAtivacao, DataVencimento, Situacao, Valor)");
                    sql.Append(" VALUES (@TipoLicenca, @NumeroSerie, @DataAtivacao, @DataVencimento, @Situacao, @Valor)");

                    cmd.Parameters.Add(new SqlParameter("@TipoLicenca", TipoLicenca));
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@DataAtivacao", DataAtivacao));
                    cmd.Parameters.Add(new SqlParameter("@DataVencimento", DataVencimento));                  
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar licença {ex.Message}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally 
                { 
                    conexao.Close(); 
                }
        }

        public void EditarLicenca(int ID, string TipoLicenca, string NumeroSerie, DateTime DataAtivacao, DateTime DataVencimento, string Situacao, double Valor)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();

                    sql.Append("UPDATE tbLicencas SET TipoLicenca = @TipoLicenca, NumeroSerie = @NumeroSerie, DataAtivacao = @DataAtivacao, DataVencimento = @DataVencimento, Situacao = @Situacao, Valor = @Valor");
                    sql.Append(" WHERE ID = @ID");

                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    cmd.Parameters.Add(new SqlParameter("@TipoLicenca", TipoLicenca));
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@DataAtivacao", DataAtivacao));
                    cmd.Parameters.Add(new SqlParameter("@DataVencimento", DataVencimento));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar licença {ex.Message}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"Erro ao pesquisar licenças {ex.Message}", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    sql.Append("SELECT ID, TipoLicenca, NumeroSerie, DataAtivacao, DataVencimento, Situacao, Valor FROM tbLicencas");
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
                    MessageBox.Show($"Erro ao pesquisar Licença pelo Tipo {ex.Message}", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    sql.Append("SELECT ID, TipoLicenca, NumeroSerie, DataAtivacao, DataVencimento, Situacao, Valor FROM tbLicencas");
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
                    MessageBox.Show($"Erro ao pesquisar licenças por data {ex.Message}", "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    sql.Append("SELECT ID, TipoLicenca, NumeroSerie, DataAtivacao, DataVencimento, Situacao, Valor FROM tbLicencas");
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
        public DataTable PesquisaNumero(string NumeroSerie)
        {
            DataTable dtLocal = new DataTable();

            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();
                    sql.Append("SELECT ID, TipoLicenca, NumeroSerie, DataAtivacao, DataVencimento, Situacao, Valor FROM tbLicencas");
                    sql.Append(" WHERE NumeroSerie = @NumeroSerie");
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;

                    dtLocal.Load(cmd.ExecuteReader());
                    return dtLocal;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar licenças por Numero Serie {ex.Message}", "Numero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public DataTable PesquisaValor(int Valor)
        {
            DataTable dtLocal = new DataTable();

            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();
                    sql.Append("SELECT ID, TipoLicenca, NumeroSerie, DataAtivacao, DataVencimento, Situacao, Valor FROM tbLicencas");
                    sql.Append(" WHERE Valor = @Valor");
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;

                    dtLocal.Load(cmd.ExecuteReader());
                    return dtLocal;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar licenças por Valor {ex.Message}", "Valor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        //Pesquisa tudo
        public DataTable PesquisaAvancada(string ID, string NumeroSerie, string TipoLicenca, string Valor, string Situacao, string DataAtivacao,string DataVencimento)
        {
            // O 1=1 é um macete do SQL. Como é sempre verdade, podemos ir adicionando "AND" depois dele sem dar erro de sintaxe.
            //Aqui ta passando os comandos do sql Server pra quando o tiverem preenchidas la no código
            string sql = "SELECT * FROM tbLicencas WHERE 1=1 ";

            // Vai construindo o SQL dinamicamente
            if (!string.IsNullOrEmpty(ID))
                sql += " AND ID = @ID";

            if (!string.IsNullOrEmpty(NumeroSerie))
                sql += " AND NumeroSerie LIKE @NumeroSerie";

            if (!string.IsNullOrEmpty(TipoLicenca))
                sql += " AND TipoLicenca LIKE @TipoLicenca";

            if (!string.IsNullOrEmpty(Valor))
                sql += " AND Valor = @Valor"; 

            if (!string.IsNullOrEmpty(Situacao))
                sql += " AND Situacao = @Situacao"; 


            //ZERANDO VARIÁVEIS
            DateTime dataAtivValida = DateTime.MinValue;
            DateTime dataVencValida = DateTime.MinValue;
            //VERIFICANDO SE SÃO VÁLIDAS
            bool datasSaoValidas = DateTime.TryParse(DataAtivacao, out dataAtivValida) && DateTime.TryParse(DataVencimento, out dataVencValida);

            // 2. Só adiciona o BETWEEN no SQL se as datas realmente forem válidas!
            if (datasSaoValidas)
            {
                sql += " AND DataAtivacao BETWEEN @DataAtivacao AND @DataVencimento";
            }





            using (SqlConnection con = new SqlConnection(clsConexao.StringConexao)) // Use sua classe de conexão
            {
                //Adicionando parâmetros poderia fazer do jeito comun, mas aqui ele verifica 1 por 1 que se ta preenchido e passa pra executar
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // Agora preenche os parâmetros (isso evita falhas de segurança/SQL Injection)
                    if (!string.IsNullOrEmpty(ID))
                        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(ID));

                    if (!string.IsNullOrEmpty(NumeroSerie))
                        cmd.Parameters.AddWithValue("@NumeroSerie", "%" + NumeroSerie + "%");

                    if (!string.IsNullOrEmpty(TipoLicenca))
                        cmd.Parameters.AddWithValue("@TipoLicenca", "%" + TipoLicenca + "%");

                    if (!string.IsNullOrEmpty(Valor))
                        cmd.Parameters.AddWithValue("@Valor", Convert.ToString(Valor)); // Converte para Decimal/Dinheiro

                    if (!string.IsNullOrEmpty(Situacao))
                        cmd.Parameters.AddWithValue("@Situacao", Situacao);

                    // Só cria os parâmetros se a validação lá de cima tiver dado certo
                    if (datasSaoValidas)
                    {
                        cmd.Parameters.AddWithValue("@DataAtivacao", dataAtivValida);
                        cmd.Parameters.AddWithValue("@DataVencimento", dataVencValida);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Retorna a tabela filtrada exatamente com o que o usuário combinou!
                    return dt;
                }
            }
        }

        // Aqui é um tipo de pesquisa que funciona tudo dentro de um campo de pesquisa só.
        public DataTable PesquisaFiltrada(string termo)
        {
            DataTable dtLocal = new DataTable();

            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
            {
                try
                {
                    conexao.Open();

                    // O "OR" permite que a pessoa digite o Tipo da Licença (Ex: Windows) 
                    // ou o Número de Série (Ex: 1234) na mesma caixinha e o SQL acha!
                    string sqlComando = "SELECT * FROM tbLicencas WHERE Situacao = 'A' AND (TipoLicenca LIKE @termo OR NumeroSerie LIKE @termo)";

                    using (SqlCommand comando = new SqlCommand(sqlComando, conexao))
                    {
                        comando.Parameters.AddWithValue("@termo", "%" + termo + "%");
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        da.Fill(dtLocal);
                    }
                    return dtLocal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao filtrar licenças: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        public DataTable PesquisaTodosA()
        {
            DataTable dtLocal = new DataTable();

            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();

                    sql.Append("SELECT * FROM tbLicencas WHERE Situacao = 'A'");
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    dtLocal.Load(cmd.ExecuteReader());
                    return dtLocal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar licenças {ex.Message}", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }
    }
}
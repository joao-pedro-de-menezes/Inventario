using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    internal class clsEquipamentoGeral
    {
        SqlCommand cmd = new SqlCommand();
        StringBuilder sql = new StringBuilder();


        /*public void SalvarMonitor(int NumeroSerie, string LicencaAti, string Situacao, double Valor, DateTime DataAtivacao, DateTime DataVencimento)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("INSERT INTO tbMonitor (NumeroSerie, LicencaAti, Situacao, Valor, DataAtivacao, DataVencimento)");
                    sql.Append(" VALUES (@NumeroSerie, @LicencaAti, @Situacao, @Valor, @DataAtivacao, @DataVencimento)");

                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@LicencaAti", LicencaAti));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));
                    cmd.Parameters.Add(new SqlParameter("@DataAtivacao", DataAtivacao));
                    cmd.Parameters.Add(new SqlParameter("@DataVencimento", DataVencimento));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar Monitor {ex.Message}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();

                }
        }

        public void EditarMonitor(int ID, int NumeroSerie, string LicencaAti, string Situacao, double Valor, DateTime DataAtivacao, DateTime DataVencimento)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("UPDATE tbMonitor SET NumeroSerie = @NumeroSerie, LicencaAti = @LicencaAti, Situacao = @Situacao, Valor = @valor, DataAtivacao = @DataAtivacao, DataVencimento = @DataVencimento");
                    sql.Append(" WHERE ID = @ID");

                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@LicencaAti", LicencaAti));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));
                    cmd.Parameters.Add(new SqlParameter("@DataAtivacao", DataAtivacao));
                    cmd.Parameters.Add(new SqlParameter("@DataVencimento", DataVencimento));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar Monitor {ex.Message}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public void SalvarNav900(int NumeroSerie, string LicencaAti, string Situacao, double Valor, DateTime DataAtivacao, DateTime DataVencimento)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("INSERT INTO tbNav900 (NumeroSerie, LicencaAti, Situacao, Valor, DataAtivacao, DataVencimento)");
                    sql.Append(" VALUES (@NumeroSerie, @LicencaAti, @Situacao, @Valor, @DataAtivacao, @DataVencimento)");

                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@LicencaAti", LicencaAti));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));
                    cmd.Parameters.Add(new SqlParameter("@DataAtivacao", DataAtivacao));
                    cmd.Parameters.Add(new SqlParameter("@DataVencimento", DataVencimento));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar Nav 900 {ex.Message}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();

                }
        }

        public void EditarNav900(int ID, int NumeroSerie, string LicencaAti, string Situacao, double Valor, DateTime DataAtivacao, DateTime DataVencimento)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("UPDATE tbNav900 SET NumeroSerie = @NumeroSerie, LicencaAti = @LicencaAti, Situacao = @Situacao, Valor = @Valor, DataAtivacao = @DataAtivacao, DataVencimento = @DataVencimento");
                    sql.Append(" WHERE ID = @ID");

                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@LicencaAti", LicencaAti));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));
                    cmd.Parameters.Add(new SqlParameter("@DataAtivacao", DataAtivacao));
                    cmd.Parameters.Add(new SqlParameter("@DataVencimento", DataVencimento));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar Nav 900 {ex.Message}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public void SalvarNav2(int NumeroSerie, string Situacao, double Valor)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("INSERT INTO tbNav2 (NumeroSerie, Situacao, Valor)");
                    sql.Append(" VALUES (@NumeroSerie, @Situacao, @Valor)");
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar Nav 2 {ex.Message}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public void EditarNav2(int ID, int NumeroSerie, string Situacao, double Valor)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("UPDATE tbNav2 SET NumeroSerie = @NumeroSerie, Situacao = @Situacao, Valor = @Valor");
                    sql.Append(" WHERE ID = @ID");

                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar Nav 2 {ex.Message}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public void SalvarNav3(int NumeroSerie, string Situacao, double Valor)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("INSERT INTO tbNav3 (NumeroSerie, Situacao, Valor)");
                    sql.Append(" VALUES (@NumeroSerie, @Situacao, @Valor)");
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar Nav 3 {ex.Message}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public void EditarNav3(int ID, int NumeroSerie, string Situacao, double Valor)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("UPDATE tbNav3 SET NumeroSerie = @NumeroSerie, Situacao = @Situacao, Valor = @Valor");
                    sql.Append(" WHERE ID = @ID");

                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar Nav 3 {ex.Message}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public void SalvarTm200(int NumeroSerie, string Situacao, double Valor)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("INSERT INTO tbTm200 (NumeroSerie, Situacao, Valor)");
                    sql.Append(" VALUES (@NumeroSerie, @Situacao, @Valor)");
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar Tm 200 {ex.Message}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public void EditarTm200(int ID, int NumeroSerie, string Situacao, double Valor)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("UPDATE tbTm200 SET NumeroSerie = @NumeroSerie, Situacao = @Situacao, Valor = @Valor");
                    sql.Append(" WHERE ID = @ID");

                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar Tm 200 {ex.Message}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public void SalvarAntenaAg25(string NumeroSerie, string Situacao, double Valor)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("INSERT INTO tbAntenaAg25 (NumeroSerie, Situacao, Valor)");
                    sql.Append(" VALUES (@NumeroSerie, @Situacao, @Valor)");

                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar Antena Ag 25 {ex.Message}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public void EditarAntenaAg25(int ID, string NumeroSerie, string Situacao, double Valor)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("UPDATE tbAntenaAg25 SET NumeroSerie = @NumeroSerie, Situacao = @Situacao, Valor = @Valor");
                    sql.Append(" WHERE ID = @ID");

                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar Antena Ag 25 {ex.Message}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public void SalvarControladorTaxa(string NumeroSerie, string Marca, string Situacao, double Valor)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("INSERT INTO tbControladorTaxa (NumeroSerie, Marca, Situacao, Valor)");
                    sql.Append(" VALUES (@NumeroSerie, @Marca, @Situacao, @Valor)");

                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@Marca", Marca));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar Controlador de Taxa {ex.Message}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public void EditarControladorTaxa(int ID, string NumeroSerie, string Marca, string Situacao, double Valor)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("UPDATE tbControladorTaxa SET NumeroSerie = @NumeroSerie, Marca = @Marca, Situacao = @Situacao, Valor = @Valor");
                    sql.Append(" WHERE ID = @ID");

                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@Marca", Marca));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar Controlador de Taxa {ex.Message}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public void SalvarBotoeira(string NumeroSerie, string Situacao, double Valor)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("INSERT INTO tbBotoeira (NumeroSerie, Situacao, Valor)");
                    sql.Append(" VALUES (@NumeroSerie, @Situacao, @Valor)");

                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar Botoeira {ex.Message}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }

        public void EditarBotoeira(int ID, string NumeroSerie, string Situacao, double Valor)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();

                    conexao.Open();

                    sql.Append("UPDATE tbBotoeira SET NumeroSerie = @NumeroSerie, Situacao = @Situacao, Valor = @Valor");
                    sql.Append(" WHERE ID = @ID");

                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar Botoeira {ex.Message}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
        }*/



        // Passamos o Tipo do Equipamento e usamos o DateTime? (que aceita null)
        public void SalvarEquipamento(string TipoEquipamento, string NumeroSerie, string Marca, string Situacao, double Valor, string LicencaAti)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
            {
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();

                    sql.Append("INSERT INTO tbEquipamentosL (TipoEquipamento, NumeroSerie, Marca, Situacao, Valor, LicencaAti)");
                    sql.Append(" VALUES (@TipoEquipamento, @NumeroSerie, @Marca, @Situacao, @Valor, @LicencaAti)");

                    cmd.Parameters.Add(new SqlParameter("@TipoEquipamento", TipoEquipamento));
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));

                    if (Marca == "" || Marca == null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@Marca", DBNull.Value));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Marca", Marca));
                    }

                    if (LicencaAti == "" || LicencaAti == null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@LicencaAti", DBNull.Value));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@LicencaAti", LicencaAti));
                    }

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar Equipamento: {ex.Message}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }


        public void EditarEquipamento(int ID, string TipoEquipamento, string NumeroSerie, string Marca, string Situacao, double Valor, string LicencaAti)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();

                    sql.Append("UPDATE tbEquipamentosL SET TipoEquipamento = @TipoEquipamento, NumeroSerie = @NumeroSerie, Marca = @Marca, Situacao = @Situacao, Valor = @Valor, LicencaAti = @LicencaAti");
                    sql.Append(" WHERE ID = @ID");

                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    cmd.Parameters.Add(new SqlParameter("@TipoEquipamento", TipoEquipamento));
                    cmd.Parameters.Add(new SqlParameter("@NumeroSerie", NumeroSerie));
                    cmd.Parameters.Add(new SqlParameter("@Marca", Marca));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", Situacao));
                    cmd.Parameters.Add(new SqlParameter("@Valor", Valor));
                    cmd.Parameters.Add(new SqlParameter("@LicencaAti", LicencaAti));

                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar Equipamento: {ex.Message}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            {
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();

                    sql.Append("SELECT * FROM tbEquipamentosL");
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    dtLocal.Load(cmd.ExecuteReader());
                    return dtLocal;


                    // Aqui você pode retornar o DataTable ou fazer algo com ele
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar Equipamentos: {ex.Message}", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        public DataTable PesquisaPorID(int Codigo)
        {
            DataTable dtLocal = new DataTable();
            using (SqlConnection conexao = new SqlConnection(clsConexao.StringConexao))
            {
                try
                {
                    sql.Clear();
                    cmd.Parameters.Clear();
                    conexao.Open();

                    sql.Append("SELECT ID, TipoEquipamento, NumeroSerie, Marca, Situacao, Valor, LicencaAti FROM tbEquipamentosL");
                    sql.Append(" WHERE ID = @Codigo");
                    cmd.Parameters.Add(new SqlParameter("@Codigo", Codigo));
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    dtLocal.Load(cmd.ExecuteReader());
                    return dtLocal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar Equipamento por ID: {ex.Message}", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        public DataTable PesquisaAvancada(string ID, string TipoEquipamento, string NumeroSerie, string Marca, string Situacao, string Valor, string LicencaAti)
        {
            // O 1=1 é um macete do SQL. Como é sempre verdade, podemos ir adicionando "AND" depois dele sem dar erro de sintaxe.
            //Aqui ta passando os comandos do sql Server pra quando o tiverem preenchidas la no código
            string sql = "SELECT * FROM tbEquipamentosL WHERE 1=1 ";

            // Vai construindo o SQL dinamicamente
            if (!string.IsNullOrEmpty(ID))
                sql += " AND ID = @ID";

            if (!string.IsNullOrEmpty(TipoEquipamento))
                sql += " AND TipoEquipamento LIKE @TipoEquipamento";

            if (!string.IsNullOrEmpty(NumeroSerie))
                sql += " AND NumeroSerie LIKE @NumeroSerie";

            if (!string.IsNullOrEmpty(Marca))
                sql += " AND Marca LIKE @Marca";

            if (!string.IsNullOrEmpty(Situacao))
                sql += " AND Situacao = @Situacao";

            if (!string.IsNullOrEmpty(Valor))
                sql += " AND Valor = @Valor";

            if (!string.IsNullOrEmpty(LicencaAti))
                sql += " AND LicencaAti LIKE @LicencaAti";

            using (SqlConnection con = new SqlConnection(clsConexao.StringConexao)) // Use sua classe de conexão
            {
                //Adicionando parâmetros poderia fazer do jeito comun, mas aqui ele verifica 1 por 1 que se ta preenchido e passa pra executar
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // Agora preenche os parâmetros (isso evita falhas de segurança/SQL Injection)
                    if (!string.IsNullOrEmpty(ID))
                        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(ID));

                    if (!string.IsNullOrEmpty(TipoEquipamento))
                        cmd.Parameters.AddWithValue("@TipoEquipamento", "%" + TipoEquipamento + "%");

                    if (!string.IsNullOrEmpty(NumeroSerie))
                        cmd.Parameters.AddWithValue("@NumeroSerie", "%" + NumeroSerie + "%");

                    if (!string.IsNullOrEmpty(Marca))
                        cmd.Parameters.AddWithValue("@Marca", "%" + Marca + "%");

                    if (!string.IsNullOrEmpty(Situacao))
                        cmd.Parameters.AddWithValue("@Situacao", Situacao);

                    if (!string.IsNullOrEmpty(Valor))
                        cmd.Parameters.AddWithValue("@Valor", Convert.ToDouble(Valor));

                    if (!string.IsNullOrEmpty(LicencaAti))
                        cmd.Parameters.AddWithValue("@LicencaAti", "%" + LicencaAti + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Retorna a tabela filtrada exatamente com o que o usuário combinou!
                    return dt;
                }
            }
        }
    }
}


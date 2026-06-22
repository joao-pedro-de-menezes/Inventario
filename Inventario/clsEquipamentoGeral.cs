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
        DataTable dt = new DataTable();

        public void SalvarMonitor(int NumeroSerie, string LicencaAti, string Situacao, double Valor, DateTime DataAtivacao, DateTime DataVencimento)
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
        }
    }
}

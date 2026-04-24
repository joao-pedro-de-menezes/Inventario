using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    internal class clsCriarBanco
    {


        //Criando Banco de dados
        public void CriarBd()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(clsConexao.StringCriar))
                {
                    string CriarBd = "IF DB_ID('bdInventario') IS NULL CREATE DATABASE bdInventario;"; //Verificando se o banco está criado
                    using (SqlCommand cmd = new SqlCommand(CriarBd, conexao)) //aqui está mostrando oque o sql tem que executar, no caso executar as duas strings 
                    {
                        cmd.ExecuteNonQuery();
                    }
                    conexao.ChangeDatabase("bdContComissao"); // Após fazer a verificação/criar a database
                    //Fazer as tabelas
                    string CriartbUsuario = @" IF OBJECT_ID('tbUsuario', 'U') IS NULL
                    CREATE TABLE tbUsuario (
                    Codigo INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
                    NomeUsuario VARCHAR(100) NOT NULL,
                    Email VARCHAR(75) NOT NULL,
                    Cracha INT NOT NULL,
                    Senha VARCHAR(50) NULL,
                    Situacao CHAR(1) NULL DEFAULT 'A',
                    Tipo INT NULL DEFAULT 0
                    )";

                    using (SqlCommand cmd = new SqlCommand(CriartbUsuario, conexao)) //aqui está mostrando oque o sql tem que executar, no caso executar as duas strings 
                    {
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados" + ex.Message + ex);
                throw;
            }
        }
    }
}

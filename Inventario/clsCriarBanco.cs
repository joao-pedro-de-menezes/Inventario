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
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                    }


                    conexao.ChangeDatabase("bdInventario"); // Após fazer a verificação/criar a database
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


                    conexao.ChangeDatabase("bdInventario");
                    string CriartbMaquinas = @" IF OBJECT_ID('tbMaquinas', 'U') IS NULL
                    CREATE TABLE tbMaquinas (
                    ID INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
                    NumeroFrota INT NOT NULL,
                    TipoMaquina VARCHAR(50) NOT NULL,
                    Situacao CHAR(1) NOT NULL DEFAULT 'A',
                    Frente INT NOT NULL,
                    Observacao VARCHAR(150) NULL
                    )";
                    
                    using (SqlCommand cmd = new SqlCommand(CriartbMaquinas, conexao))
                    {
                        cmd.ExecuteNonQuery();
                    }


                    conexao.ChangeDatabase("bdInventario");
                    string CriartbLicencas = @" IF OBJECT_ID('tbLicencas', 'U') IS NULL
                    CREATE TABLE tbLicencas (
                    ID INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
                    TipoLicenca VARCHAR(50) NOT NULL,       
                    NumeroSerie INT NOT NULL,
                    DataAtivacao DATE NOT NULL,
                    DataVencimento DATE NOT NULL,   
                    Situacao CHAR(1) NULL DEFAULT 'A'
                    )";
                    using (SqlCommand cmd = new SqlCommand(CriartbLicencas, conexao))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    conexao.ChangeDatabase("bdInventario");
                    string CriartbEquipamentosL = @" IF OBJECT_ID('tbEquipamentosL', 'U') IS NULL
                    CREATE TABLE tbEquipamentosL (
                    ID INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
                    TipoEquipamento VARCHAR(50) NOT NULL,
                    NumeroSerie INT NOT NULL, 
                    Modelo VARCHAR(50) NOT NULL,
                    DataAquisicao DATE NOT NULL,
                    Localizacao VARCHAR(50) NOT NULL,
                    Frente INT NOT NULL
                    )";
                    using (SqlCommand cmd = new SqlCommand(CriartbEquipamentosL, conexao))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    conexao.ChangeDatabase("bdInventario");
                    string CriartbEquipamentosN = @" IF OBJECT_ID('tbEquipamentosN', 'U') IS NULL
                    CREATE TABLE tbEquipamentosN (
                    ID INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
                    TipoEquipamento VARCHAR(50) NOT NULL,
                    NumeroSerie INT NOT NULL,
                    Modelo VARCHAR(50) NOT NULL,
                    DataAquisicao DATE NOT NULL,
                    Localizacao VARCHAR(50) NOT NULL,
                    Frente INT NOT NULL
                    )";
                    using (SqlCommand cmd = new SqlCommand(CriartbEquipamentosN, conexao))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados" + ex.Message);
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    internal class clsConexao
    {
        //Classe conexão 
        //Criando conexão com Sql Server (Local)

        private static string conexao = "Data Source=(localdb)\\MSSQLLocalDB ; Initial Catalog=bdIventario; Integrated Security = true;"; //Conexão para chamar para usar comandos

        private static string conexaoCriar = "Data Source=(localdb)\\MSSQLLocalDB ; Initial Catalog=master; Integrated Security = true;"; //Conexao para criar banco sem senha


        public static string StringConexao
        {
            get
            {
                return conexao;
            }
        }

        public static string StringCriar
        {
            get
            {
                return conexaoCriar;
            }
        }


    }
}

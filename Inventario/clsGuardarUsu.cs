using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    internal class clsGuardarUsu
    {
        //Essa classe está criada para receber e armazenar todos os dados coletados pelos usuario para poder ser modelados

        //Variável para guardar o nome
        public static string NomeGuardado
        {
            get; set;
        }
        //Variável para guardar o email
        public static string EmailGuardado
        {
            get; set;
        }
        //Variável para guardar o tipo do usuário
        public static int TipoUsuario
        {
            get; set;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
        //Criar classe estática poruqe se não o método não funciona, quando faz isso não precisa estanciar a classe, é só chamar o método
        public static class FerramentasUI
        {
        //Agora sim o método pode ser feito
             public static void LimparBtns(this Control campo, string textoPadrao)
              {
            campo.Text = textoPadrao;
            //Colocar a mensagem padrão no campo armazenado pelo Sender
            //Tem que usar o this Control porque a gente ta usando Material Skin, texto padrão é o texto que vai ser definido por variável no txt
            campo.Enter += (sender, e) =>
                        {
                            //Aqui é para armazenar cada ação do usuário dentro do campo ou seja se ele esta no campo txtEmail, ele vai armazenar no SENDER e se ele der Tab a ação é armazenada dentro do E. o "=>" seria o arrow function, aqui é mais pra não ter q usar e fazer um método separado gigantesco
                           
                            if (campo.Text == textoPadrao)
                            {
                                campo.Text = "";
                            }
                     
                        };

                  campo.Leave += (sender, e) =>
                    {
                        //mesma lógica do método de cima, ele armazena o campo no SENDER e a ação LEAVE no E, é meio que um if, tipo SE sair do campo, armazena e faça isso no caso o código debaixo
                        if (string.IsNullOrWhiteSpace(campo.Text))
                        {
                            campo.Text = textoPadrao;
                        }
                    };
              }


        }
    //Fim do método é meio complicado de gravar mais é facil de achar pra fazer ou de entender, agora tem que ir para a tela de login
    
}
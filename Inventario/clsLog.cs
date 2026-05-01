using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms; // Biblioteca importada para usar as classes do windows Forms

namespace Inventario
{ 
    //IMPORTANTE: A classe log deve ser chamada para cada ação que o usuário fazer, tudo que é clicável o log deve ser chamado com a sua mensagem e o usuario carregado pela classe clsGuarda
    internal class clsLog
    {
        //Classe Log para analisar oque os usuários estão fazendo, da pra fazer de várias formas aqui eu optei por fazer em uma pasta em arquivo txt mais tem como fazer mais legal e bonito só que da mais trampo
        //Complicado mais intendível, João: Entendi

        //String do caminho da pasta
        private static string pastaLog = Path.Combine(Application.StartupPath, "Logs");

        /*Seguinte essa string faz assim: ta verificando a pasta do projeto e ele ve se tem a pasta "Logs", e concatena com a pasta inicial ou seja ele pega a pasta raíz e coloca o arquivo nas pastas padrões de arquivos temporarios, vulgo pasta bin/debug */

        /*"A Ehdin eu quero trocar a pasta pq eu so o jão e dou o cu" FODASSE
         mentira tem que fazer assim:
        string rootPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")); Pega a pasta, o caminho da pasta que você quer aqui ele volta as pasta, mas a idéia é a mesma
        private static string pastaLog = Path.Combine(rootPath, "Logs");  e combina com o log 
        após isso vou voltar a fazer meu projeto obrigado denada, amado João Pedro 
        */
        //Método para o escrever o log

        private static void EscreverLog(string Mensagem)
        {
            try
            {
                //Verificação da pasta log la de cima
                if (!Directory.Exists(pastaLog))
                {
                    Directory.CreateDirectory(pastaLog);
                }
                //Após criado / verificado temos que fazer ele criar os arquivos
                string NomeArquivo = $"Log_{DateTime.Now:yyyyMMdd}.txt";
                //Toda vez que o dia trocar ele perceber q vai ser um dia diferente e cria um log, da pra fazer depois verificar pro hora eai a cada 3 horas ele cria um log e depois zipa tudo em um dia muito foda isso
                //Agora pegar o caminho inteiro da pasta e concatena com o arquivo
                string CaminhoLog = Path.Combine(pastaLog, NomeArquivo);
                //Frase do log
                string LinhaLog = $"[{DateTime.Now:dd/MM/yyyy HH:mm:ss}] - {Mensagem}{Environment.NewLine}";
                //Environment ele pula para linha debaixo após escrever o log
                //E por ultimo salvar o arquivo log
                File.AppendAllText(CaminhoLog, LinhaLog);
                //Aqui ele verifica se o arquivo existe mesmo, se existir OK e junta com a ultima linha do log, se não existir ele vai criar uma nova

            }
            catch (Exception ex)
            {

                //Mensagem de erro
                System.Diagnostics.Debug.WriteLine($"ERRO, o log falhou {ex.Message}");
            }
        }


    }
}

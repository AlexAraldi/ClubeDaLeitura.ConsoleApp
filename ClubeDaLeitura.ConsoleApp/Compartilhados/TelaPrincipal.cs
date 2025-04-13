
namespace ClubeDaLeitura.ConsoleApp.Compartilhados
{
    public class TelaPrincipal
    {

        public char ApresentarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("|              Clude da Leitura             |");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine();

            Console.WriteLine("1) Menu de Amigos");
            Console.WriteLine("2) Menu de caixas");
            Console.WriteLine("3) Menu de empréstimos");
            Console.WriteLine("4) Menu de revistas");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");
            char opcaoEscolhida = Console.ReadLine()[0];

            return opcaoEscolhida;


        }


    }

}





    // Aqui criar switch case para todos os menus 
    // os repositorios armazenam a logica dos metodos de cada arquivo
    // tela apresenta a interacao com o usuario e chama os metodos do repositorio 


    // criar os geradores de ids um pra cada objeto .
    // primeiro passos desenvolver o crud repositorio
    // segundo realizar tela



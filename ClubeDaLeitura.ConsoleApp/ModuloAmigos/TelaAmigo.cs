
namespace ClubeDaLeitura.ConsoleApp.ModuloAmigos
{
    // Requisitos Funcionais
    //  ● O sistema deve permitir a inserção de novos amigos 
    //  ● O sistema deve permitir a edição de amigos já cadastrados
    //  ● O sistema deve permitir excluir amigos já cadastrados
    //  ● O sistema deve permitir visualizar amigos cadastrados 
    //  ● O sistema deve permitir visualizar os empréstimos do amigo.
   


    public class TelaAmigo
    {

        public void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|         Cadastros de Amigos           |");
            Console.WriteLine("-----------------------------------------");

        }
        public char ApresentarMenuAmigos()
        {
            ExibirCabecalho();

            Console.WriteLine();
            Console.WriteLine("1) Cadastrar novo amigo:");
            Console.WriteLine("2) Editar cadastro de amigo:");
            Console.WriteLine("3) Excluir cadastro de amigo:");
            Console.WriteLine("4) Vizualizar cadastro de amigo:");

            Console.WriteLine("S) para sair:");
            Console.WriteLine();
            Console.WriteLine("Digite uma opção válida");
            char opcaoEscolhida = Console.ReadLine()[0];     //<<<- pq array ????

            return opcaoEscolhida;

        }

    }
}

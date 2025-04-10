
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevistas
{
//  Requisitos Funcionais:
//      ● O sistema deve permitir cadastrar novas revistas
//      ● O sistema deve permitir editar revistas existentes
//      ● O sistema deve permitir excluir revistas
//      ● O sistema deve permitir visualizar todas as revistas
//      ● O sistema deve mostrar o status atual(disponível/emprestada/reservada)
//  
    public class TelaRevista
    {
        public void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|         Cadastros de Revistas           |");
            Console.WriteLine("-----------------------------------------");

        }
        public char ApresentarMenuAmigos()
        {
            ExibirCabecalho();

            Console.WriteLine();
            Console.WriteLine("1) Cadastrar nova revista:");
            Console.WriteLine("2) Editar cadastro de revistas:");
            Console.WriteLine("3) Excluir cadastro de revistas:");
            Console.WriteLine("4) Vizualizar cadastro de revistas:");

            Console.WriteLine("S) para sair:");
            Console.WriteLine();
            Console.WriteLine("Digite uma opção válida");
            char opcaoEscolhida = Console.ReadLine()[0];     //<<<- pq array ????

            return opcaoEscolhida;

        }

    }
}

    }
}

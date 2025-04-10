

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixas
{
// Requisitos Funcionais: 
//  ● O sistema deve permitir cadastrar novas caixas 
//  ● O sistema deve permitir editar caixas existentes 
//  ● O sistema deve permitir excluir caixas
//  ● O sistema deve permitir visualizar todas as caixas



    public class TelaCaixa
    {
        public void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|         Cadastros de Caixas           |");
            Console.WriteLine("-----------------------------------------");

        }
        public char ApresentarMenuCaixas()
        {
            ExibirCabecalho();

            Console.WriteLine();
            Console.WriteLine("1) Cadastrar nova caixa:");
            Console.WriteLine("2) Editar cadastro de caixa:");
            Console.WriteLine("3) Excluir cadastro de caixa:");
            Console.WriteLine("4) Vizualizar cadastro de caixa:");

            Console.WriteLine("S) para sair:");
            Console.WriteLine();
            Console.WriteLine("Digite uma opção válida");
            char opcaoEscolhida = Console.ReadLine()[0];     //<<<- pq array ????

            return opcaoEscolhida;

        }



    }
}

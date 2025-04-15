



namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimos
{
//   Requisitos Funcionais:
//      ● O sistema deve permitir registrar novos empréstimos
//      ● O sistema deve permitir registrar devoluções
//      ● O sistema deve permitir visualizar empréstimos abertos e fechados



    public class TelaEmprestimo
    {
        RepositorioEmprestimo repositorioEmprestimo;

        public TelaEmprestimo(RepositorioEmprestimo repositorioEmprestimo) 
        {
            this.repositorioEmprestimo = repositorioEmprestimo;
        }

        public void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|         Cadastro de empréstimos           |");
            Console.WriteLine("-----------------------------------------");

        }
        public char ApresentarMenuAmigos()
        {
            ExibirCabecalho();

            Console.WriteLine();
            Console.WriteLine("1) Cadastrar nova empréstimo:");
            Console.WriteLine("2) Editar cadastro de empréstimo:");
            Console.WriteLine("3) Excluir cadastro de empréstimo:");
            Console.WriteLine("4) Vizualizar cadastro de empréstimo:");

            Console.WriteLine("S) para sair:");
            Console.WriteLine();
            Console.WriteLine("Digite uma opção válida");
            char opcaoEscolhida = Console.ReadLine()[0];     //<<<- pq array ????

            return opcaoEscolhida;

        }

    }
}

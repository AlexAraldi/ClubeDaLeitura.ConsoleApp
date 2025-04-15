



using ClubeDaLeitura.ConsoleApp.ModuloAmigos;
using ClubeDaLeitura.ConsoleApp.ModuloCaixas;
using ClubeDaLeitura.ConsoleApp.ModuloRevistas;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimos
{
//   Requisitos Funcionais:
//      ● O sistema deve permitir registrar novos empréstimos
//      ● O sistema deve permitir registrar devoluções
//      ● O sistema deve permitir visualizar empréstimos abertos e fechados



    public class TelaEmprestimo
    {
        RepositorioEmprestimo repositorioEmprestimo;
        RepositorioAmigo repositorioAmigo;
        RepositorioRevista repositorioRevista;


        public TelaEmprestimo(RepositorioEmprestimo repositorioEmprestimo, RepositorioAmigo repositorioAmigo, RepositorioRevista repositorioRevista) 
        {
            this.repositorioEmprestimo = repositorioEmprestimo;
            this.repositorioAmigo = repositorioAmigo;
            this.repositorioRevista = repositorioRevista;
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
            char opcaoEscolhida = Console.ReadLine()[0];  

            return opcaoEscolhida;

        }

        public void CadastrarEmprestimo()
        {
            Console.Clear();
            int idAmigo = 0, idRevista = 0;
            int diasEmprestimo = 0;
            DateTime hoje = DateTime.Today;
            ListarAmigos();
            idAmigo = ObterIdUsuario(idAmigo);
            Amigo amigo = repositorioAmigo.BuscarAmigo(idAmigo);
            idRevista = ObterIdRevista(idRevista);
            Emprestimo emprestimo = new Emprestimo(amigo, idRevista, hoje, dataDevolucao, status);
        }
        public int ObterIdUsuario(int idAmigo)
        {
            Console.WriteLine("Digite Id do Amigo: ");
            idAmigo = Convert.ToInt32(Console.ReadLine())!;
            return idAmigo;
        }
        public int ObterIdRevista(int idRevista)
        {
            Console.WriteLine("Digite Id da revista:");
            idRevista =Convert.ToInt32 (Console.ReadLine())!;
            return idRevista;
        }
        public int ObterDiaEmprestimos(int diasEmprestimo)
        {
            Console.WriteLine("Digite quantos dias de empréstimo:");
            diasEmprestimo = Convert.ToInt32(Console.ReadLine());
            return diasEmprestimo;
        }
        public void ListarAmigos()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|         Lista de Amigos           |");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine(
          "{0, -6} | {1, -20} | {2, -30} | {3, -30} ",
          "Id", "Nome", "Nome Responsável", "Telefone");

            Amigo[] amigos = repositorioAmigo.SelecionarAmigo();
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null) continue;
                Console.WriteLine("{0, -6} | {1, -20} | {2, -30} | {3, -30} ",
                amigos[i].Id, amigos[i].Nome, amigos[i].NomeResponsavel, amigos[i].Telefone);
            }
            Console.ReadLine();
        }

    }
}

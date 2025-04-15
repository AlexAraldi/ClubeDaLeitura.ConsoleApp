
using ClubeDaLeitura.ConsoleApp.ModuloCaixas;

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
        RepositorioCaixa repositorioCaixa;
        RepositorioRevista repositorioRevista;

        public TelaRevista(RepositorioRevista repositorioRevista, RepositorioCaixa repositorioCaixa)
        {
            this.repositorioRevista = repositorioRevista;
            this.repositorioCaixa = repositorioCaixa;

        }
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
            char opcaoEscolhida = Console.ReadLine()[0];

            return opcaoEscolhida;

        }
        public void CadastrarRevista()
        {
            Console.Clear();
            string titulo = " ";
            int status = 0, anoPublicacao = 0, edicao = 0;
            titulo = ObterTituloRevista(titulo);
            status = ObterStatus(status);
            anoPublicacao = ObterAnoPublicacao(anoPublicacao);
            edicao = ObterEdicao(edicao);
            Revista revista = new Revista(titulo, status, anoPublicacao, edicao);
            repositorioRevista.CadastrarRevista(revista);
        }
        public string ObterTituloRevista(string titulo)
        {
            Console.WriteLine("Digite nome da nova revista: ");
            titulo = Console.ReadLine();
            return titulo;
        }
        public int ObterStatus(int status)
        {
            Console.WriteLine("Digite o status: ");
            status = Convert.ToInt32(Console.Read());
            return status;
        }
        public int ObterAnoPublicacao(int anoPublicacao)
        {
            Console.WriteLine("Digite o número da publicação: ");
            anoPublicacao = Convert.ToInt32(Console.Read());
            return anoPublicacao;
        }
        public int ObterEdicao(int edicao)
        {
            Console.WriteLine("Digite o número da edição: ");
            edicao = Convert.ToInt32(Console.Read());
            return edicao;
        }
        public void ListarRevista()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|         Lista de Revistas           |");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine(
          "{0, -6} | {1, -20} | {2, -30} | {3, -30} ",
          "Título", "Status", "Ano Publicação", "Edição");

            Revista[] revista = repositorioRevista.SelecionarRevista();
            for (int i = 0; i < revista.Length; i++)
            {
                if (revista[i] == null) continue;
                Console.WriteLine("{0, -6} | {1, -20} | {2, -30} | {3, -30} ",
                revista[i].Titulo, revista[i].Status, revista[i].AnoPublicacao , revista[i].Edicao);
            }
            Console.ReadLine();
        }


    }

}


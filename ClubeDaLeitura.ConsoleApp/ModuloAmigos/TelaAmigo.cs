namespace ClubeDaLeitura.ConsoleApp.ModuloAmigos
{
    public class TelaAmigo
    {
        RepositorioAmigo repositorioAmigo;
        public TelaAmigo(RepositorioAmigo repositorioAmigo)
        {
           this.repositorioAmigo = repositorioAmigo;
        }

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
            char opcaoEscolhida = Console.ReadLine()!.ToUpper()[0];     

            return opcaoEscolhida;

        }

        public void CadastrarAmigo()
        {
            Console.Clear();
            string nome = " ", nomeResponsavel = " ", telefone = " ";
           
            nome = ObterNomeAmigo(nome);
            nomeResponsavel = ObterNomeResponsavel(nomeResponsavel);
            telefone = ObterTelefone(telefone);
            Amigo amigo = new Amigo(nome, nomeResponsavel, telefone);
            repositorioAmigo.CadastrarAmigo(amigo);
        }

       
        public string ObterNomeAmigo(string Nome)
        {
            Console.WriteLine("Digite nome do novo amigo: ");
            Nome = Console.ReadLine();
            return Nome;
        }
        public string ObterNomeResponsavel(string NomeResponsavel)
        {
            Console.WriteLine("Digite o nome do responsável: ");
            NomeResponsavel = Console.ReadLine();
            return NomeResponsavel;
        }
        public string ObterTelefone(string Telefone)
        {
            Console.WriteLine("Digite Telefone (formato validado: (XX) XXXX-XXXX ou (XX) XXXXX-XXXX): ");
            Telefone = Console.ReadLine();
            return Telefone;
        }
        
        public void VizualizarTodos()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|         Lista de Amigos           |");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine(
          "{0, -6} | {1, -20} | {2, -30} | {3, -30} ",
          "Id", "Nome", "Nome Responsável", "Telefone");

            Amigo[] amigos = repositorioAmigo.SelecionarTodos();
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null) continue;
                Console.WriteLine("{0, -6} | {1, -20} | {2, -30} | {3, -30} ",
                amigos[i].Id, amigos[i].Nome, amigos[i].NomeResponsavel, amigos[i].Telefone );
            }
            Console.ReadLine();

        }


        public void ExcluirAmigo()
        {

            
        }
        public void EditarAmigo()
        {

        }
        public void VizualizarEmprestimo()
        {

        }








    }
}

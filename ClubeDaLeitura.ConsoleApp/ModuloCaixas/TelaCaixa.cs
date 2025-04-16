
namespace ClubeDaLeitura.ConsoleApp.ModuloCaixas
{
    // Requisitos Funcionais: 
    //  ● O sistema deve permitir cadastrar novas caixas 
    //  ● O sistema deve permitir editar caixas existentes 
    //  ● O sistema deve permitir excluir caixas
    //  ● O sistema deve permitir visualizar todas as caixas



    public class TelaCaixa
    {
        RepositorioCaixa repositorioCaixa;
        public TelaCaixa(RepositorioCaixa repositorioCaixa)
        {
            this.repositorioCaixa = repositorioCaixa;
        }
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
            char opcaoEscolhida = Console.ReadLine()!.ToUpper()[0];

            return opcaoEscolhida;
        }
        public void CadastrarCaixas()
        {
            Console.Clear();
            string nomeEtiqueta = " ", corEtiqueta = " ";
            int diasEmprestimo = 0;
            nomeEtiqueta = ObterNomeEtiquetas(nomeEtiqueta);
            corEtiqueta = ObterCorEtiquetas(corEtiqueta);
            diasEmprestimo = ObterDiaEmprestimos(diasEmprestimo);
            Caixa caixa = new Caixa(nomeEtiqueta, corEtiqueta, diasEmprestimo);
            repositorioCaixa.CadastrarCaixas(caixa);
        }
        public string ObterNomeEtiquetas(string nomeEtiqueta)
        {
            Console.WriteLine("Digite nome da etiqueta da caixa: ");
            nomeEtiqueta = Console.ReadLine()!;
            return nomeEtiqueta;
        }
        public string ObterCorEtiquetas(string corEtiqueta)
        {
            Console.WriteLine("Digite cor da etiqueta da caixa:");
            corEtiqueta = Console.ReadLine()!;
            return corEtiqueta;
        }
        public int ObterDiaEmprestimos(int diasEmprestimo)
        {
            Console.WriteLine("Digite quantos dias de empréstimo:");
            diasEmprestimo = Convert.ToInt32(Console.ReadLine());
            return diasEmprestimo;
        }
        public void VizualizarTodos()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|         Lista de Caixas           |");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine(
          "{0, -6} | {1, -20} | {2, -30} | {3, -30} ",
          "Id", "Etiqueta", "Cor Etiqueta", "Dias de empréstimo");

            Caixa[]caixas = repositorioCaixa.SelecionarTodos();
            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] == null) continue;
                Console.WriteLine("{0, -6} | {1, -20} | {2, -30} | {3, -30} ",
                caixas[i].Id, caixas[i].NomeEtiqueta, caixas[i].CorEtiqueta, caixas[i].DiasEmprestimo);
            }
            Console.ReadLine();
        }

        // telaCaixa = implementar os metodos = Editar( ), Excluir( ),
        public void Editar(int id)
        {

        }

        public void Excluir()
        {

        }



    }
}

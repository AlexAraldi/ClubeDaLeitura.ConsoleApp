using ClubeDaLeitura.ConsoleApp.ModuloAmigos;
using ClubeDaLeitura.ConsoleApp.ModuloCaixas;
using ClubeDaLeitura.ConsoleApp.ModuloEmprestimos;
using ClubeDaLeitura.ConsoleApp.ModuloRevistas;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program

    {
        static void Main(string[] args)
        {
            RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
            RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
            RepositorioRevista repositorioRevista = new RepositorioRevista();
            RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();
            TelaAmigo telaAmigo = new TelaAmigo(repositorioAmigo);
            TelaCaixa telaCaixa = new TelaCaixa(repositorioCaixa);
            TelaEmprestimo telaEmprestimo = new TelaEmprestimo(repositorioEmprestimo , repositorioAmigo, repositorioRevista);
            TelaRevista telaRevista = new TelaRevista(repositorioRevista, repositorioCaixa);
            telaAmigo.CadastrarAmigo();
            telaAmigo.VizualizarTodos();
            telaCaixa.CadastrarCaixas();
            telaCaixa.VizualizarTodos();
        }


    }
}

// blocos faltantes:
// 
// dentro do objeto amigo.cs = implementar os metodos = Validar( ), ObterEmprestimos( )
// tela amigo = implementar = tela de excluiramigo(), editaramigo(), vizualizaremprestimos();
//
// dentro do objeto caixa.cs = implementar os metodos = Validar(), AdicionarRevista(),RemoverRevista()
// dentro do repositorioCaixa = implementar o metodo =  SelecionarPorId( ) 
// telaCaixa = implementar os metodos = Editar( ), Excluir( ),
//
// dentro do objeto revista.cs = implementar os metodos = Validar(), Emprestar(), Devolver(), Reservar()
// dentro do repositorioRevista = implementar os metodos = SelecionarTodos(),SelecionarPorId()
// dentro do telaRevista = implementar os metodos = VisualizarCaixas()
//
// dentro do objeto Emprestimo.cs = implementar os metodos = Validar( ), ObterDataDevolucao( ), RegistrarDevolucao()
// dentro do repositorioEmprestimo = implementar os metodos = Inserir( ), Editar( ), Excluir( ),SelecionarTodos(), SelecionarPorId()
// dentro do telaEmprestimo = implementar os metodos = VisualizarRevistas(),VisualizarAmigos(),RegistrarDevolucao()

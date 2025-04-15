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
            TelaEmprestimo telaEmprestimo = new TelaEmprestimo(repositorioEmprestimo);
            TelaRevista telaRevista = new TelaRevista(repositorioRevista, repositorioCaixa);
            telaAmigo.CadastrarAmigo();
            telaAmigo.ListarAmigos();
            telaCaixa.CadastrarCaixas();
            telaCaixa.ListarCaixas();
        }


    }
}



// tela revista 
// seguindo os mesmos parametros do tela caixa

// tela emprestimo 
// seguir os parametros 
// puxar revista e amigo 

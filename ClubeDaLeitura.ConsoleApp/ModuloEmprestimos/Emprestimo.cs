

using ClubeDaLeitura.ConsoleApp.ModuloAmigos;
using ClubeDaLeitura.ConsoleApp.ModuloRevistas;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimos
{


    public class Emprestimo
    {
        public int Id;
        public Amigo Amigo;
        public Revista Revista;
        public DateTime DataEmprestimo;
        public DateTime DataDevolucao;
        public string Status;

        public Emprestimo(Amigo amigo, Revista revista, DateTime dataEmprestimo, DateTime dataDevolucao, string status)
        {
            Amigo = amigo;
            Revista = revista;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
            Status = status;
        }
        // dentro do objeto Emprestimo.cs = implementar os metodos = Validar( ), ObterDataDevolucao( ), RegistrarDevolucao()
        public void Validar()
        {

        }
        public void ObterDataDevolucao()
        {
            DataEmprestimo = DateTime.Now;
        }
        public void RegistrarDevolucao()
        {
            DataEmprestimo = DateTime.Now;
        }



    }



}


using ClubeDaLeitura.ConsoleApp.ModuloEmprestimos;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigos
{
   
    public class Amigo                                  // Está é uma classe da regra de negócio para utilizar em algum momento.
    {                                                  // Alt + Enter apos clicar no atributo, seleciona extract method to constructor.          
        public int Id;
        public string Nome;
        public string NomeResponsavel;
        public string Telefone;
        public DateTime DataAbertura;
        public Amigo(string nome, string nomeResponsavel, string telefone)                     
        {
            Nome = nome;
            NomeResponsavel = nomeResponsavel;
            Telefone = telefone;
            DataAbertura = DateTime.Now;
        }
               
        //public string Validar()
        //{
        //    string erros = " ";
        //    if (string.IsNullOrEmpty(Nome))
        //        erros += "O compo nome é obrigatório. \n";
        //    if (Nome.Length < 3 && Nome.Length > 100)
        //        erros += "O nome deve ter no mínimo 3 e máximo 100 caracteres";
        //}
        //public string ObterEmprestimo()
        //{


        //}
    }
    
}

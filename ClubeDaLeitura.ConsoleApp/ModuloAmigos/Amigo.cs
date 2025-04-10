
namespace ClubeDaLeitura.ConsoleApp.ModuloAmigos
{
   

    // Regras de Negócio: 
    //  ● Campos obrigatórios: 
    //   ○ Nome(mínimo 3 caracteres, máximo 100)
    //   ○ Nome do responsável(mínimo 3 caracteres, máximo 100)
    //   ○ Telefone(formato validado: (XX) XXXX-XXXX ou (XX) XXXXX-XXXX)
    //  ● Não pode haver amigos com o mesmo nome e telefone.
    //  ● Não permitir excluir um amigo caso tenha empréstimos vinculados

    public class Amigo                                  // Está é uma classe da regra de negócio para utilizar em algum momento.
                                                        // Alt + Enter apos clicar no atributo, seleciona extract method to constructor.          
    {

        public string NomeAmigo;
        public string NomeResponsavel;
        public string Telefone;

        public Amigo(string nomeAmigo, string nomeResponsavel, string telefone)                     // criado um construtor
        {
            NomeAmigo = nomeAmigo;
            NomeResponsavel = nomeResponsavel;
            Telefone = telefone;
        }
    }
}

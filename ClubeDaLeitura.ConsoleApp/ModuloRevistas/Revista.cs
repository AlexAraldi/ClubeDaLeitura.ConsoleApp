

namespace ClubeDaLeitura.ConsoleApp.ModuloRevistas
{
    //    Regras de Negócio:
    //      ● Campos obrigatórios:
    //        ○ Título(2-100 caracteres)
    //        ○ Número da edição(número positivo)
    //        ○ Ano de publicação(data válida)
    //        ○ Caixa(seleção obrigatória)
    //      ● Não pode haver revistas com mesmo título e edição
    //      ● Status possíveis: Disponível / Emprestada / Reservada
    //      ● Ao cadastrar, o status padrão é "Disponível"

    public class Revista
    {
        public int Id;
        public string Titulo;
        public int Status;
        public int AnoPublicacao;
        public int Edicao;
        public string Caixa;

        public Revista (string titulo, int status, int anoPublicacao, int edicao)
        {
            Titulo = titulo;
            Status = status;
            AnoPublicacao = anoPublicacao;
            Edicao = edicao;
        }


       

    }

}

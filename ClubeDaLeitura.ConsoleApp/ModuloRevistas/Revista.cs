

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
        public string TituloRevista;
        public int NumeroEdicao;
        public DateTime AnoPublicacao;

        public Revista(string tituloRevista, int numeroEdicao, DateTime anoPublicacao)
        {
            TituloRevista = tituloRevista;
            NumeroEdicao = numeroEdicao;
            AnoPublicacao = anoPublicacao;
        }
    }
}

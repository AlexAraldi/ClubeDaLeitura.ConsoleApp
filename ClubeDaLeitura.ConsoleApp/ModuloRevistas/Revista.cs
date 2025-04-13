

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
        public int AnoPublicacao;

        public Revista(string tituloRevista, int numeroEdicao, int anoPublicacao)
        {
            TituloRevista = tituloRevista;
            NumeroEdicao = numeroEdicao;
            AnoPublicacao = anoPublicacao;
        }


        public int ObterAnoPublicacao()
        {
            Console.WriteLine("Digite o número da publicação: ");
            return 0;
        }
        public string ObterTituloRevista()
        {
            Console.WriteLine("Digite nome do nova revista: ");
            return TituloRevista;
        }
        public int ObterNumeroEdicao()
        {
            Console.WriteLine("Digite o número da edição: ");
            return NumeroEdicao;
        }

    }

}

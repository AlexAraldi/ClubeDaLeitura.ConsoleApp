

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixas
{
    // Regras de Negócio: 
    //  ● Campos obrigatórios: 
    //    ○ Etiqueta(texto único, máximo 50 caracteres)
    //    ○ Cor(seleção de paleta ou hexadecimal)
    //    ○ Dias de empréstimo(número, padrão 7)
    //  ● Não pode haver etiquetas duplicadas 
    //  ● Não permitir excluir uma caixa caso tenha revistas vinculadas 
    //  ● Cada caixa define o prazo máximo para empréstimo de suas revistas
    public class Caixa
    {
        public string NomeCaixas;
        public string NomeEtiquetas;
        public int DataEmprestimo;

        public Caixa(string nomeCaixas, string nomeEtiquetas, int dataEmprestimo)
        {
            NomeCaixas = nomeCaixas;
            NomeEtiquetas = nomeEtiquetas;
            DataEmprestimo = dataEmprestimo;
        }



    }
}

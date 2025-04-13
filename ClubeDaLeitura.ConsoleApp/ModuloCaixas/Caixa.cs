

using ClubeDaLeitura.ConsoleApp.ModuloRevistas;

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
        public int DataEmprestimos;
        public Revista[] Revistas;
        public DateTime DataAbertura;

        public Caixa(string nomeCaixas, string nomeEtiquetas, int dataEmprestimos)
        {
            NomeCaixas = nomeCaixas;
            NomeEtiquetas = nomeEtiquetas;
            DataEmprestimos = dataEmprestimos;
            DataAbertura = DateTime.Now;

        }

        public int ObterTempoDecorrido()
        {
            TimeSpan diferencaTempo = DateTime.Now.Subtract(DataAbertura);

            return diferencaTempo.Days;
        }

        public string ObterNomeCaixas()
        {
            Console.WriteLine("Digite nome da caixa: ");
            return NomeCaixas;
        }
        public string ObterNomeEtiquetas()
        {
            Console.WriteLine("Digite nome da etiqueta");
            return NomeEtiquetas;
        }

       

    }
}

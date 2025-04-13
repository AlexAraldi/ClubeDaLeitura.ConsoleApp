

using ClubeDaLeitura.ConsoleApp.ModuloAmigos;
using ClubeDaLeitura.ConsoleApp.ModuloRevistas;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimos
{
    //   Regras de Negócio:
    //      ● Campos obrigatórios:
    //        ○ Amigo
    //        ○ Revista(disponível no momento)
    //        ○ Data empréstimo(automática)
    //        ○ Data devolução(calculada conforme caixa)
    //      ● Status possíveis: Aberto / Concluído / Atrasado
    //      ● Cada amigo só pode ter um empréstimo ativo por vez
    //      ● Empréstimos atrasados devem ser destacados visualmente
    //      ● A data de devolução é calculada automaticamente(data empréstimo + dias da
    //      caixa)

   public class Emprestimo                      // isso aqui ta errado.
    {
        public int Id;
        public Amigo Amigo;
        public Revista Revista;
        public DateTime DataEmprestimo;
        public DateTime DataDevolucao;
        public string Status;
    }
}

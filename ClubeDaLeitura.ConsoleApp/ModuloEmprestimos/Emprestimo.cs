

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
        public string NomeAmigo;
        public string NomeRevista;
        public int DataEmprestimo;
        public int DataDevolucao;
        public bool Status;

    }
}

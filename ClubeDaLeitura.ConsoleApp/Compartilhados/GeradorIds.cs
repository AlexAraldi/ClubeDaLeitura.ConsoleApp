

namespace ClubeDaLeitura.ConsoleApp.Compartilhados
{

    public static class GeradorIds
    {
        public static int IdAmigos = 0;
        public static int IdRevistas = 0;
        public static int IdCaixas = 0;
        public static int IdEmprestimos = 0;

        public static int GerarIdRevistas()
        {
            IdRevistas++;

            return IdRevistas;
        }

        public static int GerarIdcaixas()
        {
            IdCaixas++;

            return IdCaixas;
        }

        public static int GerarIdCaixas()
        {
            IdAmigos++;

            return IdAmigos;
        }
        public static int GerarEmprestimos()
        {
            IdEmprestimos++;

            return IdEmprestimos;
        }
    }



}



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

        public static int GerarIdCaixas()
        {
            IdCaixas++;

            return IdCaixas;
        }

        public static int GerarIdAmigos()
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

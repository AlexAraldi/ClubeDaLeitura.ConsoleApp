using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.Compartilhados
{

    public static class GeradorIds
    {
        public static int IdAmigos = 0;
        public static int IdRevistas = 0;
        public static int IdCaixas = 0;

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

        public static int GerarIdAmigos()
        {
            IdAmigos++;

            return IdAmigos;
        }
    }



}

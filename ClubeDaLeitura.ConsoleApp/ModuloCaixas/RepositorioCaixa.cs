
using ClubeDaLeitura.ConsoleApp.Compartilhados;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixas
{
    public class RepositorioCaixa
    {
        public Caixa[] caixas = new Caixa[100];
        public int contadorCaixas = 0;

        public void CadastrarCaixas(Caixa novaCaixa)
        {
            novaCaixa.Id = GeradorIds.GerarIdCaixas();

            caixas[contadorCaixas++] = novaCaixa;
        }

        public bool EditarCaixa(int idChamado, Caixa novaCaixa)
        {
            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] == null)
                    continue;

                else if (caixas[i].Id == novaCaixa.Id)
                {
                    caixas[i].NomeEtiqueta = novaCaixa.NomeEtiqueta;
                    caixas[i].CorEtiqueta = novaCaixa.CorEtiqueta;
                    caixas[i].DiasEmprestimo = novaCaixa.DiasEmprestimo;


                    return true;
                }
            }

            return false;
        }

        public Caixa[] SelecionarCaixa()
        {
            return caixas;
        }

        public bool ExcluirCaixa(int idCaixa)
        {
            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] == null) continue;

                else if (caixas[i].Id == idCaixa)
                {
                    caixas[i] = null;

                    return true;
                }
            }

            return false;
        }
    }
}

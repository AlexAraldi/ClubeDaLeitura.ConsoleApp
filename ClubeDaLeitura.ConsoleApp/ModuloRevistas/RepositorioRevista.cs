
using ClubeDaLeitura.ConsoleApp.Compartilhados;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevistas
{
    public class RepositorioRevista
    {
        public Revista[] revista = new Revista[100];
        public int contadorRevista = 0;

        public void CadastrarRevista(Revista novaRevista)
        {
            novaRevista.Id = GeradorIds.GerarIdRevistas();

            revista[contadorRevista++] = novaRevista;
        }

        public bool EditarRevista(int idChamado, Revista novaRevista)
        {
            for (int i = 0; i < revista.Length; i++)
            {
                if (revista[i] == null)
                    continue;

                else if (revista[i].Id == novaRevista.Id)
                {
                    revista[i].Titulo = novaRevista.Titulo;
                    revista[i].Status = novaRevista.Status;
                    revista[i].AnoPublicacao = novaRevista.AnoPublicacao;
                    revista[i].Edicao = novaRevista.Edicao;

                    
                    return true;
                }
            }

            return false;
        }

        public Revista[] SelecionarRevista()     // implementar se for null, nao retornar. Para somente mandar os blocos do array quer forem completos
        {
            return revista;
        }

        public bool ExcluirRevista(int idCaixa)
        {
            for (int i = 0; i < revista.Length; i++)
            {
                if (revista[i] == null) continue;

                else if (revista[i].Id == idCaixa)
                {
                    revista[i] = null;

                    return true;
                }
            }

            return false;
        }
        // dentro do repositorioRevista = implementar os metodos = SelecionarTodos(),SelecionarPorId()
        public void SelecionarTodos()
        {

        }
        public void SelecionarPorId()
        {

        }


    }
}

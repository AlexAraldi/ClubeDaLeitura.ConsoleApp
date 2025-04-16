

using ClubeDaLeitura.ConsoleApp.Compartilhados;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigos
{
    public class RepositorioAmigo
    {
        public Amigo[] amigos = new Amigo[100];
        public int contadorAmigos = 0;

        public void CadastrarAmigo(Amigo novoAmigo)
        {
            novoAmigo.Id = GeradorIds.GerarIdAmigos();

            amigos[contadorAmigos++] = novoAmigo;
        }

        public bool EditarAmigo(int idChamado, Amigo novoAmigo)
        {
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                    continue;

                else if (amigos[i].Id == novoAmigo.Id)
                {
                    amigos[i].Nome = novoAmigo.Nome;
                    amigos[i].NomeResponsavel = novoAmigo.NomeResponsavel;
                    amigos[i].Telefone = novoAmigo.Telefone;
                    amigos[i].DataAbertura = novoAmigo.DataAbertura;

                    return true;
                }
            }

            return false;
        }

        public Amigo[] SelecionarTodos()     // implementar se for null, nao retornar. Para somente mandar os blocos do array quer forem completos.
        {
            return amigos;
        }

        public bool ExcluirAmigo(int idAmigos)
        {
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null) continue;

                else if (amigos[i].Id == idAmigos)
                {
                    amigos[i] = null;

                    return true;
                }
            }

            return false;
        }
        public Amigo SelecionarPorId(int idamigo)
        {
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i].Id == idamigo)
                {
                    return amigos[i];
                }
            }
            return null;
        } 





    }

}


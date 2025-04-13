

using ClubeDaLeitura.ConsoleApp.Compartilhados;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigos
{
    public Amigo[] amigos = new Amigo[100];
    public int contadorAmigos = 0;

    public void CadastrarAmigo(Amigo novoAmigo)
    {
        novoAmigo.Id = GeradorIds.GerarIdAmigo();

        Amigos[contadorAmigo++] = novoAmigo;
    }

    public bool EditarAmigo(int idChamado, Amigo novoAmigo)
    {
        for (int i = 0; i < amigos.Length; i++)
        {
            if (amigos[i] == null)
                continue;

            else if (amigos[i].Id == idAmigos)
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

    public Amigos[] SelecionarAmigos()
    {
        return amigos;
    }

    public bool ExcluirAmigos(int idAmigos)
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
}
}

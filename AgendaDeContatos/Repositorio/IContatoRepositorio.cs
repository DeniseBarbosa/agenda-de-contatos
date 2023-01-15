using AgendaDeContatos.Models;
using System.Collections.Generic;

namespace AgendaDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}

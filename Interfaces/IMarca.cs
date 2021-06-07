using System.Collections.Generic;
using Projeto_ProdutosPOO.Classes;

namespace Projeto_ProdutosPOO.Interfaces
{
    public interface IMarca
    {
         string Cadastrar(Marca marca);
         List<Marca> Listar();
         string Deletar(Marca marca);
    }
}
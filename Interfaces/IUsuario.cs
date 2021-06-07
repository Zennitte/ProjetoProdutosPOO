using Projeto_ProdutosPOO.Classes;

namespace Projeto_ProdutosPOO.Interfaces
{
    public interface IUsuario
    {
         string Cadastrar(Usuario usuario);
         string Deletar(Usuario usuario);
    }
}
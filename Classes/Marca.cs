using System;
using System.Collections.Generic;
using Projeto_ProdutosPOO.Interfaces;

namespace Projeto_ProdutosPOO.Classes
{
    public class Marca : IMarca
    {
        private int Codigo { get; set; }

        internal static void Cadastrar(object marca)
        {
            throw new NotImplementedException();
        }

        private string NomeMarca { get; set; }
        private DateTime DataCadastro { get; set; }    
        List<Marca> marcas = new List<Marca>();
        // Marca novaMarca = new Marca();
        public Marca()
        {

        }
        public Marca(string _nomeMarca)
        {
            NomeMarca = _nomeMarca;
            DataCadastro = DateTime.Now;            
        }
        public string Cadastrar(Marca marca)
        {
            marcas.Add(marca);
            return "Marca Cadastrada";
        }

        public string Deletar(Marca marca)
        {
            marcas.RemoveAll(x => x.NomeMarca == marca.NomeMarca);
            return "Marca Removida";
        }

        public List<Marca> Listar()
        {
            return marcas;
        }
    }
}
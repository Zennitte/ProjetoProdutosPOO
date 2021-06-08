using System;
using System.Collections.Generic;
using Projeto_ProdutosPOO.Interfaces;

namespace Projeto_ProdutosPOO.Classes
{
    public class Marca : IMarca
    {
        private int Codigo { get; set; }
        private string NomeMarca { get; set; }
        private DateTime DataCadastro { get; set; }    
        List<Marca> ListaMarcas = new List<Marca>();
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
            ListaMarcas.Add(marca);
            return "Marca Cadastrada";
        }

        public string Deletar(Marca marca)
        {
            ListaMarcas.RemoveAll(x => x.NomeMarca == marca.NomeMarca);
            return "Marca Removida";
        }

        public List<Marca> Listar()
        {
            return ListaMarcas;
        }
    }
}
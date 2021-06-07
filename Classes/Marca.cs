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
        Marca novaMarca = new Marca();
        public string Cadastrar(Marca marca)
        {
            Console.WriteLine("Qual o código da marca?");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o nome da marca?");
            novaMarca.NomeMarca = Console.ReadLine();
            
            novaMarca.DataCadastro = DateTime.Now;

            marca = novaMarca;

            marcas.Add(marca);
            return "Marca Cadastrada";
        }

        public string Deletar(Marca marca)
        {
            Console.WriteLine("Qual marca você quer remover");
            string marcaRemovida = Console.ReadLine();

            marcas.RemoveAll(x => x.NomeMarca == marcaRemovida);
            return "Marca Removida";
        }

        public List<Marca> Listar()
        {
            return marcas;
        }
    }
}
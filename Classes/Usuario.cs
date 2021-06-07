using System;
using System.Collections.Generic;
using Projeto_ProdutosPOO.Interfaces;

namespace Projeto_ProdutosPOO.Classes
{
    public class Usuario : IUsuario
    {
        private int Codigo;
        private string Nome;
        private string Email;
        private string Senha;
        private DateTime DataCadastro;
        List<Usuario> usuarios = new List<Usuario>();
        public string Cadastrar(Usuario usuario)
        {
            Usuario novoUsuario = new Usuario();
            Console.WriteLine("Qual o código do usuário?");
            novoUsuario.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o nome do usuário?");
            novoUsuario.Nome = Console.ReadLine();
            Console.WriteLine("Qual o Email do usuário?");
            novoUsuario.Email = Console.ReadLine();
            Console.WriteLine("Qual o senha do usuário?");
            novoUsuario.Senha = Console.ReadLine();
            novoUsuario.DataCadastro = DateTime.Now;
            usuarios.Add(novoUsuario);
            return "Cadastro efetuado";
        }

        public string Deletar(Usuario usuario)
        {
            Console.WriteLine("Qual é o nome do usuario que deseja deletar?");
            string nomeDelete = Console.ReadLine();
            usuarios.RemoveAll(x => x.Nome == nomeDelete);
            return "Cadastro deletado";
        }
    }
}
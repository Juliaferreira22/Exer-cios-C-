using System;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
           Produto produto = new Produto(); // instanciando um objeto 
           produto.setNome("Arroz");
           Console.WriteLine(produto); 

           Usuario usuario = new Usuario(); 
           usuario.Login = "ddeconto";
           Console.WriteLine(usuario.Login); 
           
           Usuario u = new Usuario
           {
               Login = "teste",
               Email = "a@a.com",
               Senha = "1234",
               Idade = 25
           }; 

           Console.WriteLine(u); 
        }
    }
}

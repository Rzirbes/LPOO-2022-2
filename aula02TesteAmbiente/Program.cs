using System;
using Aula02TesteAmbiente.entidades;
using aula02TesteAmbiente.Autor;

namespace Aula02TesteAmbiente
{
    class Program
    {
        static void Main(string[] args)
        {
            //use o ctrl + . para pegar as referências (imports) dos pacotes
            Console.WriteLine("Hello World!");
            Autor oAutor = new Autor(555, "Rafaela");
            Livro objLivro = new Livro(100, "Banco de Dados", oAutor);


            Console.WriteLine(
                objLivro.GetId() + " - " +
                objLivro.GetTitulo() + " - " + 
                objLivro.GetValor() + " - " + 
                objLivro.Autor.Nome);

            objLivro.SetValor(199);
            Console.WriteLine("valor do livro: " + objLivro.GetValor());

            
        }
    }
}

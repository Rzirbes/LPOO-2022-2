using System;
using Aula03Encapsulamento.Domain;

namespace Aula03Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteMsg("Criar o objeto mochila!");

            Mochila mochila = new Mochila(1, "Mochila de Notebook", 199, 10, eCor.Amarelo);

            WriteMsg("Nome: " + mochila.Descricao + 
            "Cor: " + mochila.cor);

            WriteMsg($"Nome {mochila.Descricao}, cor da mochila {mochila.cor}");


        }

        private static void WriteMsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}

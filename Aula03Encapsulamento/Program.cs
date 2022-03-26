using System;
using Aula03Encapsulamento.Domain;

namespace Aula03Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteMsg("Criar o objeto mochila!");

            Mochila mochilaPreta = new Mochila(1, "Mochila de Notebook", 199, 10, eCor.Amarelo);

            WriteMsg("Nome: " + mochilaPreta.Descricao + 
            "Cor: " + mochilaPreta.cor);

            WriteMsg($"Nome {mochilaPreta.Descricao}, cor da mochila {mochilaPreta.cor}");

            Item celular = new Item(100, "Nokia 3030");
            Item caneta = new Item(101, "Caneta de Quadro Branco");
            
            mochilaPreta.Itens.Add(celular);
            mochilaPreta.Itens.Add(caneta);

            WriteMsg("Nome: " + mochilaPreta.Descricao);
            WriteMsg("Itens");
            foreach (var item in mochilaPreta.Itens)
            {
                WriteMsg(item.Nome);
            }


        }

        private static void WriteMsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}

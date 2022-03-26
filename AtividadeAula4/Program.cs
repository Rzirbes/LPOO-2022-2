using System;
using System.Collections.Generic;
using AtividadeAula4.Domain;

namespace AtividadeAula4
{
    class Program
    {
        static Pedido primeiroPedido;
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            //produtos criados
            Produto produto1 = new Produto(100,"teclado", 10, 15.99);
            Produto produto2 = new Produto(100,"mouse", 10, 15.99);
            Produto produto3 = new Produto(100,"tela", 10, 15.99);

            //clientes
            Cliente cliente1 = new Cliente(10, "João Pedro");

            //formas de pagamento
            FormaDePagamento dinheiro = new FormaDePagamento(1, "Dinheiro");
            FormaDePagamento cartao = new FormaDePagamento(2, "Cartão");
            FormaDePagamento cheque = new FormaDePagamento(3, "Cheque");  

            //novo pedido
            primeiroPedido = new Pedido(
                001, 
                new DateTime(2022,03,01),
                cliente1,
                new List<Produto>()
                {
                    produto1, produto2,
                }
            );

            //adicionando forma de pagamento ao pedido
            primeiroPedido.FormaDePagamentos.Add(dinheiro);

            print($"Pedido do {primeiroPedido.Cliente.Nome}, na data {primeiroPedido.Data.ToString("dd/MM//yyyy")}");
            print("------------");
            foreach (var item in primeiroPedido.Produtos)
            {
                print(item.Nome);
            }
            print("---------");
            foreach (var item in primeiroPedido.FormaDePagamentos)
            {
                print(item.Nome);
            }

            


        }

        private static void print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}

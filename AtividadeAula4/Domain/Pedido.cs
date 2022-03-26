using System;
using System.Collections.Generic;

namespace AtividadeAula4.Domain
{
    public class Pedido
    {


        public int Id { get; private set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();
        public List<FormaDePagamento> FormaDePagamentos { get; set; } = new List<FormaDePagamento>();

        public Pedido(int id, DateTime data, Cliente cliente, List<Produto> produtos)
        {
            this.Id = id;
            this.Data = data;
            this.Cliente = cliente;
            this.Produtos = produtos;

        }


    }
}
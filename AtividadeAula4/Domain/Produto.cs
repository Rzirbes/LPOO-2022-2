namespace AtividadeAula4.Domain
{
    public class Produto
    {

        
        public int Cod { get; set; }
        public string Nome { get; set; }
        public int QtdeEstoque { get; set; }
        public double Valor { get; set; }

        public Produto(int cod, string nome, int qtde, double valor)
        {
            this.Cod = cod;
            this.Nome = nome;
            this.QtdeEstoque = qtde;
            this.Valor = valor;

        }

    }
}
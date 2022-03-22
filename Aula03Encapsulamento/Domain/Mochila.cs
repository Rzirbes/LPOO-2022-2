namespace Aula03Encapsulamento.Domain
{
    public class Mochila
    {
        public Mochila(int id, string descricao, decimal preco, int quantMax, eCor cor)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Preco = preco;
            this.QuantMax = quantMax;
            this.cor = cor;

        }
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; set; }
        public int QuantMax { get; private set; }
        public eCor cor { get; set; }



    }
}
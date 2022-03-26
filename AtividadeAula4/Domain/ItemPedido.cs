namespace AtividadeAula4.Domain
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ItemPedido(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;

        }
    }
}
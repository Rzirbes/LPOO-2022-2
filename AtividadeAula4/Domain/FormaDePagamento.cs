namespace AtividadeAula4.Domain
{
    public class FormaDePagamento
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }

        public FormaDePagamento(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;

        }
    }
}
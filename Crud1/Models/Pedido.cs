namespace Crud1.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public decimal Valor { get; set; }
        

        public DateTime Vencimento { get; set; }
        public int PedidoStatus()
        {
            TimeSpan IntervaloDias = Vencimento.Subtract(DateTime.Now);
            int Status = 2;
            if (IntervaloDias.Days <= 0)
            {
                Status = 0;
            }
            else if (IntervaloDias.Days < 2)
            {
                Status = 1;
            }

            return Status;
        }

        
    }
}

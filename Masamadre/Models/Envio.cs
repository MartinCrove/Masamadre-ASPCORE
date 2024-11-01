namespace Masamadre.Models
{
    public class Envio
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public int IdPedido { get; set; }
        public Pedido pedidos { get; set; }
    }
}

namespace Masamadre.Models
{
    public class Usuario
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }

        public string Direccion { get; set;}
        public string Ciudad { get; set; }

        public string Provincia { get; set; }
        public string CodigoPostal { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public List<Pedido> Pedidos { get; set; }
        



    }
}

using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Data;

namespace Masamadre.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdProducto { get; set; } 
        public DataSetDateTime Fecha { get; set; }
        public string Estado { get; set; }
        public float PrecioFinal { get; set; }

        public Usuario Usuarios { get; set; }
        public Producto Productos { get;set; }

    }
}

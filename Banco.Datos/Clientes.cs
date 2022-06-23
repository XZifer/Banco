using Banco.Modelos.Clases;

namespace Banco.Datos
{
    public class Clientes
    {
        public List<Cliente> ListaPokemones { get; set; } = new List<Cliente>();
        public Clientes()
        {
            Cliente C1 = new()
            {
                Nombre = "Jose",
                Monto = 0
                
            };
            Cliente C2 = new()
            {
                Nombre = "Arturo",
                Monto = 5000
            };
            Cliente C3 = new()
            {
                Nombre = "Debora",
                Monto = 63575
            };

        }
}
using Banco.Datos;
using Banco.Modelos.Clases;

namespace Banco.Aplicacion
{
    public class Program
    {
        public static void Main()
        {
            //Mensaje de Bienvenida
            Console.WriteLine("Bienvenido a su banco");
            //Identificarse
            SeleccionarCliente();
            
        }

        private static void SeleccionarCliente()
        {
            //Selecciona un cliente
            Cliente ClienteSeleccionado = null;
            Clientes clientes = new Clientes();
            
            while (ClienteSeleccionado == null)
            {
                Console.WriteLine("Ingrese su nombre:");
                string ClienteElegido = Console.ReadLine();
                switch (ClienteElegido)
                {
                    case "Jose":
                        ClienteSeleccionado = clientes.ObtenerClientePorNombre(ClienteElegido);
                        break;
                    case "Arturo":
                        ClienteSeleccionado = clientes.ObtenerClientePorNombre(ClienteElegido);
                        break;
                    case "Debora":
                        ClienteSeleccionado = clientes.ObtenerClientePorNombre(ClienteElegido);
                        break;
                    default:
                        ClienteSeleccionado = null;
                        Console.WriteLine("Cliente no encontrado");
                        break;
                }
                
            }
            //Mostrar cliente
            BancoDatos banco = new BancoDatos();
            Console.WriteLine(banco.ObtenerFichaCliente(ClienteSeleccionado));
            
        }
    }
}

using Banco.Datos;
using Banco.Modelos.Clases;

namespace Banco.Aplicacion
{
    public class program
    {
        public static void main()
        {
            //Mensaje de Bienvenida
            Console.WriteLine("bienvenido a su banco");
            //Identificarse
            SeleccionarCliente();
        }

        private static Cliente SeleccionarCliente()
        {
            //Selecciona un cliente
            Cliente ClienteSeleccionado = null;
            Clientes clientes = new Clientes();
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
                    break;
            }
            return ClienteSeleccionado;
            //Mostrar cliente
        }
    }
}

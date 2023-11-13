using AltaClientes.Dtos;
using AltaClientes.Servicios;

namespace AltaClientes
{
    class Program
    {

        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            int continUsu = mi.menu();
            
            bool cerraMenu = false;

            while (!cerraMenu) { 
            
            switch (continUsu)
                {
                    case 0:
                        cerraMenu = true;

                        break;

                    case 1:
                        ClientesDtos cliente01 = new ClientesDtos();



                        Console.WriteLine("hola");
                        break;
                            default:
                        break;
                }
            
            }

        }

    }

}


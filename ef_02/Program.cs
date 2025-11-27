using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(140, 40);
            Console.SetBufferSize(140, 40);

            int opc;

            do
            {
                Console.Clear();
                Class1.Interfaz();            // Dibuja marco y encabezado
                opc = Class1.OpcionInterfaz(); // Selecciona opción SIN limpiar pantalla

                // Limpiar solo la zona de contenido (dentro del cuadro)
                Class1.LimpiarZona(5, 28);

                Console.SetCursorPosition(10, 10);

                switch (opc)
                {
                    case 0:
                        Console.WriteLine("UWUS1");
                        Class1.SubmenuRegistrar();
                        menu.productos();
                        Console.ReadKey();
                        break;

                    case 1:
                        Console.WriteLine("UWUS2");                    
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("UWUS3");                       
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("UWUS4");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("UWUS5");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("UWUS6");
                        Console.ReadKey();
                        break;
                }

            } while (opc != 5);

            Console.SetCursorPosition(0, 30);


        }
    }
}

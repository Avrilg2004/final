using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_02
{
    public class Class1
    {
        public static void LimpiarZonaInterna()
        {
            for (int y = 5; y < 29; y++)
            {
                Console.SetCursorPosition(1, y);
                Console.Write(new string(' ', 101)); // limpia la zona dentro del marco
            }
        }

        public static void SubmenuRegistrar()
        {
            string[] submenu = { "PRODUCTOS", "CLIENTES", "VENDEDORES", "PROVEEDORES", "VOLVER" };
            int index = 0;
            ConsoleKeyInfo key;

            do
            {
                // Limpia solo el interior, NO la pantalla completa
                LimpiarZonaInterna();              

                // Dibuja el submenu
                for (int i = 0; i < submenu.Length; i++)
                {
                    Console.SetCursorPosition(10, 6 + i);

                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" " + submenu[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("  " + submenu[i]);
                    }
                }

                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.DownArrow)
                    index = (index + 1) % submenu.Length;

                if (key.Key == ConsoleKey.UpArrow)
                    index = (index - 1 + submenu.Length) % submenu.Length;

                if (key.Key == ConsoleKey.Enter)
                {
                    if (index == submenu.Length - 1)  // VOLVER
                        return;

                    // Cuando escoja un elemento
                    LimpiarZonaInterna();

                    Console.SetCursorPosition(0, 10);

                    switch (index)
                    {
                        case 0:
                            menu.productos();
                            break;

                        case 1:
                            menu.clientes();
                            break;

                        case 2:
                            menu.vendedores();
                            break;

                        case 3:
                            menu.proveedores();
                            break;

                        case 4: // VOLVER
                            return;
                    }
                }

            } while (true);
        }


        public static void Interfaz()
        {
            // Encabezado
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 103; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }

            // Título
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(33, 1);
            Console.Write("SISTEMA PARA GESTIONAR VENTAS");
            Console.ResetColor();

            // Líneas superior e inferior
            for (int i = 0; i < 103; i++)
            {
                Console.SetCursorPosition(i, 4);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(" ");
                Console.ResetColor();

                Console.SetCursorPosition(i, 29);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(" ");
                Console.ResetColor();
            }

            // Líneas laterales
            for (int i = 4; i < 29; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(" ");
                Console.ResetColor();

                Console.SetCursorPosition(102, i);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(" ");
                Console.ResetColor();
            }
        }


        public static int OpcionInterfaz()
        {
            ConsoleKey tecla;
            string[] menu = { "REGISTRAR", "VENTAS", "REPORTES", "MODIFICAR", "AYUDA", "SALIR" };
            int index = 0;

            do
            {
                int left = 0;

                for (int i = 0; i < menu.Length; i++)
                {
                    Console.SetCursorPosition(left, 3);

                    if (index == i)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("     " + menu[i] + "     ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("     " + menu[i] + "     ");
                    }

                    left += 18;
                }

                ConsoleKeyInfo info = Console.ReadKey(true);
                tecla = info.Key;

                if (tecla == ConsoleKey.RightArrow)
                {
                    index = (index + 1) % menu.Length;
                }
                else if (tecla == ConsoleKey.LeftArrow)
                {
                    index--;
                    if (index < 0) index = menu.Length - 1;
                }

            } while (tecla != ConsoleKey.Enter);

            return index;
        }
      
        // LIMPIA SOLO EL CUERPO DEL CUADRO
        
        public static void LimpiarZona(int yInicio, int yFin)
        {
            for (int y = yInicio; y <= yFin; y++)
            {
                Console.SetCursorPosition(1, y);
                Console.Write(new string(' ', 100));
            }
        }

        public static void SubmenuReportes()
        {
            string[] submenu = { "CLIENTES","PRODUCTOS", "VENDEDORES", "PROVEEDORES", "BOLETAS","FACTURAS","GUIAS","PROFORMAS" };
            int index = 0;
            ConsoleKeyInfo key;

            do
            {
                LimpiarZonaInterna();

                for (int i = 0; i < submenu.Length; i++)
                {
                    Console.SetCursorPosition(10, 6 + i);

                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" " + submenu[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("  " + submenu[i]);
                    }
                }

                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.DownArrow)
                    index = (index + 1) % submenu.Length;

                if (key.Key == ConsoleKey.UpArrow)
                    index = (index - 1 + submenu.Length) % submenu.Length;

                if (key.Key == ConsoleKey.Enter)
                {
                    if (index == submenu.Length - 1)  // VOLVER
                        return;

                    // Cuando escoja un elemento
                    LimpiarZonaInterna();

                    Console.SetCursorPosition(0, 10);

                    switch (index)
                    {
                        case 0:
                            menu.productos();
                            break;

                        case 1:
                            menu.clientes();
                            break;

                        case 2:
                            menu.Listar();
                            break;

                        case 3:
                            menu.proveedores();
                            break;

                        case 5:
                            menu.proveedores();
                            break;

                        case 6:
                            menu.productos();
                            break;

                        case 7:
                            menu.clientes();
                            break;
                    }
                }

            } while (true);
        }
    }
}

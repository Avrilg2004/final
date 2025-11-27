using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_02
{
    internal class menu
    {
        // arreglos para clientes
        public static string[] nombre_cliente = new string[50];
        public static string[] dni_cliente = new string[50];
        public static string[] apellidos_cliente = new string[50];
        public static string[] telefono_cliente = new string[50];
        public static string[] email_cliente = new string[50];
        public static string[] direccion_cliente = new string[50];

        // Arreglos paralelos para almacenar datos( vendedores )
        static string[] codigos = new string[50];
        static string[] nombres = new string[50];
        static string[] apellidos = new string[50];
        static double[] sueldos = new double[50];
        static string[] telefonos = new string[50];
        static int total = 0;

        
        public static void productos()
        {
            string[] codigos = new string[50];
            string[] nombres = new string[50];
            string[] categorias = new string[50];
            int[] stocks = new int[50];
            double[] precios = new double[50];

            int totalProductos = 0;

            string continuar;

            
            do 
            {
                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }
                Console.SetCursorPosition(5, 7);
                Console.WriteLine("** REGISTRAR PRODUCTO **");
                Console.SetCursorPosition(5, 8);
                Console.Write("Ingrese el código: ");
                string codigo = Console.ReadLine();

                for (int i = 0; i < totalProductos; i++)
                {
                    if (codigos[i] == codigo)
                    {
                        Console.SetCursorPosition(5, 9);
                        Console.WriteLine("\nERROR: El código ya existe.");
                        return;
                    }
                }

                Console.SetCursorPosition(5, 9);
                Console.Write("Ingrese el nombre: ");
                string nombre = Console.ReadLine();

                for (int i = 0; i < totalProductos; i++)
                {
                    if (nombres[i].ToLower() == nombre.ToLower())
                    {
                        Console.SetCursorPosition(5, 10);
                        Console.WriteLine("\nERROR: Ese nombre ya existe.");
                        return;
                    }
                }
                Console.SetCursorPosition(5, 10);
                Console.Write("Ingrese la categoría: ");
                string categoria = Console.ReadLine();
                Console.SetCursorPosition(5, 11);
                Console.Write("Ingrese el stock: ");
                int stock = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(5, 12);
                Console.Write("Ingrese el precio unitario: ");
                double precio = double.Parse(Console.ReadLine());

                codigos[totalProductos] = codigo;
                nombres[totalProductos] = nombre;
                categorias[totalProductos] = categoria;
                stocks[totalProductos] = stock;
                precios[totalProductos] = precio;

                totalProductos++;
                Console.SetCursorPosition(5, 13);
                Console.Write("Producto registrado correctamente.");
                Console.SetCursorPosition(5, 14);
                Console.Write("¿Desea registrar otro producto? (s/n): ");
                continuar = Console.ReadLine().ToLower();

                if (continuar != "s") 
                {
                    Console.SetCursorPosition(5, 16);
                    Console.WriteLine("Presione cualquier tecla para continuar... ");
                    Console.ReadKey();
                }
                
            } while (continuar == "s");
        }
        

        public static void clientes()
        {
            
            string nombre, dni, apellidos, telefono, email, direccion,opcion;
            bool dnivalido,valido;

            do
            {
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR CLIENTES");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Nombres: ");
                    nombre = Console.ReadLine();
                    valido = SoloLetras(nombre);

                    if (!valido)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Error: El nombre solo debe contener letras");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                    }
                } while (!valido);


                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR CLIENTES");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Apellidos: ");
                    apellidos = Console.ReadLine();
                    valido = SoloLetras(apellidos);

                    if (!valido)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Error: El apellido solo debe contener letras");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                    }
                } while (!valido);



                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR CLIENTES");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Teléfono (9 dígitos): ");
                    telefono = Console.ReadLine();
                    valido = true;

                    // Validar que solo sean números
                    if (!SoloNumeros(telefono))
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.WriteLine("Error: El teléfono solo debe contener números");
                        Console.SetCursorPosition(5, 9);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadLine();
                        valido = false;
                        continue;
                    }

                    // Validar longitud exacta
                    if (telefono.Length != 9)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.WriteLine("Error: El teléfono debe tener exactamente 9 dígitos");
                        Console.SetCursorPosition(5, 9);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadLine();
                        valido = false;
                    }
                } while (!valido);


                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }
                Console.SetCursorPosition(5, 6);
                Console.Write("REGISTRAR CLIENTES");
                Console.SetCursorPosition(5, 7);
                Console.Write("EMAIL: ");
                email = Console.ReadLine();


                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }
                Console.SetCursorPosition(5, 6);
                Console.Write("REGISTRAR CLIENTES");
                Console.SetCursorPosition(5, 7);
                Console.Write("DIRECCIÓN: ");
                direccion = Console.ReadLine();

                do
                {
                    dnivalido = true;

                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR CLIENTES");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("DNI: ");
                    dni = Console.ReadLine();

                    // Validar formato del DNI: 8 dígitos numéricos
                    if (dni.Length != 8 || !int.TryParse(dni, out _))
                    {
                        
                        Console.SetCursorPosition(5, 8);
                        Console.Write("DNI debe tener 8 dígitos numéricos");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione una tecla para volver a intentarlo");
                        Console.ReadKey();
                        dnivalido = false;
                        continue;
                    }

                    // Validar que no exista en el array
                    for (int i = 0; i < dni_cliente.Length; i++)
                    {
                        if (dni_cliente[i] == dni)
                        {
                            Console.SetCursorPosition(5, 8);
                            Console.Write("El DNI ya existe. Intente con otro.");
                            Console.ReadKey();
                            dnivalido = false;
                            break;
                        }
                    }

                } while (!dnivalido);

                for (int i = 0; i < nombre_cliente.Length; i++)
                {
                    if (nombre_cliente[i] == null)
                    {
                        nombre_cliente[i] = nombre;
                        apellidos_cliente[i] = apellidos;
                        telefono_cliente[i] = telefono;
                        email_cliente[i] = email;
                        direccion_cliente[i] = direccion;
                        dni_cliente[i] = dni;

                        Console.SetCursorPosition(6, 9);
                        Console.Write("Datos guardados correctamente en la posición: " + i);
                        break;
                    }
                }

                
                Console.SetCursorPosition(6, 10);
                Console.Write("cliente registrado correctamente!");
                Console.SetCursorPosition(6, 11);
                Console.Write("Desea incribir a otro vendedor?(s/n): ");
                opcion = Console.ReadLine().ToLower();

                if (opcion != "s")
                {

                    Console.SetCursorPosition(5, 12);
                    Console.Write("Presione ESC para volver al menu principal...");
                    Console.ReadLine();
                }
            } while (opcion == "s");
        }
        public static void vendedores()
        {
            string opcion;
            ConsoleKey tecla;
            do
            {
                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }


                if (total >= 50)
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("Error: Límite de 50 vendedores alcanzado");
                    return;
                }

                // Código (debe tener exactamente 11 dígitos y no repetido)
                string codigo;
                bool valido;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(7, 7);
                    Console.Write("REGISTRAR VENDEDOR");
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código (11 dígitos): ");
                    codigo = Console.ReadLine();
                    valido = true;

                    // Validar que solo sean números
                    if (!SoloNumeros(codigo))
                    {
                        Console.SetCursorPosition(5, 9);
                        Console.WriteLine("Error: El código solo debe contener números");
                        Console.SetCursorPosition(5, 10);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar longitud exacta
                    if (codigo.Length != 11)
                    {
                        Console.SetCursorPosition(5, 11);
                        Console.WriteLine("Error: El código debe tener exactamente 11 dígitos");
                        Console.SetCursorPosition(5, 12);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que no exista
                    for (int i = 0; i < total; i++)
                    {
                        if (codigos[i] == codigo)
                        {
                            Console.SetCursorPosition(5, 13);
                            Console.WriteLine("Error: El código ya existe");
                            Console.SetCursorPosition(5, 14);
                            Console.WriteLine("Presione Enter para intentar de nuevo...");
                            Console.ReadKey();
                            valido = false;
                            break;
                        }
                    }
                } while (!valido);

                // Nombres (solo letras)
                string nom;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(7, 6);
                    Console.Write("REGISTRAR VENDEDOR");
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Nombres: ");
                    nom = Console.ReadLine();
                    valido = SoloLetras(nom);

                    if (!valido)
                    {
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Error: El nombre solo debe contener letras");
                        Console.SetCursorPosition(5, 10);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                    }
                } while (!valido);

                // Apellidos (solo letras)
                string ape;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR VENDEDOR");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Apellidos: ");
                    ape = Console.ReadLine();
                    valido = SoloLetras(ape);

                    if (!valido)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Error: El apellido solo debe contener letras");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                    }
                } while (!valido);

                // Sueldo (solo números positivos)
                double sueldo;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR VENDEDOR");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Sueldo: ");
                    string sueldoTexto = Console.ReadLine();
                    valido = double.TryParse(sueldoTexto, out sueldo);

                    if (!valido || sueldo < 0)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Error: El sueldo debe ser un número ");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadLine();
                        valido = false;
                    }
                } while (!valido);

                // Teléfono (debe tener exactamente 9 dígitos)
                string tel;
                do
                {
                    for (int y = 5; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 6);
                    Console.Write("REGISTRAR VENDEDOR");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Teléfono (9 dígitos): ");
                    tel = Console.ReadLine();
                    valido = true;

                    // Validar que solo sean números
                    if (!SoloNumeros(tel))
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Error: El teléfono solo debe contener números");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar longitud exacta
                    if (tel.Length != 9)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Error: El teléfono debe tener exactamente 9 dígitos");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                    }
                } while (!valido);

                // Guardar
                codigos[total] = codigo;
                nombres[total] = nom;
                apellidos[total] = ape;
                sueldos[total] = sueldo;
                telefonos[total] = tel;
                total++;

                Console.SetCursorPosition(6, 10);
                Console.Write("Vendedor registrado!");
                Console.SetCursorPosition(6, 11);
                Console.Write("Desea incribir a otro vendedor?(s/n): ");
                opcion = Console.ReadLine().ToLower();

                if (opcion != "s")
                {
                    
                    Console.SetCursorPosition(5, 12);
                    Console.Write("Presione ESC para volver al menu principal...");
                    Console.ReadLine();
                }

            } while (opcion == "s");
        }

        public static void Registrar()
        {
            for (int y = 5; y < 29; y++)
            {
                Console.SetCursorPosition(1, y);
                Console.Write(new string(' ', 101));
            }

            Console.SetCursorPosition(5, 7);
            Console.WriteLine("REGISTRAR VENDEDOR");

            if (total >= 50)
            {
                Console.WriteLine("Error: Límite de 50 vendedores alcanzado");
                return;
            }

            // Código (debe tener exactamente 11 dígitos y no repetido)
            string codigo;
            bool valido;
            do
            {
                Console.SetCursorPosition(5, 8);
                Console.Write("Código (11 dígitos): ");
                codigo = Console.ReadLine();
                valido = true;

                // Validar que solo sean números
                if (!SoloNumeros(codigo))
                {
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Error: El código solo debe contener números");
                    Console.SetCursorPosition(5, 10);
                    Console.Write("Presione Enter para intentar de nuevo...");
                    Console.ReadKey();
                    valido = false;
                    continue;
                }

                // Validar longitud exacta
                if (codigo.Length != 11)
                {
                    Console.SetCursorPosition(5, 11);
                    Console.Write("Error: El código debe tener exactamente 11 dígitos");
                    Console.SetCursorPosition(5, 12);
                    Console.Write("Presione Enter para intentar de nuevo...");
                    Console.ReadKey();
                    valido = false;
                    continue;
                }

                // Validar que no exista
                for (int i = 0; i < total; i++)
                {
                    if (codigos[i] == codigo)
                    {
                        Console.SetCursorPosition(5, 13);
                        Console.WriteLine("Error: El código ya existe");
                        Console.SetCursorPosition(5, 14);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        break;
                    }
                }
            } while (!valido);

            // Nombres (solo letras)
            string nom;
            do
            {
                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }

                Console.SetCursorPosition(5, 6);
                Console.WriteLine("\n--- REGISTRAR VENDEDOR ---");
                Console.SetCursorPosition(5, 7);
                Console.Write("Nombres: ");
                nom = Console.ReadLine();
                valido = SoloLetras(nom);

                if (!valido)
                {
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("Error: El nombre solo debe contener letras");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadKey();
                }
            } while (!valido);

            // Apellidos (solo letras)
            string ape;
            do
            {
                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }
                Console.SetCursorPosition(5, 6);
                Console.WriteLine("\n--- REGISTRAR VENDEDOR ---");
                Console.SetCursorPosition(5, 7);
                Console.Write("Apellidos: ");
                ape = Console.ReadLine();
                valido = SoloLetras(ape);

                if (!valido)
                {
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("Error: El apellido solo debe contener letras");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadKey();
                }
            } while (!valido);

            // Sueldo (solo números positivos)
            double sueldo;
            do
            {
                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }
                Console.SetCursorPosition(5, 6);
                Console.WriteLine("\n--- REGISTRAR VENDEDOR ---");
                Console.SetCursorPosition(5, 7);
                Console.Write("Sueldo: ");
                string sueldoTexto = Console.ReadLine();
                valido = double.TryParse(sueldoTexto, out sueldo);

                if (!valido || sueldo < 0)
                {
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("Error: El sueldo debe ser un número ");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadLine();
                    valido = false;
                }
            } while (!valido);

            // Teléfono (debe tener exactamente 9 dígitos)
            string tel;
            do
            {
                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }

                Console.SetCursorPosition(5, 6);
                Console.Write("REGISTRAR VENDEDOR");
                Console.SetCursorPosition(5, 7);
                Console.Write("Teléfono (9 dígitos): ");
                tel = Console.ReadLine();
                valido = true;

                // Validar que solo sean números
                if (!SoloNumeros(tel))
                {
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("Error: El teléfono solo debe contener números");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadLine();
                    valido = false;
                    continue;
                }

                // Validar longitud exacta
                if (tel.Length != 9)
                {
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("Error: El teléfono debe tener exactamente 9 dígitos");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadLine();
                    valido = false;
                }
            } while (!valido);

            // Guardar
            codigos[total] = codigo;
            nombres[total] = nom;
            apellidos[total] = ape;
            sueldos[total] = sueldo;
            telefonos[total] = tel;
            total++;

            Console.WriteLine("Vendedor registrado!");
        }

        static bool SoloLetras(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return false;

            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return false;
            }
            return true;
        }

        static bool SoloNumeros(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return false;

            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        static void Listar()
        {
            Console.WriteLine("\n--- LISTA DE VENDEDORES ---");

            if (total == 0)
            {
                Console.WriteLine("No hay vendedores registrados");
                return;
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"\nVendedor {i + 1}:");
                Console.WriteLine($"Código: {codigos[i]}");
                Console.WriteLine($"Nombres: {nombres[i]}");
                Console.WriteLine($"Apellidos: {apellidos[i]}");
                Console.WriteLine($"Sueldo: ${sueldos[i]}");
                Console.WriteLine($"Teléfono: {telefonos[i]}");
            }
        }

        static void Buscar()
        {
            Console.WriteLine("\n--- BUSCAR VENDEDOR ---");
            Console.Write("Código a buscar: ");
            string codigo = Console.ReadLine();

            for (int i = 0; i < total; i++)
            {
                if (codigos[i] == codigo)
                {
                    Console.WriteLine("\nVendedor encontrado:");
                    Console.WriteLine($"Código: {codigos[i]}");
                    Console.WriteLine($"Nombre: {nombres[i]} {apellidos[i]}");
                    Console.WriteLine($"Sueldo: ${sueldos[i]}");
                    Console.WriteLine($"Teléfono: {telefonos[i]}");
                    return;
                }
            }

            Console.WriteLine("Vendedor no encontrado");
        }
        public static void proveedores()
        {

        }

    }    
}

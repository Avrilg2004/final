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

        //Arreglos para productos
        public static string[] codigos_producto = new string[50];
        public static string[] nombres_producto = new string[50];
        public static string[] categorias_producto = new string[50];
        public static int[] stocks_producto = new int[50];
        public static double[] precios_producto = new double[50];
        public static int totalProductos = 0;



        public static void productos()
        {
            string opcion;

            do
            {
                // Limpia la zona interna
                for (int y = 5; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }

                // Verifica límite
                if (totalProductos >= 50)
                {
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("Error: Límite de 50 productos alcanzado");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    return;
                }

                Console.SetCursorPosition(5, 6);
                Console.Write("REGISTRAR PRODUCTO");

                // ====== CÓDIGO (único) ======
                string codigo;
                bool valido;
                do
                {
                    for (int y = 8; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código: ");
                    codigo = Console.ReadLine();
                    valido = true;

                    // Validar que no esté vacío
                    if (codigo.Length == 0)
                    {
                        Console.SetCursorPosition(5, 9);
                        Console.WriteLine("Error: El código no puede estar vacío");
                        Console.SetCursorPosition(5, 10);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que no exista
                    for (int i = 0; i < totalProductos; i++)
                    {
                        if (codigos_producto[i] == codigo)
                        {
                            Console.SetCursorPosition(5, 9);
                            Console.WriteLine("Error: El código ya existe");
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Presione Enter para intentar de nuevo...");
                            Console.ReadKey();
                            valido = false;
                            break;
                        }
                    }
                } while (!valido);

                // ====== NOMBRE (único) ======
                string nombre;
                do
                {
                    for (int y = 9; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }

                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código: " + codigo);
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    valido = true;

                    // Validar que no esté vacío
                    if (nombre.Length == 0)
                    {
                        Console.SetCursorPosition(5, 10);
                        Console.WriteLine("Error: El nombre no puede estar vacío");
                        Console.SetCursorPosition(5, 11);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                        continue;
                    }

                    // Validar que no exista (sin importar mayúsculas/minúsculas)
                    for (int i = 0; i < totalProductos; i++)
                    {
                        if (nombres_producto[i].ToLower() == nombre.ToLower())
                        {
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Error: Ese nombre ya existe");
                            Console.SetCursorPosition(5, 11);
                            Console.WriteLine("Presione Enter para intentar de nuevo...");
                            Console.ReadKey();
                            valido = false;
                            break;
                        }
                    }
                } while (!valido);

                // ====== CATEGORÍA ======
                for (int y = 10; y < 29; y++)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(new string(' ', 101));
                }
                Console.SetCursorPosition(5, 8);
                Console.Write("Código: " + codigo);
                Console.SetCursorPosition(5, 9);
                Console.Write("Nombre: " + nombre);
                Console.SetCursorPosition(5, 10);
                Console.Write("Categoría: ");
                string categoria = Console.ReadLine();

                // ====== STOCK ======
                int stock = 0;
                do
                {
                    for (int y = 11; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código: " + codigo);
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Nombre: " + nombre);
                    Console.SetCursorPosition(5, 10);
                    Console.Write("Categoría: " + categoria);
                    Console.SetCursorPosition(5, 11);
                    Console.Write("Stock: ");

                    try
                    {
                        stock = int.Parse(Console.ReadLine());

                        if (stock < 0)
                        {
                            Console.SetCursorPosition(5, 12);
                            Console.WriteLine("Error: El stock debe ser un número positivo");
                            Console.SetCursorPosition(5, 13);
                            Console.WriteLine("Presione Enter para intentar de nuevo...");
                            Console.ReadKey();
                            valido = false;
                        }
                        else
                        {
                            valido = true;
                        }
                    }
                    catch
                    {
                        Console.SetCursorPosition(5, 12);
                        Console.WriteLine("Error: El stock debe ser un número positivo");
                        Console.SetCursorPosition(5, 13);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                    }
                } while (!valido);

                // ====== PRECIO ======
                double precio = 0;
                do
                {
                    for (int y = 12; y < 29; y++)
                    {
                        Console.SetCursorPosition(1, y);
                        Console.Write(new string(' ', 101));
                    }
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Código: " + codigo);
                    Console.SetCursorPosition(5, 9);
                    Console.Write("Nombre: " + nombre);
                    Console.SetCursorPosition(5, 10);
                    Console.Write("Categoría: " + categoria);
                    Console.SetCursorPosition(5, 11);
                    Console.Write("Stock: " + stock);
                    Console.SetCursorPosition(5, 12);
                    Console.Write("Precio unitario: ");

                    try
                    {
                        precio = double.Parse(Console.ReadLine());

                        if (precio <= 0)
                        {
                            Console.SetCursorPosition(5, 13);
                            Console.WriteLine("Error: El precio debe ser un número mayor a 0");
                            Console.SetCursorPosition(5, 14);
                            Console.WriteLine("Presione Enter para intentar de nuevo...");
                            Console.ReadKey();
                            valido = false;
                        }
                        else
                        {
                            valido = true;
                        }
                    }
                    catch
                    {
                        Console.SetCursorPosition(5, 13);
                        Console.WriteLine("Error: El precio debe ser un número mayor a 0");
                        Console.SetCursorPosition(5, 14);
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                    }
                } while (!valido);

                // ====== GUARDAR PRODUCTO ======
                codigos_producto[totalProductos] = codigo;
                nombres_producto[totalProductos] = nombre;
                categorias_producto[totalProductos] = categoria;
                stocks_producto[totalProductos] = stock;
                precios_producto[totalProductos] = precio;
                totalProductos++;

                Console.SetCursorPosition(5, 14);
                Console.Write("Producto registrado correctamente.");
                Console.SetCursorPosition(5, 15);
                Console.Write("¿Desea registrar otro producto? (s/n): ");
                opcion = Console.ReadLine().ToLower();

                if (opcion != "s")
                {
                    Console.SetCursorPosition(5, 16);
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion == "s");
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
                    Console.Write("REGISTRAR VENDEDOR");
                    Console.SetCursorPosition(5, 7);
                    Console.Write("Teléfono (9 dígitos): ");
                    telefono = Console.ReadLine();
                    valido = true;

                    // Validar que solo sean números
                    if (!SoloNumeros(telefono))
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
                    if (telefono.Length != 9)
                    {
                        Console.SetCursorPosition(5, 8);
                        Console.Write("Error: El teléfono debe tener exactamente 9 dígitos");
                        Console.SetCursorPosition(5, 9);
                        Console.Write("Presione Enter para intentar de nuevo...");
                        Console.ReadKey();
                        valido = false;
                    }

                    for (int i = 0; i < telefono_cliente.Length; i++)
                    {
                        if (telefono_cliente[i] == telefono)
                        {
                            Console.SetCursorPosition(5, 8);
                            Console.Write("El teléfono ya existe.");
                            Console.ReadKey();
                            valido = false;
                            break;
                        }
                    }

                } while (!valido);


                bool emailValido;
                do
                {
                    emailValido = true;

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
                    for (int i = 0; i < email_cliente.Length; i++)
                    {
                        if (email_cliente[i] == email)
                        {
                            Console.SetCursorPosition(5, 8);
                            Console.Write("El email ya existe.");
                            Console.ReadKey();
                            emailValido = false;
                            break;
                        }
                    }

                } while (!emailValido);

                bool direccionValida;
                do
                {
                    direccionValida = true;
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

                    for (int i = 0; i < direccion_cliente.Length; i++)
                    {
                        if (direccion_cliente[i] == direccion)
                        {
                            Console.SetCursorPosition(5, 8);
                            Console.Write("La dirección ya existe.");
                            Console.ReadKey();
                            direccionValida = false;
                            break;
                        }
                    }

                } while (!direccionValida);

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
                    Console.Write("Presione enter para volver al menu principal...");
                    Console.ReadLine();
                }
            } while (opcion == "s");
        }
        public static void vendedores()
        {
            string opcion;
            
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

                    for (int i = 0; i < total; i++)
                    {
                        if (telefonos[i] == tel)
                        {
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Error: El teléfono ya existe");
                            Console.SetCursorPosition(5, 11);
                            Console.WriteLine("Presione Enter para intentar de nuevo...");
                            Console.ReadKey();
                            valido = false;
                            break;
                        }
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
                    Console.Write("Presione enter para volver al menu principal...");
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

        public static void Listar()
        {
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("LISTA DE VENDEDORES");

            if (total == 0)
            {
                Console.SetCursorPosition(5, 7);
                Console.Write("No hay vendedores registrados");
                return;
            }

            for (int i = 0; i < total; i++)
            {
                Console.SetCursorPosition(5, 7);
                Console.Write($"Vendedor {i + 1}:");
                Console.SetCursorPosition(5, 8);
                Console.Write($"Código: {codigos[i]}");
                Console.SetCursorPosition(5, 9);
                Console.Write($"Nombres: {nombres[i]}");
                Console.SetCursorPosition(5, 10);
                Console.Write($"Apellidos: {apellidos[i]}");
                Console.SetCursorPosition(5, 11);
                Console.Write($"Sueldo: ${sueldos[i]}");
                Console.SetCursorPosition(5, 12);
                Console.Write($"Teléfono: {telefonos[i]}");
            }
        }

        public static void BuscarVendedor()
        {
            Console.SetCursorPosition(5, 6);
            Console.Write("BUSCAR VENDEDOR");
            Console.SetCursorPosition(5, 7);
            Console.Write("Código a buscar: ");
            string codigo = Console.ReadLine();

            if (total == 0)
            {
                Console.SetCursorPosition(5, 8);
                Console.Write("No hay vendedores registrados");
            }

            for (int i = 0; i < total; i++)
            {
                if (codigos[i] == codigo)
                {
                    Console.SetCursorPosition(5, 8);
                    Console.Write("Vendedor encontrado:");
                    Console.SetCursorPosition(5, 9);
                    Console.Write($"Código: {codigos[i]}");
                    Console.SetCursorPosition(5, 10);
                    Console.Write($"Nombre: {nombres[i]} {apellidos[i]}");
                    Console.SetCursorPosition(5, 11);
                    Console.Write($"Sueldo: {sueldos[i]}");
                    Console.SetCursorPosition(5, 12);
                    Console.Write($"Teléfono: {telefonos[i]}");
                }
            }
        }

        public static void provedor()
        {

        }

    }    
}

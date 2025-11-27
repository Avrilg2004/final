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
            int[] codigos = new int[50];
            string[] nombres = new string[50];
            string[] categorias = new string[50];
            int[] stocks = new int[50];
            double[] precios = new double[50];

            int totalProductos = 0;

            Console.WriteLine("** REGISTRAR PRODUCTO **");

            Console.Write("Ingrese el código: ");
            int codigo = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalProductos; i++)
            {
                if (codigos[i] == codigo)
                {
                    Console.WriteLine("\nERROR: El código ya existe.");
                    return;
                }
            }

            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < totalProductos; i++)
            {
                if (nombres[i].ToLower() == nombre.ToLower())
                {
                    Console.WriteLine("\nERROR: Ese nombre ya existe.");
                    return;
                }
            }

            Console.Write("Ingrese la categoría: ");
            string categoria = Console.ReadLine();

            Console.Write("Ingrese el stock: ");
            int stock = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio unitario: ");
            double precio = double.Parse(Console.ReadLine());

            codigos[totalProductos] = codigo;
            nombres[totalProductos] = nombre;
            categorias[totalProductos] = categoria;
            stocks[totalProductos] = stock;
            precios[totalProductos] = precio;

            totalProductos++;

            Console.WriteLine("\nProducto registrado correctamente.");
        }
        

        public static void clientes()
        {
            
            string nombre, dni, apellidos, telefono, email, direccion;
            bool dnivalido;

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("APELLIDOS: ");
            apellidos = Console.ReadLine();

            Console.Write("TELEFONO: ");
            telefono = Console.ReadLine();

            Console.Write("EMAIL: ");
            email = Console.ReadLine();

            Console.Write("DIRECCIN: ");
            direccion = Console.ReadLine();

            do
            {
                dnivalido = true;

                Console.Write("DNI: ");
                dni = Console.ReadLine();

                // Validar formato del DNI: 8 dígitos numéricos
                if (dni.Length != 8 || !int.TryParse(dni, out _))
                {
                    Console.WriteLine("\t  DNI debe tener 8 dígitos numéricos");
                    Console.WriteLine("\t  Presione una tecla para volver a intentarlo");
                    Console.ReadKey();
                    dnivalido = false;
                    continue;
                }

                // Validar que no exista en el array
                for (int i = 0; i < dni_cliente.Length; i++)
                {
                    if (dni_cliente[i] == dni)
                    {
                        Console.WriteLine("\t  El DNI ya existe. Intente con otro.");
                        Console.ReadKey();
                        dnivalido = false;
                        break;
                    }
                }

            } while (!dnivalido);

        }
        public static void vendedores()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== REGISTRO DE VENDEDORES ===");
                Console.WriteLine("1. Registrar vendedor");
                Console.WriteLine("2. Listar vendedores");
                Console.WriteLine("3. Buscar vendedor");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Registrar(); break;
                    case 2: Listar(); break;
                    case 3: Buscar(); break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("\nPresione Enter...");
                    Console.ReadLine();
                }

            } while (opcion != 4);
        }

        public static void Registrar()
        {
            Console.WriteLine("\n--- REGISTRAR VENDEDOR ---");

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
                Console.Write("Código (11 dígitos): ");
                codigo = Console.ReadLine();
                valido = true;

                // Validar que solo sean números
                if (!SoloNumeros(codigo))
                {
                    Console.WriteLine("Error: El código solo debe contener números");
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadLine();
                    valido = false;
                    continue;
                }

                // Validar longitud exacta
                if (codigo.Length != 11)
                {
                    Console.WriteLine("Error: El código debe tener exactamente 11 dígitos");
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadLine();
                    valido = false;
                    continue;
                }

                // Validar que no exista
                for (int i = 0; i < total; i++)
                {
                    if (codigos[i] == codigo)
                    {
                        Console.WriteLine("Error: El código ya existe");
                        Console.WriteLine("Presione Enter para intentar de nuevo...");
                        Console.ReadLine();
                        valido = false;
                        break;
                    }
                }
            } while (!valido);

            // Nombres (solo letras)
            string nom;
            do
            {
                Console.Write("Nombres: ");
                nom = Console.ReadLine();
                valido = SoloLetras(nom);

                if (!valido)
                {
                    Console.WriteLine("Error: El nombre solo debe contener letras");
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadLine();
                }
            } while (!valido);

            // Apellidos (solo letras)
            string ape;
            do
            {
                Console.Write("Apellidos: ");
                ape = Console.ReadLine();
                valido = SoloLetras(ape);

                if (!valido)
                {
                    Console.WriteLine("Error: El apellido solo debe contener letras");
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadLine();
                }
            } while (!valido);

            // Sueldo (solo números positivos)
            double sueldo;
            do
            {
                Console.Write("Sueldo: ");
                string sueldoTexto = Console.ReadLine();
                valido = double.TryParse(sueldoTexto, out sueldo);

                if (!valido || sueldo < 0)
                {
                    Console.WriteLine("Error: El sueldo debe ser un número ");
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadLine();
                    valido = false;
                }
            } while (!valido);

            // Teléfono (debe tener exactamente 9 dígitos)
            string tel;
            do
            {
                Console.Write("Teléfono (9 dígitos): ");
                tel = Console.ReadLine();
                valido = true;

                // Validar que solo sean números
                if (!SoloNumeros(tel))
                {
                    Console.WriteLine("Error: El teléfono solo debe contener números");
                    Console.WriteLine("Presione Enter para intentar de nuevo...");
                    Console.ReadLine();
                    valido = false;
                    continue;
                }

                // Validar longitud exacta
                if (tel.Length != 9)
                {
                    Console.WriteLine("Error: El teléfono debe tener exactamente 9 dígitos");
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

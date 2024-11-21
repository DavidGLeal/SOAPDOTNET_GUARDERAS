//Console.WriteLine("Hello, World!");
using System;

using CLICON.ec.edu.monster.controlador;

public class ConvUniCliCon
{
    public static void Main(string[] args)
    {
        logIn();
    }

    private static void logIn()
    {
        Console.Clear();
        LoginControlador controlador = new LoginControlador();

        bool res = false;

        for(int i = 0; i < 3; i++)
        {
            string us = "";
            string ps = "";

            Console.Write("Usuario: ");
            us = Console.ReadLine();
            Console.Write("Contraseña: ");
            ps = leerClave();

            res = controlador.verificar(us, ps);

            if (res)
            {
                menuPrincipal();
                break;
            }
            else
            {
                Console.WriteLine("Usuario y/o contraseña incorrectos.");
                continue;
            }
        }

            if(!res)
            {
                Console.WriteLine("Excedió el número de intentos.");
                Console.WriteLine("Cerrando sistema.");
                Environment.Exit(0);
            }
    }

    private static void menuPrincipal()
    {
        bool salir = false;
        Console.Clear();

        Console.WriteLine("\t\t\t\tCONVERSOR DE UNIDADES (SOAP - .NET)");
        Console.WriteLine("\n---------------------------------------\n");
        do
        {
            Console.WriteLine("\nElija una opción:\n");
            Console.WriteLine("1. °C a °F");
            Console.WriteLine("2. °F a °C");
            Console.WriteLine("3. Salir");
            Console.Write("=> ");

            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:

                    convertCF();
                        break;
                    
                case 2:

                    convertFC();
                        break;
                    
                case 3:
                    
                        salir = true;
                        break;
                default:
                        Console.WriteLine("Opción inválida. Vuelva a intentar.");
                        break;
            }
        } while (!salir);
    }

    private static void convertCF()
    {
        ConvUniControlador controlador = new ConvUniControlador();

        Console.Clear();

        Console.WriteLine("\t\t\t\t(°C -> °F)\n");
        Console.WriteLine("\n---------------------------------------------------\n");
        Console.Write("Ingrese la cantidad en °C => ");

        bool valida = false;
        double c = 0;
        do
        {
            try
            {
                c = double.Parse(Console.ReadLine());
                valida = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Entrada no válida. Vuelva a ingresar.");
                Console.Write("=> ");

            }
        } while (!valida);

        Object res = controlador.convertCF(c);

        if (res == null)
        {
            Console.WriteLine("Error. El servicio web no está disponible");
            Environment.Exit(1);
        }

        Console.WriteLine("\n" + c + "°C = " + res + "°F");

        int op = postMenu();

        Console.Clear();

        if (op == 1)
        {
            convertCF();
        }
        else
        {
            return;
        }

    }

    private static void convertFC()
    {
        ConvUniControlador controlador = new ConvUniControlador();

        Console.Clear();

        Console.WriteLine("\t\t\t\t(°F -> °C)\n");
        Console.WriteLine("\n---------------------------------------------------\n");
        Console.Write("Ingrese la cantidad en °F => ");

        bool valida = false;
        double f = 0;
        do
        {
            try
            {
                f = double.Parse(Console.ReadLine());
                valida = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Entrada no válida. Vuelva a ingresar.");
                Console.Write("=> ");

            }
        } while (!valida);

        Object res = controlador.convertFC(f);

        if (res == null)
        {
            Console.WriteLine("Error. El servicio web no está disponible");
            Environment.Exit(1);
        }

        Console.WriteLine("\n" + f + "°F = " + res + "°C");

        int op = postMenu();

        Console.Clear();

        if (op == 1)
        {
            convertFC();
        }
        else
        {
            return;
        }

    }

    private static int postMenu()
    {
        Console.WriteLine("\n¿Qué desea hacer a continuación?\n");
        Console.WriteLine("1. Convertir de nuevo.\n");
        Console.WriteLine("2. Regresar\n");
        Console.Write("=> ");

        bool valida = false;
        int op = 0;
        while (!valida)
        {
            try
            {
                op = int.Parse(Console.ReadLine());
                if (op > 2 || op < 1)
                {
                    throw new FormatException();
                }
                else
                {
                    valida = true;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Opción inválida. vuelva a intentar.");
                Console.Write("=> ");
            }
        }
        return op;
    }

    private static string leerClave()
    {
        string clave = "";
        ConsoleKeyInfo keyInfo;

        while((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Enter)
        {
            if(keyInfo.Key == ConsoleKey.Backspace && clave.Length > 0)
            {
                clave = clave.Substring(0, clave.Length - 1);
                Console.Write("\b \b");
            }
            else if (!char.IsControl(keyInfo.KeyChar))
            {
                clave += keyInfo.KeyChar;
                Console.Write("*");
            }
        }
        Console.WriteLine();
        return clave;
    }
}
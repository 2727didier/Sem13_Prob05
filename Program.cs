namespace Sem13_Prob05
{
    internal class Program
    {
        private static readonly Array respuestasEncuesta;

        public static int cantidadRespuestas { get; private set; }

        // Agrega esta función al código existente
        static void OrdenarDatos()
        {
            if (cantidadRespuestas == 0)
            {
                Console.WriteLine("No hay datos para ordenar.");
            }
            else
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Ordenar datos");
                Console.WriteLine("===============================");

                MostrarDatosConIndice();

                Array.Sort(respuestasEncuesta, 0, cantidadRespuestas);

                Console.WriteLine("\nDatos ordenados de menor a mayor.");
                MostrarDatosConIndice();
            }

            Console.WriteLine("\nPresione una tecla para regresar ...");
            Console.ReadKey();


        }

        private static void MostrarDatosConIndice()
        {
            throw new NotImplementedException();
        }
    }
}


class Program
{
    static int[] respuestasEncuesta = new int[100];
    static int cantidadRespuestas = 0;

    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Encuestas de Calidad");
            Console.WriteLine("===============================");
            Console.WriteLine("1: Realizar Encuesta");
            Console.WriteLine("2: Ver datos registrados");
            Console.WriteLine("3: Eliminar un dato");
            Console.WriteLine("4: Ordenar datos de menor a mayor");
            Console.WriteLine("5: Salir");
            Console.WriteLine("===============================");
            Console.Write("Ingrese una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        RealizarEncuesta();
                        break;
                    case 2:
                        VerDatosRegistrados();
                        break;
                    case 3:
                        EliminarDato();
                        break;
                    case 4:
                        OrdenarDatos();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción del 1 al 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }

        } while (opcion != 5);
    }

    static void RealizarEncuesta()
    {
        Console.WriteLine("===============================");
        Console.WriteLine("Nivel de Satisfacción");
        Console.WriteLine("===============================");
        Console.WriteLine("¿Qué tan satisfecho está con la atención de nuestra tienda?");
        Console.WriteLine("1: Nada satisfecho");
        Console.WriteLine("2: No muy satisfecho");
        Console.WriteLine("3: Tolerable");
        Console.WriteLine("4: Satisfecho");
        Console.WriteLine("5: Muy satisfecho");
        Console.WriteLine("===============================");
        Console.Write("Ingrese una opción: ");

        if (int.TryParse(Console.ReadLine(), out int respuesta) && respuesta >= 1 && respuesta <= 5)
        {
            respuestasEncuesta[cantidadRespuestas] = respuesta;
            cantidadRespuestas++;
            Console.WriteLine("\n¡Gracias por participar!\n");
        }
        else
        {
            Console.WriteLine("Por favor, ingrese una opción válida (1-5).");
        }
    }

    static void VerDatosRegistrados()
    {
        if (cantidadRespuestas == 0)
        {
            Console.WriteLine("No hay datos registrados.");
        }
        else
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Ver datos registrados");
            Console.WriteLine("===============================");

            for (int i = 0; i < cantidadRespuestas; i += 5)
            {
                for (int j = i; j < Math.Min(i + 5, cantidadRespuestas); j++)
                {
                    Console.Write($"{j:D3}:[{respuestasEncuesta[j]}]  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            MostrarResumenRespuestas();
        }

        Console.WriteLine("\nPresione una tecla para regresar ...");
        Console.ReadKey();
    }

    static void EliminarDato()
    {
        if (cantidadRespuestas == 0)
        {
            Console.WriteLine("No hay datos para eliminar.");
        }
        else
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Eliminar un dato");
            Console.WriteLine("===============================");

            MostrarDatosConIndice();

            Console.WriteLine("===============================");
            Console.Write("Ingrese la posición a eliminar: ");

            if (int.TryParse(Console.ReadLine(), out int posicion) && posicion >= 0 && posicion < cantidadRespuestas)
            {
                EliminarEncuesta(posicion);
                Console.WriteLine("\nDato eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Posición no válida. Intente nuevamente.");
            }
        }

        Console.WriteLine("\nPresione una tecla para regresar ...");
        Console.ReadKey();
    }

    static void OrdenarDatos()
    {
        if (cantidadRespuestas == 0)
        {
            Console.WriteLine("No hay datos para ordenar.");
        }
        else
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Ordenar datos");
            Console.WriteLine("===============================");

            MostrarDatosConIndice();

            Array.Sort(respuestasEncuesta, 0, cantidadRespuestas);

            Console.WriteLine("\nDatos ordenados de menor a mayor.");
            MostrarDatosConIndice();
        }

        Console.WriteLine("\nPresione una tecla para regresar ...");
        Console.ReadKey();
    }

    static void MostrarDatosConIndice()
    {
        for (int i = 0; i < cantidadRespuestas; i++)
        {
            Console.Write($"{i:D3}:[{respuestasEncuesta[i]}]  ");
        }
        Console.WriteLine();
    }

    static void MostrarResumenRespuestas()
    {
        Console.WriteLine();
        Console.WriteLine($"{ContarRespuestas(1)} personas: Nada satisfecho");
        Console.WriteLine($"{ContarRespuestas(2)} personas: No muy satisfecho");
        Console.WriteLine($"{ContarRespuestas(3)} personas: Tolerable");
        Console.WriteLine($"{ContarRespuestas(4)} personas: Satisfecho");
        Console.WriteLine($"{ContarRespuestas(5)} personas: Muy satisfecho");
    }

    static int ContarRespuestas(int opcion)
    {
        return respuestasEncuesta.Count(r => r == opcion);
    }

    static void EliminarEncuesta(int posicion)
    {
        for (int i = posicion; i < cantidadRespuestas - 1; i++)
        {
            respuestasEncuesta[i] = respuestasEncuesta[i + 1];
        }
        cantidadRespuestas--;
    }
}







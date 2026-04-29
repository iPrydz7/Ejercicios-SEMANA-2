int nota;

        Console.Write("Ingrese la nota: ");
        nota = int.Parse(Console.ReadLine());

        if (nota >= 11)
        {
            if (nota == 20)
            {
                Console.WriteLine("¡Excelente!");
            }
            else
            {
                Console.WriteLine("Aprobado");
            }
        }
        else
        {
            Console.WriteLine("Desaprobado");
        }

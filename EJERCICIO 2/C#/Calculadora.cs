        double num1, num2, resultado;
        int opcion;

        Console.Write("Ingrese el primer número: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");

        Console.Write("Seleccione una opción: ");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case 2:
                resultado = num1 - num2;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case 3:
                resultado = num1 * num2;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case 4:
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine("Resultado: " + resultado);
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre cero");
                }
                break;

            default:
                Console.WriteLine("Opción inválida");
                break;
        }
// Programa que permite calcular el IMC

double peso;
double altura;
double imc;

// Obtener datos del usuario
Console.WriteLine("Ingrese su peso (KG): ");
peso = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su altura (m): ");
altura = double.Parse(Console.ReadLine());

// Calcular IMC
imc = CalcularIMC(peso, altura);

// Mostrar resultado
if(imc > 0)
{
    Console.WriteLine("Usted tiene un IMC de: " + imc);

    // Clasificación del IMC
    if(imc < 18.5)
    {
        Console.WriteLine("Clasificación: Bajo peso");
    }
    else if(imc < 25)
    {
        Console.WriteLine("Clasificación: Peso normal");
    }
    else if(imc < 30)
    {
        Console.WriteLine("Clasificación: Sobrepeso");
    }
    else
    {
        Console.WriteLine("Clasificación: Obesidad");
    }
}

// Función para calcular IMC
double CalcularIMC(double peso, double altura)
{
    double imc = 0.0;

    // Validar datos de entrada
    bool valido = ValidarEntrada(peso, altura);

    if(valido == true)
    {
        imc = peso / Math.Pow(altura, 2);
    }
    else
    {
        Console.WriteLine("Datos de entrada no válidos");
    }

    return imc;
}

// Función para validar datos
bool ValidarEntrada(double peso, double altura)
{
    bool valido = false;

    if(peso <= 400 && peso >= 5)
    {
        if(altura <= 2.5 && altura >= 0.6)
        {
            valido = true;
        }
        else
        {
            Console.WriteLine("Altura inválida");
            valido = false;
        }
    }
    else
    {
        Console.WriteLine("Peso inválido");
        valido = false;
    }

    return valido;
}
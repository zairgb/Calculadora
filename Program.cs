Console.Title = "Calculadora";

bool continuar = true;
while (continuar)
{
    Console.WriteLine("================================");
    Console.WriteLine("         Calculadora         ");
    Console.WriteLine("================================");

    double num1;
    while (true)
    {
        Console.WriteLine("Digite el primer número: ");
        if (double.TryParse(Console.ReadLine(), out num1))
        {
            break;
        }
        Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
    }

    double num2;
    while (true)
    {
        Console.WriteLine("Digite el segundo número: ");
        if (double.TryParse(Console.ReadLine(), out num2))
        {
            break;
        }
        Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
    }

    Console.WriteLine();
    Console.WriteLine("Selecciona una operación:");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. División");
    Console.WriteLine("5. Potencia");
    Console.WriteLine("6. Módulo");

    Console.WriteLine("Opcion: ");

    int opcion;
    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        opcion = 0;
    }

    switch (opcion)
    {
        case 1:
            Console.WriteLine($"Resultado: {num1 + num2}");
            break;
        case 2:
            Console.WriteLine($"Resultado: {num1 - num2}");
            break;
        case 3:
            Console.WriteLine($"Resultado: {num1 * num2}");
            break;
        case 4:
            if (num2 != 0)
            {
                Console.WriteLine($"Resultado: {num1 / num2}");
            }
            else
            {
                Console.WriteLine("Error: División por cero no permitida.");
            }
            break;
        case 5:
            Console.WriteLine($"Resultado: {Math.Pow(num1, num2)}");
            break;
        case 6:
            if (num2 != 0)
            {
                Console.WriteLine($"Resultado: {num1 % num2}");
            }
            else
            {
                Console.WriteLine("Error: Módulo por cero no permitido.");
            }
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("¿Deseas realizar otra operación? (s/n)");
    string respuesta = Console.ReadLine()?.Trim().ToLower() ?? "n";
    if (respuesta != "s" && respuesta != "si")
    {
        continuar = false;
    }

    Console.WriteLine();
}
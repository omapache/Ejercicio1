int opc;
do
{
    Console.WriteLine("Bienvenido, Que desea hacer");
    Console.WriteLine("1. mirar cual es el n-ésimo número de Fibonacci");
    Console.WriteLine("2. si es o no un número de Fibonacci");
    Console.WriteLine("3. los m primeros números de Fibonacci");
    Console.WriteLine("0. Salir");
    opc = Convert.ToInt32(Console.ReadLine());
    switch (opc)
    {
        case (1):
            int anterior = 0;
            int anterior2 = 1;
            int suma = 0;
            Console.WriteLine("Ingrese el numero para saber el numero Fibonacci");

            int input = Convert.ToInt32(Console.ReadLine());
            int a = input - 1;
            for (int i = 0; i < a; i++)
            {
                suma = anterior + anterior2;
                anterior = anterior2;
                anterior2 = suma;
            }
            Console.WriteLine("El numero Fibonacci es: " + suma);
            return;
        case (2):
            int anteriorE2 = 0;
            int anterior2E2 = 1;
            int sumaEjercicio2 = 0;
            Console.WriteLine("Ingrese el numero para saber si es o no Fibonacci ");

            int inputEjercicio2 = Convert.ToInt32(Console.ReadLine());
            int b = inputEjercicio2;
            for (int i = 0; i < b; i++)
            {
                sumaEjercicio2 = anteriorE2 + anterior2E2;
                anteriorE2 = anterior2E2;
                anterior2E2 = sumaEjercicio2;

                if (sumaEjercicio2 == b)
                {
                    Console.WriteLine("El numero " + b + " si es Fibonacci");
                    return;
                }
                if (sumaEjercicio2 > b)
                {
                    Console.WriteLine("El numero " + b + " no  es Fibonacci");
                    return;
                }
            }
            return;
        case (3):
            int anteriorE3 = 1;
            int anterior2E3 = 0;
            int sumaE3 = 0;
            Console.WriteLine("Ingrese el numero para saber los m numeros de Fibonacci ");

            int inputE3 = Convert.ToInt32(Console.ReadLine());
            int c = inputE3;
            Console.WriteLine("los numero fibonacci son los siguiente: ");

            for (int i = 0; i < c; i++)
            {
                Console.WriteLine(sumaE3);

                sumaE3 = anteriorE3 + anterior2E3;
                anteriorE3 = anterior2E3;
                anterior2E3 = sumaE3;

            }
            return;
        default:
            Console.WriteLine("Ingreso un numero equivocado");
            return;

    }
} while (opc != 0);

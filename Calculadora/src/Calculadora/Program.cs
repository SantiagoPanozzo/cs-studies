using Library;

class Program{
    static void Main(){

    // DEMOSTRACION DE LOS MÉTODOS DE "Calculadora" EN ../Library/Class.cs

    // Primeros 10 elementos de la secuencia fibonacci
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Fibonacci: ");
    for (int i = 0; i <= 10; i++){
        Console.Write($"{i+1}:{Calculadora.fibonacci(i)}\n");
    }

    // Primeros 10 factoriales enteros
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Factoriales: ");
    for (int i = 0; i < 10; i++){
        Console.Write($"{i}:{Calculadora.factorial(i)}\n");
    }

    // Del 0 al 100 los que son primos
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Primos: ");
    List<int> primos = new List<int>{};
    for (int i = 0; i <= 100; i++){
        if (Calculadora.esPrimo(i)){
            primos.Add(i);
        }
    }
    Console.WriteLine(String.Join(", ",primos));

    // Del 0 al 100 los que son par
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Pares: ");
    List<int> pares = new List<int>{};
    for (int i = 0; i <= 100; i++){
        if (Calculadora.esPar(i)){
            pares.Add(i);
        }
    }
    Console.WriteLine(String.Join(", ",pares));

    // Del 0 al 100 los que son impar
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Impares: ");
    List<int> impares = new List<int>{};
    for (int i = 0; i <= 100; i++){
        if (Calculadora.esImpar(i)){
            impares.Add(i);
        }
    }
    Console.WriteLine(String.Join(", ",impares));

    // Suma de un array 1,2,3,4,5 enteros
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Suma array: ");
    int[] nums = new int[] {1,2,3,4,5};
    Console.WriteLine(Calculadora.sumaArray(nums));

    // Numero aleatorio entre 1 y 10
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Aleatorio: ");
    int a = 1;
    int b = 10;
    Console.WriteLine($"{a}-{b}: {Calculadora.getAleatorio(a,b)}");

    }
}
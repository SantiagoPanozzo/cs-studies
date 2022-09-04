using Library;
static class Program{
    static void Main(){
        bool bucle = true;
        while(bucle){
            Menu();
            Console.Write("Desea continuar? ");
            string a = Console.ReadLine();
            bucle = !(a.ToLower().Equals("no"));
            Console.WriteLine("");
            }
    }
    static void Menu(){
        Console.WriteLine(UI.MenuText);
        short opcion = GetOpcion();
        switch (opcion){
            case 1:
                OPconvert();
                break;
            case 2:
                OPOperate();
                break;
            default:
                break;
        }
    }
    static void OPconvert(){
        Console.WriteLine(UI.ConvertOptions);
        short opcion = GetOpcion();
        switch (opcion){
            case 1:
                Console.Write("Numero: ");
                int numero1;
                bool check = Int32.TryParse(Console.ReadLine(),out numero1);
                while (!check){
                    Console.WriteLine("\nError: ");
                    Console.Write("Numero: ");
                    check = Int32.TryParse(Console.ReadLine(),out numero1);
                }
                Console.WriteLine($"El numero {numero1} es: {Convertir.dec2bin(numero1)} en binario");
                break;
            case 2:
                Console.Write("Numero: ");
                string numero2 = Console.ReadLine();
                while (String.IsNullOrEmpty(numero2)) {
                    Console.Write("Numero: ");
                    numero2 = Console.ReadLine();
                }
                Console.WriteLine($"El numero {numero2} es: {Convertir.bin2dec(numero2)} en decimal");
                break;
        }
        Console.WriteLine("Pulsa ENTER para continuar...");
        Console.ReadLine();
    }
    static void OPOperate(){
        Console.WriteLine(UI.OperateOptions);
        short opcion = GetOpcion();
        string[] numeros = getNumerosOperables();
        string a = numeros[0];
        string b = numeros[1];
        switch(opcion){
            case 1:
                Console.WriteLine($"El resultado es: {Operar.Suma(a,b)}");
                break;
            case 2:
                Console.WriteLine($"El resultado es: {Operar.Resta(a,b)}");
                break;
            case 3:
                Console.WriteLine($"El resultado es: {Operar.Multiplicacion(a,b)}");
                break;
            case 4:
                Console.WriteLine($"El resultado es: {Operar.Division(a,b)}");
                break;
            default:
                break;
        }
    }
    static string[] getNumerosOperables(){
        string numA;
        do{
            do{
                Console.Write("Primer número: ");
                numA = Console.ReadLine();
                if (String.IsNullOrEmpty(numA)) Console.WriteLine("\nError");
            } while(String.IsNullOrEmpty(numA));
        } while(utils.checkIfBinary(numA));

        string numB;
        do{
            do{
                Console.Write("Segundo número: ");
                numB = Console.ReadLine();
                if (String.IsNullOrEmpty(numB)) Console.WriteLine("\nError");
            } while(String.IsNullOrEmpty(numB));
        } while(utils.checkIfBinary(numB));
        Console.Write("\n");
        return new string[]{numA,numB};

    }
    static short GetOpcion(){
        short opcion;
        Console.Write("Opcion: ");
        bool verif = Int16.TryParse(Console.ReadLine(),out opcion);
        while (!verif){
            Console.WriteLine("\nError");
            Console.Write("Opcion: ");
            verif = Int16.TryParse(Console.ReadLine(),out opcion);
        }
        return opcion;
    } 

}
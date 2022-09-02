using Library;
static class Program{
    static void Main(){
        bool bucle = true;
        while(bucle){
            OPconvert();
            Console.Write("Desea continuar? ");
            string a = Console.ReadLine();
            bucle = !(a.ToLower().Equals("no"));
            Console.WriteLine("");
            }
    }
    static void OPconvert(){
        Console.WriteLine(@"
###########################################################
Programa para pasar de decimales a binarios y viceversa
¿Qué conversión deseas realizar?
1) Decimal a binario
2) Binario a decimal
3) Salir
###########################################################\n");
        short opcion = GetOpcion();
        switch (opcion){
            case 1:
                Console.Write("Numero: ");
                int numero1;
                bool check = Int32.TryParse(Console.ReadLine(),out numero1);
                while (!check){
                    Console.Write("\nError: ");
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
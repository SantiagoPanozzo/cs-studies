bool ShouldExecuteMain = true;

while (ShouldExecuteMain == true){
main();
}

void main(){
    Console.WriteLine(@"
#########################################################
Programa para pasar de decimales a binarios y viceversa
¿Qué conversión deseas realizar?
1) Decimal a binario
2) Binario a decimal
3) Salir
#########################################################
    ");
    Console.Write("Opcion: ");
    bool LecturaDeOpcion = int.TryParse(Console.ReadLine(),out int TipoDeConversion);
    while(!LecturaDeOpcion){
        Console.WriteLine("\nVuelve a intentarlo");
        Console.Write("Opcion: ");
        LecturaDeOpcion = int.TryParse(Console.ReadLine(),out TipoDeConversion);
    }
    switch(TipoDeConversion){
        case 1:
            Dec2Bin();
            break;
        case 2:
            Bin2Dec();
            break;
        case 3:
            ShouldExecuteMain = false;
            break;
        default:
            Console.WriteLine("Opcion no valida, pulsa ENTER para volver a intentarlo");
            Console.ReadLine();
            break;
    }
}

void Dec2Bin(){
    Console.WriteLine("\nIntroduce el numero decimal a convertir a binario");
    Console.Write("Numero: ");
    bool DecimalEsValido = int.TryParse(Console.ReadLine(), out int DecimalAConvertir);
    while (!DecimalEsValido){
        Console.WriteLine("\nVuelve a intentarlo");
        Console.Write("Numero: ");
        DecimalEsValido = int.TryParse(Console.ReadLine(), out DecimalAConvertir);
    }
    if(DecimalAConvertir == 1){Console.WriteLine("Resultado: 1");}
    int NumeroEnConversion = DecimalAConvertir;
    int EsteResultado;
    List<int> Resto = new List<int>(); 
    while (NumeroEnConversion > 0){
        EsteResultado = NumeroEnConversion/ 2;
        Resto.Add(EsteResultado % 2);
        NumeroEnConversion = EsteResultado;
        
    }
    Console.Write("Resultado: ");
    foreach(int Caracter in Resto){
        Console.Write(Caracter);
    }
    /* for(int i = Resto.Count-1; i >= 0; i--){
        Console.Write(Resto[i]);
    }     */
    Console.Write("\n");}

void Bin2Dec(){
    Console.WriteLine("\nIntroduce el numero binario a convertir a decimal");
    Console.Write("Numero: ");
    bool BinarioEsValido = int.TryParse(Console.ReadLine(), out int BinarioAConvertir);
    while (!BinarioEsValido){
        Console.WriteLine("\nVuelve a intentarlo");
        Console.Write("Numero: ");
        BinarioEsValido = int.TryParse(Console.ReadLine(), out BinarioAConvertir);
    }
    List<double> Caracteres = new List<double>();    
    string BinarioConvirtiendose = Convert.ToString(BinarioAConvertir);
    for(int i = 0; i < BinarioConvirtiendose.Length; i++){
        double CadaNumero = double.Parse(BinarioConvirtiendose[i].ToString());
        double Exponente = Convert.ToDouble(BinarioConvirtiendose.Length-1-i);
        Caracteres.Add(CadaNumero*Math.Pow(2,Exponente));
    }
    double Sumatoria = 0;
    foreach(double Termino in Caracteres){
        Sumatoria += Termino;
    }
    Console.WriteLine($"Resultado: {Sumatoria}");
}
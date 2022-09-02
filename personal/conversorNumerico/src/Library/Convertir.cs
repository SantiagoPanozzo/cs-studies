namespace Library;
using System.Linq;
public static class Convertir
{
    public static string dec2bin(int entrada){
        List<string> Resto = new List<string> {};
        while (entrada > 0){
            int res = entrada/2;
            Resto.Add((entrada%2).ToString());
            entrada = res;
        }
        Resto.Reverse();
        string outputs = String.Join("",Resto); 
        return outputs;
    }
    public static int bin2dec(string entrada){
        string revEntrada = ""; // reversed entrada
        foreach(char bit in entrada){ // TODO optimize
            revEntrada = bit + revEntrada;}
        double i = 0;
        List<double> operations = new List<double>{};
        foreach(char bit in revEntrada){
            // int num = bit - '0';
            double num = char.GetNumericValue(bit);
            operations.Add(num*(Math.Pow(2,i)));
            i += 1; 
        }
        double output = operations.Sum();
        return Int32.Parse(output.ToString());
    }
}

namespace Library;
public static class Operar{
    public static string Suma(string a, string b){
        int x = Library.Convertir.bin2dec(a);
        int y = Library.Convertir.bin2dec(b);
        return String.Join("",(Library.Convertir.dec2bin(x+y)));
    }
    public static string Resta(string a, string b){
        int x = Library.Convertir.bin2dec(a);
        int y = Library.Convertir.bin2dec(b);
        return String.Join("",(Library.Convertir.dec2bin(x-y)));
    }
    public static string Multiplicacion(string a, string b){
        int x = Library.Convertir.bin2dec(a);
        int y = Library.Convertir.bin2dec(b);
        return String.Join("",(Library.Convertir.dec2bin(x*y)));
    }
    public static string Division(string a, string b){
        int x = Library.Convertir.bin2dec(a);
        int y = Library.Convertir.bin2dec(b);
        return String.Join("",(Library.Convertir.dec2bin(x/y)));
    }
}
namespace Library;
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
}

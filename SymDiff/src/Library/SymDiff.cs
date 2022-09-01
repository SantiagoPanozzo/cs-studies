public class Diferenciador{
    // TODO System.Collections.ArrayList
    public static List<int> symdiff(List<int> list1,List<int> list2){
        List<int> diferencia = new List<int> {};
        foreach (int elemento in list1){
            if (!list2.Contains(elemento)){
                diferencia.Add(elemento);
            }
        }
        foreach (int elemento in list2){
            if (!list1.Contains(elemento)){
                diferencia.Add(elemento);
            }
        }
        return diferencia;
}
}

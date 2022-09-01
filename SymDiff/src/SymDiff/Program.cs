using Library;
class Program{
    static void Main(){
        List<int> List1 = new List<int> {1,2,3};
        List<int> List2 = new List<int> {3,4,5};
        Console.WriteLine(string.Join(", ",Diferenciador.symdiff(List1,List2)));
    }
}
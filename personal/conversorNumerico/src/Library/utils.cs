namespace Library;
public static class utils{
    public static bool checkIfBinary(string a){
        foreach(char bit in a){
            if(!bit.Equals('0')||!(bit.Equals('1'))) return false;
        }
        return true;
    }
}
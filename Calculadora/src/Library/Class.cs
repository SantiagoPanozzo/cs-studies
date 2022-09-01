namespace Library;
public static class Calculadora
{
    /*public static int fibonacci(int n){
        int prev = 0;
        int curr = 1;
        int bridge;
        int i = 3;
        if (n == 1) return 0;
        do{
            bridge = curr;
            curr = curr+prev;
            prev = bridge;
            i++;
        }while(i<=n);
        return curr;
    }*/
    public static int fibonacci(int n){
        if (n == 0){return 0;}
        else if (n == 1 || n == 2){return 1;}
        else return ((fibonacci(n-1)) + (fibonacci(n-2)));
    }
    public static int factorial(int n){
        int res = 1; // ya soluciona 0!
        for (int i = n; i > 0; i--){
            res *= i;
        }
        return res;
    }
    public static bool esPrimo(int n){
        if (n == 1 || n == 0){
            return false;
            }
        for (int i = 2; i < n; i++){
            if (n%i == 0){
                return false;
            }
        }
        return true;
    }
    public static bool esPar(int n){
        if (n%2 == 0){
            return true;
        } else{
            return false;
        }
    }
    public static bool esImpar(int n){
        if (n%2 != 0){
            return true;
        } else{
            return false;
        }
    }
    public static int sumaArray(int[] S){
        int sum = 0;
        foreach(int elem in S){
            sum += elem;
        }
        return sum;
    }
    public static int getAleatorio(int n, int m){
        Random rnd = new Random();
        return rnd.Next(n,m);
    }
}

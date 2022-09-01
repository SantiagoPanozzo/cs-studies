class Program{ // clase con el mismo nombre del archivo
    static void Main(){ // "Main" siempre se llama así, es lo que se ejecuta solo 
        Console.WriteLine($"El factorial de 5 es: {factorial_for(5)}");
        Console.WriteLine($"El factorial de 5 es: {factorial_while(5)}");
        // aca llamamos a las funciones
    }
    
    static int factorial_for(int n){ // funcion for (no es una clase, es un metodo de Program)
        int r = 1;
        for(int i = 1; i < n+1; i++){
            r = r * i;
        }
        return r; 
    }
    static int factorial_while(int n){ // funcion while (no es una clase, es un metodo de Program)
        int r = 1;
        int i = 1;
        while (i <= n){
            r = r * i;
            i += 1;
        }
        return r;
    }
}

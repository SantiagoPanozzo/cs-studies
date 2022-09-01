// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string nombre;
nombre = "Pepe";
string apellido = "Pepepepe";
int edad = 22;

Console.WriteLine(nombre);
Console.WriteLine(apellido);
Console.Write(nombre);
Console.Write(apellido);

Console.Write("\n");
Console.Write("Tienes " + edad + " años? \n");
string x = Console.ReadLine();
Console.WriteLine($"{x}, {x.ToLower()} tengo {edad} años");
var TrueEdad = Console.ReadLine();
TrueEdad = Convert.ToString(TrueEdad);

int jaja = 1;
Console.WriteLine(jaja++); // se actualiza despues de printear
Console.WriteLine(jaja); // ahora ya esta actualizado
Console.WriteLine(jaja+=1); // se actualiza a la vez que se printea

Console.WriteLine(@"this is
a 
multiline
comment
haha");
Console.WriteLine("foo");

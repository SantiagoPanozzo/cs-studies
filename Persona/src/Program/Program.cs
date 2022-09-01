using Library;

Persona p = new Persona("1.234.567-8","Jorge",new DateTime(1985,1,3));
Persona p1 = new Persona("12345678","Jorge",new DateTime(1985,1,3));
Persona p2 = new Persona("1234567-8","Jorge",new DateTime(1985,1,3));
Persona p3 = new Persona("1234567/8","Jorge",new DateTime(1985,1,3));
Persona p4 = new Persona("1234567 8","Jorge",new DateTime(1985,1,3));
Persona p5 = new Persona("1.234.567 8","Jorge",new DateTime(1985,1,3));
Persona p6 = new Persona("1.234 567-8","Jorge",new DateTime(1985,1,3));

Console.WriteLine(@$"Nombre: {p.GetNombre()}    Cedula: {p.GetCedula()}     Nacimiento: {p.GetFechaNacimiento().ToShortDateString()}    Edad: {p.GetEdad()}");
Console.WriteLine(@$"Nombre: {p1.GetNombre()}    Cedula: {p1.GetCedula()}     Nacimiento: {p1.GetFechaNacimiento().ToShortDateString()}    Edad: {p1.GetEdad()}");
Console.WriteLine(@$"Nombre: {p2.GetNombre()}    Cedula: {p2.GetCedula()}     Nacimiento: {p2.GetFechaNacimiento().ToShortDateString()}    Edad: {p2.GetEdad()}");
Console.WriteLine(@$"Nombre: {p3.GetNombre()}    Cedula: {p3.GetCedula()}     Nacimiento: {p3.GetFechaNacimiento().ToShortDateString()}    Edad: {p3.GetEdad()}");
Console.WriteLine(@$"Nombre: {p4.GetNombre()}    Cedula: {p4.GetCedula()}     Nacimiento: {p4.GetFechaNacimiento().ToShortDateString()}    Edad: {p4.GetEdad()}");
Console.WriteLine(@$"Nombre: {p5.GetNombre()}    Cedula: {p5.GetCedula()}     Nacimiento: {p5.GetFechaNacimiento().ToShortDateString()}    Edad: {p5.GetEdad()}");
Console.WriteLine(@$"Nombre: {p6.GetNombre()}    Cedula: {p6.GetCedula()}     Nacimiento: {p6.GetFechaNacimiento().ToShortDateString()}    Edad: {p6.GetEdad()}");

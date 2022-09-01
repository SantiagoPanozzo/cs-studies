using Libary;

Persona Pepito = new Persona();

Pepito.setNombre("Pepito");
Pepito.setEdad(21);
Pepito.setFecha(DateTime.Today);
Console.WriteLine(Pepito.getNombre());
Console.WriteLine(Pepito.getFecha());
Console.WriteLine(Pepito.getEdad());

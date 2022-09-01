namespace Libary;
public class Persona
{
    private string nombre;
    private string cedula;
    private int edad;
    private DateTime FechaDeNacimiento;

    public string getNombre(){
        return this.nombre;
    }

    public void setNombre(string nombre){
        this.nombre = nombre;
    }

    public string getCedula(){
        return this.cedula;
    }
    public void setCedula(string cedula){
        // IMPRIMIR cedula
        this.cedula = cedula;
    }
    
    public DateTime getFecha(){
        return this.FechaDeNacimiento;
    }
    public void setFecha(DateTime fecha){
        this.FechaDeNacimiento = fecha;
    }
    
    public int getEdad(){
        return this.edad;
    }
    public void setEdad(int edad){
        this.edad = edad;
    }
}


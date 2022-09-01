namespace Library;
using System.Text.RegularExpressions;
public class Persona {

    private static string cedulaReferencia = "2987634";
    private string cedula;  //Cedula tiene el formato 12345678
    private string nombre;
    private DateTime fechaNacimiento;

    private int edad;

    /// <summary>
    /// Crea una nueva instancia de Persona.
    /// </summary>
    /// <param name="cedula">Una cédula válida.</param>
    /// <param name="nombre">Un nombre válido.</param>
    /// <param name="nacimiento">Una fecha de nacimiento válida.</param>
    public Persona(string cedula, string nombre, DateTime nacimiento) {
        Regex regex = new Regex("[^0-9]");
        cedula = regex.Replace(cedula,"");
        this.cedula = cedula;       //Normalizando
        this.nombre = nombre;
        this.fechaNacimiento = nacimiento;
    }

    public string GetCedula() {
        return this.cedula;
    }

    public void SetCedula(string cedula) {
        int new_ci = Convert.ToInt32(cedula.Replace(".", "").Replace("-", ""));
        if (1000000<=new_ci && new_ci<=99999999){
            int counter;
            int expected_dig = 0;
            if (new_ci<=10000000){
                counter = 1;}
            else{
                counter = 0;}
            int index = 0;
            int last_index = 7-counter;
            int[] values = {2, 9, 8, 7, 6, 3, 4};
            int sum = 0;
            foreach(int num in values[counter..^0]){
                sum += num*new_ci.ToString().Select(x => Convert.ToInt16(x.ToString())).ToArray()[index];
                index += 1;
            }
            int remainder = sum%10;
            if (!(remainder == 0)){
                expected_dig = remainder;
            }
            if (expected_dig == Convert.ToInt32(new_ci.ToString().Select(x => Convert.ToInt32(x.ToString())).ToArray()[last_index]))
            this.cedula = cedula;
        }
        else
        Console.WriteLine("Cédula inválida.");
    }

        //TODO Implementar este método para que solo asigne el valor si el dígito verificador es correcto.
        //El valor guardado contiene 8 caracteres numéricos y no se guardan otros caracteres.
    public string GetNombre() {
        return $"El nombre es {this.nombre}";
    }
    public void SetNombre(string nombre) {
        this.nombre = nombre;
    }
    public int GetEdad() {
        return this.edad;
    }
    public void SetEdad(int edad) {
        this.edad = edad;
    }

    public DateTime GetFechaNacimiento(){
        return this.fechaNacimiento;
    }

    public void SetFechaNacimiento(DateTime fecha) {
        this.fechaNacimiento = fecha;
    }

    public static bool isCedulaValida(string cedula){
        int new_ci = Convert.ToInt32(cedula.Replace(".", "").Replace("-", ""));
        if (1000000<=new_ci && new_ci<=99999999){
            int counter;
            int expected_dig = 0;
            if (new_ci<=10000000){
                counter = 1;}
            else{
                counter = 0;}
            int index = 0;
            int last_index = 7-counter;
            int[] values = {2, 9, 8, 7, 6, 3, 4};
            int sum = 0;
            foreach(int num in values[counter..^0]){
                sum += num*new_ci.ToString().Select(x => Convert.ToInt16(x.ToString())).ToArray()[index];
                index += 1;
            }
            int remainder = sum%10;
            if (!(remainder == 0)){
            expected_dig = remainder;
            }
            if (expected_dig == Convert.ToInt32(new_ci.ToString().Select(x => Convert.ToInt16(x.ToString())).ToArray()[last_index])){
                return true;}
            else{
            return false;
            }
        }
        else{
            return false;}
        //Se aceptan cédulas en los formatos:
        //1.234.567-8, 12345678, 1234567-8, 1234567/8, 1234567 8, 1.234.567 8s
    //        return true;    //TODO corregir para que retorne true o false en base al dígito verificador de la cédula.
    }

    }

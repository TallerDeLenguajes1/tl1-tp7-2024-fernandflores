
public class Empresa
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldo;
        private Cargo puesto;

    public Empresa()
    {
    }

    public Empresa(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldo, Cargo puesto) // the constructor 
    {
        this.nombre= nombre;
        this.apellido=apellido;
        this.fechaNacimiento=fechaNacimiento;
        this.estadoCivil=estadoCivil;
        this.fechaIngreso=fechaIngreso;
        this.sueldo=sueldo;
        this.puesto=puesto;
    }

    public string Nombre { get => nombre; set => nombre = value; } // esto permite poder usar Nombre en Calculadora.cs
    public string Apellido { get => apellido; set => apellido = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public double SueldoBasico { get => sueldo; set => sueldo = value; }
    public DateTime FechaNacimiento {get=>fechaNacimiento; set=>fechaNacimiento=value;}
    public DateTime FechaIngreso {get=>fechaIngreso; set=>fechaIngreso=value;}
    public Cargo Puesto { get => puesto; set => puesto = value; }
    public int calcularAntiguedad(DateTime ingreso){
        DateTime fechaActual= DateTime.Today;
        int antiguedad= fechaActual.Year - ingreso.Year; // ej: antiguedad= 2024-05-19 - 2020-08-08= 2024-2020= 4
        if(ingreso.Date>fechaActual.AddYears(-antiguedad)) //// compara la fecha fechacimiento con la fechaactual(-antiguedad) 2024-05-19 - 4(antiguedad) = 2020-05-19 si ingreso (2020-08-08) es mayor que 2020-05-19 le resta uno a antiguedad ya que signfica que aun no se cumplio el aniversario
        {
            antiguedad--;
        }
        return antiguedad;
    }
    public int calcularEdad(){ //puedo no pedir parametros ya que esta todo aca en la clase y no necesito ingresar datos de afuera (por el usuario) igual hice una asi de ejemplo en el calcularAntiguedad 
        DateTime fechaActual= DateTime.Today;
        int edad= fechaActual.Year - fechaNacimiento.Year;
        if(fechaNacimiento.Date>fechaActual.AddYears(-edad)) // compara la fecha fechacimiento con la fechaactual(-edad)...
        {
            edad--;
        }
        return edad;
    }
    public int calcularjubilacion()
    {
        int edad= calcularEdad(); //uso la funcion porque... para que volver a calcular la edad si tengo una funcion que ya lo hace
        int cantidadAnios=0;
        if(edad<65)
        {
            cantidadAnios= 65-edad;
        }
        return cantidadAnios;
    }

    public double calcularSalario()
    {
        double adicional=0, sueldoNeto=0;
        int antiguedad= calcularAntiguedad(fechaIngreso);
        if(antiguedad>20)
        {
            adicional=sueldo*0.25;
        }
        else
        {
            adicional= sueldo*(antiguedad/100.0);
        }
        if (puesto == Cargo.ingeniero || puesto== Cargo.especialista)
        {
            adicional*=1.50;
        }
        if(estadoCivil=='c')
        {
            adicional+=150000;
        }
        sueldoNeto=sueldo + adicional;
        return sueldoNeto;
    }
    public string showClase ()
    {
        return (apellido+"\n"+nombre+"\n"+"fecha de nacimiento: "+fechaNacimiento+"\n"+"estado civil: "+estadoCivil+"\n"+"fecha ingreso: "+fechaIngreso+"\n"+"sueldo: "+sueldo+"\n"+"puesto: "+puesto+"\n"+"edad: "+calcularEdad()+"\n"+"antiguedad: "+calcularAntiguedad(fechaIngreso)+"\n"+"le faltan: "+calcularjubilacion()+" años para jubilarse"+"\n"+"sueldo neto: ARS$ "+calcularSalario()); 
    }
}
 public enum Cargo
        {
            auxiliar,
            administrativo,
            ingeniero,
            especialista,
            investigador
        }
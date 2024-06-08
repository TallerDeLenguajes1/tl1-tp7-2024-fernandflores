
public class Empresa
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldo;
        private Cargo puesto;

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

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public double Salario { get => sueldo; set => sueldo = value; }
    public DateTime FechaNacimiento {get=>fechaNacimiento; set=>fechaNacimiento=value;}
    public DateTime FechaIngreso {get=>fechaIngreso; set=>fechaIngreso=value;}
    public Cargo Puesto { get => puesto; set => puesto = value; }
    public int calcularAntiguedad(DateTime ingreso){
        DateTime fechaActual= DateTime.Today;
        int antiguedad= fechaActual.Year - ingreso.Year;
        if(ingreso.Date>fechaActual.AddYears(-antiguedad))
        {
            antiguedad--;
        }
        return antiguedad;
    }
    public int calcularEdad(DateTime nacimiento){
        DateTime fechaActual= DateTime.Today;
        int edad= fechaActual.Year - nacimiento.Year;
        if(nacimiento.Date>fechaActual.AddYears(-edad))
        {
            edad--;
        }
        return edad;
    }
    public int calcularjubilacion()
    {
        int edad= calcularEdad(fechaNacimiento); //uso la funcion porque... para que volver a calcular la edad si tengo una funcion que ya lo hace
        int cantidadAnios=0;
        if(edad<65)
        {
            cantidadAnios= 65-edad;
        }
        return cantidadAnios;
    }

    public double calcularSalario()
    {
        double adicional=0;
        int antiguedad= calcularAntiguedad(fechaIngreso);
        if(antiguedad>20)
        {
            adicional=sueldo*0.25;
        }
        else
        {
            adicional= sueldo*(antiguedad/100);
        }
        if (puesto == Cargo.ingeniero || puesto== Cargo.especialista)
        {
            adicional*=1.50;
        }
        if(estadoCivil=='c')
        {
            adicional+=150000;
        }
        return sueldo;
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
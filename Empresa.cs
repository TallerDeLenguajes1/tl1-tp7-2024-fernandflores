
public class Empresa
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldo;
        private Cargo puesto;


    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public double Sueldo { get => sueldo; set => sueldo = value; }
    public DateTime FechaNacimiento {get=>fechaNacimiento; set=>fechaNacimiento=value;}
    public DateTime FechaIngreso {get=>fechaIngreso; set=>fechaIngreso=value;}
    public Cargo Puesto { get => puesto; set => puesto = value; }
}
 public enum Cargo
        {
            auxiliar,
            administrativo,
            ingeniero,
            especialista,
            investigador
        }
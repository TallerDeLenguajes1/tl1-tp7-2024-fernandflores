DateTime fecha1, fecha2;
char estadoC;
Empresa empresa= new Empresa();
Console.WriteLine("ingrese nombre");
empresa.Nombre=Console.ReadLine();
Console.WriteLine("ingrese apellido");
empresa.Apellido=Console.ReadLine();
bool banderaFechaNacimiento=false;
do
{
  Console.WriteLine("ingrese fecha nacimiento");
  if (DateTime.TryParse(Console.ReadLine(), out fecha1))
  {
    empresa.FechaNacimiento=fecha1;
    banderaFechaNacimiento=true;
  }
  else
  {
    Console.WriteLine("ingreso fecha incorrecta");
  }
}while(!banderaFechaNacimiento); 
bool banderaEstadoCivil=false;
do
{
  Console.WriteLine("ingrese estado civil c: | casado s: soltero");
  if (char.TryParse(Console.ReadLine().ToLower(), out estadoC) && (estadoC=='c' || estadoC=='s')) // console.readline().tolower lee lo que se ingresa, lo pasa a minuscula y si es un char sale la variable estadoC
  {
    empresa.EstadoCivil=estadoC;
    banderaEstadoCivil= true;
  }
}while(!banderaEstadoCivil);  
bool banderaFechaIngreso=false;
do
{
  Console.WriteLine("ingrese fecha de ingreso a la empresa");
  if (DateTime.TryParse(Console.ReadLine(), out fecha2))
  {
    empresa.FechaIngreso=fecha2;
    banderaFechaIngreso= true;
  }
  else
  {
    Console.WriteLine("ingreso fecha incorrecta");
  }
}while(!banderaFechaIngreso);  
Console.WriteLine("ingrese su sueldo");
if (double.TryParse(Console.ReadLine(), out double auxSueldo))
{
  empresa.SueldoBasico=auxSueldo;
}
bool banderaCargo=false; // bandera para realizar el encontrado
do
{
  Console.WriteLine("ingrese su puesto 1: auxiliar | 2: administrativo | 3: ingeniero | 4: especialista | 5: investigador");
  if (int.TryParse(Console.ReadLine(), out int cargo))
  {
    switch (cargo)
    {
      case 1:
        empresa.Puesto= Cargo.auxiliar;
        banderaCargo= true;
      break;
      case 2:
        empresa.Puesto= Cargo.administrativo;
        banderaCargo= true;
      break;
      case 3:
        empresa.Puesto= Cargo.ingeniero; 
        banderaCargo= true;
      break;
      case 4:
        empresa.Puesto= Cargo.especialista;
        banderaCargo= true;
      break;
      case 5:
        empresa.Puesto= Cargo.investigador;
        banderaCargo= true;
      break;
      default:
        Console.WriteLine("ingreso opcion invalida");
      break;
    }
  }
}while(!banderaCargo); 
int edad= empresa.calcularEdad();
int antiguedad= empresa.calcularAntiguedad(empresa.FechaIngreso);
int jubilacion= empresa.calcularjubilacion();
double sueldoNeto= empresa.calcularSalario();
Console.WriteLine(empresa.showClase());
/*
Empresa empresa= new Empresa("Cesar Fernando", "Flores", new DateTime(1999,05,19), 'c', new DateTime(2010,02,01), 100000, Cargo.ingeniero); //usamos the constructor
int edad= empresa.calcularEdad();
int antiguedad= empresa.calcularAntiguedad(empresa.FechaIngreso);
int jubilacion= empresa.calcularjubilacion();
double sueldoNeto= empresa.calcularSalario();
mostrarEmpleado(empresa);
void mostrarEmpleado(Empresa empresita){
Console.WriteLine("\n ----- empleado -------");
Console.WriteLine("nombre "+empresita.Nombre);
Console.WriteLine("apellido "+empresita.Apellido);
Console.WriteLine("sueldo: "+empresita.SueldoBasico);
Console.WriteLine("estado civil "+empresita.EstadoCivil);
Console.WriteLine("ingreso: "+empresita.FechaIngreso);
Console.WriteLine("fecha nacimiento: "+empresita.FechaNacimiento);
Console.WriteLine("edad: "+edad);
Console.WriteLine($"antiguedad: {antiguedad}"); //otra forma de mostrar texto
Console.WriteLine($"le faltan {jubilacion} años para jubilarse");
Console.WriteLine($"sueldo neto: {sueldoNeto}");
}
*/

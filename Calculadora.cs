DateTime fecha1, fecha2;
char estadoC;
Empresa empresa= new Empresa();
Console.WriteLine("ingrese nombre");
empresa.Nombre=Console.ReadLine();
Console.WriteLine("ingrese apellido");
empresa.Apellido=Console.ReadLine();
Console.WriteLine(empresa.Apellido);
Console.WriteLine("ingrese fecha nacimiento");
if (DateTime.TryParse(Console.ReadLine(), out fecha1))
{
  empresa.FechaNacimiento=fecha1;
}
else
{
  Console.WriteLine("ingreso fecha incorrecta");
}
Console.WriteLine("ingrese estado civil c: | casado s: soltero");
if (char.TryParse(Console.ReadLine(), out estadoC))
{
  empresa.EstadoCivil=estadoC;
}
Console.WriteLine("ingrese fecha de ingreso a la empresa");
if (DateTime.TryParse(Console.ReadLine(), out fecha2))
{
  empresa.FechaIngreso=fecha2;
}
else
{
  Console.WriteLine("ingreso fecha incorrecta");
}
Console.WriteLine("ingrese su sueldo");
if (double.TryParse(Console.ReadLine(), out double auxSueldo))
{
  empresa.SueldoBasico=auxSueldo;
}
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

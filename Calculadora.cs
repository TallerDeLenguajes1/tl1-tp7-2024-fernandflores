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
  empresa.Sueldo=auxSueldo;
}
mostrarEmpleado(empresa);
void mostrarEmpleado(Empresa empresita){
Console.WriteLine("\n ----- empleado -------");
Console.WriteLine("nombre "+empresita.Nombre);
Console.WriteLine("apellido "+empresita.Apellido);
Console.WriteLine("sueldo: "+empresita.Sueldo);
Console.WriteLine("estado civil "+empresita.EstadoCivil);
Console.WriteLine("ingreso: "+empresita.FechaIngreso);
Console.WriteLine("fecha nacimiento: "+empresita.FechaNacimiento);
}

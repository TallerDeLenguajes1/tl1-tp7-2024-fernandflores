
Empresa empresa= new Empresa("Cesar Fernando", "Flores", new DateTime(1999,05,19), 'c', new DateTime(2023,02,01), 7000, Cargo.ingeniero);
int edad= empresa.calcularEdad(empresa.FechaNacimiento);
int antiguedad= empresa.calcularAntiguedad(empresa.FechaIngreso);
int jubilacion= empresa.calcularjubilacion();
double sueldoNeto= empresa.calcularSalario();
mostrarEmpleado(empresa);
void mostrarEmpleado(Empresa empresita){
Console.WriteLine("\n ----- empleado -------");
Console.WriteLine("nombre "+empresita.Nombre);
Console.WriteLine("apellido "+empresita.Apellido);
Console.WriteLine("sueldo: "+empresita.Salario);
Console.WriteLine("estado civil "+empresita.EstadoCivil);
Console.WriteLine("ingreso: "+empresita.FechaIngreso);
Console.WriteLine("fecha nacimiento: "+empresita.FechaNacimiento);
Console.WriteLine("edad: "+edad);
Console.WriteLine($"antiguedad: {antiguedad}"); //otra forma de mostrar texto
Console.WriteLine($"");
}

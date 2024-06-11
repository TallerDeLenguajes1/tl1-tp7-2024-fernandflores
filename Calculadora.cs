DateTime fecha1, fecha2;
char estadoC;
//Empresa empresa= new Empresa();
Empresa[] empresa= new Empresa[3]; //declaramos empresa como arreglo (se da la memoria si o si[3])
double totalSalarios=0;
/*empresa[0]= new Empresa("Cesar", "Flores", new DateTime(2002,05,19), 'c', new DateTime(2010,02,01), 100000, Cargo.auxiliar);
empresa[1]= new Empresa("Cesar Fernando", "Flores", new DateTime(1999,05,19), 's', new DateTime(2010,02,01), 90000, Cargo.ingeniero);
empresa[2]= new Empresa("valentina", "Flores", new DateTime(2004,05,19), 'c', new DateTime(2010,02,01), 7000, Cargo.investigador);*/ //si quisiera ahorrarme el cargar datos lo hago asi, comentaria desde la creacion del espacio para cada uno de los 3 hasta el while de banderaCargo: }while(!banderaCargo);
for(int i=0; i<3; i++)
{
  empresa[i]= new Empresa(); //creamos el espacio de memoria para cada uno de los 3
  Console.WriteLine("ingrese nombre");
  empresa[i].Nombre=Console.ReadLine();
  Console.WriteLine("ingrese apellido");
  empresa[i].Apellido=Console.ReadLine();
  bool banderaFechaNacimiento=false;
  do
  {
    Console.WriteLine("ingrese fecha nacimiento");
    if (DateTime.TryParse(Console.ReadLine(), out fecha1))
    {
      empresa[i].FechaNacimiento=fecha1;
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
      empresa[i].EstadoCivil=estadoC;
      banderaEstadoCivil= true;
    }
  }while(!banderaEstadoCivil);  
  bool banderaFechaIngreso=false;
  do
  {
    Console.WriteLine("ingrese fecha de ingreso a la empresa");
    if (DateTime.TryParse(Console.ReadLine(), out fecha2))
    {
      empresa[i].FechaIngreso=fecha2;
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
    empresa[i].SueldoBasico=auxSueldo;
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
          empresa[i].Puesto= Cargo.auxiliar;
          banderaCargo= true;
        break;
        case 2:
          empresa[i].Puesto= Cargo.administrativo;
          banderaCargo= true;
        break;
        case 3:
          empresa[i].Puesto= Cargo.ingeniero; 
          banderaCargo= true;
        break;
        case 4:
          empresa[i].Puesto= Cargo.especialista;
          banderaCargo= true;
        break;
        case 5:
          empresa[i].Puesto= Cargo.investigador;
          banderaCargo= true;
        break;
        default:
          Console.WriteLine("ingreso opcion invalida");
        break;
      }
    }
  }while(!banderaCargo); 
  int edad= empresa[i].calcularEdad();
  int antiguedad= empresa[i].calcularAntiguedad(empresa[i].FechaIngreso);
  int jubilacion= empresa[i].calcularjubilacion();
  double sueldoNeto= empresa[i].calcularSalario();
  totalSalarios+=sueldoNeto;
}
int aux= empresa[0].calcularjubilacion(); // inicializamos
int indice=0; //inicializamos el indice por si el primero ya es mas proximo a jubilarse 
for (int k = 0; k < 3; k++)
{
  if(empresa[k].calcularjubilacion() < aux) // empresa[k].calcularJubilacion devuelve la cantidad de años que le faltan para jubilarse
  {                                         // a eso lo compara con aux 
    aux= empresa[k].calcularjubilacion();
    indice=k;    // guarda la posicion en la que  se encuentra 
  }
}
for (int j = 0; j < 3; j++)
{   
    Console.WriteLine("\n-------------EMPLEADO "+(j+1)+"--------------------\n");
    Console.WriteLine(empresa[j].showClase());
    Console.WriteLine("\n");
}
Console.WriteLine("\nse paga en total: AR$: "+totalSalarios+" de sueldos\n");
Console.WriteLine("\nempleado mas proximo a jubilarse: n° "+(indice+1)+"\n");
Console.WriteLine(empresa[indice].showClase());
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
} solo funciona para uno
*/

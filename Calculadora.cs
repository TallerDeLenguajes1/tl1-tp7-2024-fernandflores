using espacioCalculador;
//ConsoleKeyInfo key = Console.ReadKey();
//key.Key == ConsoleKey.Escape;

int opc, rep=1;
Calculadora clase= new Calculadora();
do
{
  Console.WriteLine("----------------MENU----------------");
  Console.WriteLine("1: Sumar");
  Console.WriteLine("2: restar");
  Console.WriteLine("3: multiplicar");
  Console.WriteLine("4: dividir");
  Console.WriteLine("5: limpiar");
  Console.WriteLine("*~-ingrese tecla de escape para salir-~*");
  string buffopc= Console.ReadLine();
  ConsoleKeyInfo key= Console.ReadKey();
  if (key.Key!=ConsoleKey.Escape){
    if (int.TryParse(buffopc, out opc))
    {
        Console.WriteLine("numero antes de la operacion: "+clase.Resultado);
        switch(opc)
        {
            case 1: 
                clase.Sumar(20);
                Console.WriteLine(clase.Resultado);     
                break;            
            case 2: 
                clase.Restar(10);
                Console.WriteLine(clase.Resultado);     
                break;
            case 3: 
                clase.Multriplicar(5);
                Console.WriteLine(clase.Resultado);     
                break;
            case 4: 
                clase.Dividir(2);
                Console.WriteLine(clase.Resultado);     
                break;
            case 5: 
                clase.Limpiar();
                Console.WriteLine(clase.Resultado);     
                break;
        }
    }
  }else{
    rep=0;
  }
} while (rep!=0);

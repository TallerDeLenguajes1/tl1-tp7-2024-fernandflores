namespace espacioCalculador
{
public class Calculadora
{
    private double dato;


    public Calculadora()  // contructor para inicializar dato en 0
    {
        dato =0;
    }
    public Calculadora(int valorinicial) //contructor para inicializar el dato en un valor 
    {
        dato= valorinicial;
    }

    public void Sumar (double termino)
    {
        dato+= termino;
    }
    public void Restar (double termino)
    {
        dato-= termino;
    }
    public void Multriplicar (double termino)
    {
        dato*= termino;
    }
    public void Dividir(double termino)
    {
        if (termino!=0)
        {
            dato/= termino;
        }else{
            Console.WriteLine("no es posible dividir por 0");
        }
    }
    public void Limpiar(){
        dato=0;
    }
    public double Resultado{ get => dato;}
    }
    }/*
    calculadora.sumar(20);
    double resultado= Calculadora.Resultado;
    System.Console.WriteLine(resultado);*/
   
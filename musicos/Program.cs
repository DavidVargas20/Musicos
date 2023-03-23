 
 abstract class musico // abstract 
{

    public string? Nombre {get;set;}


    public musico (string nombre){ Nombre=nombre ; }

     public void saluda(){ Console.WriteLine($" hola soy {Nombre} ");}

    public  abstract /*virtual*/ void toca();// no  van a tener implementacion debido a ser muy general. y se delegan de forma obligatoria
    /* deben estar en clases clases abstractaspara existir .*/
    /*{
       /*Console.WriteLine($"  {Nombre}   tocando su instrumento");
    }*/
     


}
   

class baterista:musico
{
   public string Bateria {get;set;}

   public baterista ( string Nombre , string bateria):base(Nombre)=> Bateria=bateria;
   public override /*new*/ void toca() /*override*/
  {
    Console.WriteLine($"{Nombre} tocando su {Bateria }");
  }
    
}
class bajista:musico
{

  public string Bajo {get;set;}

  public bajista(string Nombre, string bajo):base(Nombre) => Bajo=bajo;
  public override /*new*/ void toca() /*overide*/
  {
    Console.WriteLine($"{Nombre} tocando su { Bajo }");
  }
  
}


 class program
{
    private static void Main(string[] args)
    {
        //musico.gustavocerati = new musico ("Gustavo Cerati");
         /* se pueden tener crear listas de clases abstractas pero no objetos */
        List<musico> sodaestereo= new List<musico>();
        sodaestereo.Add(new musico("gustavo cerati"));
        sodaestereo.Add(new bajista("zeta","musicam"));
        sodaestereo.Add(new baterista("charlie","yamaha"));

        foreach(var m in sodaestereo) m.saluda();// polimorfismo
        foreach(var m in sodaestereo) m.toca();


        //

    }
}
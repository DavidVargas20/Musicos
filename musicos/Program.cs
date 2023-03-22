 
 class musico
{

    public string Nombre {get;set;}


    public musico (string nombre){ Nombre=nombre ; }

     public void saluda(){ Console.WriteLine($"{Nombre} hola soy ");}

    public virtual void toca()
    {
       Console.WriteLine($"  {Nombre}   tocando su instrumento");
    }
     


}
   

class baterista:musico
{
   public string Bateria {get;set;}

   public baterista ( string Nombre , string bateria):base(Nombre)=> Bateria=bateria;
   public override void toca()
  {
    Console.WriteLine($"{Nombre} tocando su {Bateria }");
  }
    
}
class bajista:musico
{

  public string Bajo {get;set;}

  public bajista(string Nombre, string bajo):base(Nombre) => Bajo=bajo;
  public /*override*/ new void toca()
  {
    Console.WriteLine($"{Nombre} tocando su { Bajo }");
  }
  
}


 class program
{
    private static void Main(string[] args)
    {
        //musico.gustavocerati = new musico ("Gustavo Cerati");

        List<musico> sodaestereo= new List<musico>();
        sodaestereo.Add(new musico("gustavo cerati"));
        sodaestereo.Add(new bajista("zeta","musicam"));
        sodaestereo.Add(new baterista("charlie","yamaha"));

        foreach(var m in sodaestereo) m.saluda();// polimorfismo
        foreach(var m in sodaestereo) m.toca();

    }
}
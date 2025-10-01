class ClaseBase
{
    public void test()
    { 
    }
    public virtual void masTests()
    { 
    }
}
class ClaseHijo : ClaseBase
{
    public override void masTests()
    { 
    }
}
internal class Program
{
    private static void Main(String[] args)
    {
        Console.WriteLine("Corrio la aplicacion");
    }
}

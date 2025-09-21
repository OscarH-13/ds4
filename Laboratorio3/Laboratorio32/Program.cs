internal class Program
{
    private static void Main(string[] args)
    {
        double a;
        CalculosMatematicos cm = new CalculosMatematicos();
        Console.WriteLine("Ingrese el radio del circulo");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("el area del circulo es: " + cm.calculoArea(a));
    }
}
internal class CalculosMatematicos
{
    public double calculoArea(double a)
    {
        return Math.PI * Math.Pow(a, 2);
    }
}
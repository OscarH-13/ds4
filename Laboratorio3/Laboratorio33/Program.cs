internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        CalculosMatematicos cm = new CalculosMatematicos();
        Console.WriteLine("Ingrese el largo del rectangulo ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el ancho del rectangulo ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El perimetro del triangulo es " + cm.calcularPerimetro(a,b));
    }
}
internal class CalculosMatematicos
{
    public int calcularPerimetro(int a, int b)
    {
        return 2*(a+b);
    }
}
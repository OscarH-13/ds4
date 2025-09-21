internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        CalculosMatematicos cm = new CalculosMatematicos();
        Console.WriteLine("Ingrese el primer número");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("el resultado de la operacion (num1+num2)*(num1-num2) es: " + cm.calcular(a, b));
    }
}
internal class CalculosMatematicos
{
    public int calcular(int a, int b)
    {
        return (a + b) * (a - b);
    }
}
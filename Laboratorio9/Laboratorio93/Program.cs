internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer lado del triángulo:");
        double l1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo lado del triángulo:");
        double l2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer lado del triángulo:");
        double l3 = Convert.ToDouble(Console.ReadLine());
        Triangulo tr = new Triangulo();
        Console.WriteLine(tr.verificar(l1, l2, l3));
        Console.ReadKey();
    }
}
public class Triangulo
{
    public string verificar(double l1, double l2, double l3) 
    {
        if (l1 + l2 > l3 && l1 + l3 > l2 && l2 + l3 > l1)
        {
            if (l1 == l2 && l2 == l3)
            {
                return "El triángulo es Equilátero";
            }
            else if (l1 == l2 || l1 == l3 || l2 == l3)
            {
                return "El triángulo es Isósceles";
            }
            else
            {
                return "El triángulo es Escaleno";
            }
        }
        else
        {
            return "No es un triangulo valido";
        }
    }

}

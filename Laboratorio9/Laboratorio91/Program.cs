internal class Program
{
    private static void Main(string[] args)
    {
        double pago = 0;
        Console.WriteLine("Ingrese el precio de el producto:");
        double precio = Convert.ToDouble(Console.ReadLine());
        do
        {
            Console.WriteLine("Para pagar con efectivo ingrese 1\n Para pagar con tarjeta ingrese 2");
            pago = Convert.ToDouble(Console.ReadLine());
        }
        while (pago != 1 && pago != 2);
        Determinar d = new Determinar();
        Console.WriteLine(d.verificar(pago));
        Console.ReadKey();
    }
}

public class Determinar
{
    public string verificar(double pago) 
    {
        if (pago == 1)
        {
            return "pago en efectivo";
        }
        else 
        {
            string cuenta;
            do
            {
                Console.WriteLine("Ingrese su numero de cuenta de 16 digitos");
                cuenta = Console.ReadLine();
            }
            while (cuenta.Length !=16);
            return $"su cuenta es : {cuenta}";
        }
    }
}
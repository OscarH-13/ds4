public class Aleatorios
{
    int num1, num2, num3;
    Random random = new Random();
    public void generar()
    {
        num1 = random.Next();
        num2 = random.Next();
        if (num1 < num2)
        {
            num3 = random.Next(num1, num2);
        }
        else 
        {
            num3 = random.Next(num2, num1);
        }
        Console.WriteLine($"Num 1: {num1}. Num 2: {num2}. El nuevo numero generado: {num3} ");
    }
    public void almacenar()
    {
        int i=0;
        num1 = random.Next(0,101);//se le pone limite porque durante la prueba nunca termino de escribir
        num2 = random.Next(0,101);//se le pone limite porque durante la prueba nunca termino de escribir
        Console.WriteLine($"num 1: {num1}, num 2: {num2}");
        if (num1 <= num2)//menor o igual por si sale el mismo numero
        {
            int[] array = new int[(num2 - num1) + 1];
            while (num1 <= num2)
            {
                array[i] = num1;
                num1++;
                Console.Write($"[{array[i]}]");
                i++;
            }
        }
        else if (num2 <= num1)//menor o igual por si sale el mismo numero
        {
            int[] array = new int[(num1 - num2) + 1];
            while (num2 <= num1)
            { 
                array[i] = num2;
                num2++;
                Console.Write($"[{array[i]}]");
                i++;
            }
        }
    }
}
internal class Program 
{
    public static void Main(String[] args)
    {
        Aleatorios al = new Aleatorios();
        al.generar();
        al.almacenar();
        Console.ReadKey();
    }
}
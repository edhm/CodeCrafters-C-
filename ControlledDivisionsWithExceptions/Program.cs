using ControlledDivisionsWithExceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        int resultado = 0;
        Console.WriteLine("Ingrese dos números");

        Console.WriteLine("Ingrese el Dividendo");
        int dividendo = int.Parse(Console.ReadLine());

       Console.WriteLine("Ingrese el Divisor");
       int divisor = int.Parse(Console.ReadLine());
  
        try
        {
           
            resultado = MathOperations.division(dividendo, divisor);
            Console.WriteLine($"El resultados es: {resultado}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error...{ex.Message}");
        }
        Console.ReadLine();
    }
  }
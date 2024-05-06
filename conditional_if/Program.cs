// Console.WriteLine("Hello, World!");

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese edad");
        int edad = int.Parse(Console.ReadLine());
        if (edad > 18) { Console.WriteLine("Es mayor de edad"); } else { Console.WriteLine("No es mayor de edad"); }
    }
}
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Seleccione LL.PP a aprender: java, net, cobol, delphi  ");
        String llpp = Console.ReadLine();
        switch(llpp){ case "java":Console.WriteLine("LL.PP. level One"); break;
            case "net": Console.WriteLine("LL.PP. level Two"); break;
            case "cobol": Console.WriteLine("LL.PP. level Three"); break;
            case "delphi": Console.WriteLine("LL.PP. level Four");break;
        }

    }
}
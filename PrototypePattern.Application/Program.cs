namespace PrototypePattern.Application;

internal static class Program
{
    private static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("═══════════════════════════════════════════════════════");
        Console.WriteLine("  Паттерн Прототип: Греческие Боги");
        Console.WriteLine("═══════════════════════════════════════════════════════\n");

        Demonstrate.PrototypePattern();

        Console.WriteLine("\n═══════════════════════════════════════════════════════");
        Console.WriteLine("  Демонстрация завершена");
        Console.WriteLine("═══════════════════════════════════════════════════════");
        Console.ReadKey();
    }
}
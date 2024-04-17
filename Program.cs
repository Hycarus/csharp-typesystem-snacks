namespace csharp_typesystem_snacks;

class Program
{
    static void Main(string[] args)
    {
        // Snack 1
        Console.WriteLine("Inserisci un numero");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci un altro numero");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 > num2)
        {
            Console.WriteLine($"Il maggiore è: {num1}");
        }
        else
        {
            Console.WriteLine($"Il maggiore è: {num2}");
        }

        
    }
}


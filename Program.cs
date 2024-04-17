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

        // Snack 2
        Console.WriteLine("Inserisci una parola");
        string word1 = Console.ReadLine();
        Console.WriteLine("Inserisci un altra parola");
        string word2 = Console.ReadLine();
        if(word1.Length > word2.Length)
        {
            Console.WriteLine($"La parola più lunga è: {word1}");
        }
        else
        {
            Console.WriteLine($"La parola più lunga è: {word2}");
        }
    }
}


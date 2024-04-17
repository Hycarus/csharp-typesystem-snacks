namespace csharp_typesystem_snacks;

class Program
{
    static void Main(string[] args)
    {
        // Snack 1
        //Console.WriteLine("Inserisci un numero");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Inserisci un altro numero");
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //if (num1 > num2)
        //{
        //    Console.WriteLine($"Il maggiore è: {num1}");
        //}
        //else
        //{
        //    Console.WriteLine($"Il maggiore è: {num2}");
        //}

        //// Snack 2
        //Console.WriteLine("Inserisci una parola");
        //string? word1 = Console.ReadLine();
        //Console.WriteLine("Inserisci un altra parola");
        //string? word2 = Console.ReadLine();
        //if (word1?.Length > word2?.Length)
        //{
        //    Console.WriteLine($"La parola più lunga è: {word1}");
        //}
        //else
        //{
        //    Console.WriteLine($"La parola più lunga è: {word2}");
        //}

        //// Snack 3
        //int sum = 0;
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine("Inserisci un numero");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    sum += num;
        //}
        //Console.WriteLine(sum);

        //// Snack 4
        //int[] numArray = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int sumArray = 0;
        //for(int i = 0; i < numArray.Length; i++)
        //{
        //    sumArray += numArray[i];
        //}
        //Console.WriteLine($"La somma dei numeri è: {sumArray}");
        //Console.WriteLine($"La media dei numeri è: {sumArray / numArray.Length}");

        // Snack 5
        //Console.WriteLine("Inserisci un numero");
        //int numEven = Convert.ToInt32(Console.ReadLine());
        //if(numEven % 2 == 0)
        //{
        //    Console.WriteLine($"Il tuo numero è pari: {numEven}");
        //}
        //else
        //{
        //    Console.WriteLine($"Il tuo numero è dispari, perciò ti faccio vedere quello successivo: {numEven + 1}");
        //}

        // Snack 6

        string[] invited = { "Luca", "Paolo", "Giovanni", "Marta", "Giada" };
        Console.WriteLine("Inserisci il tuo nome");
        string? you = Console.ReadLine();
        if (invited.Contains(you))
        {
            Console.WriteLine("Benvenuto alla festa");
        }
        else
        {
            Console.WriteLine("Il tuo nome non è sulla lista");
        }

    }
}


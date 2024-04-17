using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_typesystem_snacks;



class Program
{
    static void Main(string[] args)
    {
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
        {
            // Snack 2
            Console.WriteLine("Inserisci una parola");
            string? word1 = Console.ReadLine();
            Console.WriteLine("Inserisci un altra parola");
            string? word2 = Console.ReadLine();
            if (word1?.Length > word2?.Length)
            {
                Console.WriteLine($"La parola più lunga è: '{word1}', mentre quella più corta '{word2}'");
            }
            else
            {
                Console.WriteLine($"La parola più lunga è: '{word2}', mentre quella più corta '{word1}'");
            }
        }
        {
            // Snack 3
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Inserisci un numero");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
        {
            // Snack 4
            int[] numArray = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sumArray = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                sumArray += numArray[i];
            }
            Console.WriteLine($"La somma dei numeri è: {sumArray}");
            Console.WriteLine($"La media dei numeri è: {sumArray / numArray.Length}");
        }
        {
            // Snack 5
            Console.WriteLine("Inserisci un numero");
            int numEven = Convert.ToInt32(Console.ReadLine());
            if (numEven % 2 == 0)
            {
                Console.WriteLine($"Il tuo numero è pari: {numEven}");
            }
            else
            {
                Console.WriteLine($"Il tuo numero è dispari, perciò ti faccio vedere quello successivo: {numEven + 1}");
            }
        }
        {
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
        {
            // Snack 7
            int[] voidArray = new int[0];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Inserisci un numero");
                int userNum = Convert.ToInt32(Console.ReadLine());
                if (userNum % 2 != 0)
                {
                    Array.Resize(ref voidArray, voidArray.Length + 1);
                    voidArray[voidArray.Length - 1] = userNum;
                }
            }
            Console.WriteLine($"Ecco tutti i numeri dispari che hai inserito: ");
            foreach (int oddNum in voidArray)
            {
                Console.WriteLine(oddNum);
            }
        }
        {
            // Snack 8
            int[] intNum = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int sumOdd = 0;
            for (int i = 0; i < intNum.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumOdd += intNum[i];
                }
            }
            Console.WriteLine($"La somma dei numeri in posizioni dispari è: {sumOdd}");
        }
        {
            // Snack 9
            int[] numArray = new int[0];
            int breakNum = 0;
            Console.WriteLine("Inserisci numeri finchè la somma non è maggiore o uguale a 50");
            while (breakNum < 50)
            {
                Console.WriteLine("Inserisci un numero");
                int userNum = Convert.ToInt32(Console.ReadLine());
                Array.Resize(ref numArray, numArray.Length + 1);
                numArray[numArray.Length - 1] = userNum;
                breakNum += userNum;
            }
            Console.WriteLine("La somma degli elementi è maggiore o uguale a 50: ");
            foreach (int item in numArray)
            {
                Console.WriteLine(item);
            }
        }
        {
            // Snack 10
            Console.WriteLine("Inserisci un numero");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int[] newArray = { };
                for (int y = 0; y < 10; y++)
                {
                    Array.Resize(ref newArray, newArray.Length + 1);
                    Random rnd = new Random();
                    newArray[newArray.Length - 1] = rnd.Next(1, 101);

                }
                Console.WriteLine("\n");
                Console.WriteLine($"Array numero {i + 1}:");
                for (int x = 0; x < newArray.Length; x++)
                {
                    Console.WriteLine(newArray[x]);
                }
            }
        }
    }
}


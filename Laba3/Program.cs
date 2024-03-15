namespace Laba3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-----Task1-----\n");
            int[] numbers = { 1, 2, 3, 4, 5, 2, 3, 6, 7, 8, 9, 1 };
            Task.Num1(numbers);
            Console.WriteLine("\n---------------\n");


            Console.WriteLine("\n-----Task2-----\n");
            int[] array = { 1, 3, 5, 7, 9, 2, 4, 6, 8 };

            Console.WriteLine("Enter a threshold value:");
            int threshold = int.Parse(Console.ReadLine());

            int count = Task.Num2(array, threshold);
            Console.WriteLine($"The number of values ​​in the array is less {threshold}: {count}");
            Console.WriteLine("\n---------------\n");


            Console.WriteLine("\n-----Task3-----\n");
            Console.WriteLine("Enter three numbers separated by a space:");
            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(' ');

            if (inputNumbers.Length != 3)
            {
                Console.WriteLine("Invalid input format.");
                return;
            }

            int num1 = int.Parse(inputNumbers[0]);
            int num2 = int.Parse(inputNumbers[1]);
            int num3 = int.Parse(inputNumbers[2]);

            int[] mas = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };

            int count2 = Task.Num3(mas, num1, num2, num3);

            Console.WriteLine($"The number of repetitions of the sequence: {count}");
            Console.WriteLine("\n---------------\n");


            Console.WriteLine("\n-----Task4-----\n");
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };

            int[] resultArray = Task.Num4(array1, array2);

            Console.WriteLine("Resulting Array:");
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i] + " ");
            }
            Console.WriteLine("\n---------------\n");


            Console.WriteLine("\n-----Task5-----\n");
            int[,] mas1 = {
                { 31, 17, 52 },
                { 39, 64, 96 },
                { 10, 28, 35 }
            };
            Task.Num5(mas1);
            Console.WriteLine("\n---------------\n");


            Console.WriteLine("\n-----Task6-----\n");
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine(); // Зчитуємо речення з клавіатури

            int wordCount = Task.Num6(sentence); // Викликаємо метод для підрахунку слів у реченні

            Console.WriteLine($"Number of words in a sentence: {wordCount}");
            Console.WriteLine("\n---------------\n");

        }
    }
}


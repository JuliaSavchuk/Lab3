namespace Laba3
{
    public class Task
    {
        public static void Num1(int[] numbers)
        {
            int evenCount = numbers.Count(n => n % 2 == 0);

            int oddCount = numbers.Count(n => n % 2 != 0);

            int uniqueCount = numbers.Distinct().Count();

            Console.WriteLine($"Even numbers: {evenCount}");
            Console.WriteLine($"Odd numbers: {oddCount}");
            Console.WriteLine($"Unique numbers: {uniqueCount}");
        }
        public static int Num2(int[] array, int threshold)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < threshold)
                {
                    count++;
                }
            }
            return count;
        }
        public static int Num3(int[] array, int num1, int num2, int num3)
        {
            int count = 0;

            for (int i = 0; i < array.Length - 2; i++)
            {
                if (array[i] == num1 && array[i + 1] == num2 && array[i + 2] == num3)
                {
                    count++;
                }
            }

            return count;
        }
        public static int[] Num4(int[] array1, int[] array2)
        {
            // Знаходимо розмірність третього масиву
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            // Створюємо третій масив
            int[] result = new int[count];
            int index = 0;

            // Заповнюємо третій масив
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        result[index++] = array1[i];
                        break;
                    }
                }
            }

            return result;
        }
        public static void Num5(int[,] array)
        {
            int min = array[0, 0]; 
            int max = array[0, 0];

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int current = array[i, j];

                    
                    if (current < min)
                    {
                        min = current; 
                    }

                   
                    if (current > max)
                    {
                        max = current;
                    }
                }
            }

            Console.WriteLine("Minimum value: " + min);
            Console.WriteLine("Maximum value: " + max);
        }
        public static int Num6(string sentence)
        {
            int wordCount = 0;
            bool inWord = false;

            for (int i = 0; i < sentence.Length; i++)
            {
                // Якщо поточний символ - буква чи цифра, і ми не знаходимось у слові,
                // то це початок нового слова
                if (char.IsLetterOrDigit(sentence[i]) && !inWord)
                {
                    inWord = true; 
                    wordCount++; 
                }
                // Якщо поточний символ - не буква чи цифра, і ми знаходимось у слові,
                // то це кінець слова
                else if (!char.IsLetterOrDigit(sentence[i]) && inWord)
                {
                    inWord = false;
                }
            }

            return wordCount;
        }
    }
}

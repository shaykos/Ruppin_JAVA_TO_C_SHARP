using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        #region strings

        /*
            יש לכתוב תוכנית שמקבלת מהמשתמש מחרוזת ומדפיסה את המחרוזת הפוכה.
            לדוגמה, אם המשתמש יכניס "Hello World", התוכנית תדפיס "dlroW olleH".
        */

        // Console.Write("Please enter a string: ");
        // string input = Console.ReadLine();

        // for(int i = input.Length - 1; i >= 0; i--)
        // {
        //     Console.Write(input[i]);
        // }


        /*
            יש לכתוב תוכנית הקולטת מחרוזות המכילה מספרים ואותיות קטנות בלבד. 
            יש לספור והלציג כמה ספרות יש במחרוזת וכמה אותיות קטנות יש במחרוזת.
            לדוגמה, אם המשתמש יכניס "abc123def", התוכנית תדפיס "There are 6 letters and 3 digits in the string."
        */

        // Console.Write("Please enter a string: ");
        // string input = Console.ReadLine();

        // int letterCount = 0;
        // int digitCount = 0;

        // foreach (char c in input)
        // {
        //     if (c >= '0' && c <= '9') //char.IsDigit(c)
        //     {
        //         digitCount++;
        //     }
        //     else if (c >= 'a' && c <= 'z') //char.IsLower(c)
        //     {
        //         letterCount++;
        //     }
        // }

        // Console.WriteLine($"There are {letterCount} letters and {digitCount} digits in the string.");


        /*
        Please enter a string: hhjyg ig ig  wth w 323563256dfh jej
        There are 19 letters and 9 digits in the string.
        */

        #endregion

        #region arrays

        // int[] numbers = new int[5];
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     Console.Write($"Please enter number {i + 1}: ");
        //     numbers[i] = int.Parse(Console.ReadLine());
        // }

        // int sum = 0;
        // foreach (int num in numbers)
        // {
        //     sum += num;
        // }

        // Console.WriteLine($"The sum of the numbers is: {sum}");

        /*
        Please enter number 1: 5
        Please enter number 2: 4
        Please enter number 3: 7
        Please enter number 4: 9
        Please enter number 5: 0
        The sum of the numbers is: 25
        */

        #endregion

        #region matrix

        // int[,] matrix = new int[4, 3];
        // // matrix.GetLength(0) -> כמות השורות --> 4
        // // matrix.GetLength(1) -> כמות העמודות --> 3
        // // matrix.Length -> כמות התאים הכוללת --> 12    

        // //קליטת ערכים למטריצה
        // for (int r = 0; r < matrix.GetLength(0); r++)
        // {
        //     for (int c = 0; c < matrix.GetLength(1); c++)
        //     {
        //         Console.Write($"Please enter a number for position [{r}, {c}]: ");
        //         matrix[r, c] = int.Parse(Console.ReadLine());
        //     }
        // }

        // // חישוב הסכום של כל המספרים במטריצה
        // int matrixSum = 0;
        // for (int r = 0; r < matrix.GetLength(0); r++)
        // {
        //     for (int c = 0; c < matrix.GetLength(1); c++)
        //     {
        //         matrixSum += matrix[r, c];
        //     }
        // }

        // // חישוב הממוצע של המספרים במטריצה
        // double average = (double)matrixSum / matrix.Length;
        // Console.WriteLine($"The average of the numbers in the matrix is: {average}");

        // // מציאת כל הערכים במטריצה שהם מעל הממוצע
        // Console.WriteLine("Numbers above the average:");
        // for (int r = 0; r < matrix.GetLength(0); r++)
        // {
        //     for (int c = 0; c < matrix.GetLength(1); c++)
        //     {
        //         if (matrix[r, c] > average)
        //         {
        //             Console.WriteLine(matrix[r, c]);
        //         }
        //     }
        // }

        /*
        Please enter a number for position [0, 0]: 5
        Please enter a number for position [0, 1]: 9
        Please enter a number for position [0, 2]: 7
        Please enter a number for position [1, 0]: 1
        Please enter a number for position [1, 1]: 2
        Please enter a number for position [1, 2]: 4
        Please enter a number for position [2, 0]: 4
        Please enter a number for position [2, 1]: 5
        Please enter a number for position [2, 2]: 10
        Please enter a number for position [3, 0]: 4
        Please enter a number for position [3, 1]: 3
        Please enter a number for position [3, 2]: 6
        The average of the numbers in the matrix is: 5
        Numbers above the average:
        9
        7
        10
        6
        */

        #endregion

        #region objects

        Cat c = new Cat("Mimi", 3, "Black");
        c.Meow();
        c.Meow();
        c.PrintInfo();

        /*
        Meow!
        Meow!
        Name: Mimi, Age: 3, Color: Black
        */

        #endregion
    }
}
using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {

        #region Strings
        // Console.Write("What is your name? ");
        // string name = Console.ReadLine();
        // Console.WriteLine($"Hello, {name}!");
        // Console.WriteLine($"Total characters in your name: {name.Length}");

        /*
            יש לקלוט מחרוזת הכוללת מספרים, אותיות קטנות ואותיות גדולות בלבד.
            יש להדפיס את כמות האותיות הקטנות, האותיות הגדולות והמספרים במחרוזת.
        */

        // Console.Write("Enter a string: ");
        // string input = Console.ReadLine();
        // int lowercaseCount = 0;
        // int uppercaseCount = 0;
        // int digitCount = 0;

        // foreach (char c in input)
        // {
        //     if (c >= 'a' && c <= 'z') //char.IsLower(c)
        //     {
        //         lowercaseCount++;
        //     }
        //     else if (c >= 'A' && c <= 'Z') //char.IsUpper(c)
        //     {
        //         uppercaseCount++;
        //     }
        //     else if (c >= '0' && c <= '9') //char.IsDigit(c)
        //     {
        //         digitCount++;
        //     }
        // }

        // Console.WriteLine($"Lowercase letters: {lowercaseCount}");
        // Console.WriteLine($"Uppercase letters: {uppercaseCount}");
        // Console.WriteLine($"Digits: {digitCount}");

        /*
        Enter a string: ihfq2536lSDDHGWTH2545451fwehwthAFHJ
        Lowercase letters: 12
        Uppercase letters: 12
        Digits: 11
        */
        #endregion

        #region Arrays - Part 1

        // int[] numbers = new int[5];
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     Console.Write($"Enter number {i + 1}: ");
        //     numbers[i] = int.Parse(Console.ReadLine());
        // }

        // int above100Count = 0;
        // int totalSum = 0;
        // Console.WriteLine("You entered:");
        // foreach (int number in numbers)
        // {
        //     if (number > 100)
        //     {
        //         above100Count++;
        //     }

        //     Console.WriteLine(number);

        //     totalSum += number;
        // }

        // Console.WriteLine($"Numbers above 100: {above100Count}");
        // Console.WriteLine($"Total sum: {totalSum}");

        /*
        Enter number 1: 90
        Enter number 2: 101
        Enter number 3: 302
        Enter number 4: 7
        Enter number 5: -20
        You entered:
        90
        101
        302
        7
        -20
        Numbers above 100: 2
        Total sum: 480
        */

        #endregion

        #region Arrays - Part 2

        /*
        יש לכתוב תוכנית השואלת את המשתמש כמה תאים הוא רוצה שיהיו במערך של המספרים עשרוניים. 
        לאחר מכן יש לקלוט את מספרים למערך ולחשב את הממוצע. 
        התוכנית תדפיס את כל המספרים שהם מעל לממוצע.
        */

        // Console.Write("How many decimal numbers do you want to enter? ");
        // int size = int.Parse(Console.ReadLine());
        // double[] numbers = new double[size];

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     Console.Write($"Enter decimal number {i + 1}: ");
        //     numbers[i] = double.Parse(Console.ReadLine());
        // }

        // double sum = 0;
        // foreach (double number in numbers)
        // {
        //     sum += number;
        // }   

        // double average = sum / numbers.Length;
        // Console.WriteLine($"Average: {average}");

        // Console.WriteLine("Numbers above average:");
        // foreach (double number in numbers)
        // {
        //     if (number > average)
        //     {
        //         Console.WriteLine(number);
        //     }
        // }

        /*
        How many decimal numbers do you want to enter? 4
        Enter decimal number 1: 12.8
        Enter decimal number 2: -7.4
        Enter decimal number 3: 4.0
        Enter decimal number 4: 80
        Average: 22.35
        Numbers above average:
        80
        */

        #endregion

        #region Multidimensional Arrays

        // int[,] matrix = new int[3, 4];
        // // GetLength(0) - number of rows --> 3
        // // GetLength(1) - number of columns --> 4
        // for (int r = 0; r < matrix.GetLength(0); r++)
        // {
        //     for (int c = 0; c < matrix.GetLength(1); c++)
        //     {
        //         Console.Write($"Enter value for cell [{r}, {c}]: ");
        //         matrix[r, c] = int.Parse(Console.ReadLine());
        //     }
        // }

        // for (int r = 0; r < matrix.GetLength(0); r++)
        // {
        //     for (int c = 0; c < matrix.GetLength(1); c++)
        //     {
        //         Console.Write(matrix[r, c] + "\t");
        //     }
        //     Console.WriteLine();
        // }

        /*
        
        Enter value for cell [0, 0]: 1
        Enter value for cell [0, 1]: 2
        Enter value for cell [0, 2]: 3
        Enter value for cell [0, 3]: 4
        Enter value for cell [1, 0]: 5
        Enter value for cell [1, 1]: 6
        Enter value for cell [1, 2]: 7
        Enter value for cell [1, 3]: 8
        Enter value for cell [2, 0]: 9
        Enter value for cell [2, 1]: 10
        Enter value for cell [2, 2]: 11
        Enter value for cell [2, 3]: 12
        1       2       3       4
        5       6       7       8
        9       10      11      12
        
        */

        #endregion
    
        #region Obejcts and Classes

        Dog rocky = new Dog("Rocky", 5, "Bulldog");
        rocky.Bark();
        rocky.Bark();
        rocky.DisplayInfo();

        #endregion
    }

}
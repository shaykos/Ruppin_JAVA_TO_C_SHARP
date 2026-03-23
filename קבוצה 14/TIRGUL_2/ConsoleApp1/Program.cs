internal class Program
{
    private static void Main(string[] args)
    {

        #region Q1 - Print a right-angled triangle of stars

        //לכתוב תוכנית שקולטת מספר שלם  שמהווה את הבסיס
        //ומדפיסה משולש ישר זווית צמוד לשמאל
        //למשל אם הבסיס הוא 5 אז התוכנית תדפיס את המשולש הבא:
        /*
         *
         * *
         * * *
         * * * *
         * * * * *
         */
        // החוקיות היא שמספר הכוכביות בכל שורה זהה למספר השורה
        Console.WriteLine("Enter a base number:");
        int baseNumber = int.Parse(Console.ReadLine());
        PrintRightAngledTriangle(baseNumber);

        #endregion


        #region Q2 - Calculate the average of the digits of an integer
        /*
            יש לכתוב תוכנית שקולטת מספר שלם כלשהו 
            מחשבת ומדפיסה את ממוצע הספרות שלו
            לדוגמה עבור הקלט 372
            הממוצע הוא  4
            כי (3 + 7 + 2) / 3 = 4
        */

        Console.Write("Enter an integer to calculate the average of its digits: ");
        int number = int.Parse(Console.ReadLine());
        int sum = SumOfDigits(number); //חישוב סכום הספרות
        int count = CountDigits(number); //חישוב כמות הספרות

        if (count > 0)
        {
            //חוק הברזל -> שלם/שלם = שלם
            double average = (double)sum / count; //חישוב הממוצע
            Console.WriteLine($"The average of the digits is: {average:f2}"); //הדפסת הממוצע עם 2 ספרות אחרי הנקודה
        }
        else
        {
            Console.WriteLine("No digits to calculate the average.");
        }

        #endregion



        #region Q3 - Add 10 to a number using a method with ref parameter
        
        Console.Write("Enter a number to add 10: ");
        int numToAdd = int.Parse(Console.ReadLine());
        Console.WriteLine($"The original number is: {numToAdd}");
        Add10(ref numToAdd); //קריאה לפונקציה שמוסיפה 10 למספר
        Console.WriteLine($"The result after adding 10 is: {numToAdd}");
        
        #endregion
    }

    static void PrintRightAngledTriangle(int baseNumber)
    {
        for (int row = 1; row <= baseNumber; row++)
        {
            //בלולאה הפנימית אנחנו למעשה מדפיסים את הכוכביות בכל שורה
            for (int stars = 1; stars <= row; stars++)
            {
                Console.Write("* ");
            }
            Console.WriteLine(); //מעבר לשורה חדשה אחרי כל שורה של כוכב
        }
    }

    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10; //הוספת הספרה האחרונה לסכום
            number /= 10; //הסרת הספרה האחרונה מהמספר
        }
        return sum;
    }

    static int CountDigits(int number)
    {
        int count = 0;
        while (number > 0)
        {
            count++; //הגדלת הספירה עבור כל ספרה
            number /= 10; //הסרת הספרה האחרונה מהמספר
        }
        return count;
    }

    static void Add10(ref int number)
    {
        number += 10; //הוספת 10 למספר
    }
}
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // מגדירים את כמות התאים שרוצים במערך - ניתן לבקש זאת מהמשתמש
            int[] number = new int[5];
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The numbers you entered are: ");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();

            // ניתן גם להגדיר מערך עם ערכים כברירת מחדל
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //מערך דו ממדי - טבלה
            int[,] matrix = new int[3, 4];
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write($"Enter a number in matrix[{r},{c}]: ");
                    matrix[r, c] = int.Parse(Console.ReadLine());
                }
            }

            // הדפסת המטריצה
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine(matrix);
        }
    }
}

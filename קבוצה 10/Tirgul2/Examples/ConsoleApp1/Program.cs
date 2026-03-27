internal class Program
{
    private static void Main(string[] args)
    {
        int num1 = 5, num2 = 7;
        Console.WriteLine($"Before Swap1: num1 = {num1}, num2 = {num2}");
        Swap1(num1, num2); // Call by Value
        Console.WriteLine($"After Swap1: num1 = {num1}, num2 = {num2}");
        Swap2(ref num1, ref num2); // Call by Reference
        Console.WriteLine($"After Swap2: num1 = {num1}, num2 = {num2}");

        int num3;
        SetValue(out num3); // Call by Output
        Console.WriteLine($"Value set by SetValue: num3 = {num3}");
    }

    static void Swap1(int a, int b)
    {
        Console.WriteLine($"Inside Swap1 (before swap): a = {a}, b = {b}");
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"Inside Swap1 (after swap): a = {a}, b = {b}");
    }

    static void Swap2(ref int a, ref int b)
    {
        Console.WriteLine($"Inside Swap2 (before swap): a = {a}, b = {b}");
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"Inside Swap2 (after swap): a = {a}, b = {b}");
    }

    static void SetValue(out int num3)
    {
        num3 = 10; // Must assign a value before exiting the method
    }
}
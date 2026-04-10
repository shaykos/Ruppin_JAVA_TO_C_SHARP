namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        string text = "Nadav and Shaked are software developers.";
        Console.WriteLine($"text.ToUpper(): {text.ToUpper()}");
        Console.WriteLine($"text.ToLower(): {text.ToLower()}");
        Console.WriteLine($"text.Length: {text.Length}");
        Console.WriteLine($"text.Contains(\"developers\"): {text.Contains("developers")}");
        Console.WriteLine($"text.Replace(\"developers\", \"programmers\"): {text.Replace("developers", "programmers")}");
        Console.WriteLine($"text.Substring(0, 5): {text.Substring(0, 5)}");
    }
}

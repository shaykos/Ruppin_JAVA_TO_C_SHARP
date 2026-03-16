
// Console.WriteLine("Hello, World!");

// //Console.Write --> מדפיס את הטקסט על המסך בלי לרדת שורה
// Console.Write("Enter the first number: ");
// //Console.ReadLine() --> קורא קלט מהמשתמש ומחזיר אותו כמחרוזת
// int a = int.Parse(Console.ReadLine());
// Console.Write("Enter the second number: ");
// int b = int.Parse(Console.ReadLine());

// //Console.WriteLine("The sum of {a} and {b} is {a + b}.");
// Console.WriteLine($"The sum of {a} and {b} is {a + b}.");



Console.Write("Hello, Please enter your name: ");
string name = Console.ReadLine();
Console.Write("Please enter your age: ");
int age = int.Parse(Console.ReadLine());
Console.Write("Did you pass the driving theory test? (true/false): ");
bool passedTheoryTest = bool.Parse(Console.ReadLine()); 

//במידה והמשתמש בן 16 ומעלה ועבר את מבחן התיאוריה, נדפיס לו שהוא יכול לנהוג, אחרת נדפיס לו שהוא לא יכול לנהוג
if (age >= 16 && passedTheoryTest)
{
    Console.WriteLine($"Hello {name}, you are old enough to drive!");
}
else
{
    Console.WriteLine($"Hello {name}, you are not old enough to drive.");
}
//אנחנו נבצע רק אם התנאי לא מתקיים else את הבלוק של ה 
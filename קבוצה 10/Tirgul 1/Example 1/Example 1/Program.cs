// Console.WriteLine("Hello, World!");

// Console.Write("Enter the first number: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Enter the second number: ");
// int b = int.Parse(Console.ReadLine());

// //Console.WriteLine("The sum of {a} and {b} is {a + b}.");
// Console.WriteLine($"The sum of {a} and {b} is {a + b}.");


// Console.Write("Enter your name: ");
// string name = Console.ReadLine();
// Console.Write("Enter your age: ");
// int age = int.Parse(Console.ReadLine());
// Console.Write("Did you pass the driving test? (true/false): ");
// bool passedTest = bool.Parse(Console.ReadLine());

// /*
//     אם הגיל של המשתמש הוא 16 או יותר, נדפיס הודעה שמברכת אותו ומציינת שהוא מספיק מבוגר כדי לנהוג.
//     אחרת, נדפיס הודעה שמברכת אותו ומציינת שהוא לא מספיק מבוגר כדי לנהוג.
// */
// //if(age >= 16 || passedTest) // same as if(age >= 16 || passedTest == true)
// if(age >= 16 && passedTest) // same as if(age >= 16 && passedTest == true)
// {
//     Console.WriteLine($"Hello, {name}! You are able to drive.");
// }
// else
// {
//     Console.WriteLine($"Hello, {name}! You are not able to drive.");
// }


Console.Write("Enter your a letter: ");
char letter = char.Parse(Console.ReadLine());

switch (letter)
{
    case 'a':
        Console.WriteLine("Apple");
        break; // לצאת מהסוויץ' אחרי שמצאנו את המקרה המתאים
    case 'b':
        Console.WriteLine("Banana");
        break;
    case 'c':
        Console.WriteLine("Cherry");
        break;
    default:
        Console.WriteLine("Unknown letter");
        break;
}

// if(letter == 'a')
// {
//     Console.WriteLine("Apple");
// }
// else if(letter == 'b')
// {
//     Console.WriteLine("Banana");
// }
// else if(letter == 'c')
// {
//     Console.WriteLine("Cherry");
// }
// else
// {
//     Console.WriteLine("Unknown letter");
// }
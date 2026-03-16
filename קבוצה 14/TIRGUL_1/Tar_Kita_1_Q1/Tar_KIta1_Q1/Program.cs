// כלל: סכום 2 צלעות במשולש חייב להיות גדול מהצלע השלישית

Console.WriteLine("Side1:");
double side1 = double.Parse(Console.ReadLine());
Console.WriteLine("Side2:");
double side2 = double.Parse(Console.ReadLine());
Console.WriteLine("Side3:");
double side3 = double.Parse(Console.ReadLine());

if(side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
{
    Console.WriteLine("The triangle is valid.");
}
else
{
    Console.WriteLine("The triangle is not valid.");
}


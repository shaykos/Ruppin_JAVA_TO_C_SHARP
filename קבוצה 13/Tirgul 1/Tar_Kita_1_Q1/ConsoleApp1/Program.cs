// סכום כל 2 צלעות במשולש חייב להיות גדול מהצלע השלישית

Console.Write("side 1 = ");
int side1 = int.Parse(Console.ReadLine());
Console.Write("side 2 = ");
int side2 = int.Parse(Console.ReadLine());
Console.Write("side 3 = ");
int side3 = int.Parse(Console.ReadLine());

if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
{
    Console.WriteLine("This is a triangle");
}
else
{
    Console.WriteLine("This is not a triangle");
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter amount of electronic devices: ");
        int amount = int.Parse(Console.ReadLine());
        double totalDailyConsumption = 0;

        //לולאה שמבקשת מהמשתמש להזין את צריכת החשמל שלו ואת כמות שעות הפעילות ביום עבור כל מכשיר
        for (int i = 1; i <= amount; i++) // אם נאתחל את i ב-0 אז נצטרך לשנות את תנאי הלולאה ל- i < amount
        {
            Console.Write($"Enter power consumption of device {i} (in watts): ");
            double powerConsumption = double.Parse(Console.ReadLine());

            Console.Write($"Enter hours of usage per day for device {i}: ");
            double hoursPerDay = double.Parse(Console.ReadLine());

            // סעיף 3 - חישוב צריכת החשמל היומית של כל מכשיר
            double dailyConsumption = CalculateDailyConsumption(powerConsumption, hoursPerDay);

            totalDailyConsumption += dailyConsumption; // סכימת צריכת החשמל היומית של כל המכשירים   
        }

        // סעיף 4+5 - הצגת התוצאה הסופית
        if (totalDailyConsumption > 50)
        {
            Console.WriteLine("Warning: High consumption!");
        }

        Console.WriteLine($"Total daily electricity consumption: {totalDailyConsumption:f2} kWh");
    }

    static double CalculateDailyConsumption(double powerConsumption, double hoursPerDay)
    {
        // צריכת חשמל יומית = צריכת חשמל בשעות * שעות פעילות ביום
        return powerConsumption * hoursPerDay / 1000; // המרה מקילוואט לשעות
    }
}
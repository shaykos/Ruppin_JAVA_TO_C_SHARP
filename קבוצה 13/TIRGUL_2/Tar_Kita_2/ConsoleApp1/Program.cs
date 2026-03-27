internal class Program
{
    private static void Main(string[] args)
    {
        double balance = 1000;
        while (true)
        {
            Console.Write("Enter 1 to deposit, 2 to withdraw, or 0 to exit: ");
            int code = int.Parse(Console.ReadLine());
            if (code == 0)
            {
                break;
            }

            Console.WriteLine("Enter the amount:");
            double amount = double.Parse(Console.ReadLine());

            PerformAction(code, amount, ref balance);
            Console.WriteLine($"Current balance: {balance}");

            double interest;
            GetMonthlyInterest(balance, out interest);
            Console.WriteLine($"Monthly interest: {interest}");
        }
    }


    static void PerformAction(int code, double amount, ref double balance)
    {
        if (code == 1)
        {
            balance += amount;
        }
        else if (code == 2)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                balance -= amount;
            }
        }
    }

    static void GetMonthlyInterest(double balance, out double interest)
    {
        interest = balance * 0.03;
    }
}

/*

Enter 1 to deposit, 2 to withdraw, or 0 to exit: 1
Enter the amount:
500
Current balance: 1500
Monthly interest: 45
Enter 1 to deposit, 2 to withdraw, or 0 to exit: 2
Enter the amount:
3000
Insufficient funds
Current balance: 1500
Monthly interest: 45
Enter 1 to deposit, 2 to withdraw, or 0 to exit: 1
Enter the amount:
1420
Current balance: 2920
Monthly interest: 87.6
Enter 1 to deposit, 2 to withdraw, or 0 to exit: 2
Enter the amount:
2900
Current balance: 20
Monthly interest: 0.6
Enter 1 to deposit, 2 to withdraw, or 0 to exit: 0

*/
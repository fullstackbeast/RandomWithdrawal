using System;

namespace RandomWithdrawal
{
    class Program
    {

        static double currentBalance;

        static void Main(string[] args)
        {
            Random random = new Random();

            double openingBalance = random.Next(5000, 10000);
            
            currentBalance = openingBalance;

            Console.WriteLine($"OpeningBalance is {openingBalance}");

            for(; currentBalance > 0;){
                double withdrawalAmount = random.Next(1, 100);
                withrawal(withdrawalAmount);
            }

        }

         static void withrawal(double withrawalAmount){
            currentBalance -= withrawalAmount;
            Console.WriteLine($"A withrawal of {withrawalAmount} made");
            Console.WriteLine($"New Balance is: {currentBalance} ");
        }
    }
}

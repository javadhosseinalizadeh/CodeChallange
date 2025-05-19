using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange.Challenges
{
    public static class BankAccountDemo
    {
        public static void Run()
        {
            var account = new BankAccount(2000);

            var tasks = new List<Task>();

            // 10 واریز همزمان
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(Task.Run(() => account.Deposit(100)));
            }

            // 10 برداشت همزمان
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(Task.Run(() =>
                {
                    bool result = account.Withdraw(50);
                    Console.WriteLine($"Withdraw 50: {(result ? "OK" : "Failed")}");
                }));
            }

            Task.WaitAll(tasks.ToArray());

            Console.WriteLine($"\nFinal Balance: {account.GetBalance()}");
        }
    }
}

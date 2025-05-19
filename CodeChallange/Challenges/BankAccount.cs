using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange.Challenges
{
    public class BankAccount
    {
        private decimal _balance = 0;
        private readonly object _lock = new();

        public BankAccount(decimal initialBalance = 0)
        {
            _balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be positive.");

            lock (_lock)
            {
                _balance += amount;
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be positive.");

            lock (_lock)
            {
                if (_balance >= amount)
                {
                    _balance -= amount;
                    return true;
                }

                return false; // insufficient funds
            }
        }

        public decimal GetBalance()
        {
            lock (_lock)
            {
                return _balance;
            }
        }
    }
}

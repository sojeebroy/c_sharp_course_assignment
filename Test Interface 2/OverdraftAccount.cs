using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    class OverdraftAccount : BasicBankingInterface
    {
        private string name;
        private string accountNumber;
        private double balance; 
        private double WithdrawLimit;
        public OverdraftAccount() 
        {
            Console.WriteLine("<<<<<This is a Overdraft Account.>>>>>");
        }
        public void Information(string name, string accountNumber, double balance)
        {
            this.name = name;
            this.accountNumber = accountNumber;
            this.balance = balance;

            Console.WriteLine("Name of the account owner \t:" + name);
            Console.WriteLine("Account number \t\t\t:" + accountNumber);
            Console.WriteLine("Balance of the account is \t:" + balance + "\n");
        }
        public bool deposit(int amount)
        {
            if (amount != 0)
            {
                balance = balance + amount;
                Console.WriteLine("Depodit successfull...!!");
                Console.WriteLine("Current balance after deposit is  :" + balance + "\n");
            }
            else
            {
                Console.WriteLine("Invalit amount.!! \n Failled deposit");
            }
            return true;
        }

        public bool withdraw(int amount)
        {
            WithdrawLimit = balance + (balance * 0.4);
            if (amount <= WithdrawLimit)
            {
                balance = balance - amount;
                Console.WriteLine("Withdraw successfull...!!");
                if (balance<0 )
                {
                    Console.WriteLine("You have credited :" + balance + " amount.\n");
                    Console.WriteLine("----------------------------------\n");

                }
                else
                {
                   
                    Console.WriteLine("Current balance after withdraw is  :" + balance + "\n");
                    Console.WriteLine("----------------------------------\n");
                }
             
            }
            else
            {
                Console.WriteLine("Invalit amount.!! \n Failled Withdaw");
            }
            return true;

        }
    }
}

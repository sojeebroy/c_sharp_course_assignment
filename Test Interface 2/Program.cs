using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            CurrentAccount c1 = new CurrentAccount();
            c1.Information("Mr.Sojeeb","34-32",5000);
            c1.deposit(400);
            c1.withdraw(300);


            SavingsAccount c2 = new SavingsAccount();
            c2.Information("Mr.Partho", "34-34", 1000);
            c2.deposit(400);
            c2.withdraw(1120);

            OverdraftAccount c3 = new OverdraftAccount();
            c3.Information("Mr.Roy", "39-34", 1000);
            c3.deposit(400);
            c3.withdraw(1500);
        }
    }
}

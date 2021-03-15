using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    interface BasicBankingInterface
    {
        void Information(string name, string accountNumber,double balance);
        bool deposit(int amount);
        bool withdraw(int amount);

    }
}

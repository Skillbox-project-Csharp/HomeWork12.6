using HomeWork12._6.BankSystem.BankData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12._6.BankSystem.BankWorkers
{
    interface IGetDataClient
    {
        string GetName(BankClient client);
        string GetSurName(BankClient client);
        string GetPatronymic(BankClient client);
        string GetPhoneNumber(BankClient client);
        string GetPassportSeriesNumber(BankClient client);
    }
}

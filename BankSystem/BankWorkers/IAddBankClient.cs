using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12._6.BankSystem.BankWorkers
{
    internal interface IAddBankClient
    {
        void AddBankClient(ObservableCollection<BankClient> bankClients, BankClient bankClient);
    }
}

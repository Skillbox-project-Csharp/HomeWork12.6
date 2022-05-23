using HomeWork12._6.BankSystem.BankData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12._6.BankSystem.BankWorkers
{
    internal class Manager : Worker, IGetDataClient, ISetDataClient, IAddBankClient
    {
        #region Конструкторы
        internal Manager() { }
        #endregion
        #region Методы
        #region Получение данных клиента
        public string GetName(BankClient client)
        {
            return client.Name;
        }
        public string GetSurName(BankClient client)
        {
            return client.SurName;
        }
        public string GetPatronymic(BankClient client)
        {
            return client.Patronymic;
        }
        public string GetPhoneNumber(BankClient client)
        {
            return client.PhoneNumber;
        }
        public string GetPassportSeriesNumber(BankClient client)
        {
            return client.PassportSeriesNumber;
        }
        #endregion
        #region Изменение данных клиента
        public bool SetName(BankClient client, string name)
        {
            if(client.Name == name)
                return true;
            client.Name = name;
            TypesChenge typesChenge;
            if (string.IsNullOrEmpty(name))
                typesChenge = TypesChenge.Remove;
            else typesChenge = TypesChenge.Change;
            client.InfoChangeDataClients.Add
                (
                new InfoChangeDataClient
                    (
                    BankClientProperties.Name, 
                    typesChenge,
                    this.GetType().Name
                    )
                );
            return true;
        }
        public bool SetSurName(BankClient client, string surName)
        {
            if(client.SurName == surName)
                return true;
            client.SurName = surName;
            TypesChenge typesChenge;
            if (string.IsNullOrEmpty(surName))
                typesChenge = TypesChenge.Remove;
            else typesChenge = TypesChenge.Change;
            client.InfoChangeDataClients.Add
                (
                new InfoChangeDataClient
                    (
                    BankClientProperties.SurName,
                    typesChenge,
                    this.GetType().Name
                    )
                );
            return true;
        }
        public bool SetPatronymic(BankClient client, string patronymic)
        {
            if (client.Patronymic == patronymic)
                return true;
            client.Patronymic = patronymic;
            TypesChenge typesChenge;
            if (string.IsNullOrEmpty(patronymic))
                typesChenge = TypesChenge.Remove;
            else typesChenge = TypesChenge.Change;
            client.InfoChangeDataClients.Add
                (
                new InfoChangeDataClient
                    (
                    BankClientProperties.Patronymic,
                    typesChenge,
                    this.GetType().Name
                    )
                );
            return true;
        }
        public bool SetPhoneNumber(BankClient client, string phoneNumber)
        {
            if (client.PhoneNumber == phoneNumber)
                return true;
            bool saveIsPossible = false;
            TypesChenge typesChenge = TypesChenge.Change;
            if (string.IsNullOrEmpty(phoneNumber))
            {
                typesChenge = TypesChenge.Remove;
                saveIsPossible = true;
            }
            else if (BankClient.CheckPhoneNumber(phoneNumber))
            {
                typesChenge = TypesChenge.Change;
                saveIsPossible = true;
            }
            if (saveIsPossible)
            {
                client.PhoneNumber = phoneNumber;
                client.InfoChangeDataClients.Add
                    (
                    new InfoChangeDataClient
                        (
                        BankClientProperties.PhoneNumber, typesChenge, this.GetType().Name
                        )
                    );
                return true;
            }
            return false;
        }
        public bool SetPassportSeriesNumber(BankClient client, string passportSeriesNumber)
        {
            if (client.PhoneNumber == passportSeriesNumber)
                return true;
            bool saveIsPossible = false;
            TypesChenge typesChenge = TypesChenge.Change;
            if (string.IsNullOrEmpty(passportSeriesNumber))
            {
                typesChenge = TypesChenge.Remove;
                saveIsPossible = true;
            }
            else if (BankClient.CheckPassportSeriesNumber(passportSeriesNumber))
            {
                typesChenge = TypesChenge.Change;
                saveIsPossible = true;
            }
            if (saveIsPossible)
            {
                client.PassportSeriesNumber = passportSeriesNumber;
                client.InfoChangeDataClients.Add
                    (
                    new InfoChangeDataClient
                        (
                        BankClientProperties.PassportSeriesNumber, typesChenge, this.GetType().Name
                        )
                    );
                return true;
            }
            return false;
        }

        public void AddBankClient(ObservableCollection<BankClient> bankClients, BankClient bankClient)
        {
            if(!string.IsNullOrEmpty(bankClient.Name))
                if (!string.IsNullOrEmpty(bankClient.SurName))
                    if (!string.IsNullOrEmpty(bankClient.Patronymic))
                        if (!string.IsNullOrEmpty(bankClient.PhoneNumber))
                            if (!string.IsNullOrEmpty(bankClient.PassportSeriesNumber))
                                bankClients.Add(bankClient);
        }
        #endregion
        #endregion
    }
}

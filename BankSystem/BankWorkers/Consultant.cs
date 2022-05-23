using HomeWork12._6.BankSystem.BankData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12._6.BankSystem.BankWorkers
{
    internal class Consultant : Worker, IGetDataClient, ISetDataClient
    {
        #region Конструкторы
        internal Consultant() { }
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
            return string.IsNullOrEmpty(client.PassportSeriesNumber) ? client.PassportSeriesNumber : "**********";
        }
        #endregion
        #region Изменение данных клиента
        public bool SetName(BankClient client, string name)
        {
            return false;
        }
        public bool SetSurName(BankClient client, string surName)
        {
            return false;
        }
        public bool SetPatronymic(BankClient client, string patronymic)
        {
            return false;
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
            return false;
        }
        #endregion
        #endregion
    }
}

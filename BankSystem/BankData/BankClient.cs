using HomeWork12._6.BankSystem.BankData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12._6.BankSystem
{
    public class BankClient : INotifyPropertyChanged, IHistoryChanges
    {
        #region Поля
        private string _name;
        private string _surName;
        private string _patronymic;
        private string _phoneNumber;
        private string _passportSeriesNumber;

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Свойсва
        public List<InfoChangeDataClient> InfoChangeDataClients { get; set; }
        public string Name
        {
            get => _name;
            set
            {
                if (CheckName(value))
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string SurName
        {
            get => _surName;
            set
            {
                if (CheckSurName(value))
                {
                    _surName = value;
                    OnPropertyChanged("SurName");
                }
            }
        }
        public string Patronymic
        {
            get => _patronymic;
            set
            {
                if (CheckPatronymic(value))
                {
                    _patronymic = value;
                    OnPropertyChanged("Patronymic");
                }
            }
        }
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (CheckPhoneNumber(value))
                {
                    _phoneNumber = value;
                    OnPropertyChanged("PhoneNumber");
                }
            }
        }
        public string PassportSeriesNumber
        {
            get => _passportSeriesNumber;
            set
            {
                if (CheckPassportSeriesNumber(value))
                {
                    _passportSeriesNumber = value;
                    OnPropertyChanged("PassportSeriesNumber");
                }
            }
        }

        #endregion
        #region Конструкторы
        public BankClient()
        {
            Name = string.Empty;
            SurName = string.Empty;
            Patronymic = string.Empty;
            PhoneNumber = string.Empty;
            PassportSeriesNumber = string.Empty;
            InfoChangeDataClients = new List<InfoChangeDataClient>();
        }
        public BankClient(string name, string surName, string patronymic, string phoneNumber, string passportSeriesNumber)
        {
            Name = name;
            SurName = surName;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            PassportSeriesNumber = passportSeriesNumber;
            InfoChangeDataClients = new List<InfoChangeDataClient>();
        }
        #endregion
        #region методы
        #region Проверка коректности данных
        public static bool CheckName(string name) => true;
        public static bool CheckSurName(string surName) => true;
        public static bool CheckPatronymic(string patronymic) => true;
        public static bool CheckPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return true;
            else if (phoneNumber.Length == 11)
            {
                foreach (var symbol in phoneNumber)
                    if (!char.IsNumber(symbol))
                        return false;
                return true;
            }
            else return false;
        }
        public static bool CheckPassportSeriesNumber(string PassportSeriesNumber)
        {
            if (string.IsNullOrEmpty(PassportSeriesNumber))
                return true;
            else if (PassportSeriesNumber.Length == 10)
            {
                foreach (var symbol in PassportSeriesNumber)
                    if (!char.IsNumber(symbol))
                        return false;
                return true;
            }
            else return false;
        }
        #endregion
        #region Вывод в консоль
        public void Print()
        {
            Debug.WriteLine($"Name: {Name}");
            Debug.WriteLine($"SurName: {SurName}");
            Debug.WriteLine($"Patronymic: {Patronymic}");
            Debug.WriteLine($"PhoneNumber: {PhoneNumber}");
            Debug.WriteLine($"PassportSeriesNumber: {PassportSeriesNumber}");
        }
        #endregion
        #region Сигнализирование об изменениях
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
        #endregion
    }
    public enum BankClientProperties { Name, SurName, Patronymic, PhoneNumber, PassportSeriesNumber };
}

using HomeWork12._6.BankSystem;
using HomeWork12._6.BankSystem.BankWorkers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HomeWork12._6
{
    /// <summary>
    /// Логика взаимодействия для WindowaAdingNewClient.xaml
    /// </summary>

    public partial class WindowaAdingNewClient : Window
    {
        public BankClient NewBankClient;
        private ISetDataClient Setfunctional;
        internal WindowaAdingNewClient(ISetDataClient setfunctional)
        {
            InitializeComponent();
            NewBankClient = new BankClient();
            if (setfunctional != null)
            {
                Setfunctional = setfunctional;
            }
            else
            {
                DialogResult = false;
            }
        }

        private void ButtonСreate_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckAllFields())
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }
            bool setStatus;
            setStatus = Setfunctional.SetName(NewBankClient, TextBoxNameClient.Text);
            if (!setStatus)
            {
                MessageBox.Show("Имя введено неверно");
                return;
            }
            setStatus = Setfunctional.SetSurName(NewBankClient, TextBoxSurNameClient.Text);
            if (!setStatus)
            {
                MessageBox.Show("Фамилия введена неверно");
                return;
            }
            setStatus = Setfunctional.SetPatronymic(NewBankClient, TextBoxPatronymicClient.Text);
            if (!setStatus)
            {
                MessageBox.Show("Отчество введено неверно");
                return;
            }
            setStatus = Setfunctional.SetPhoneNumber(NewBankClient, TextBoxPhoneNumberClient.Text);
            if (!setStatus)
            {
                MessageBox.Show("Телефон введен неверно");
                return;
            }
            setStatus = Setfunctional.SetPassportSeriesNumber(NewBankClient, TextBoxPussportSeriesNumberClient.Text);
            if (!setStatus)
            {
                MessageBox.Show("Данные паспотра введены неверно");
                return;
            }
            DialogResult = true;
        }
        private bool CheckAllFields()
        {
            if(string.IsNullOrEmpty(TextBoxNameClient.Text))
                return false;
            if (string.IsNullOrEmpty(TextBoxSurNameClient.Text))
                return false;
            if (string.IsNullOrEmpty(TextBoxPatronymicClient.Text))
                return false;
            if (string.IsNullOrEmpty(TextBoxPhoneNumberClient.Text))
                return false;
            if (string.IsNullOrEmpty(TextBoxPussportSeriesNumberClient.Text))
                return false;
            return true;
        }
        private void ButtonCancal_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}

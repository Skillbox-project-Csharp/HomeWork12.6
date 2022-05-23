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
    /// Логика взаимодействия для WorkerSelection.xaml
    /// </summary>
    public partial class WorkerSelection : Window
    {
        public WorkerSelection()
        {
            InitializeComponent();
        }

        private void ButtonSelection_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow;
            switch (ComboBoxWorkers.SelectedIndex)
            {
                case 0:
                    mainWindow = new MainWindow(new Consultant());
                    mainWindow.Show();
                    break;
                case 1:
                    mainWindow = new MainWindow(new Manager());
                    mainWindow.Show();
                    break;
            }
            this.Close();
        }
    }
}

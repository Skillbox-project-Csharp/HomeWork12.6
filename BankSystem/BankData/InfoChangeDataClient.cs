using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12._6.BankSystem.BankData
{
    public class InfoChangeDataClient
    {
        private readonly DateTime _DateChenge;
        private readonly BankClientProperties _PropertyChenge;
        private readonly TypesChenge _TypesChenge;
        private readonly string _Modifier;

        public InfoChangeDataClient( BankClientProperties propertyChenge, TypesChenge typesChenge, string modifier)
        {
            _DateChenge = DateTime.UtcNow;
            _PropertyChenge = propertyChenge;
            _TypesChenge = typesChenge;
            _Modifier = modifier;
        }

        public DateTime DateChenge => _DateChenge;

        public BankClientProperties PropertyChenge => _PropertyChenge;

        public TypesChenge TypesChenge => _TypesChenge;

        public string Modifier => _Modifier;

        public void PrintAll()
        {
            Debug.WriteLine($"DateChenge: {DateChenge}");
            Debug.WriteLine($"PropertyChenge: {PropertyChenge}");
            Debug.WriteLine($"TypesChenge: {TypesChenge}");
            Debug.WriteLine($"Modifier: {Modifier}");
        }
    }
    public enum TypesChenge {Remove, Change }
}

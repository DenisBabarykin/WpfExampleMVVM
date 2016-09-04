using FactorialListApp.Commands;
using FactorialListApp.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FactorialListApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Factorials = new ObservableCollection<int>();
            BtnText = "Calc";
        }

        public const int MAX_FACTORIAL_ARG = 12;

        public string BtnText { get; set; }

        public ObservableCollection<int> Factorials
        {
            get { return factorials; }
            set
            {
                factorials = value;
                NotifyPropertyChanged();
            }
        }
        private ObservableCollection<int> factorials;

        public ICommand FillFactorialComboboxCommand
        {
            get
            {
                if (fillFactorialComboboxCommand == null)
                {
                    fillFactorialComboboxCommand = new DelegateCommand(o => FillFactorials());
                }
                return fillFactorialComboboxCommand;
            }
        }
        private DelegateCommand fillFactorialComboboxCommand;

        public void FillFactorials()
        {
            Random rand = new Random();
            int factorialArg = rand.Next(MAX_FACTORIAL_ARG);
            Factorials = new ObservableCollection<int>(Factorial.GetFactorials(factorialArg));
        }
    }
}

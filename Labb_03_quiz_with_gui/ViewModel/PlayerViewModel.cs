using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Labb_03_quiz_with_gui.ViewModel
{
    internal class PlayerViewModel : ViewModelBase
    {
        private readonly MainWindowViewModel mainWindowViewModel;

        private DispatcherTimer timer;
        private string _testData = "Start Value";

        //public string TestData { get => "This is testdata."; }
        public string TestData { 
            get => _testData;
            private set
            {
                _testData = value;
                // Nedanstående funktionsanrop är bäst att ha här, men man kan skriva det
                // på alla ställen i koden där man ändrar den istället om man vill. T ex 
                // i private void Timer_Tick(...) nedan i denna klass.
                RaisePropertyChanged(); 
                //RaisePropertyChanged("TestData"); Är samma som ovanstående kodrad pga [CallerMemberName] i metod-definitionen.
            }
        }
        public PlayerViewModel(MainWindowViewModel? mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1); // Skapar ett timespan som är 1 sekund.
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            TestData += "x";
        }
    }
}

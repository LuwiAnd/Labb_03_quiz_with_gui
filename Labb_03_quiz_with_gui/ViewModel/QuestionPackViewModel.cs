using Labb_03_quiz_with_gui.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Labb_03_quiz_with_gui.ViewModel
{
    //internal class QuestionPackViewModel : INotifyPropertyChanged
    internal class QuestionPackViewModel : ViewModelBase
    {
        private readonly QuestionPack model;

        public QuestionPackViewModel(QuestionPack model)
        {
            this.model = model;
            this.Questions = new ObservableCollection<Question>(model.Questions);
        }

        public string Name 
        {
            get => model.Name;
            set
            {
                model.Name = value;
                RaisePropertyChanged();
            }
        }
        public Difficulty Difficulty
        {
            get => model.Difficulty;
            set
            {
                model.Difficulty = value;
                RaisePropertyChanged();
            }
        }
        public int TimeLimitInSeconds
        {
            get => model.TimeLimitInSeconds;
            set
            {
                model.TimeLimitInSeconds = value;
                //RaisePropertyChanged("TimeLimitInSeconds"); // när man inte använder [CallerMemberName] i funktionsdefinitionen.
                RaisePropertyChanged(); // med [CallerMemberName] i funktionsdefinitionen
            }
        }
        public ObservableCollection<Question> Questions { get; }

        
    }
}

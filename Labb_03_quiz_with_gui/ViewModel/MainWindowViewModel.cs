using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_03_quiz_with_gui.Model;

namespace Labb_03_quiz_with_gui.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<QuestionPackViewModel> Packs { get; set; }
		public ConfigurationViewModel ConfigurationViewModel { get; }
		public PlayerViewModel PlayerViewModel { get; }


		private QuestionPackViewModel? _activePack;


		public QuestionPackViewModel? ActivePack
		{
			get { return _activePack; }
			set 
			{
				_activePack = value;
				RaisePropertyChanged();

				ConfigurationViewModel.RaisePropertyChanged("ActivePack"); // För att det inte finns en set-funktion för denna Property.
			}
		}

        public MainWindowViewModel()
        {
			ConfigurationViewModel = new ConfigurationViewModel(this);
			PlayerViewModel = new PlayerViewModel(this);
            //using Labb_03_quiz_with_gui.Model;
            ActivePack = new QuestionPackViewModel(new QuestionPack("My Question Pack"));
        }

    }
}

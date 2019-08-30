using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using IMakeIt.Models;
using Prism.Navigation;

namespace IMakeIt.ViewModels
{
    public class RecipesListViewModel : ViewModelBase
    {



        public ObservableCollection<Game> Games { get; }

        private int _rating;
        public int Rating
        {
            get { return _rating; }
            set => SetProperty(ref _rating, value);
        }



        public RecipesListViewModel(INavigationService navigationService)
            : base(navigationService)
        {

            Games = new ObservableCollection<Game>();

            Games.Add(new Game
            {
                Nome = "God of War",
                TituloBR = "O bom da guerra"
            });

            Games.Add(new Game
            {
                Nome = "The last of us",
                TituloBR = "Nois que sobramus"
            });

            Games.Add(new Game
            {
                Nome = "Mario Kart 8",
                TituloBR = "Correndo com meus Amig..Inimigos"
            });

            Games.Add(new Game
            {
                Nome = "Super Mario Odyssey",
                TituloBR = "As viagens do Bigode"
            });

            Games.Add(new Game
            {
                Nome = "Halo",
                TituloBR = "E eu passei metiolate"
            });
        }
    }
}

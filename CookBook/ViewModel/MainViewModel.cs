using CommunityToolkit.Mvvm.ComponentModel;
using CookBook.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = "";

        private CuisineList cuisineList = new CuisineList();

        [ObservableProperty]
        private ObservableCollection<Cuisine> cuisines;

        [ObservableProperty]
        private Cuisine selectedCuisine;
        public MainViewModel()
        {
            cuisines = new ObservableCollection<Cuisine>(cuisineList.Cuisines);
            SelectedCuisine = cuisines[0];
        }
    }


}

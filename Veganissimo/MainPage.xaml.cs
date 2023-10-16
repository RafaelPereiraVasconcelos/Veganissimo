using Microsoft.Maui.Handlers;
using System.Collections.ObjectModel;
using Veganissimo.Models;

namespace Veganissimo
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Vegan> Vegans { get; set; }
        public MainPage()
        {
            InitializeComponent();
            ModifySearchBar();
            InitializeVegan();
            BindingContext = this;
        }

        private void InitializeVegan()
        {
            Vegans = new ObservableCollection<Vegan>
                {
                    new Vegan { Name = "Burger Vegano", Image = "burger.jpg" },
                    new Vegan { Name = "Mix de Saladas", Image = "mix.jpg" },
                    new Vegan { Name = "Pizza Vegana", Image = "pizza.jpg" }
                };
        }

        private void ModifySearchBar()
        {
   
        }
    }
}
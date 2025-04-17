using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.ViewModels
{
    [QueryProperty(nameof(Pizza), nameof(Pizza))]
    public partial class DetailsViewModel : ObservableObject
    {
        public DetailsViewModel()
        {
        }
        [ObservableProperty]
        private Pizza _pizza = new Pizza();
    }
}

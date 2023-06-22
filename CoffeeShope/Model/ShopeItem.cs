using CoffeeShope.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShope.Model
{
    public class ShopeItem : BasePageViewModel
    {
        private string _title;
        private int _price;
        private int _itemCount;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public int Rank { get; set; }

        public string Image { get; set; }

        public int Price 
        {
            get => _price; 
            set => SetProperty(ref _price, value);
        }

        public int ItemCount
        {
            get => _itemCount;
            set => SetProperty(ref _itemCount, value);
        }
    }
}

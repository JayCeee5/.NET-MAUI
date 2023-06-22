using CoffeeShope.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoffeeShope.ViewModel
{
    public class BasketPageViewModel : BasePageViewModel
    {
        private Command _selectCommand;
        private Command _tapItemImagelCommand;
        private Command _countCommand;
        private Command _tapButtonlCommand;
        private List<ShopeItem> _shopeItemsList;
        private ShopeItem _selectedShopeItem;
        private int _count;
        private int _itemCount;
        private string _buttonText;

        public ShopeItem SelectedShopeItem
        {
            get => _selectedShopeItem;
            set => SetProperty(ref _selectedShopeItem, value);
        }

        public List<ShopeItem> ShopeItemList
        {
            get => _shopeItemsList;
            set => SetProperty(ref _shopeItemsList, value);
        }

        public int Count
        {
            get => _count;
            set => SetProperty(ref _count, value);
        }

        public string ButtonText
        {
            get => _buttonText;
            set => SetProperty(ref _buttonText, value);
        }

        public int ItemCount
        {
            get => _itemCount;
            set => SetProperty(ref _itemCount, value);
        }



        public ICommand SelectItemCommand => _selectCommand ?? new Command(OnSelectItems);

        public ICommand TapItemImageCommand => _tapItemImagelCommand ?? new Command((parameter) => OnTapItemImage((ShopeItem)parameter));

        public ICommand IncrementCountCommand => _countCommand ?? new Command(OnIncrementCount);

        public ICommand DecrementCountCommand => _countCommand ?? new Command(OnDecrementCount);

        

        public BasketPageViewModel()
        {
            ShopeItemList = new List<ShopeItem>()
            {
                new ShopeItem { Title = "Flat White", Rank = 1, Image = "flatwhite.JPG", Price = 100, ItemCount = 0},
                new ShopeItem { Title = "Hot Chocolate", Rank = 2, Image = "hotchocolate.JPG" , Price = 200, ItemCount = 0},
                new ShopeItem { Title = "Latte", Rank = 3, Image = "latte.JPG" , Price = 250, ItemCount = 0},
                new ShopeItem { Title = "Mocha", Rank = 4, Image = "mocha.JPG" , Price =300, ItemCount = 0}
            };
        }

        private void OnIncrementCount(object obj)
        {
            Count += 1;
        }

        private void OnDecrementCount(object obj)
        {
            

            if (Count > 0)
            {
                Count -= 1;
            } else if(Count <= 0)
            {
                Count = 0;
            }
        }

        private void OnSelectItems()
        {

        }

        private void OnTapItemImage(ShopeItem parameter)
        {
            SelectedShopeItem = parameter;
        }
    }
}

using CoffeeShope.ViewModel;

namespace CoffeeShope;

public partial class BasketPage : ContentPage
{
	public BasketPage()
	{
		InitializeComponent();
		BindingContext = new BasketPageViewModel();
		
    }
}
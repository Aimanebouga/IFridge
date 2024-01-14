using IFridge.MVVM.ViewModels;


namespace IFridge.MVVM.Views;

public partial class ItemView : ContentPage
{ 
	public ItemView(ItemViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}
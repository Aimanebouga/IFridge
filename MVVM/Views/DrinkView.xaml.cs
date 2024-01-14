using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using IFridge.MVVM.ViewModels;
using Font = Microsoft.Maui.Font;

namespace IFridge.MVVM.Views;


public partial class DrinkView : ContentPage
{
    private readonly DrinkViewModel drinkViewModel;    
	public DrinkView(DrinkViewModel drinkViewModel)
	{
		InitializeComponent();
        BindingContext = drinkViewModel; 
        this.drinkViewModel = drinkViewModel;
        
        
	}
    

    private async void AddButton_Clicked(object sender, EventArgs e)
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        string text = "Drink is added succesfully";
        ToastDuration duration = ToastDuration.Short;
        double fontSize = 14;

        var toast = Toast.Make(text, duration, fontSize);
        
        await toast.Show(cancellationTokenSource.Token);    
    }

   

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        
            double getal = Math.Round(e.NewValue);
            SliderNumber.Text = string.Format("{0:F0}", getal);
        
    }
}
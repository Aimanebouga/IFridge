﻿using IFridge.MVVM.Models;
using IFridge.MVVM.ViewModels;
using IFridge.MVVM.Views;

namespace IFridge
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoToFridges_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FridgeView());
        }

        private void GoToDrinks_Clicked(object sender, EventArgs e)
        {
            DrinkViewModel viewModel = new DrinkViewModel();
            Navigation.PushAsync(new DrinkView(viewModel));
        }

        private void AllFridges_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new AllFridgesView());
        }
        private void GoToQrPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QrCodeReader());
        }

        private async void Test_Clicked(object sender, EventArgs e)
        {
            string upc = "0049000051995";
            var items = await UPCLogic.GetItemByUPC(upc);

            ItemViewModel viewModel = new ItemViewModel
            {
                Title = items[0].title,
                Description = items[0].description,
                ImageUrl = items[0].images[0].Replace("http://", "https://")
            };

            ItemView itemView = new ItemView(viewModel);

            await Navigation.PushAsync(itemView);

        }
    }
}
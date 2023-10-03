using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinMvvm.ViewModels;

namespace XamarinMvvm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ProductViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await(BindingContext as ProductViewModel).LoadDataAsync();

        }

    }

}

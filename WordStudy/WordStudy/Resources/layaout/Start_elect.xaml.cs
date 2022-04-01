using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WordStudy.Resources.layaout
{
    public partial class Start_elect : ContentPage
    {
        public Start_elect()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            // Показывать количество слов в каждом сптиске но нужно добавить ссылку на другую дб
            WordList.ItemsSource = App.Database_Classifications.GetItems();
            base.OnAppearing();
        }
        protected async void Back_(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        protected async void Start_(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Start());
        }

        protected async void SwipeItem_Invoked_Del(object sender, ItemTappedEventArgs e)
        {

            await Navigation.PushModalAsync(new Sattings());
        }
    }
}
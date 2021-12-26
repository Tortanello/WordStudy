using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WordStudy.Resources.layaout.LayaoutListWord
{
    // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListWord_Look : ContentPage
    {
        public ListWord_Look()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            WordList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        protected async void Back_(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        protected async void ListLanguage (object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        protected void SwipeItem_Invoked_Del(object sender, EventArgs e)
        {
            int id = 5;
            App.Database.DeleteItem(id);
        }
    }
}
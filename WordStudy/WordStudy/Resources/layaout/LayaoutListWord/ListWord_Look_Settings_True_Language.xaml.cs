using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordStudy.Resources.layaout.Word;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WordStudy.Resources.layaout.LayaoutListWord
{

    public partial class ListWord_Look_Settings_True_Language : ContentPage
    {
        public ListWord_Look_Settings_True_Language()
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
        protected async void SwipeItem_Invoked_Del(object sender, ItemTappedEventArgs e)
        {

            await Navigation.PushModalAsync(new Word_Modal(e));
        }
    }
}
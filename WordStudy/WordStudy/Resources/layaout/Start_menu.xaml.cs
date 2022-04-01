using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WordStudy.Resources.layaout
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Start_menu : ContentPage
    {
        public Start_menu()
        {
            InitializeComponent();
        }
        private async void elsect_word_list(object sender, FocusEventArgs e)
        {
            list_word_elect.IsReadOnly = true;
            await Navigation.PushModalAsync(new Start_elect());
            list_word_elect.IsReadOnly = false;
        }

        private async void Back_(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void Start_(object sender, EventArgs e)
        {
            return;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            /*Classification_db classification = new Classification_db();
            classification.First_Letter = First_Letter.Text;
            classification.My_List = My_List.Text;
            classification.Save_Settings = Save_Settings.Text;
            App.Database_Classification.input_or_Update(classification);*/
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordStudy.Resources.BaseData;
using WordStudy.Resources.layaout.LayaoutListWord.LayaoutAddLanguage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WordStudy.Resources.layaout.Word
{
    // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Insert_Language_Repet : ContentPage
    {
        public Insert_Language_Repet()
        {
            InitializeComponent();
        }

        private async void ListLanguage(object sender, ItemTappedEventArgs e)
        {
            // var T_lang = App.Database_Lang_C.GetItems();

            Language_db language_Choice_Db = e.Item as Language_db;

            string Lang = language_Choice_Db.Language;
            Language_Choice_db language_Choice_Db1 = new Language_Choice_db();
            language_Choice_Db1.Id = 1;
            language_Choice_Db1.Language_Choice = Lang;

            // App.Database_Lang_C.update_Lang_for_repet(language_Choice_Db1);
            await Navigation.PopModalAsync();
        }

        private async void Back_(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void Input_Language(object sender, EventArgs e)
        {
            // Cretcha nummue db and  ListWord
            Language_db languages_db = new Language_db();
            Add_Language add_Language_page = new Add_Language();

            add_Language_page.BindingContext = languages_db;
            await Navigation.PushModalAsync(add_Language_page);
        }

        protected override void OnAppearing()
        {
            WordList.ItemsSource = App.Database_Lang.GetItems();
            base.OnAppearing();
        }
    }
}
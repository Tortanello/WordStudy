using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordStudy.Resources.layaout.LayaoutListWord;
using WordStudy.Resources.layaout.LayaoutListWord.Choice_My_List;
using WordStudy.Resources.layaout.LayaoutListWord.SSf_C_Completed;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WordStudy.Resources.layaout
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Start : ContentPage
    {
        public Start()
        {
            InitializeComponent();
        }

        private async void Choice_My_List(object sender, EventArgs e)
        {
            My_List.IsReadOnly = true;
            string lang = MyEntry_Language.Text;
            string lang_translated = MyEntry_Language_translated.Text;
            string letter = First_Letter.Text;
            await Navigation.PushModalAsync(new Choice_My_List(letter, lang, lang_translated));
            My_List.IsReadOnly = false;
        }

        async void Insert_Language(object sender, EventArgs e)
        {
            MyEntry_Language.IsReadOnly = true;
            //await Navigation.PushModalAsync(new Insert_Language());
            MyEntry_Language.Text = "TEST";
            MyEntry_Language.IsReadOnly = false;
        }
        async void Insert_Language_Translated(object sender, EventArgs e)
        {
            MyEntry_Language_translated.IsReadOnly = true;
            //await Navigation.PushModalAsync(new Insert_Language_Translated());
            MyEntry_Language_translated.Text = "TEST";
            MyEntry_Language_translated.IsReadOnly = false;
        }

        private async void Save_Settings_Completed(object sender, EventArgs e)
        {
            Save_Settings.IsReadOnly = true;
            await Navigation.PushModalAsync(new SSf_C_Completed());
            Save_Settings.IsReadOnly = false;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            return;
        }

        private void Start_ (object sender, EventArgs e)
        {
            return;
        }
        private async void Back_(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        protected override void OnAppearing()
        {
            // MyEntry_Language.Text = "None";
            // MyEntry_Language_translated.Text = "None";
            // First_Letter.Text = "None";
            My_List.Text = "None";
            Save_Settings.Text = "None";
            base.OnAppearing();

        }
    }
}
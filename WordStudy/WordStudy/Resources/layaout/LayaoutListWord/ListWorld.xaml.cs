using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using WordStudy.Resources.BaseData;

using SQLite;
using WordStudy.Resources.Custom;

namespace WordStudy.Resources.layaout.LayaoutListWord
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListWorld : ContentPage
    {
        public ListWorld()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //var friend = (Words_db)BindingContext;
            // //Console.WriteLine(BindingContext);
            var word_db = (Words_db)BindingContext;
            if (!String.IsNullOrEmpty(word_db.Word))
            {
                if (!String.IsNullOrEmpty(word_db.Translated))
                {
                    translated.Placeholder = "Tranlated";
                    word.Placeholder = "Word";
                    // Проблема в том что слово не может пройти все циклы фо, теперь всё решено !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    App.Database.input_World(word_db);
                }
                // critcha alert about error input
                else
                {
                    word.Placeholder = "Word";
                    translated.Placeholder = "NULL";
                }
            }
            // critcha alert about error input
            else
            {
                word.Placeholder = "NULL";
                if (String.IsNullOrEmpty(word_db.Translated))
                {
                    translated.Placeholder = "NULL";
                }
                else
                {
                    translated.Placeholder = "Translated";
                }
            }

            if (MyEntry_Language.Text == "Language")
            {
                MyEntry_Language.Text = "ERROR";
                if (MyEntry_Language.Text == "ERROR")
                {
                    return;
                }
                // return;
            }

            if (MyEntry_Language_translated.Text == "Language")
            {
                MyEntry_Language_translated.Text = "ERROR";
                if (MyEntry_Language_translated.Text == "ERROR")
                {
                    return;
                }
                // return;
            }

            // App.Database.input_World(word_db);
        }
        async private void Back_(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void Insert_Language(object sender, EventArgs e)
        {
            //await Language_F.ScaleTo(0.8, 30);
            //await Language_F.ScaleTo(1, 10);
            MyEntry_Language.IsReadOnly = true;
            await Navigation.PushModalAsync(new Insert_Language());
            MyEntry_Language.IsReadOnly = false;
        }
        async void Insert_Language_Translated(object sender, EventArgs e)
        {
            MyEntry_Language_translated.IsReadOnly = true;
            await Navigation.PushModalAsync(new Insert_Language_Translated());
            MyEntry_Language_translated.IsReadOnly = false;
        }

        async private void ListWord_ (object sender, EventArgs e)
        {
            if (App.Database_Settins.GetItem(1).De_Activetion_Language == "False")
            {
                var page = new ListWord_Look();
                await Navigation.PushModalAsync(page);
            }
            else
            {
                var page = new ListWord_Look_Settings_True_Language();
                await Navigation.PushModalAsync(page);
            }
        }

        private void if_db()
        {
            if (App.Database_Settins.GetItem(1).De_Activetion_Transcription == "False")
            {
                transcription.IsReadOnly = true;
                translated.Completed += MyEntry_Completed;
                translated.ReturnType = default;
            }

            if (App.Database_Settins.GetItem(1).First_Word_Is_Big_Lettar == "False")
            {
                word.Keyboard = default;
                translated.Keyboard = default;
                transcription.Keyboard = default;

                word.Placeholder = "word";
                translated.Placeholder = "translated";
                transcription.Placeholder = "transcription";
            }
        }

        //public void OnAppearing(object sender, EventArgs e)
        protected override void OnAppearing()
        {
            /*MyEntry_Language.Text = "Language";
            MyEntry_Language_translated.Text = "Language";*/
            var s = App.Database_Lang_C.GetItems_to_List().First();
            MyEntry_Language.Text = s.Language_Choice;
            MyEntry_Language_translated.Text = s.Language_Translated_Choice;

            if_db();

            base.OnAppearing();

        }

        private void MyEntry_Completed(object sender, EventArgs e)
        {
            Button_Clicked(sender, e);
            word.Focus();
            word.Text = "";
            translated.Text = "";
            transcription.Text = "";
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordStudy.Resources.BaseData;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace WordStudy.Resources.layaout
{
    // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sattings : ContentPage
    {
        public Sattings()
        {
            InitializeComponent();
        }
        private void Switch_De_Activetion_Transcription_Toggled_(object sender, ToggledEventArgs e)
        {
            var state = App.Database_Settins.GetItem(1);
            string value_s;
            bool value = e.Value;
            if (value == true)
            {
                value_s = "True";
            }
            else
            {
                value_s = "False";
            }
            Settings_db settings_T = new Settings_db();
            settings_T.ID = 1;
            settings_T.De_Activetion_Transcription = value_s;
            settings_T.First_Word_Is_Big_Lettar = state.First_Word_Is_Big_Lettar;
            App.Database_Settins.Update_Settings(settings_T);
        }

        private void Switch_F(object sender, ToggledEventArgs e)
        {
            var state = App.Database_Settins.GetItem(1);
            string value_s;
            bool value = e.Value;
            if (value == true)
            {
                value_s = "True";
            }
            else
            {
                value_s = "False";
            }
            Settings_db settings_F = new Settings_db();
            settings_F.ID = 1;
            settings_F.First_Word_Is_Big_Lettar = value_s;
            settings_F.De_Activetion_Transcription = state.De_Activetion_Transcription;
            App.Database_Settins.Update_Settings(settings_F);
            if (value_s == "True")
            {
                First_Big();
            }
            else if (value_s == "False")
            {
                First_Smoll();
            }
        }

        private void First_Big()
        {
            var date = App.Database.GetItems();
            Words_db [] massiv_date = new Words_db [date.Count()];

            for (int i = 0; i < date.Count(); i++)
            {
                var word_ = date.ElementAt(i).Word;
                var translated_ = date.ElementAt(i).Translated;

                string letter = word_.ToCharArray().First().ToString().ToUpper();
                char[] char_ = word_.ToCharArray();
                char_[0] = letter.ToCharArray().First();


                string string_down;
                for (int k = 1; k < char_.Length; k++)
                {
                    string_down = char_[k].ToString().ToLower();
                    char_[k] = string_down.ToCharArray().First();
                }

                string str = "";
                for (int a = 0; a < char_.Length; a++)
                {
                    str += char_[a].ToString();
                }

                // str

                string letter_t = translated_.ToCharArray().First().ToString().ToUpper();
                char[] char_t = translated_.ToCharArray();
                char_t[0] = letter_t.ToCharArray().First();


                string string_down_t;
                for (int k = 1; k < char_t.Length; k++)
                {
                    string_down_t = char_t[k].ToString().ToLower();
                    char_t[k] = string_down_t.ToCharArray().First();
                }

                string str_t = "";
                for (int a = 0; a < char_t.Length; a++)
                {
                    str_t += char_t[a].ToString();
                }

                // str_t

                date.ElementAt(i).Word = str;

                date.ElementAt(i).Translated = str_t;

                App.Database.Update_sattings(date.ElementAt(i));
            }
        }

        private void First_Smoll()
        {
            var date = App.Database.GetItems();
            Words_db[] massiv_date = new Words_db[date.Count()];

            for (int i = 0; i < date.Count(); i++)
            {
                var word_ = date.ElementAt(i).Word;
                var translated_ = date.ElementAt(i).Translated;

                char[] char_ = word_.ToCharArray();

                string string_down;
                for (int k = 0; k < char_.Length; k++)
                {
                    string_down = char_[k].ToString().ToLower();
                    char_[k] = string_down.ToCharArray().First();
                }

                string str = "";
                for (int a = 0; a < char_.Length; a++)
                {
                    str += char_[a].ToString();
                }

                // str

                char[] char_t = translated_.ToCharArray();

                string string_down_t;
                for (int k = 0; k < char_t.Length; k++)
                {
                    string_down_t = char_t[k].ToString().ToLower();
                    char_t[k] = string_down_t.ToCharArray().First();
                }

                string str_t = "";
                for (int a = 0; a < char_t.Length; a++)
                {
                    str_t += char_t[a].ToString();
                }

                // str_t

                date.ElementAt(i).Word = str;

                date.ElementAt(i).Translated = str_t;

                App.Database.Update_sattings(date.ElementAt(i));
            }
        }

        private void Switch_De_Activetion_Language_(object sender, ToggledEventArgs e)
        {
            var state = App.Database_Settins.GetItem(1);
            string value_s;
            bool value = e.Value;
            if (value == true)
            {
                value_s = "True";
            }
            else
            {
                value_s = "False";
            }

            Settings_db settings_T = new Settings_db();
            settings_T.ID = 1;
            settings_T.De_Activetion_Transcription = state.De_Activetion_Transcription;
            settings_T.First_Word_Is_Big_Lettar = state.First_Word_Is_Big_Lettar;
            settings_T.De_Activetion_Language = value_s;
            App.Database_Settins.Update_Settings(settings_T);
        }


        /*async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }*/
        async private void Back_(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        protected override void OnAppearing()
        {
            var state = App.Database_Settins.GetItem(1);
            if (state.First_Word_Is_Big_Lettar == "True")
            {
                Switch_F_N.IsToggled = true;
            }
            else if (state.First_Word_Is_Big_Lettar == "False")
            {
                Switch_F_N.IsToggled = false;
            }

            if (state.De_Activetion_Transcription == "True")
            {
                Switch_De_Activetion_Transcription.IsToggled = true;
            }
            else if (state.De_Activetion_Transcription == "False")
            {
                Switch_De_Activetion_Transcription.IsToggled = false;
            }

            if (state.De_Activetion_Language == "True")
            {
                Switch_De_Activetion_Language.IsToggled = true;
            }
            else if (state.De_Activetion_Language == "False")
            {
                Switch_De_Activetion_Language.IsToggled = false;
            }

            base.OnAppearing();

        }
    }
}
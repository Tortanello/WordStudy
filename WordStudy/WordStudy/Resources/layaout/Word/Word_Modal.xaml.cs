using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using WordStudy.Resources.BaseData;
using WordStudy.Resources.layaout.LayaoutListWord;

namespace WordStudy.Resources.layaout.Word
{
    public partial class Word_Modal : ContentPage
    {
        int e_id;
        public Word_Modal(ItemTappedEventArgs e)
        {
            InitializeComponent();


            // Перенести на onAppeare не меняется язык
            var q = e.Item as Words_db;

            MyEntry_Language.Text = q.Language;
            MyEntry_Language_translated.Text = q.Language_Translated;

            word.Text = q.Word;
            translated.Text = q.Translated;
            transcription.Text = q.Transcription;

            e_id = q.Id;
        }

        protected async void Back_(object sender, EventArgs e)
        {
            // Назад
            await Navigation.PopModalAsync();
        }
        async private void Button_Clicked(object sender, EventArgs e)
        {
            // Готово
            // Можно добавить проверки
            // var word_db = (Words_db)BindingContext;

            Words_db word_db = new Words_db();
            word_db.Language = MyEntry_Language.Text;
            word_db.Language_Translated = MyEntry_Language_translated.Text;
            word_db.Word = word.Text;
            word_db.Translated = translated.Text;
            word_db.Transcription = transcription.Text;

            word_db.Id = e_id;

            App.Database.Update_sattings(word_db);
            await Navigation.PopModalAsync();
        }

        async private void ListWord_(object sender, EventArgs e)
        {
            // Удалить
            Words_db word_db = new Words_db();
            word_db.Id = e_id;
            App.Database.DeleteItem(word_db.Id);
            await Navigation.PopModalAsync();
        }
    }
}
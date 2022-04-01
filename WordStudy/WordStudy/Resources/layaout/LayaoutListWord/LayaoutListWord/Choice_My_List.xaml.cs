using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordStudy.Resources.BaseData;
using WordStudy.Resources.Class;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.Widget.AdapterView;

namespace WordStudy.Resources.layaout.LayaoutListWord.Choice_My_List
{
    public partial class Choice_My_List : ContentPage
    {
        Words_db[] WordMass_Selection;
        Words_db[] WordMass_Selection_another;
        IReadOnlyList<object> SelectWordsArray;
        public Choice_My_List(string letter, string lang, string lang_trinslated)
        {
            InitializeComponent();
            // WordList.ItemsSource = App.Database.GetItems();
            //  Прогоняем все слова по каждой из категорий и устраняем постепено те которые не подходят, оставшиеся выводим
            int[] selection = Selection_Word.Selection_Word_metod(letter, lang, lang_trinslated);
            int[] selection_remake = Selection_Word.Count_not_zero(selection);

            var date = App.Database.GetItems();

            WordMass_Selection = new Words_db[selection_remake.Length];
            for (int i = 0; i < selection_remake.Length; i++)
            {
                WordMass_Selection[i] = date.ElementAt(selection_remake[i]);  
            }

            WordList.ItemsSource = WordMass_Selection;

            // This are ALL words print on screen // WordList.ItemsSource = WordMass_Selection;
            try
            {
                WordMass_Selection_another = new Words_db[WordMass_Selection.Count() - 1];
            }
            catch (Exception)
            {
                WordMass_Selection_another = new Words_db[WordMass_Selection.Count()];
            }
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        // Массив со всеми элементами для того что бы после нажатия на кнопку сохранения поместить их в бд
        private async void WordList_ItemTapped(object sender, SelectionChangedEventArgs e)
        {
            SelectWordsArray = e.CurrentSelection;
            /*var CurrentSelection = e.CurrentSelection;
            var str = CurrentSelection.GetType();
            var qweq = CurrentSelection[0];
            Words_db qaz = (Words_db)qweq;
            string qwes = qaz.Word;*/
            //SelectWordsArray[0] = e.CurrentSelection;
        }
        protected async void Back_(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        protected async void Start_ (object sender, EventArgs e)
        {
            WordsForStudy_db[] wordsCollection = new WordsForStudy_db [SelectWordsArray.Count()];
            string[] str = new string[SelectWordsArray.Count()];
            for (int i = 0; i < SelectWordsArray.Count(); i++)
            {
                Words_db word = (Words_db)SelectWordsArray[i];
                /*wordsCollection[i].data[i] = word.Word;
                wordsCollection[i].data[i+1] = word.Translated;
                wordsCollection[i].data[i+2] = word.Language_Translated;
                wordsCollection[i].data[i+3] = word.Transcription;
                wordsCollection[i].data[i+4] = word.Language;*/

                wordsCollection[i].Word = word.Word;
                wordsCollection[i].Translated = word.Translated;
                wordsCollection[i].Language_Translated = word.Language_Translated;
                wordsCollection[i].Transcription = word.Transcription;
                wordsCollection[i].Language = word.Language;
                /*// Можно переделать дизайн и убрать поле Name в отдельный layaout
                wordsCollection[i].Name = NameEntry.Text;*/
            }

            // App.Database_WordsForStudy.input_World(wordsCollection);

            //var qq = SelectWordsArray[0];
            //var q = array[0];
            /*foreach (var word in array)
            {
                var input = word.;
                App.Database_WordsForStudy.input_World(input);
            }*/
            await Navigation.PushAsync(new StartCreateList(wordsCollection));
        }
    }
}
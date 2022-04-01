using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordStudy.Resources.BaseData;
using WordStudy.Resources.Class;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WordStudy.Resources.layaout.LayaoutListWord.Choice_My_List
{
    public partial class Choice_My_List : ContentPage
    {
        public Choice_My_List(string letter, string lang, string lang_trinslated)
        {
            InitializeComponent();
            // WordList.ItemsSource = App.Database.GetItems();
            //  Прогоняем все слова по каждой из категорий и устраняем постепено те которые не подходят, оставшиеся выводим
            int[] selection = Selection_Word.Selection_Word_metod(letter, lang, lang_trinslated);
            int[] selection_remake = Selection_Word.Count_not_zero(selection);

            var date = App.Database.GetItems();

            Words_db[] WordMass_Selection = new Words_db[selection_remake.Length];
            for (int i = 0; i < selection_remake.Length; i++)
            {
                WordMass_Selection[i] = date.ElementAt(selection_remake[i]);  
            }

            WordList.ItemsSource = WordMass_Selection;

            // This are ALL words print on screen // WordList.ItemsSource = WordMass_Selection;

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void WordList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var q = e.Item as Words_db;

            Words_db w = q;
        }
    }
}
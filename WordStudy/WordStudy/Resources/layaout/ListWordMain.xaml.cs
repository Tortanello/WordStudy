using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordStudy.Resources.BaseData;
using WordStudy.Resources.layaout.LayaoutListWord;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WordStudy.Resources.layaout
{
    // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListWordMain : ContentPage
    {
        public ListWordMain()
        {
            InitializeComponent();
        }

        private async void FraimWordInsert_(object sender, EventArgs e)
        {

            /*await FraimWordInsert.ScaleTo(0.8, 30);
            await FraimWordInsert.ScaleTo(1, 10);*/

            // Cretcha nummue db and  ListWord
            Words_db words_Db = new Words_db();
            ListWorld listWordPage = new ListWorld();

            listWordPage.BindingContext = words_Db;

            await Navigation.PushModalAsync(listWordPage);
        }
        private async void FraimWordDelite_(object sender, EventArgs e)
        {
            /*await FraimWordDelite.ScaleTo(0.8, 30);
            await FraimWordDelite.ScaleTo(1, 10);*/

            // Cretcha nummue db and  ListWord
            /*Words_db words_Db = new Words_db();
            ListWorld listWordPage = new ListWorld();

            listWordPage.BindingContext = words_Db;*/
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
        /*private async void FraimWordReword_(object sender, EventArgs e)
        {
            await FraimWordReword.ScaleTo(0.8, 30);
            await FraimWordReword.ScaleTo(1, 10);

            // Cretcha nummue db and  ListWord
            Words_db words_Db = new Words_db();
            ListWorld listWordPage = new ListWorld();

            listWordPage.BindingContext = words_Db;

            await Navigation.PushModalAsync(listWordPage);
        }*/
        private async void Static_(object sender, EventArgs e)
        {
            /*await Static.ScaleTo(0.8, 30);
            await Static.ScaleTo(1, 10);*/

            // Cretcha nummue db and  ListWord
            Words_db words_Db = new Words_db();
            ListWorld listWordPage = new ListWorld();

            listWordPage.BindingContext = words_Db;

            await Navigation.PushModalAsync(listWordPage);
        }
        private async void Back_(object sender, EventArgs e)
        {
            /*await Back.ScaleTo(0.8, 30);
            await Back.ScaleTo(1, 10);*/

            await Navigation.PopModalAsync();
        }
    }
}
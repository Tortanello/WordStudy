using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WordStudy.Resources.BaseData;
using WordStudy.Resources.layaout;
using WordStudy.Resources.layaout.LayaoutListWord;
using Xamarin.Forms;


using Xamarin.Forms.Xaml;

namespace WordStudy.Resources.layaout
{
    
    public partial class MainPage : ContentPage
    {
        private Sattings st;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Start(object sender, EventArgs e)
        {
            //StartStudyF.BorderColor = new Color(255, 0, 0);
            /*await StartStudyF.ScaleTo(0.8, 30);
            await StartStudyF.ScaleTo(1,10);*/
            //StartStudyF.BorderColor = new Color(0.3, 0.73, 0.98);

            /*Classification_db classification = new Classification_db();*/
            /*Start listWordPage = new Start();*/

            /*listWordPage.BindingContext = classification;*/
            Start_Main listWordPage = new Start_Main();
            await Navigation.PushModalAsync(listWordPage);
        }

        private async void ListWord(object sender, EventArgs e)
        {
            //ListLetterF.BorderColor = new Color(255, 0, 0);
            /*await ListLetterF.ScaleTo(0.8, 30);
            await ListLetterF.ScaleTo(1, 10);*/
            //ListLetterF.BorderColor = new Color(0.3, 0.73, 0.98);
            await Navigation.PushModalAsync(new ListWordMain());
        }

        private async void Satting(object sender, EventArgs e)
        {
            //SattingF.BorderColor = new Color(255, 0, 0);
            /*await SattingF.ScaleTo(0.8, 30);
            await SattingF.ScaleTo(1, 10);*/
            //SattingF.BorderColor = new Color(0.3, 0.73, 0.98);
            await Navigation.PushModalAsync(st);
        }

        private void Exit(object sender, EventArgs e)
        {

            int [] exit = new int[1];
            int num = exit[2];
            // await Navigation.PopAsync();
        }

        protected override void OnAppearing()
        {
            // проверить, как выше производителтность 
            st = new Sattings();
            base.OnAppearing();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WordStudy.Resources.layaout
{

    public partial class Start_Main : ContentPage
    {
        public Start_Main()
        {
            InitializeComponent();
        }

        private async void Words(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Start_menu());
        }
    }
}
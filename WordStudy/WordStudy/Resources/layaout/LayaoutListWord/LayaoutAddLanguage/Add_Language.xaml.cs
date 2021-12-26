using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using WordStudy.Resources.BaseData;
using SQLite;

namespace WordStudy.Resources.layaout.LayaoutListWord.LayaoutAddLanguage
{
    public partial class Add_Language : ContentPage
    {
        public Add_Language()
        {
            InitializeComponent();
        }

        async private void Back_(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async private void Add_lang(object sender, EventArgs e)
        {
            /*var lang_ = new Language_db();
            lang_.SetBinding(MyEntry.TextProperty, "Text");*/
            var lang = (Language_db)BindingContext;
            App.Database_Lang.input_Lang(lang);

            await Navigation.PopModalAsync();
        }
    }
}
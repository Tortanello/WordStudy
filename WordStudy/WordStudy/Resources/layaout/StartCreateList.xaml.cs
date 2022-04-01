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
    public partial class StartCreateList : ContentPage
    {
        public StartCreateList(WordsForStudy_db[] wordsCollection)
        {
            InitializeComponent();
        }
    }
}
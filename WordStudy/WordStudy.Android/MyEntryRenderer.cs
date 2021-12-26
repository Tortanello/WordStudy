using Android.Content;
using Android.Graphics.Drawables;
using System;
using System.Collections.Generic;
using System.Text;
using WordStudy.Resources.Custom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using System.Security.Cryptography;

[assembly: ExportRenderer(typeof(MyEntry),typeof(MyEntryRenderer))]
namespace WordStudy.Resources.Custom
{
    class MyEntryRenderer: EntryRenderer
    {
        public MyEntryRenderer(Context context ):base(context)
        {
            
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.Rgb(255, 255, 255));
            }
        }
    }
}

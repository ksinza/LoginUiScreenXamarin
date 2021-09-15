﻿using System;
using Android.Content;
using LoginPage.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace LoginPage.Droid
{
    public class CustomEntryRenderer : EntryRenderer 
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
          
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(e.OldElement == null)
            {
                Control.Background = null;
            }
        }
    }
}

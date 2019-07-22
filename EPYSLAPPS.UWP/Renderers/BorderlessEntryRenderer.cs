#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Windows.UI.Xaml;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using Setter = Windows.UI.Xaml.Setter;
using Style = Windows.UI.Xaml.Style;

[assembly: ExportRenderer(typeof(EPYSLAPPS.Controls.BorderlessEntry), typeof(EPYSLAPPS.UWP.BorderlessEntryRenderer))]
namespace EPYSLAPPS.UWP
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
                Control.VerticalAlignment = VerticalAlignment.Center;

                // Make the text vertically aligned at centre of the entry.
                Style style = new Style(typeof(Windows.UI.Xaml.Controls.ContentControl));
                style.Setters.Add(new Setter(VerticalAlignmentProperty, VerticalAlignment.Center));                
                this.Control.Resources.Add(typeof(Windows.UI.Xaml.Controls.ContentControl), style);
            }
        }
    }
}

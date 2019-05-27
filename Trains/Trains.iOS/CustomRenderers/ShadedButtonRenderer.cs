using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Trains.iOS.CustomRenderers;
using Trains.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ShadedButton),typeof(ShadedButtonRenderer))]
namespace Trains.iOS.CustomRenderers
{
    public class ShadedButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.BackgroundColor = UIColor.Gray;
            }
        }
    }
}
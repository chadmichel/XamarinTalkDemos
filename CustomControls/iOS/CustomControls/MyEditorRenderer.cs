using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using BasicDemo.iOS;
using BasicDemo;

[assembly: ExportRenderer (typeof (MyEditor), typeof (MyEditorRenderer))]
namespace BasicDemo.iOS
{
    public class MyEditorRenderer : EditorRenderer
    {
        public MyEditorRenderer()
        {
        }

        protected override void OnElementChanged (ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged (e);

            if (Control != null) 
            {   // perform initial setup
                // do whatever you want to the UITextField here!

                if (e.NewElement.IsEnabled)
                {
                    Control.Layer.BorderColor = UIColor.LightGray.CGColor;
                    Control.Layer.BorderWidth = (nfloat)0.5;
                    Control.Editable = true;
                }
                else
                {
                    Control.Editable = false;
                }
            }
        }
    }
}


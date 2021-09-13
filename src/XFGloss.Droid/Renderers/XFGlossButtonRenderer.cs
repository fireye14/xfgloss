using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFGloss.Droid.Extensions;
using XFGloss.Droid.Drawables;
using AColor = Android.Graphics.Color;
using AView = Android.Views.View;
using AViewGroup = Android.Views.ViewGroup;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using System;
using Android.Views;
using System.Xml;
using AppCompat = Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(Button), typeof(XFGloss.Droid.Renderers.XFGlossButtonRenderer))]
namespace XFGloss.Droid.Renderers
{
    [Android.Runtime.Preserve(AllMembers = true)]
    public class XFGlossButtonRenderer : AppCompat.ButtonRenderer
    {
        //Context _context;

        public XFGlossButtonRenderer(Context context) : base(context)
        {
            //_context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                // Cleanup
            }

            if (e.NewElement != null)
            {
                if (false)
                    Control.Background = DroidXFGlossCellRenderer.BackgroundRippleDrawable.Create(AColor.Yellow, AColor.Green);

                // example of setting a style from resource; if it's a resource specific to the app, I'd have to have the renderer there instead
                //Control.SetBackgroundResource(Resource.Drawable.abc_ab_share_pack_mtrl_alpha);
            }
        }

    }
}
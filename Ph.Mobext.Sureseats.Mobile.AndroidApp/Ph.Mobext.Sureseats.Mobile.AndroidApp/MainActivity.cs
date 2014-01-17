#region Directives
using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;
using Android.Graphics;
#endregion

namespace Ph.Mobext.Sureseats.Mobile.AndroidApp
{
	[Activity (Label = "Ph.Mobext.Sureseats.Mobile.AndroidApp", MainLauncher = true)]
	public class MainActivity : Activity
	{
		#region Events
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;
			RequestWindowFeature (WindowFeatures.NoTitle);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			Init ();
		}
		#endregion

		#region Methods
		public void Init(){
			var linHeader = FindViewById<LinearLayout> (Resource.Id.Main_linHeader);
			linHeader.SetMinimumHeight (Computer.Generator.GetPreferredHeight(Resources.DisplayMetrics));
			linHeader.SetBackgroundDrawable (new BitmapDrawable(BitmapFactory.DecodeResource (this.Resources, Resource.Drawable.bgHeader)));

			var linTitleBar = FindViewById<LinearLayout> (Resource.Id.Main_linTitleBar);
			linTitleBar.SetMinimumHeight (Computer.Generator.GetPreferredHeight (Resources.DisplayMetrics) / 2);
			linTitleBar.SetBackgroundDrawable (new BitmapDrawable (BitmapFactory.DecodeResource (this.Resources, Resource.Drawable.bgTitleBar)));
		}
		#endregion
	}
}



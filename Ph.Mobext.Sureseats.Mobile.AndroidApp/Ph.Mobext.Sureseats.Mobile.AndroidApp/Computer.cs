#region Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.OS;
using Android.Util;
using Android.Views;
using Android.Widget;
#endregion

namespace Ph.Mobext.Sureseats.Mobile.AndroidApp
{
	public class Computer
	{
		private static Computer _math;

		#region Constructor
		private Computer(){
			//empty constructor
		}
		#endregion

		#region Singleton
		public static Computer Generator {
			get {
				_math = new Computer();
				return _math;
			}
		}
		#endregion

		#region Methods and Functions
		public int GetPreferredHeight(Android.Util.DisplayMetrics metrics){
			int height = 32;
			switch (metrics.DensityDpi) {

			case DisplayMetricsDensity.High:
				height = 48;
				break;
			case DisplayMetricsDensity.Medium:
				height = 32;
				break;
			case DisplayMetricsDensity.Low:
				height = 24;
				break;
			default:
				Console.WriteLine ("Display : Unknown density");
				break;
			}
			return height;
		}
		#endregion
	}
}


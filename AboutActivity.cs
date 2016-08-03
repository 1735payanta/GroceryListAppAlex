
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GroceryListAppAddo
{
	[Activity (Label = "AboutActivity")]			
	public class AboutActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.About);

			FindViewById<Button>(Resource.Id.learnMoreButton).Click += OnLearnMoreClick;
			FindViewById<Button>(Resource.Id.btnViewMap).Click += OnbtnViewMap;
		}

		void OnbtnViewMap (object sender, EventArgs e)
		{
			var intent = new Intent();
			intent.SetAction(Intent.ActionView);
			intent.SetData(Android.Net.Uri.Parse("geo:43.0384823,-87.9318297?z=16"));
			StartActivity(intent);

		}

		void OnLearnMoreClick(object sender, EventArgs e)
		{
			var intent = new Intent();
			intent.SetAction(Intent.ActionView);
			intent.SetData(Android.Net.Uri.Parse("http://www.itinnovationtoday.com"));
			StartActivity(intent);
		}
	}
}
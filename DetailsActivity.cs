
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
	[Activity (Label = "DetailsActivity")]			
	public class DetailsActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Details);

			//			int position = 0;

			int position = Intent.GetIntExtra("ItemPosition", -1);

			var item = MainActivity.Items[position];

			FindViewById<TextView>(Resource.Id.nameTextView ).Text = "Name: "  + item.Name;
			FindViewById<TextView>(Resource.Id.countTextView).Text = "Count: " + item.Count.ToString();
		}
	}
}
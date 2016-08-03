
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
	[Activity (Label = "ItemsActivity")]			
	public class ItemsActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Items);

			var lv = FindViewById<ListView>(Resource.Id.listView);
			lv.Adapter = new ArrayAdapter<Item>(this, Android.Resource.Layout.SimpleListItem1, Android.Resource.Id.Text1, MainActivity.Items);	
			lv.ItemClick += OnItemClick;
		}

		void OnItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			int position = e.Position; // e.Position is the position in the list of the item the user touched
			var intent = new Intent(this, typeof(DetailsActivity));
			intent.PutExtra("ItemPosition", position);
			StartActivity(intent); 
		}
	}
}

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
	[Activity (Label = "AddItemsActivity")]			
	public class AddItemsActivity : Activity
	{
//	Why don't we need to call these?!?!

//		EditText txtName;
//		EditText txtCount;
//		Button btnSave;
//		Button btnCancel;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.AddItem);

			FindViewById<Button>(Resource.Id.saveButton  ).Click += OnSaveClick;
			FindViewById<Button>(Resource.Id.cancelButton).Click += OnCancelClick;
		}

		void OnSaveClick(object sender, EventArgs e)
		{
			string name  = FindViewById<EditText>(Resource.Id.nameInput).Text;
			int    count = int.Parse(FindViewById<EditText>(Resource.Id.countInput).Text);

			var intent = new Intent();
			intent.PutExtra("ItemName",  name );
			intent.PutExtra("ItemCount", count);
			SetResult(Result.Ok, intent);
			Finish ();

		}

		void OnCancelClick(object sender, EventArgs e)
		{
			Finish ();
		}
	}
}
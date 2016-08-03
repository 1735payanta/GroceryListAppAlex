//Why do we not need any using directives?!?!?

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//
//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;

namespace GroceryListAppAddo
{
	public class Item
	{
		public Item(string name, long count)
		{
			Name  = name;
			Count = count;
		}

		public string Name  { get; set; }
		public long   Count { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
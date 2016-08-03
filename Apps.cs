using Android.App;
using Android.Runtime;
using Parse;
using System;

[Application]
public class App : Application
{
	public App (IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer){ }

	public override void OnCreate ()
	{
		base.OnCreate ();

		// Initialize the Parse client with your Application ID and .NET Key found on
		// your Parse dashboard, this is a private security key for your Parse account
		// To find your key, select your application on Parse, go to "Settings",
		// then open the "Application Keys" tab.
		ParseClient.Initialize("CmBeFPlvT9vPiRYGMNlfzuNJcyWUoln6SAHRNfY9", "dciRa50jCgqAplnF2x1v7ZThZszFkRsIAra9LHrR");
	}
}


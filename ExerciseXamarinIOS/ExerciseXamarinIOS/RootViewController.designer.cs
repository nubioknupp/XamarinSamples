// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ExerciseXamarinIOS
{
	[Register ("RootViewController")]
	partial class RootViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tabNews { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIWebView web { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (tabNews != null) {
				tabNews.Dispose ();
				tabNews = null;
			}
			if (web != null) {
				web.Dispose ();
				web = null;
			}
		}
	}
}

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
	[Register ("NewsViewController")]
	partial class NewsViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UINavigationItem newsNav { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tableNews { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (newsNav != null) {
				newsNav.Dispose ();
				newsNav = null;
			}
			if (tableNews != null) {
				tableNews.Dispose ();
				tableNews = null;
			}
		}
	}
}

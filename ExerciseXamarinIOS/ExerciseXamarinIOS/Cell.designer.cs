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
	[Register ("Cell")]
	partial class Cell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblDescription { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblTitle { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lblDescription != null) {
				lblDescription.Dispose ();
				lblDescription = null;
			}
			if (lblTitle != null) {
				lblTitle.Dispose ();
				lblTitle = null;
			}
		}
	}
}

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
	[Register ("Celula")]
	partial class Celula
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblID { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblTitulo { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView txtDescricao { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lblID != null) {
				lblID.Dispose ();
				lblID = null;
			}
			if (lblTitulo != null) {
				lblTitulo.Dispose ();
				lblTitulo = null;
			}
			if (txtDescricao != null) {
				txtDescricao.Dispose ();
				txtDescricao = null;
			}
		}
	}
}

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
    [Register("WebViewController")]
    partial class WebViewController
    {
        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UITabBarItem tabWeb { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIWebView webBrowser { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (tabWeb != null)
            {
                tabWeb.Dispose();
                tabWeb = null;
            }
            if (webBrowser != null)
            {
                webBrowser.Dispose();
                webBrowser = null;
            }
        }
    }
}

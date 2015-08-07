
using System;
using System.Drawing;
using CoreGraphics;
using Foundation;
using UIKit;

namespace ExerciseXamarinIOS
{
    public partial class DetailViewController : UIViewController
    {
        private News _currentNews;
        static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public DetailViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            //Screen
            Title = _currentNews.Title;

            txtDescription.Text = _currentNews.Description;

            //txtDescription.Text = "\tLorem ipsum dolor sit er elit lamet, consectetaur cillium adipisicing pecu, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Nam liber te conscient to factor tum poen legum odioque civiuda.";
            //txtDescription.Text = txtDescription.Text + System.Environment.NewLine +
            //                       "\tIt is possible to use a Storyboard to create custom Table Views. This recipe demonstrates how to create both Dynamic Prototype and Static content for cells in a table using the Storyboard.";
            //txtDescription.Text = txtDescription.Text + System.Environment.NewLine +
            //           "\tIt is possible to use a Storyboard to create custom Table Views. This recipe demonstrates how to create both Dynamic Prototype and Static content for cells in a table using the Storyboard.";

        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion

        public void SetNews(News news)
        {
            _currentNews = news;
        }
    }
}
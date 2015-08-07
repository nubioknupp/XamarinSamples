
using System;
using System.Collections.Generic;
using System.Drawing;

using Foundation;
using UIKit;

namespace ExerciseXamarinIOS
{
    public partial class NewsViewController : UIViewController
    {
        public int IdNews { get; set; }

        static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public NewsViewController(IntPtr handle)
            : base(handle)
        {
        }

        public NewsViewController()
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

            // Perform any additional setup after loading the view, typically from a nib.
            if (tableNews != null)
            {
                var newsDao = new NewsDao();
                var newses = newsDao.GetNewses();
                var tableSourceNews = new TableSourceNews(newses);

                tableNews.Source = tableSourceNews;
            }
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
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

        #region RowSelected

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "DetailSegue")
            {
                var detail = segue.DestinationViewController as DetailViewController;

                if (detail != null)
                {
                    var sourceNews = tableNews.Source as TableSourceNews;
                    var rowPathNews = tableNews.IndexPathForSelectedRow;
                    var news = sourceNews.GetNews(rowPathNews.Row);
                    detail.SetNews(news);
                    newsNav.BackBarButtonItem.Title = "";
                }
            }

            base.PrepareForSegue(segue, sender);
        }

        #endregion
    }
}
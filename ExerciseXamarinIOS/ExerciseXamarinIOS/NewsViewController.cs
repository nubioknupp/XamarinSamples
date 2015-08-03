
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
                //Teste List
                List<News> lstNewses = new List<News>();
                News news = new News();

                news.Id = 1;
                news.Title = "Touch no iOS";
                news.Description = "É importante para entender os eventos de toque e APIs e em um aplicativo iOS, como eles sendo fundamentais para todas as interações físicas com o dispositivo. Todas as interações de toque envolvem um objeto UITouch. Neste texto, vamos aprender c..";

                lstNewses.Add(news);

                news = new News();

                news.Id = 2;
                news.Title = "Introdução às Bibliotecas de Classes Portáteis";
                news.Description = "Visão geral Um componente-chave da construção de aplicações multi-plataforma é a capacidade de compartilhar um código por meio de vários projetos específicos da plataforma. No entanto, isso é complicado pelo fato de que diferentes plataformas co...";

                lstNewses.Add(news);

                news = new News();

                news.Id = 3;
                news.Title = "Crie apps para iOS usando o MAC in Cloud";
                news.Description = "Muitos tem dificuldade de desenvolver apps para iOS pela necessidade de ter um MAC para compilar e testar as apps desenvolvidas com Xamarin. Agora a coisa ficou mais simples, o MAC in Cloud permite rodar o MAC na nuvem e você pode testar seus pr...";

                lstNewses.Add(news);

                var tableSourceNews = new TableSourceNews(lstNewses);
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

        //public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        //{
        //    if (segue.Identifier == "DetalheSegue")
        //    { // set in Storyboard
        //        var navctlr = segue.DestinationViewController as DetalheViewController;
        //        if (navctlr != null)
        //        {
        //            var source = tableNews.Source as TableSourceNews;
        //            var rowPath = tableNews.IndexPathForSelectedRow;
        //            var item = source.GetNews(rowPath.Row);
        //            navctlr.SetNews(item); // to be defined on the TaskDetailViewController
        //        }
        //    }
        //}

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
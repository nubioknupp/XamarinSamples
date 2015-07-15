using System;
using System.Collections.Generic;
using System.Drawing;

using Foundation;
using UIKit;

namespace ExerciseXamarinIOS
{
    public partial class RootViewController : UIViewController
    {
        public RootViewController(IntPtr handle)
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

            // Perform any additional setup after loading the view, typically from a nib.

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            if (tabNews != null)
            {
                List<News> lstNewses = new List<News>();
                News news = new News();

                news.Titulo = "Touch no iOS";
                news.Descricao = "É importante para entender os eventos de toque e APIs e em um aplicativo iOS, como eles sendo fundamentais para todas as interações físicas com o dispositivo. Todas as interações de toque envolvem um objeto UITouch. Neste texto, vamos aprender c..";

                lstNewses.Add(news);

                news.Titulo = "Introdução às Bibliotecas de Classes Portáteis";
                news.Descricao = "Visão geral Um componente-chave da construção de aplicações multi-plataforma é a capacidade de compartilhar um código por meio de vários projetos específicos da plataforma. No entanto, isso é complicado pelo fato de que diferentes plataformas co...";

                lstNewses.Add(news);

                news.Titulo = "Crie apps para iOS usando o MAC in Cloud";
                news.Descricao = "Muitos tem dificuldade de desenvolver apps para iOS pela necessidade de ter um MAC para compilar e testar as apps desenvolvidas com Xamarin. Agora a coisa ficou mais simples, o MAC in Cloud permite rodar o MAC na nuvem e você pode testar seus pr...";

                lstNewses.Add(news);

                GerenciamentoNews gerenciamentoNews = new GerenciamentoNews(lstNewses);

                tabNews.Source = gerenciamentoNews;
            }

            if (web != null)
            {
                web.LoadRequest(new NSUrlRequest(new NSUrl("http://comocriaraplicativos.com.br")));
            }
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
    }



}
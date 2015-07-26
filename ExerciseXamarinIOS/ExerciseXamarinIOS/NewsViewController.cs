
using System;
using System.Collections.Generic;
using System.Drawing;

using Foundation;
using UIKit;

namespace ExerciseXamarinIOS
{
    public partial class NewsViewController : UIViewController
    {
        static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public NewsViewController(IntPtr handle)
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
            if (tableNews != null)
            {
                //Teste List
                List<News> lstNewses = new List<News>();
                News news = new News();

                news.Id = 1;
                news.Titulo = "Touch no iOS";
                news.Descricao = "� importante para entender os eventos de toque e APIs e em um aplicativo iOS, como eles sendo fundamentais para todas as intera��es f�sicas com o dispositivo. Todas as intera��es de toque envolvem um objeto UITouch. Neste texto, vamos aprender c..";

                lstNewses.Add(news);

                news = new News();

                news.Id = 2;
                news.Titulo = "Introdu��o �s Bibliotecas de Classes Port�teis";
                news.Descricao = "Vis�o geral Um componente-chave da constru��o de aplica��es multi-plataforma � a capacidade de compartilhar um c�digo por meio de v�rios projetos espec�ficos da plataforma. No entanto, isso � complicado pelo fato de que diferentes plataformas co...";

                lstNewses.Add(news);

                news = new News();

                news.Id = 3;
                news.Titulo = "Crie apps para iOS usando o MAC in Cloud";
                news.Descricao = "Muitos tem dificuldade de desenvolver apps para iOS pela necessidade de ter um MAC para compilar e testar as apps desenvolvidas com Xamarin. Agora a coisa ficou mais simples, o MAC in Cloud permite rodar o MAC na nuvem e voc� pode testar seus pr...";

                lstNewses.Add(news);

                GerenciamentoNews gerenciamentoNews = new GerenciamentoNews(lstNewses);
                tableNews.Source = gerenciamentoNews;
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



        public override bool ShouldPerformSegue(string segueIdentifier, NSObject sender)
        {
            if (segueIdentifier == "Detalhe")
            {

            }

            return base.ShouldPerformSegue(segueIdentifier, sender);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            //if (segue.Identifier == "DETALHE")
            //{
            //    Tela2 T2 = (Tela2)segue.DestinationViewController;
            //    T2.ID = 222;
            //}

            base.PrepareForSegue(segue, sender);
        }

        #endregion
    }
}
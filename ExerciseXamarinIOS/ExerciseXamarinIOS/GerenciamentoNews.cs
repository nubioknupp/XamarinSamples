using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace ExerciseXamarinIOS
{
    public class GerenciamentoNews : UITableViewSource
    {
        List<News> myListNewses;

        public GerenciamentoNews(List<News> lstNews)
        {
            myListNewses = lstNews;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            Celula myCell = (Celula)tableView.DequeueReusableCell("cellNews");
            myCell.MontaCelula(myListNewses[0].Titulo.ToString(),
                    myListNewses[0].Descricao.ToString());
            return myCell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return nint.Parse(myListNewses.Count.ToString());
        }
    }
}
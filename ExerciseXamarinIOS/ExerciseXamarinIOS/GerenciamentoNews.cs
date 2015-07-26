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
            myCell.MontaCelula(myListNewses[indexPath.Row].Id,
                                myListNewses[indexPath.Row].Titulo.ToString(),
                                myListNewses[indexPath.Row].Descricao.ToString());
            return myCell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return nint.Parse(myListNewses.Count.ToString());
        }
    }
}
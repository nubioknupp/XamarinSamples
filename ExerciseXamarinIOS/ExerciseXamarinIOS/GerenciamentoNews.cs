using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace ExerciseXamarinIOS
{
    public class GerenciamentoNews : UITableViewSource
    {
        List<News> News;

        public GerenciamentoNews(List<News> lstNews)
        {
            News = lstNews;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            throw new NotImplementedException();
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace ExerciseXamarinIOS
{
    public class TableSourceNews : UITableViewSource
    {

        #region Methods populates the cells
            public List<News> ListNewses { get; set; }

            public TableSourceNews(List<News> lstNews)
            {
                ListNewses = lstNews;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var myCell = (Cell)tableView.DequeueReusableCell("cellNews");
                myCell.SetCell(ListNewses[indexPath.Row].Title.ToString(),
                                    ListNewses[indexPath.Row].Description.ToString());
                return myCell;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return nint.Parse(ListNewses.Count.ToString());
            }
        #endregion

        public News GetNews(int id)
        {
            return ListNewses[id];
        }

    }
}
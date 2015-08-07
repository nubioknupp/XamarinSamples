using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Foundation;
using SQLite;
using UIKit;

namespace ExerciseXamarinIOS
{
    public class News
    {
        public News()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
    }
}
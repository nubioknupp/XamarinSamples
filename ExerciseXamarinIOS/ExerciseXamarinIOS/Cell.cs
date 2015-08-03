
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace ExerciseXamarinIOS
{
    public partial class Cell : UITableViewCell
    {
        public Cell(IntPtr handle)
            : base(handle)
        {
        }

        public void SetCell(String vTitulo, String vDescricao)
        {
            lblTitle.TextAlignment = UITextAlignment.Justified;
            lblTitle.Text = vTitulo;

            lblDescription.TextAlignment = UITextAlignment.Justified;
            lblDescription.Text = vDescricao;
        }

    }
}
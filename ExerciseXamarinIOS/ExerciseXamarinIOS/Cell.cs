
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
            lblTitle.Text = vTitulo;
            txtDescription.Editable = false;

            if (vDescricao.Length > 86)
            {
                txtDescription.Text = vDescricao.Remove(87) + "...";
            }
            else
            {
                txtDescription.Text = vDescricao;
            }
        }

    }
}
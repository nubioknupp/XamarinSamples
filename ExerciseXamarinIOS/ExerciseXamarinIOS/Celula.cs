
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace ExerciseXamarinIOS
{
    public partial class Celula : UITableViewCell
    {
        public Celula(IntPtr handle)
            : base(handle)
        {
        }

        public void MontaCelula(String vTitulo, String vDescricao)
        {
            lblTitulo.Text = vTitulo;

            txtDescricao.Editable = false;

            if (vDescricao.Length > 86)
            {
                txtDescricao.Text = vDescricao.Remove(87) + "...";
            }
            else
            {
                txtDescricao.Text = vDescricao;
            }
        }

    }
}
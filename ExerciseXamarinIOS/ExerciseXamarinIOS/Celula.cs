
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

        public void MontaCelula(int vId, String vTitulo, String vDescricao)
        {
            lblTitulo.Text = vTitulo;
            lblID.Text = vId.ToString();
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

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
            lblTitulo .Text = vTitulo;
            txtDescricao.Text = vDescricao;
        }

    }
}
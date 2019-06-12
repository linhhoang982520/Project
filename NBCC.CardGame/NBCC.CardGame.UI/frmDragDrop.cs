using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBCC.CardGame.UI
{
    public partial class frmDragDrop : Form
    {
        public frmDragDrop()
        {
            InitializeComponent();
        }

        private void frmDragDrop_Load(object sender, EventArgs e)
        {
            picLeft.AllowDrop = true;
            picRight.AllowDrop = true;
        }

        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

            if (sender == picLeft)
            {
                picRight.Image = null;
            }
            else
            {
                picLeft.Image = null;
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            //Which mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;

                if(pic.Image != null)
                {
                    pic.DoDragDrop(pic.Image, DragDropEffects.Move);
                }
            }
        }
    }
}

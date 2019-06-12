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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMakeCard f = new frmMakeCard();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMakeDeck f = new frmMakeDeck();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Uncomment once including this form
            frmAddHand f = new frmAddHand();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Uncomment once including this form
            frmAdd2Hands f = new frmAdd2Hands();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Uncomment once including this form
            frmDeleteCardFromHand f = new frmDeleteCardFromHand();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmDragDrop f = new frmDragDrop();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmBlackJack f = new frmBlackJack();
            f.ShowDialog();
        }
    }
}

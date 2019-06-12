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
    public partial class frmAdd2Hands : Form
    {
        public frmAdd2Hands()
        {
            InitializeComponent();
        }

        private Hand hand1;
        private Hand hand2;
        private Deck aDeck;

        private void frmAdd2Hands_Load(object sender, EventArgs e)
        {
            SetUp();
        }

        private void btnRedeal_Click(object sender, EventArgs e)
        {
            SetUp();
        }

        private void btnHand1_Click(object sender, EventArgs e)
        {
            try
            {
                hand1 = aDeck.DealHand(5);
                ShowHand(Panel1, hand1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnHand2_Click(object sender, EventArgs e)
        {
            try
            {
                hand2 = aDeck.DealHand(5);
                ShowHand(Panel2, hand2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ShowHand(Panel panel, Hand hand)
        {
            panel.Controls.Clear();
            Card aCard;
            PictureBox aPic;

            for(int i = 0; i < hand.Count; i++)
            {
                aCard = hand[i];
                string path = $@"images\{aCard.FaceValue}{aCard.Suit}.jpg";

                aPic = new PictureBox
                {
                    Image = Image.FromFile(path),
                    Text = aCard.FaceValue.ToString(),
                    Width = 71,
                    Height = 100,
                    Left = 75 * i,
                };

                panel.Controls.Add(aPic);
            }
        }

        private void SetUp()
        {
            try
            {
                aDeck = new Deck();
                aDeck.Shuffle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }    
}


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
    public partial class frmDeleteCardFromHand : Form
    {
        public frmDeleteCardFromHand()
        {
            InitializeComponent();
        }

        private Hand hand1;
        private Hand hand2;
        private Deck aDeck;

        private void frmDeleteCardFromHand_Load(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message, "Error");
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
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ShowHand(Panel thePanel, Hand theHand)
        {
            thePanel.Controls.Clear();
            Card aCard;
            PictureBox aPic;
            for (int i = 0; i < theHand.Count; i++)
            {
                aCard = theHand[i];
                string path = @"images\" + aCard.FaceValue.ToString() + aCard.Suit.ToString() + ".jpg";


                // same thing as above but using object initialization syntax
                // this allows the card to be identified for deletion when the picturebox is clicked                
                
                aPic = new PictureBox()
                {
                    Image = Image.FromFile(path),
                    Text = aCard.FaceValue.ToString(),
                    Width = 71,
                    Height = 100,
                    Left = 75 * i,
                    Tag = aCard
                };

                //Create a PictureBox click event handler to execute deletion of card on click
                aPic.Click += PictureBox_Click;

                thePanel.Controls.Add(aPic);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picToDelete = (PictureBox)sender;
            Panel p = (Panel)picToDelete.Parent;
            Hand tmpHand = p == Panel1 ? hand1 : hand2;
            
            tmpHand = hand1;
            tmpHand.RemoveCard((Card)picToDelete.Tag);
            ShowHand(p, tmpHand);
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

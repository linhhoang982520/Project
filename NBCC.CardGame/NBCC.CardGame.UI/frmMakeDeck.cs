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
    public partial class frmMakeDeck : Form
    {
        public frmMakeDeck()
        {
            InitializeComponent();
        }

        Deck aDeck;
        
        private void frmMakeDeck_Load(object sender, EventArgs e)
        {
            SetUp();
        }
        
        private void btnNewDeck_Click(object sender, EventArgs e)
        {
            SetUp();
        }

        private void btnDealCard_Click(object sender, EventArgs e)
        {
            //Create a show card method based off frmMakeCard
            //Copy and paste from frmMakeCard
            // Using the deck object, draw the top card then pass of to the ShowCard method
            try
            {
                Card theCard = aDeck.DrawOneCard(); 
                ShowCard(theCard);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }                      
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            //Loop our cards
            //Draw top card
            //Concatenate into txtShowALll
            for(int i = 0; i < 52; i++)
            {
                Card card = aDeck.DrawOneCard();
                txtShowAll.Text += card.FaceValue.ToString() + " of " + card.Suit.ToString() + Environment.NewLine;
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
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        public void ShowCard(Card theCard)
        {
            //Clear before poplate card
            Panel1.Controls.Clear();

            //Create a string to castnate
            string faceName = theCard.FaceValue.ToString();
            string suitName = theCard.Suit.ToString();

            string imgPath = @"images\" + faceName + suitName + ".jpg";

            PictureBox pic = new PictureBox()
            {
                Image = Image.FromFile(imgPath),
                Width = 71,
                Height = 100,
                Left = 75
            };

            Panel1.Controls.Add(pic);

        }
    }
}

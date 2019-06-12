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
    public partial class frmAddHand : Form
    {
        public frmAddHand()
        {
            InitializeComponent();
        }

        private Deck aDeck;

        private void frmAddHand_Load(object sender, EventArgs e)
        {
            SetUp();
        }
        
        private void btnNewDeck_Click(object sender, EventArgs e)
        {
            SetUp();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Hand aHand = aDeck.DealHand(5);
                ShowHand(aHand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ShowHand(Hand aHand)
        {
            Panel1.Controls.Clear();
            Card aCard;
            PictureBox aPic;

            //Loop the cards in the hand and create ui cards
            for(int i = 0; i < aHand.Count; i++)
            {
                //Assign each card
                //Get a file path as string
                //Create PictureBox instance
                //Add PictureBox Props
                //Add panel1    
                aCard = aHand[i];                
                string imgPath = @"images\" + aCard.FaceValue.ToString() + aCard.Suit.ToString() + ".jpg";
                
                aPic = new PictureBox()
                {
                    Image = Image.FromFile(imgPath),
                    Width = 71,
                    Height = 100,
                    Left = 75 * i,
                };
                Panel1.Controls.Add(aPic);                
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

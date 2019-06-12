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
    public partial class frmMakeCard : Form
    {
        public frmMakeCard()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Gen Card
            Card newCard = GenerateCard();

            //Show card
            ShowCard(newCard);
        }       

        public Card GenerateCard()
        {
            Random myRandom = new Random();

            //The random min value is inclusive. The max is exclusive
            Suit mySuit = (Suit)myRandom.Next(0, 4);
            FaceValue myFace = (FaceValue)myRandom.Next(0, 13);

            return new Card(mySuit, myFace);
        }

        /// <summary>
        /// The UI to create a picture box, add the image and then add to the Panel Control
        /// </summary>
        /// <param name="theCard"></param>
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

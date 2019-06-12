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
    public partial class frmBlackJack : Form
    {
        public frmBlackJack()
        {
            InitializeComponent();
        }

        private Hand hand1;
        private Hand hand2;
        private Deck aDeck;

        private void frmBlackJack_Load(object sender, EventArgs e)
        {
            SetUp();
            CardBack1();
            CardBack2();
            btnReset.Enabled = false;
            lblThink.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = true;
            Panel4.Visible = true;
            
            btnReset.Enabled = false;
            btnAdd.Enabled = true;
            txtWin.BackColor = Color.White;
            txtLose.BackColor = Color.White;
            txtDraw.BackColor = Color.White;

            SetUp();
        }

        private void btnHand1_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                btnReset.Enabled = false;
                lblThink.Visible = true;

                hand1 = aDeck.DealHand(2);
                ShowHand(Panel1, hand1);

                hand2 = aDeck.DealHand(2);
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

            for (int i = 0; i < hand.Count; i++)
            {
                aCard = hand[i];
                string path = $@"images\{aCard.FaceValue}{aCard.Suit}.jpg";

                aPic = new PictureBox
                {
                    Image = Image.FromFile(path),
                    Text = aCard.FaceValue.ToString(),
                    Width = 80,
                    Height = 110,
                    Left = 80 * i,
                };

                panel.Controls.Add(aPic);
            }
        }

        private void CardBack1()
        {
            string path = $@"images\cardback.gif";

            PictureBox aPic = new PictureBox
            {
                Image = Image.FromFile(path),
                Width = 80,
                Height = 110,
                Left = 0,
            };

            Panel3.Controls.Add(aPic);
        }

        private void CardBack2()
        {
            string path = $@"images\cardback.gif";

            PictureBox aPic = new PictureBox
            {
                Image = Image.FromFile(path),
                Width = 80,
                Height = 110,
                Left = 0,
            };

            Panel4.Controls.Add(aPic);
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Panel3.Visible = false;
            Panel4.Visible = false;
            lblThink.Visible = false;
            btnAdd.Enabled = false;
            btnReset.Enabled = true;           
                        
            if(Result(hand1) > Result(hand2))
            {
                SetLose();
            }
            else if(Result(hand1) < Result(hand2))
            {
                SetWin();
            }
            else if(Result(hand1) == Result(hand2))
            {
                SetDraw();
            }                        
        }

        private int Result(Hand hand)
        {
            Card aCard;
            int total = 0;
            int value = 0;

            for(int i = 0; i < hand.Count; i++)
            {
                aCard = hand[i];

                if (aCard.FaceValue.ToString() == "King" || aCard.FaceValue.ToString() == "Queen" || aCard.FaceValue.ToString() == "Jack" || aCard.FaceValue.ToString() == "Ten")
                {
                    value = 10;
                    total += value;
                }
                else if (aCard.FaceValue.ToString() == "Ace")
                {
                    value = 1;
                    total += value;
                }
                else if (aCard.FaceValue.ToString() == "Two")
                {
                    value = 2;
                    total += value;
                }
                else if (aCard.FaceValue.ToString() == "Three")
                {
                    value = 3;
                    total += value;
                }
                else if (aCard.FaceValue.ToString() == "Four")
                {
                    value = 4;
                    total += value;
                }
                else if (aCard.FaceValue.ToString() == "Five")
                {
                    value = 5;
                    total += value;
                }
                else if (aCard.FaceValue.ToString() == "Six")
                {
                    value = 6;
                    total += value;
                }
                else if (aCard.FaceValue.ToString() == "Seven")
                {
                    value = 7;
                    total += value;
                }
                else if (aCard.FaceValue.ToString() == "Eight")
                {
                    value = 8;
                    total += value;
                }
                else if(aCard.FaceValue.ToString() == "Nine")
                {
                    value = 9;
                    total += value;
                }                

                if (total >= 10)
                {
                    total -= 10;
                }
            }

            return total;
        }

        private void SetWin()
        {
            txtWin.BackColor = Color.Yellow;
        }

        private void SetLose()
        {
            txtLose.BackColor = Color.Red;
        }
        private void SetDraw()
        {
            txtDraw.BackColor = Color.Violet;
        }        
    }
}

namespace NBCC.CardGame.UI
{
    partial class frmMakeDeck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtShowAll = new System.Windows.Forms.TextBox();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnNewDeck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(291, 173);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(184, 33);
            this.btnShowAll.TabIndex = 17;
            this.btnShowAll.Text = "ShowAll";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtShowAll
            // 
            this.txtShowAll.Location = new System.Drawing.Point(291, 11);
            this.txtShowAll.Multiline = true;
            this.txtShowAll.Name = "txtShowAll";
            this.txtShowAll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShowAll.Size = new System.Drawing.Size(184, 142);
            this.txtShowAll.TabIndex = 16;
            // 
            // btnDealCard
            // 
            this.btnDealCard.Location = new System.Drawing.Point(141, 173);
            this.btnDealCard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(100, 33);
            this.btnDealCard.TabIndex = 15;
            this.btnDealCard.Text = "Deal a Card";
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(21, 11);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(220, 142);
            this.Panel1.TabIndex = 13;
            // 
            // btnNewDeck
            // 
            this.btnNewDeck.Location = new System.Drawing.Point(21, 173);
            this.btnNewDeck.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewDeck.Name = "btnNewDeck";
            this.btnNewDeck.Size = new System.Drawing.Size(101, 33);
            this.btnNewDeck.TabIndex = 14;
            this.btnNewDeck.Text = "New Deck";
            this.btnNewDeck.Click += new System.EventHandler(this.btnNewDeck_Click);
            // 
            // frmMakeDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 220);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtShowAll);
            this.Controls.Add(this.btnDealCard);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnNewDeck);
            this.Name = "frmMakeDeck";
            this.Text = "frmMakeDeck";
            this.Load += new System.EventHandler(this.frmMakeDeck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtShowAll;
        internal System.Windows.Forms.Button btnDealCard;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnNewDeck;
    }
}
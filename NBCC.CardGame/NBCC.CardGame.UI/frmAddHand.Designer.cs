namespace NBCC.CardGame.UI
{
    partial class frmAddHand
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnNewDeck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(21, 11);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(387, 142);
            this.Panel1.TabIndex = 8;
            // 
            // btnNewDeck
            // 
            this.btnNewDeck.Location = new System.Drawing.Point(94, 173);
            this.btnNewDeck.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewDeck.Name = "btnNewDeck";
            this.btnNewDeck.Size = new System.Drawing.Size(72, 33);
            this.btnNewDeck.TabIndex = 9;
            this.btnNewDeck.Text = "New Deck";
            this.btnNewDeck.Click += new System.EventHandler(this.btnNewDeck_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "New Deal";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddHand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 225);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnNewDeck);
            this.Name = "frmAddHand";
            this.Text = "frmAddHand";
            this.Load += new System.EventHandler(this.frmAddHand_Load);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnNewDeck;
        internal System.Windows.Forms.Button button1;
    }
}
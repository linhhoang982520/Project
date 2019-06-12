namespace NBCC.CardGame.UI
{
    partial class frmDeleteCardFromHand
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRedeal = new System.Windows.Forms.Button();
            this.btnHand2 = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnHand1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Click a card to delete";
            // 
            // btnRedeal
            // 
            this.btnRedeal.Location = new System.Drawing.Point(179, 273);
            this.btnRedeal.Margin = new System.Windows.Forms.Padding(2);
            this.btnRedeal.Name = "btnRedeal";
            this.btnRedeal.Size = new System.Drawing.Size(148, 33);
            this.btnRedeal.TabIndex = 18;
            this.btnRedeal.Text = "Redeal";
            this.btnRedeal.Click += new System.EventHandler(this.btnRedeal_Click);
            // 
            // btnHand2
            // 
            this.btnHand2.Location = new System.Drawing.Point(255, 235);
            this.btnHand2.Margin = new System.Windows.Forms.Padding(2);
            this.btnHand2.Name = "btnHand2";
            this.btnHand2.Size = new System.Drawing.Size(72, 33);
            this.btnHand2.TabIndex = 17;
            this.btnHand2.Text = "Deal Hand2";
            this.btnHand2.Click += new System.EventHandler(this.btnHand2_Click);
            // 
            // Panel2
            // 
            this.Panel2.Location = new System.Drawing.Point(11, 119);
            this.Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(523, 110);
            this.Panel2.TabIndex = 16;
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(11, 11);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(523, 102);
            this.Panel1.TabIndex = 14;
            // 
            // btnHand1
            // 
            this.btnHand1.Location = new System.Drawing.Point(179, 236);
            this.btnHand1.Margin = new System.Windows.Forms.Padding(2);
            this.btnHand1.Name = "btnHand1";
            this.btnHand1.Size = new System.Drawing.Size(72, 33);
            this.btnHand1.TabIndex = 15;
            this.btnHand1.Text = "Deal Hand1";
            this.btnHand1.Click += new System.EventHandler(this.btnHand1_Click);
            // 
            // frmDeleteCardFromHand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRedeal);
            this.Controls.Add(this.btnHand2);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnHand1);
            this.Name = "frmDeleteCardFromHand";
            this.Text = "frmDeleteCardFromHand";
            this.Load += new System.EventHandler(this.frmDeleteCardFromHand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnRedeal;
        internal System.Windows.Forms.Button btnHand2;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnHand1;
    }
}
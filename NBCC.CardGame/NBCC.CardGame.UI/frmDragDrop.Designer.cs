namespace NBCC.CardGame.UI
{
    partial class frmDragDrop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDragDrop));
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.picRight = new System.Windows.Forms.PictureBox();
            this.picLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // Label7
            // 
            this.Label7.AccessibleDescription = "Label with instructional text on dropping the picture to the other PictureBox con" +
    "trol.";
            this.Label7.AccessibleName = "Instructional Text Label for Example 3, drag target";
            this.Label7.Location = new System.Drawing.Point(380, 62);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(277, 59);
            this.Label7.TabIndex = 74;
            this.Label7.Text = "Drop the image into the PictureBox control. Next, drag it back to the left Pictur" +
    "eBox control.";
            // 
            // Label8
            // 
            this.Label8.AccessibleDescription = "Label with instructional text on dragging a picture to the other PictureBox contr" +
    "ol.";
            this.Label8.AccessibleName = "Instructional Text Label for Example 3, drag source";
            this.Label8.Location = new System.Drawing.Point(49, 62);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(288, 59);
            this.Label8.TabIndex = 73;
            this.Label8.Text = "Click and drag the image to the right PictureBox control. ";
            // 
            // Label9
            // 
            this.Label9.AccessibleDescription = "Label with text: \"Example 3:...\"";
            this.Label9.AccessibleName = "Example Title Label";
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(49, 22);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(608, 28);
            this.Label9.TabIndex = 72;
            this.Label9.Text = "Example: Drag-and-Drop Using PictureBox Controls";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picRight
            // 
            this.picRight.AccessibleDescription = "Empty PictureBox as drag target";
            this.picRight.AccessibleName = "Drag Target PictureBox control";
            this.picRight.BackColor = System.Drawing.SystemColors.Window;
            this.picRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picRight.Location = new System.Drawing.Point(384, 121);
            this.picRight.Margin = new System.Windows.Forms.Padding(4);
            this.picRight.Name = "picRight";
            this.picRight.Size = new System.Drawing.Size(245, 314);
            this.picRight.TabIndex = 76;
            this.picRight.TabStop = false;
            this.picRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragDrop);
            this.picRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            this.picRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            // 
            // picLeft
            // 
            this.picLeft.AccessibleDescription = "PictureBox with Beany.bmp as drag source";
            this.picLeft.AccessibleName = "Drag Source PictureBox control";
            this.picLeft.BackColor = System.Drawing.SystemColors.Window;
            this.picLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLeft.Image = ((System.Drawing.Image)(resources.GetObject("picLeft.Image")));
            this.picLeft.Location = new System.Drawing.Point(49, 121);
            this.picLeft.Margin = new System.Windows.Forms.Padding(4);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(245, 314);
            this.picLeft.TabIndex = 75;
            this.picLeft.TabStop = false;
            this.picLeft.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragDrop);
            this.picLeft.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            this.picLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            // 
            // frmDragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 475);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.picRight);
            this.Controls.Add(this.picLeft);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDragDrop";
            this.Text = "frmDragDrop";
            this.Load += new System.EventHandler(this.frmDragDrop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.PictureBox picRight;
        internal System.Windows.Forms.PictureBox picLeft;
    }
}
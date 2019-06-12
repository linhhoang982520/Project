namespace NBCC.CardGame.UI
{
    partial class frmBlackJack
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
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtWin = new System.Windows.Forms.TextBox();
            this.txtLose = new System.Windows.Forms.TextBox();
            this.txtDraw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThink = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(44, 53);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(213, 121);
            this.Panel1.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.Location = new System.Drawing.Point(44, 248);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(213, 126);
            this.Panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(462, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Win";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(464, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lose";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(330, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Card";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnHand1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(330, 277);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 34);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtWin
            // 
            this.txtWin.Enabled = false;
            this.txtWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWin.Location = new System.Drawing.Point(466, 116);
            this.txtWin.Name = "txtWin";
            this.txtWin.Size = new System.Drawing.Size(43, 24);
            this.txtWin.TabIndex = 6;
            // 
            // txtLose
            // 
            this.txtLose.Enabled = false;
            this.txtLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLose.Location = new System.Drawing.Point(466, 198);
            this.txtLose.Name = "txtLose";
            this.txtLose.Size = new System.Drawing.Size(43, 24);
            this.txtLose.TabIndex = 7;
            // 
            // txtDraw
            // 
            this.txtDraw.Enabled = false;
            this.txtDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDraw.Location = new System.Drawing.Point(468, 275);
            this.txtDraw.Name = "txtDraw";
            this.txtDraw.Size = new System.Drawing.Size(43, 24);
            this.txtDraw.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(464, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Draw";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblThink);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.Panel4);
            this.groupBox1.Controls.Add(this.Panel3);
            this.groupBox1.Controls.Add(this.Panel2);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txtDraw);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Panel1);
            this.groupBox1.Controls.Add(this.txtWin);
            this.groupBox1.Controls.Add(this.txtLose);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 426);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightBlue;
            this.label4.Location = new System.Drawing.Point(117, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Player";
            // 
            // lblThink
            // 
            this.lblThink.AutoSize = true;
            this.lblThink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThink.ForeColor = System.Drawing.Color.Gold;
            this.lblThink.Location = new System.Drawing.Point(302, 141);
            this.lblThink.Name = "lblThink";
            this.lblThink.Size = new System.Drawing.Size(135, 20);
            this.lblThink.TabIndex = 13;
            this.lblThink.Text = "Player thinking ...";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(330, 229);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(84, 30);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Panel4
            // 
            this.Panel4.Location = new System.Drawing.Point(150, 52);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(107, 122);
            this.Panel4.TabIndex = 11;
            // 
            // Panel3
            // 
            this.Panel3.Location = new System.Drawing.Point(44, 52);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(104, 122);
            this.Panel3.TabIndex = 10;
            // 
            // frmBlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBlackJack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBlackJack";
            this.Load += new System.EventHandler(this.frmBlackJack_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtWin;
        private System.Windows.Forms.TextBox txtLose;
        private System.Windows.Forms.TextBox txtDraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblThink;
        private System.Windows.Forms.Label label4;
    }
}
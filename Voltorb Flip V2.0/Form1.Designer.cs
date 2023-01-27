namespace Voltorb_Flip_V2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnThanks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(84, 564);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(199, 564);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(303, 564);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Location = new System.Drawing.Point(28, 79);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(400, 400);
            this.pnlButtons.TabIndex = 3;
            // 
            // pnlRight
            // 
            this.pnlRight.Location = new System.Drawing.Point(453, 79);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(66, 400);
            this.pnlRight.TabIndex = 4;
            // 
            // pnlBottom
            // 
            this.pnlBottom.AccessibleDescription = "pnlGuideBottom";
            this.pnlBottom.Location = new System.Drawing.Point(28, 499);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(400, 59);
            this.pnlBottom.TabIndex = 5;
            // 
            // lblScore
            // 
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Location = new System.Drawing.Point(199, 42);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(62, 23);
            this.lblScore.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "How to Play:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(286, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "https://www.dragonflycave.com/johto/voltorb-flip";
            // 
            // btnThanks
            // 
            this.btnThanks.Location = new System.Drawing.Point(436, 580);
            this.btnThanks.Name = "btnThanks";
            this.btnThanks.Size = new System.Drawing.Size(75, 23);
            this.btnThanks.TabIndex = 10;
            this.btnThanks.Text = "Thanks";
            this.btnThanks.UseVisualStyleBackColor = true;
            this.btnThanks.Click += new System.EventHandler(this.btnThanks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 615);
            this.Controls.Add(this.btnThanks);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Voltorb Flip 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private Button btnClear;
        private Button btnExit;
        private Panel pnlButtons;
        private Panel pnlRight;
        private Panel pnlBottom;
        private Label lblScore;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button btnThanks;
    }
}
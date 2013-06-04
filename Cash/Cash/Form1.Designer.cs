namespace Cash
{
    partial class Form1
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
            this.joeCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.banksCashLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joeGiveBob = new System.Windows.Forms.Button();
            this.bobGiveJohn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joeCashLabel
            // 
            this.joeCashLabel.AutoSize = true;
            this.joeCashLabel.Location = new System.Drawing.Point(46, 34);
            this.joeCashLabel.Name = "joeCashLabel";
            this.joeCashLabel.Size = new System.Drawing.Size(35, 13);
            this.joeCashLabel.TabIndex = 0;
            this.joeCashLabel.Text = "label1";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Location = new System.Drawing.Point(46, 66);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bobsCashLabel.TabIndex = 1;
            this.bobsCashLabel.Text = "label2";
            // 
            // banksCashLabel
            // 
            this.banksCashLabel.AutoSize = true;
            this.banksCashLabel.Location = new System.Drawing.Point(46, 93);
            this.banksCashLabel.Name = "banksCashLabel";
            this.banksCashLabel.Size = new System.Drawing.Size(35, 13);
            this.banksCashLabel.TabIndex = 2;
            this.banksCashLabel.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "give $10 to joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "receive $5 from bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joeGiveBob
            // 
            this.joeGiveBob.Location = new System.Drawing.Point(49, 212);
            this.joeGiveBob.Name = "joeGiveBob";
            this.joeGiveBob.Size = new System.Drawing.Size(75, 38);
            this.joeGiveBob.TabIndex = 5;
            this.joeGiveBob.Text = "joe gives $10 to bob";
            this.joeGiveBob.UseVisualStyleBackColor = true;
            this.joeGiveBob.Click += new System.EventHandler(this.joeGiveBob_Click);
            // 
            // bobGiveJohn
            // 
            this.bobGiveJohn.Location = new System.Drawing.Point(168, 212);
            this.bobGiveJohn.Name = "bobGiveJohn";
            this.bobGiveJohn.Size = new System.Drawing.Size(75, 38);
            this.bobGiveJohn.TabIndex = 6;
            this.bobGiveJohn.Text = "bob gives $5 to joe\r\n";
            this.bobGiveJohn.UseVisualStyleBackColor = true;
            this.bobGiveJohn.Click += new System.EventHandler(this.bobGiveJohn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.bobGiveJohn);
            this.Controls.Add(this.joeGiveBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.banksCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joeCashLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joeCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label banksCashLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button joeGiveBob;
        private System.Windows.Forms.Button bobGiveJohn;
    }
}


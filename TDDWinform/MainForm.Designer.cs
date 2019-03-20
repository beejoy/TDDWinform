namespace TDDWinform
{
    partial class MainForm
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
            this.LabelLength = new System.Windows.Forms.Label();
            this.LabelBreadth = new System.Windows.Forms.Label();
            this.TextBoxLength = new System.Windows.Forms.TextBox();
            this.TextBoxBreadth = new System.Windows.Forms.TextBox();
            this.TextBoxArea = new System.Windows.Forms.TextBox();
            this.LabelArea = new System.Windows.Forms.Label();
            this.ButtonCalculateArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelLength
            // 
            this.LabelLength.AutoSize = true;
            this.LabelLength.Location = new System.Drawing.Point(42, 32);
            this.LabelLength.Name = "LabelLength";
            this.LabelLength.Size = new System.Drawing.Size(43, 13);
            this.LabelLength.TabIndex = 0;
            this.LabelLength.Text = "Length:";
            // 
            // LabelBreadth
            // 
            this.LabelBreadth.AutoSize = true;
            this.LabelBreadth.Location = new System.Drawing.Point(42, 58);
            this.LabelBreadth.Name = "LabelBreadth";
            this.LabelBreadth.Size = new System.Drawing.Size(47, 13);
            this.LabelBreadth.TabIndex = 2;
            this.LabelBreadth.Text = "Breadth:";
            // 
            // TextBoxLength
            // 
            this.TextBoxLength.Location = new System.Drawing.Point(91, 29);
            this.TextBoxLength.Name = "TextBoxLength";
            this.TextBoxLength.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLength.TabIndex = 1;
            // 
            // TextBoxBreadth
            // 
            this.TextBoxBreadth.Location = new System.Drawing.Point(91, 55);
            this.TextBoxBreadth.Name = "TextBoxBreadth";
            this.TextBoxBreadth.Size = new System.Drawing.Size(100, 20);
            this.TextBoxBreadth.TabIndex = 3;
            // 
            // TextBoxArea
            // 
            this.TextBoxArea.Location = new System.Drawing.Point(91, 81);
            this.TextBoxArea.Name = "TextBoxArea";
            this.TextBoxArea.ReadOnly = true;
            this.TextBoxArea.Size = new System.Drawing.Size(100, 20);
            this.TextBoxArea.TabIndex = 5;
            this.TextBoxArea.TabStop = false;
            // 
            // LabelArea
            // 
            this.LabelArea.AutoSize = true;
            this.LabelArea.Location = new System.Drawing.Point(42, 84);
            this.LabelArea.Name = "LabelArea";
            this.LabelArea.Size = new System.Drawing.Size(32, 13);
            this.LabelArea.TabIndex = 4;
            this.LabelArea.Text = "Area:";
            // 
            // ButtonCalculateArea
            // 
            this.ButtonCalculateArea.Location = new System.Drawing.Point(91, 107);
            this.ButtonCalculateArea.Name = "ButtonCalculateArea";
            this.ButtonCalculateArea.Size = new System.Drawing.Size(100, 23);
            this.ButtonCalculateArea.TabIndex = 6;
            this.ButtonCalculateArea.Text = "Calculate Area";
            this.ButtonCalculateArea.UseVisualStyleBackColor = true;
            this.ButtonCalculateArea.Click += new System.EventHandler(this.ButtonCalculateArea_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 158);
            this.Controls.Add(this.ButtonCalculateArea);
            this.Controls.Add(this.LabelArea);
            this.Controls.Add(this.TextBoxArea);
            this.Controls.Add(this.TextBoxBreadth);
            this.Controls.Add(this.TextBoxLength);
            this.Controls.Add(this.LabelBreadth);
            this.Controls.Add(this.LabelLength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MVP and Unit Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLength;
        private System.Windows.Forms.Label LabelBreadth;
        private System.Windows.Forms.TextBox TextBoxLength;
        private System.Windows.Forms.TextBox TextBoxBreadth;
        private System.Windows.Forms.TextBox TextBoxArea;
        private System.Windows.Forms.Label LabelArea;
        private System.Windows.Forms.Button ButtonCalculateArea;
    }
}


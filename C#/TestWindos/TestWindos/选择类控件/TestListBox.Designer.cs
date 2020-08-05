namespace TestWindos.选择类控件
{
    partial class TestListBox
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
            this.LeftList = new System.Windows.Forms.ListBox();
            this.but_AddLeft = new System.Windows.Forms.Button();
            this.LeftAddTxtBox = new System.Windows.Forms.TextBox();
            this.RightList = new System.Windows.Forms.ListBox();
            this.RightAddTextBox = new System.Windows.Forms.TextBox();
            this.but_AddRight = new System.Windows.Forms.Button();
            this.LeftToRight = new System.Windows.Forms.Button();
            this.RightToLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeftList
            // 
            this.LeftList.FormattingEnabled = true;
            this.LeftList.ItemHeight = 12;
            this.LeftList.Location = new System.Drawing.Point(12, 58);
            this.LeftList.Name = "LeftList";
            this.LeftList.Size = new System.Drawing.Size(260, 208);
            this.LeftList.TabIndex = 0;
            this.LeftList.SelectedIndexChanged += new System.EventHandler(this.LeftList_SelectedIndexChanged);
            // 
            // but_AddLeft
            // 
            this.but_AddLeft.Location = new System.Drawing.Point(139, 321);
            this.but_AddLeft.Name = "but_AddLeft";
            this.but_AddLeft.Size = new System.Drawing.Size(75, 23);
            this.but_AddLeft.TabIndex = 1;
            this.but_AddLeft.Text = "添加";
            this.but_AddLeft.UseVisualStyleBackColor = true;
            this.but_AddLeft.Click += new System.EventHandler(this.but_AddLeft_Click);
            // 
            // LeftAddTxtBox
            // 
            this.LeftAddTxtBox.Location = new System.Drawing.Point(12, 323);
            this.LeftAddTxtBox.Name = "LeftAddTxtBox";
            this.LeftAddTxtBox.Size = new System.Drawing.Size(97, 21);
            this.LeftAddTxtBox.TabIndex = 2;
            // 
            // RightList
            // 
            this.RightList.FormattingEnabled = true;
            this.RightList.ItemHeight = 12;
            this.RightList.Location = new System.Drawing.Point(448, 58);
            this.RightList.Name = "RightList";
            this.RightList.Size = new System.Drawing.Size(271, 208);
            this.RightList.TabIndex = 3;
            this.RightList.SelectedIndexChanged += new System.EventHandler(this.RightList_SelectedIndexChanged);
            // 
            // RightAddTextBox
            // 
            this.RightAddTextBox.Location = new System.Drawing.Point(448, 322);
            this.RightAddTextBox.Name = "RightAddTextBox";
            this.RightAddTextBox.Size = new System.Drawing.Size(100, 21);
            this.RightAddTextBox.TabIndex = 4;
            // 
            // but_AddRight
            // 
            this.but_AddRight.Location = new System.Drawing.Point(604, 323);
            this.but_AddRight.Name = "but_AddRight";
            this.but_AddRight.Size = new System.Drawing.Size(75, 23);
            this.but_AddRight.TabIndex = 5;
            this.but_AddRight.Text = "添加";
            this.but_AddRight.UseVisualStyleBackColor = true;
            this.but_AddRight.Click += new System.EventHandler(this.but_AddRight_Click);
            // 
            // LeftToRight
            // 
            this.LeftToRight.Location = new System.Drawing.Point(312, 103);
            this.LeftToRight.Name = "LeftToRight";
            this.LeftToRight.Size = new System.Drawing.Size(75, 23);
            this.LeftToRight.TabIndex = 6;
            this.LeftToRight.Text = ">>>";
            this.LeftToRight.UseVisualStyleBackColor = true;
            this.LeftToRight.Click += new System.EventHandler(this.LeftToRight_Click);
            // 
            // RightToLeft
            // 
            this.RightToLeft.Location = new System.Drawing.Point(312, 181);
            this.RightToLeft.Name = "RightToLeft";
            this.RightToLeft.Size = new System.Drawing.Size(75, 23);
            this.RightToLeft.TabIndex = 7;
            this.RightToLeft.Text = "<<<";
            this.RightToLeft.UseVisualStyleBackColor = true;
            this.RightToLeft.Click += new System.EventHandler(this.RightToLeft_Click);
            // 
            // TestListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RightToLeft);
            this.Controls.Add(this.LeftToRight);
            this.Controls.Add(this.but_AddRight);
            this.Controls.Add(this.RightAddTextBox);
            this.Controls.Add(this.RightList);
            this.Controls.Add(this.LeftAddTxtBox);
            this.Controls.Add(this.but_AddLeft);
            this.Controls.Add(this.LeftList);
            this.Name = "TestListBox";
            this.Text = "TestListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LeftList;
        private System.Windows.Forms.Button but_AddLeft;
        private System.Windows.Forms.TextBox LeftAddTxtBox;
        private System.Windows.Forms.ListBox RightList;
        private System.Windows.Forms.TextBox RightAddTextBox;
        private System.Windows.Forms.Button but_AddRight;
        private System.Windows.Forms.Button LeftToRight;
        private System.Windows.Forms.Button RightToLeft;
    }
}
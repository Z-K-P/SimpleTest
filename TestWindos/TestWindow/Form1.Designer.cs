namespace TestWindow
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.skinChatRichTextBox1 = new CCWin.SkinControl.SkinChatRichTextBox();
            this.skinChatRichTextBox2 = new CCWin.SkinControl.SkinChatRichTextBox();
            this.skinChatRichTextBox3 = new CCWin.SkinControl.SkinChatRichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // skinChatRichTextBox1
            // 
            this.skinChatRichTextBox1.Location = new System.Drawing.Point(58, 257);
            this.skinChatRichTextBox1.Name = "skinChatRichTextBox1";
            this.skinChatRichTextBox1.SelectControl = null;
            this.skinChatRichTextBox1.SelectControlIndex = 0;
            this.skinChatRichTextBox1.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.skinChatRichTextBox1.Size = new System.Drawing.Size(402, 76);
            this.skinChatRichTextBox1.TabIndex = 1;
            this.skinChatRichTextBox1.Text = "";
            // 
            // skinChatRichTextBox2
            // 
            this.skinChatRichTextBox2.Location = new System.Drawing.Point(58, 135);
            this.skinChatRichTextBox2.Name = "skinChatRichTextBox2";
            this.skinChatRichTextBox2.SelectControl = null;
            this.skinChatRichTextBox2.SelectControlIndex = 0;
            this.skinChatRichTextBox2.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.skinChatRichTextBox2.Size = new System.Drawing.Size(402, 76);
            this.skinChatRichTextBox2.TabIndex = 2;
            this.skinChatRichTextBox2.Text = "";
            // 
            // skinChatRichTextBox3
            // 
            this.skinChatRichTextBox3.Location = new System.Drawing.Point(358, 22);
            this.skinChatRichTextBox3.Name = "skinChatRichTextBox3";
            this.skinChatRichTextBox3.SelectControl = null;
            this.skinChatRichTextBox3.SelectControlIndex = 0;
            this.skinChatRichTextBox3.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.skinChatRichTextBox3.Size = new System.Drawing.Size(402, 76);
            this.skinChatRichTextBox3.TabIndex = 3;
            this.skinChatRichTextBox3.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skinChatRichTextBox3);
            this.Controls.Add(this.skinChatRichTextBox2);
            this.Controls.Add(this.skinChatRichTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MaximizedBoundsChanged += new System.EventHandler(this.Form1_MaximizedBoundsChanged);
            this.MaximumSizeChanged += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.MinimumSizeChanged += new System.EventHandler(this.Form1_MinimumSizeChanged);
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinChatRichTextBox skinChatRichTextBox1;
        private CCWin.SkinControl.SkinChatRichTextBox skinChatRichTextBox2;
        private CCWin.SkinControl.SkinChatRichTextBox skinChatRichTextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


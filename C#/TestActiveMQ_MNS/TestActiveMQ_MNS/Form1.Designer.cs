namespace TestActiveMQ_MNS
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.but_生产者 = new System.Windows.Forms.Button();
            this.but_消费者1 = new System.Windows.Forms.Button();
            this.but_消费者2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.but_消费者2);
            this.splitContainer1.Panel1.Controls.Add(this.but_消费者1);
            this.splitContainer1.Panel1.Controls.Add(this.but_生产者);
            this.splitContainer1.Size = new System.Drawing.Size(731, 376);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 0;
            // 
            // but_生产者
            // 
            this.but_生产者.Location = new System.Drawing.Point(132, 68);
            this.but_生产者.Name = "but_生产者";
            this.but_生产者.Size = new System.Drawing.Size(75, 23);
            this.but_生产者.TabIndex = 0;
            this.but_生产者.Text = "生产者";
            this.but_生产者.UseVisualStyleBackColor = true;
            this.but_生产者.Click += new System.EventHandler(this.but_生产者_Click);
            // 
            // but_消费者1
            // 
            this.but_消费者1.Location = new System.Drawing.Point(49, 119);
            this.but_消费者1.Name = "but_消费者1";
            this.but_消费者1.Size = new System.Drawing.Size(75, 23);
            this.but_消费者1.TabIndex = 1;
            this.but_消费者1.Text = "消费者1";
            this.but_消费者1.UseVisualStyleBackColor = true;
            this.but_消费者1.Click += new System.EventHandler(this.but_消费者1_Click);
            // 
            // but_消费者2
            // 
            this.but_消费者2.Location = new System.Drawing.Point(208, 119);
            this.but_消费者2.Name = "but_消费者2";
            this.but_消费者2.Size = new System.Drawing.Size(75, 23);
            this.but_消费者2.TabIndex = 2;
            this.but_消费者2.Text = "消费者2";
            this.but_消费者2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 376);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button but_消费者2;
        private System.Windows.Forms.Button but_消费者1;
        private System.Windows.Forms.Button but_生产者;
    }
}


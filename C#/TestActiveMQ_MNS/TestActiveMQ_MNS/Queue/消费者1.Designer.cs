namespace TestActiveMQ_MNS.Queue
{
    partial class 消费者1
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
            this.lab_消息 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_消息
            // 
            this.lab_消息.AutoSize = true;
            this.lab_消息.Location = new System.Drawing.Point(104, 92);
            this.lab_消息.Name = "lab_消息";
            this.lab_消息.Size = new System.Drawing.Size(53, 12);
            this.lab_消息.TabIndex = 0;
            this.lab_消息.Text = "消息内容";
            // 
            // 消费者1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 198);
            this.Controls.Add(this.lab_消息);
            this.Name = "消费者1";
            this.Text = "消费者1";
            this.Load += new System.EventHandler(this.消费者1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_消息;
    }
}
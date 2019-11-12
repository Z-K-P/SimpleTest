namespace TestActiveMQ_MNS.Queue
{
    partial class 生产者1
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
            this.txtBox_消息 = new System.Windows.Forms.TextBox();
            this.but_发送 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "消息状态";
            // 
            // txtBox_消息
            // 
            this.txtBox_消息.Location = new System.Drawing.Point(69, 80);
            this.txtBox_消息.Name = "txtBox_消息";
            this.txtBox_消息.Size = new System.Drawing.Size(168, 21);
            this.txtBox_消息.TabIndex = 1;
            // 
            // but_发送
            // 
            this.but_发送.Location = new System.Drawing.Point(117, 119);
            this.but_发送.Name = "but_发送";
            this.but_发送.Size = new System.Drawing.Size(75, 23);
            this.but_发送.TabIndex = 2;
            this.but_发送.Text = "发送";
            this.but_发送.UseVisualStyleBackColor = true;
            this.but_发送.Click += new System.EventHandler(this.but_发送_Click);
            // 
            // 生产者1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 231);
            this.Controls.Add(this.but_发送);
            this.Controls.Add(this.txtBox_消息);
            this.Controls.Add(this.label1);
            this.Name = "生产者1";
            this.Text = "生产者1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_消息;
        private System.Windows.Forms.Button but_发送;
    }
}
namespace TestSQlServer
{
    partial class DataShow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.but_SELECT = new System.Windows.Forms.Button();
            this.but_DELETE = new System.Windows.Forms.Button();
            this.but_INSERT = new System.Windows.Forms.Button();
            this.but_UPDATE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(1, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(765, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // Column1
            // 
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "选择";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Visible = false;
            // 
            // but_SELECT
            // 
            this.but_SELECT.AllowDrop = true;
            this.but_SELECT.Location = new System.Drawing.Point(79, 368);
            this.but_SELECT.Name = "but_SELECT";
            this.but_SELECT.Size = new System.Drawing.Size(75, 23);
            this.but_SELECT.TabIndex = 1;
            this.but_SELECT.Text = "查询";
            this.but_SELECT.UseVisualStyleBackColor = true;
            this.but_SELECT.Click += new System.EventHandler(this.but_SELECT_Click);
            // 
            // but_DELETE
            // 
            this.but_DELETE.Location = new System.Drawing.Point(237, 368);
            this.but_DELETE.Name = "but_DELETE";
            this.but_DELETE.Size = new System.Drawing.Size(75, 23);
            this.but_DELETE.TabIndex = 2;
            this.but_DELETE.Text = "删除";
            this.but_DELETE.UseVisualStyleBackColor = true;
            this.but_DELETE.Click += new System.EventHandler(this.but_DELETE_Click);
            // 
            // but_INSERT
            // 
            this.but_INSERT.Location = new System.Drawing.Point(394, 368);
            this.but_INSERT.Name = "but_INSERT";
            this.but_INSERT.Size = new System.Drawing.Size(75, 23);
            this.but_INSERT.TabIndex = 3;
            this.but_INSERT.Text = "添加";
            this.but_INSERT.UseVisualStyleBackColor = true;
            this.but_INSERT.Click += new System.EventHandler(this.but_INSERT_Click);
            // 
            // but_UPDATE
            // 
            this.but_UPDATE.Location = new System.Drawing.Point(539, 368);
            this.but_UPDATE.Name = "but_UPDATE";
            this.but_UPDATE.Size = new System.Drawing.Size(75, 23);
            this.but_UPDATE.TabIndex = 4;
            this.but_UPDATE.Text = "修改";
            this.but_UPDATE.UseVisualStyleBackColor = true;
            this.but_UPDATE.Click += new System.EventHandler(this.but_UPDATE_Click);
            // 
            // DataShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 443);
            this.Controls.Add(this.but_UPDATE);
            this.Controls.Add(this.but_INSERT);
            this.Controls.Add(this.but_DELETE);
            this.Controls.Add(this.but_SELECT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataShowVie";
            this.Load += new System.EventHandler(this.DataShowVie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button but_SELECT;
        private System.Windows.Forms.Button but_DELETE;
        private System.Windows.Forms.Button but_INSERT;
        private System.Windows.Forms.Button but_UPDATE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
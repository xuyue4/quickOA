namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxReportNo = new System.Windows.Forms.TextBox();
            this.labelReportNo = new System.Windows.Forms.Label();
            this.textBoxProductCorp = new System.Windows.Forms.TextBox();
            this.labelProductCorp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "生成报告";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxReportNo
            // 
            this.textBoxReportNo.Location = new System.Drawing.Point(85, 24);
            this.textBoxReportNo.Name = "textBoxReportNo";
            this.textBoxReportNo.Size = new System.Drawing.Size(193, 25);
            this.textBoxReportNo.TabIndex = 2;
            // 
            // labelReportNo
            // 
            this.labelReportNo.AutoSize = true;
            this.labelReportNo.Location = new System.Drawing.Point(12, 27);
            this.labelReportNo.Name = "labelReportNo";
            this.labelReportNo.Size = new System.Drawing.Size(67, 15);
            this.labelReportNo.TabIndex = 3;
            this.labelReportNo.Text = "报告编号";
            // 
            // textBoxProductCorp
            // 
            this.textBoxProductCorp.Location = new System.Drawing.Point(85, 55);
            this.textBoxProductCorp.Name = "textBoxProductCorp";
            this.textBoxProductCorp.Size = new System.Drawing.Size(193, 25);
            this.textBoxProductCorp.TabIndex = 4;
            // 
            // labelProductCorp
            // 
            this.labelProductCorp.AutoSize = true;
            this.labelProductCorp.Location = new System.Drawing.Point(12, 58);
            this.labelProductCorp.Name = "labelProductCorp";
            this.labelProductCorp.Size = new System.Drawing.Size(67, 15);
            this.labelProductCorp.TabIndex = 5;
            this.labelProductCorp.Text = "生产单位";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 336);
            this.Controls.Add(this.labelProductCorp);
            this.Controls.Add(this.textBoxProductCorp);
            this.Controls.Add(this.labelReportNo);
            this.Controls.Add(this.textBoxReportNo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxReportNo;
        private System.Windows.Forms.Label labelReportNo;
        private System.Windows.Forms.TextBox textBoxProductCorp;
        private System.Windows.Forms.Label labelProductCorp;
    }
}


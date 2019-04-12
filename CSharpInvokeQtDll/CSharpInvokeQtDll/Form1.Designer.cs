namespace CSharpInvokeQtDll
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
            this.btnShowQtCtrl = new System.Windows.Forms.Button();
            this.pnlQtCtrl = new System.Windows.Forms.Panel();
            this.btnShowWind = new System.Windows.Forms.Button();
            this.pnlQtWind = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnShowQtCtrl
            // 
            this.btnShowQtCtrl.Location = new System.Drawing.Point(12, 334);
            this.btnShowQtCtrl.Name = "btnShowQtCtrl";
            this.btnShowQtCtrl.Size = new System.Drawing.Size(75, 23);
            this.btnShowQtCtrl.TabIndex = 0;
            this.btnShowQtCtrl.Text = "显示Qt弹窗";
            this.btnShowQtCtrl.UseVisualStyleBackColor = true;
            this.btnShowQtCtrl.Click += new System.EventHandler(this.btnShowQtCtrl_Click);
            // 
            // pnlQtCtrl
            // 
            this.pnlQtCtrl.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlQtCtrl.Location = new System.Drawing.Point(12, 12);
            this.pnlQtCtrl.Name = "pnlQtCtrl";
            this.pnlQtCtrl.Size = new System.Drawing.Size(331, 288);
            this.pnlQtCtrl.TabIndex = 1;
            // 
            // btnShowWind
            // 
            this.btnShowWind.Location = new System.Drawing.Point(396, 334);
            this.btnShowWind.Name = "btnShowWind";
            this.btnShowWind.Size = new System.Drawing.Size(75, 23);
            this.btnShowWind.TabIndex = 2;
            this.btnShowWind.Text = "显示Qt表格";
            this.btnShowWind.UseVisualStyleBackColor = true;
            this.btnShowWind.Click += new System.EventHandler(this.btnShowWind_Click);
            // 
            // pnlQtWind
            // 
            this.pnlQtWind.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlQtWind.Location = new System.Drawing.Point(370, 12);
            this.pnlQtWind.Name = "pnlQtWind";
            this.pnlQtWind.Size = new System.Drawing.Size(331, 288);
            this.pnlQtWind.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 373);
            this.Controls.Add(this.pnlQtWind);
            this.Controls.Add(this.btnShowWind);
            this.Controls.Add(this.pnlQtCtrl);
            this.Controls.Add(this.btnShowQtCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowQtCtrl;
        private System.Windows.Forms.Panel pnlQtCtrl;
        private System.Windows.Forms.Button btnShowWind;
        private System.Windows.Forms.Panel pnlQtWind;
    }
}


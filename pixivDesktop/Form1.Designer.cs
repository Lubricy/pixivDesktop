namespace pixivDesktop
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_toPixiv = new System.Windows.Forms.Button();
            this.pixivBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btn_toPixiv
            // 
            this.btn_toPixiv.Location = new System.Drawing.Point(30, 12);
            this.btn_toPixiv.Name = "btn_toPixiv";
            this.btn_toPixiv.Size = new System.Drawing.Size(75, 23);
            this.btn_toPixiv.TabIndex = 0;
            this.btn_toPixiv.Text = "Start";
            this.btn_toPixiv.UseVisualStyleBackColor = true;
            this.btn_toPixiv.Click += new System.EventHandler(this.btn_toPixiv_Click);
            // 
            // pixivBrowser
            // 
            this.pixivBrowser.Location = new System.Drawing.Point(30, 52);
            this.pixivBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.pixivBrowser.Name = "pixivBrowser";
            this.pixivBrowser.Size = new System.Drawing.Size(2030, 900);
            this.pixivBrowser.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 135);
            this.Controls.Add(this.pixivBrowser);
            this.Controls.Add(this.btn_toPixiv);
            this.Name = "Form1";
            this.Text = "桌面修改器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_toPixiv;
        private System.Windows.Forms.WebBrowser pixivBrowser;

    }
}


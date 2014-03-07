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
            this.btn_SetAsDesk = new System.Windows.Forms.Button();
            this.label_Statement = new System.Windows.Forms.Label();
            this.text_Statement = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_toPixiv
            // 
            this.btn_toPixiv.Location = new System.Drawing.Point(30, 30);
            this.btn_toPixiv.Name = "btn_toPixiv";
            this.btn_toPixiv.Size = new System.Drawing.Size(75, 25);
            this.btn_toPixiv.TabIndex = 0;
            this.btn_toPixiv.Text = "生成图片";
            this.btn_toPixiv.UseVisualStyleBackColor = true;
            this.btn_toPixiv.Click += new System.EventHandler(this.btn_toPixiv_Click);
            // 
            // pixivBrowser
            // 
            this.pixivBrowser.Location = new System.Drawing.Point(173, 164);
            this.pixivBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.pixivBrowser.Name = "pixivBrowser";
            this.pixivBrowser.Size = new System.Drawing.Size(2030, 900);
            this.pixivBrowser.TabIndex = 1;
            // 
            // btn_SetAsDesk
            // 
            this.btn_SetAsDesk.Enabled = false;
            this.btn_SetAsDesk.Location = new System.Drawing.Point(135, 30);
            this.btn_SetAsDesk.Name = "btn_SetAsDesk";
            this.btn_SetAsDesk.Size = new System.Drawing.Size(75, 25);
            this.btn_SetAsDesk.TabIndex = 2;
            this.btn_SetAsDesk.Text = "设为桌面";
            this.btn_SetAsDesk.UseVisualStyleBackColor = true;
            this.btn_SetAsDesk.Click += new System.EventHandler(this.btn_SetAsDesk_Click);
            // 
            // label_Statement
            // 
            this.label_Statement.AutoSize = true;
            this.label_Statement.Location = new System.Drawing.Point(30, 94);
            this.label_Statement.Name = "label_Statement";
            this.label_Statement.Size = new System.Drawing.Size(29, 12);
            this.label_Statement.TabIndex = 3;
            this.label_Statement.Text = "状态";
            // 
            // text_Statement
            // 
            this.text_Statement.Enabled = false;
            this.text_Statement.Location = new System.Drawing.Point(65, 89);
            this.text_Statement.Name = "text_Statement";
            this.text_Statement.Size = new System.Drawing.Size(145, 60);
            this.text_Statement.TabIndex = 4;
            this.text_Statement.Text = "请点击\"生成图片\"按钮";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.text_Statement);
            this.Controls.Add(this.label_Statement);
            this.Controls.Add(this.btn_SetAsDesk);
            this.Controls.Add(this.pixivBrowser);
            this.Controls.Add(this.btn_toPixiv);
            this.Name = "Form1";
            this.Text = "桌面修改器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_toPixiv;
        private System.Windows.Forms.WebBrowser pixivBrowser;
        private System.Windows.Forms.Button btn_SetAsDesk;
        private System.Windows.Forms.Label label_Statement;
        private System.Windows.Forms.RichTextBox text_Statement;

    }
}


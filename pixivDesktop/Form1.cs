using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixivDesktop
{
    public partial class Form1 : Form
    {
        String fileNameStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        // 执行JS，修正排版
        private void execJs() 
        {
            string jsStr = "";
            jsStr = jsStr +
                "function desktopView() {" +
                "var leftNode = document.getElementsByClassName('introduction-container')[0]; " +
                "leftNode.parentNode.removeChild(leftNode);" +
                "var rightNode = document.getElementsByClassName('newindex-bg-container')[0];" +
                "rightNode.style.marginLeft = 0;}";

            // 执行js
            HtmlElement headEl = pixivBrowser.Document.GetElementsByTagName("head")[0];
            HtmlElement scriptEl = pixivBrowser.Document.CreateElement("script");
            scriptEl.InnerHtml = jsStr;
            headEl.AppendChild(scriptEl);
            pixivBrowser.Document.InvokeScript("desktopView");
        }

        // 将时间作为文件名，保存图片到Cache文件夹中
        private void saveImg(Bitmap desktopImg) 
        {
            // 生成文件名
            fileNameStr = DateTime.Now.ToString("yyyyMMddhhmmss");

            // 不存在则创建
            if (!System.IO.Directory.Exists("Cache"))
            {
                System.IO.Directory.CreateDirectory("Cache");
            }

            desktopImg.Save(@"Cache\" + fileNameStr + ".bmp");
        }

        // 网站加载完成之后执行的方法
        private void pixivBrowser_DecumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // 执行js
            execJs();

            // 修改状态
            text_Statement.Text = "网页加载完成，等待生成截图...";

            // 截图
            Bitmap desktopImg = new Bitmap(1600, 900);
            pixivBrowser.DrawToBitmap(desktopImg, new Rectangle(0, 0, 1600, 900));

            // 保存截图并修改状态
            try
            {
                saveImg(desktopImg);
                text_Statement.Text = "截图成功";
                btn_SetAsDesk.Enabled = true;
            }
            catch
            {
                text_Statement.Text = "截图失败...文件夹没有读写的权限...";
            }
        }

        // 按下"生成图片"按钮，保存图片
        private void btn_toPixiv_Click(object sender, EventArgs e)
        {
            // 将事件绑定
            pixivBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(pixivBrowser_DecumentCompleted);

            // 修改状态
            text_Statement.Text = "正在加载网页...";

            // 打开Pixiv
            pixivBrowser.Url = new Uri("http://www.pixiv.net/");
        }

        // 按下"设置桌面"按钮，将图片设置为桌面
        private void btn_SetAsDesk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能完善中...");
        }
    }
}

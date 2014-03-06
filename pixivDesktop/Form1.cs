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
        int brCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // 用于控制计数器判断网页是否加载完成的方法
        private void pixivBrowser_DecumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string jsStr = "";
            jsStr = jsStr +
                "function desktopView() {" + 
                "var leftNode = document.getElementsByClassName('introduction-container')[0]; " +
                "leftNode.parentNode.removeChild(leftNode);" +
                "var rightNode = document.getElementsByClassName('newindex-bg-container')[0];" +
                "rightNode.style.marginLeft = 0;}";

            //jsStr = "function desktopView() {document.write('123');}";
            
            // 执行js
            HtmlElement headEl = pixivBrowser.Document.GetElementsByTagName("head")[0];
            HtmlElement scriptEl = pixivBrowser.Document.CreateElement("script");
            scriptEl.InnerHtml = jsStr;
            headEl.AppendChild(scriptEl);
            pixivBrowser.Document.InvokeScript("desktopView");

            // 修改结束
            MessageBox.Show("OK");

            // 截图
            Bitmap desktopImg = new Bitmap(1600, 900);
            pixivBrowser.DrawToBitmap(desktopImg, new Rectangle(0, 0, 1600, 900));
            desktopImg.Save(@"test.bmp");
        }

        private void btn_toPixiv_Click(object sender, EventArgs e)
        {
            // 将事件绑定
            pixivBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(pixivBrowser_DecumentCompleted);

            // 打开Pixiv
            pixivBrowser.Url = new Uri("http://www.pixiv.net/");
        }
    }
}

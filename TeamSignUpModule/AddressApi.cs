using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSignUpModule
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AddressApi : Form
    {
        public string Address = "";

        public AddressApi()
        {
            InitializeComponent();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.Navigate("https://~~webhost.com/");
        }

        private void webView_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            String text = e.WebMessageAsJson.Replace("\"", "");
            Address = text;
            MessageBox.Show(text);
            this.Close();
        }

    }
}

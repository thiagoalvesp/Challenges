using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge_Cap_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            lblResult.Text = await GetContent(txtUrl.Text);
        }

        public static Task<string> GetContent(string Url)
        {
            var request = (HttpWebRequest)WebRequest.Create(@Url);
            var response = (HttpWebResponse)request.GetResponse();
            var reader = new StreamReader(response.GetResponseStream());
            return reader.ReadToEndAsync();
        }

        private void btnDownloadNormal_Click(object sender, EventArgs e)
        {
            var request = (HttpWebRequest)WebRequest.Create(@txtUrl.Text);
            var response = (HttpWebResponse)request.GetResponse();
            var reader = new StreamReader(response.GetResponseStream());
            lblResult.Text = reader.ReadToEnd();
        }
    }
}

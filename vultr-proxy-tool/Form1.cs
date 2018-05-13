using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace vultr_proxy_tool
{
    public partial class Form1 : Form
    {
        List<ProxyTask> tasks = new List<ProxyTask>();
        public Form1()
        {
            InitializeComponent();
        }

        public async void AddIPs()
        {
            ProxyTask proxyTask = new ProxyTask(txtAPIKey.Text, "");
            await proxyTask.GetIPs();
            foreach (string IP in proxyTask.IPList)
            {
                rtxtLog.Text += "\n" + IP + ":3128:valyr:snivynGOD";
            }
            rtxtLog.Text += "\nAll proxies loaded.";
        }

        private async void btnCreateProxies_Click(object sender, EventArgs e)
        {
            rtxtLog.Text += "\nWorking...";
            var checkedButton = grpLocation.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            for (int i = 1; i < 6; i++)
            {
                rtxtLog.Text += "\nAttempting to create proxy " + i.ToString() + " of 5.";
                ProxyTask proxyTask = new ProxyTask(txtAPIKey.Text, checkedButton.Tag.ToString());
                await proxyTask.Start();
                tasks.Add(proxyTask);
            }

            rtxtLog.Text += "\nAll proxies have been created. They should be ready to go in a few minutes.";

            try
            {
                AddIPs();
            }
            catch
            {
                rtxtLog.Text += "\nAn error occurred while trying to retrieve servers. Please double check your API key.";
            }
        }

        private void btnLoadProxies_Click(object sender, EventArgs e)
        {
            rtxtLog.Text += "\nLoading proxies...";
            if(txtAPIKey.Text == "")
            {
                rtxtLog.Text += "\nPlease provide an API key.";
            }
            else
            {
                try
                {
                    AddIPs();
                }
                catch
                {
                    rtxtLog.Text += "\nAn error occurred while trying to retrieve servers. Please double check your API key.";
                }
            }
        }

        private void lnkDocs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/SKBvzXdc");
        }
    }
}

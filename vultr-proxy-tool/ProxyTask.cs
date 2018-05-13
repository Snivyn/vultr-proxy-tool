using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace vultr_proxy_tool
{
    class ProxyTask
    {
        HttpClient client = new HttpClient();
        string api, locale, status;
        List<string> ipList = new List<string>();
        public ProxyTask(string inAPI, string inLocale)
        {
            api = inAPI;
            locale = inLocale;
            status = "Waiting...";
            client.DefaultRequestHeaders.Add("API-Key", api);
        }
        public string Status { get { return status; } set { status = value; } }
        public List<string> IPList { get { return ipList; } set { ipList = value; } }

        public async Task CreateProxy()
        {
            for (int i = 1; i < 11; i++)
            {
                status = "Creating proxy...";
                string downloadStr, result;
                // Submit payment info
                using (HttpResponseMessage response = await client.GetAsync("https://api.vultr.com/v1/startupscript/list"))
                {
                    downloadStr = await response.Content.ReadAsStringAsync();
                    result = downloadStr.Substring(2, 6);
                    Thread.Sleep(500);
                }

                // Initialize data to be submitted
                Dictionary<string, string> createInfo = new Dictionary<string, string>();
                createInfo.Add("DCID", locale);
                createInfo.Add("VPSPLANID", "201");
                createInfo.Add("OSID", "160");
                createInfo.Add("SCRIPTID", result);
                createInfo.Add("SUBID", "test");

                FormUrlEncodedContent payload = new FormUrlEncodedContent(createInfo);

                // Create proxy
                HttpResponseMessage response2 = await client.PostAsync("https://api.vultr.com/v1/server/create", payload);
                Thread.Sleep(500);
                status = "Created proxy.";

                // Get proxy IP
                HttpResponseMessage response3 = await client.GetAsync("https://api.vultr.com/v1/server/list");
                Thread.Sleep(500);
                string rawServerList = await response3.Content.ReadAsStringAsync();
                dynamic serverData = JsonConvert.DeserializeObject<dynamic>(rawServerList);

                foreach (var obj in serverData)
                {
                    ipList.Add(obj.gateway_v4);
                }
            }
        }
        public async Task AddStartupScript()
        {
            status = "Adding startup script...";
            string result = "";
            using (StreamReader read = new StreamReader("C:\\Users\\Snivyn\\Desktop\\vultrDeploy-master\\startup.txt"))
            {
                result = read.ReadToEnd();
            }

            // Initialize data to be submitted
            Dictionary<string, string> scriptInfo = new Dictionary<string, string>();
            scriptInfo.Add("name", "script");
            scriptInfo.Add("script", result);

            FormUrlEncodedContent payload = new FormUrlEncodedContent(scriptInfo);

            // Add startup script to the account
            HttpResponseMessage response = await client.PostAsync("https://api.vultr.com/v1/startupscript/create", payload);
            status = "Added startup script.";
            Thread.Sleep(500);
        }

        public async Task Start()
        {
            try
            {
                await AddStartupScript();
            }
            catch { }

            try
            {
                await CreateProxy();
            }
            catch { }

            try
            {
                await GetIPs();
            }
            catch { }
        }

        public async Task GetIPs()
        {
            // Get proxy IP
            HttpResponseMessage response = await client.GetAsync("https://api.vultr.com/v1/server/list");
            Thread.Sleep(500);
            string rawServerList = await response.Content.ReadAsStringAsync();
            JObject serverData = JObject.Parse(rawServerList);
            ipList.Clear();

            foreach (var item in serverData)
            {
                ipList.Add(item.Value["main_ip"].ToString());
            }
        }
    }
}

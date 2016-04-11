using Newtonsoft.Json;
using System;
using System.IO;

namespace MyTestApp
{
    class Config
    {
        private static Config instance = null;
        private Config() { }

        public static Config Instance
        {
            get
            {
                if (instance == null)
                {
                    var configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ringcentral-config.json");
                    using (var sr = new StreamReader(configPath))
                    {
                        var jsonData = sr.ReadToEnd();
                        instance = JsonConvert.DeserializeObject<Config>(jsonData);
                    }
                }
                return instance;
            }
        }

        [JsonProperty("appKey")]
        public string AppKey;

        [JsonProperty("appSecret")]
        public string AppSecret;

        [JsonProperty("server")]
        public string Server;

        [JsonProperty("usernmae")]
        public string Username;

        [JsonProperty("password")]
        public string Password;

        [JsonProperty("receiver")]
        public string Receiver;

        public string ServerUrl
        {
            get
            {
                return "server url";
            }
        }

        public override string ToString()
        {
            return string.Format(@"app key: {0}
app secret: {1}
server: {2}
username: {3}
password: {4}
receiver: {5}
server url: {6}
", AppKey, AppSecret, Server, Username, Password, Receiver, ServerUrl);
        }
    }
}

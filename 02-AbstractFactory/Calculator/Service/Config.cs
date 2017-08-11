namespace AbstractFactory.Calculator.Service
{
    using System.IO;
    using Newtonsoft.Json;
    public sealed class ConfigManager
    {
        static ConfigManager(){
            ServiceConfig = JsonConvert.DeserializeObject<Config>(File.ReadAllText("serviceconfig.json"));
        }
        public static Config ServiceConfig { get; }
    }

    public class Config{

        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }

        [JsonProperty("assemblyName")]
        public string AssemblyName { get; set; }
    }
}

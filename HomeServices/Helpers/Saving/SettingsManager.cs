using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeServices;

namespace HomeServices
{
    public static class SettingsManager // Code by Toshi
    {
        private static string datapath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HomeServices");
        private static string jsonpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HomeServices", "settings.json");
        private static SettingsModel settings = null;
        public static void Save(this SettingsModel model)
        {
            if (!Directory.Exists(datapath))
            {
                Directory.CreateDirectory(datapath);
            }
	        settings = model;
            var json = JsonConvert.SerializeObject(model, Formatting.Indented);
            File.WriteAllText(jsonpath, json);
        }
        public static SettingsModel Load()
        {
            if(settings != null)
            {
                return settings;
            }
            if (!Directory.Exists(datapath))
            {
                Directory.CreateDirectory(datapath);
            }
            if (!File.Exists(jsonpath))
            {
                var model = new SettingsModel();
                model.Save();
            }
            var json = File.ReadAllText(jsonpath);
            var settingsmodel = JsonConvert.DeserializeObject<SettingsModel>(json);
            settings = settingsmodel;
            return settingsmodel;
        }
    }
}

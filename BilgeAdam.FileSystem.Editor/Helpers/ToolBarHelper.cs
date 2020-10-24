using BilgeAdam.FileSystem.Editor.Models;
using Newtonsoft.Json;
using System.IO;

namespace BilgeAdam.FileSystem.Editor.Helpers
{
    static class ToolBarHelper
    {
        public static Settings GetSettings()
        {
            var json = File.ReadAllText(PathContants.TOLLBAR_SETTINGS);
            return JsonConvert.DeserializeObject<Settings>(json);
        }

        public static void SetSettings(Settings settings)
        {
            File.WriteAllText(PathContants.TOLLBAR_SETTINGS, JsonConvert.SerializeObject(settings));
        }
    }
}

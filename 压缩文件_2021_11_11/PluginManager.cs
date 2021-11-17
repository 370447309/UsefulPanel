using Negative.Common.ExtensionMethods;
using Negative.Common.Plugin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace NegativeScreen
{
    internal class PluginManager
    {
        private static PluginManager _instance;

        private PluginManager()
        {
            //LoadPlugin(Path.Combine(App.AppPath))
            LoadPlugin(@"D:/Project/C#/NegativeScreen/Negative.Plugin/Negative.Plugin.CommonComponent/obj/x64/Debug");
        }

        internal List<IViewer> LoadedPlugins { get; private set; } = new List<IViewer>();

        internal static PluginManager GetInstance()
        {
            return _instance ?? (_instance = new PluginManager());
        }

        private async void LoadPlugin(string folder)
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.ComputerFolder;
            picker.FileTypeFilter.Add(".dll");
            var files = await picker.PickMultipleFilesAsync();

            (from t in Assembly.LoadFrom(files[0].Path).GetExportedTypes()
             where !t.IsInterface && !t.IsAbstract
             where typeof(IViewer).IsAssignableFrom(t)
             select t).ToList()
                .ForEach(type => LoadedPlugins.Add(type.CreateInstance<IViewer>()));
            
            return;

            if (!Directory.Exists(folder))
                return;

            Directory.GetFiles(folder, "Negative.Plugin.*.dll",
                SearchOption.AllDirectories)
                .ToList()
                .ForEach(
                    lib =>
                    {
                        (from t in Assembly.LoadFrom(lib).GetExportedTypes()
                         where !t.IsInterface && !t.IsAbstract
                         where typeof(IViewer).IsAssignableFrom(t)
                         select t).ToList()
                        .ForEach(type => LoadedPlugins.Add(type.CreateInstance<IViewer>()));
                    });
        }
    }
}

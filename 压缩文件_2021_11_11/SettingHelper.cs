using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml;

namespace Negative.Common.Helpers
{
    public class SettingHelper
    {
        public static readonly string LocalDataPath =
            IsPortableVersion() ?
            Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "",
                @"UserData\") :
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                @"pooi.moe\NegativeScreen\");

        private static readonly Dictionary<String, XmlDocument> FileCache = new Dictionary<string, XmlDocument>();


        public static bool IsPortableVersion()
        {
            var lck = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "",
                "portable.lock");

            return File.Exists(lck);
        }
    }
}

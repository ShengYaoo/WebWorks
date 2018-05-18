using System;
using System.IO;

namespace mLibrary.Shared
{
    public class SharedDB
    {
        public static string GetDataPath()
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relative = @"App_Data\";
            if (baseDirectory.Contains("bin"))
                relative = @"..\..\App_Data\";


            string absolute = Path.GetFullPath(Path.Combine(baseDirectory, relative));
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);
            return absolute;
        }
    }
}
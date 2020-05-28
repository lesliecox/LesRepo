using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree.Classes
{
    public class RootClass
    {
        public string FullPath;
        public object Type;  

        public RootClass()
        {

        }
        public enum Items
        {
            File,
            Folder,
            Drive
        }

        public static List<Items> GetLogicalDrives()
        {
            var FullPath = "null";
            var Type = "null";

            return Directory.GetLogicalDrives().Select(Drive => new Items {FullPath = Drive, Type = Items.Drive }).ToList();

        }






        public static string GetFileFolderName(string path)
        {
            if (string.IsNullOrEmpty(path))
                return string.Empty;

            var normalizedPath = path.Replace('/', '\\');
            var lastIndex = normalizedPath.LastIndexOf('\\');
            if (lastIndex <= 0)
                return path;
            return path.Substring(lastIndex + 1);

        }


    }

}       

        


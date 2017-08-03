using System;
using System.IO;
namespace Loyals.DataBase
{
    public class FileAccessHelper
    {
        public FileAccessHelper()
        {
        }
#if __ANDROID__
        public static string GetLocalFilePath(string filename)
        {
            string myPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return System.IO.Path.Combine(myPath, filename);
        }




          public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }




#endif

#if __IOS__
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, filename);
        }
    }
}


#endif

    }

}





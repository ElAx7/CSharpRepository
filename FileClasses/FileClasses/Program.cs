using System.IO;

namespace FileClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\something.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

            //------------------------------------------------------------//

            //Directory & DirectoryInfoClasses

            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\projects\FileClasses", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(files);
        }
    }
}


using System;
using System.Diagnostics;
using System.IO;

namespace UnZipFile
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo d = new DirectoryInfo(@"R:\");

            FileInfo[] Files = d.GetFiles("*.zip"); //Getting zip files
            string str = "";

            foreach (FileInfo file in Files)
            {
                if (file.Name.StartsWith("1") || file.Name.StartsWith("9"))
                {
                    using (
                        var process = new Process())
                    {
                        Console.WriteLine(file.FullName);
                        process.StartInfo.FileName = @"C:\Program Files\7-Zip\7zG.exe"; // relative path. absolute path works too.
                        process.StartInfo.Arguments = $" x " + file.FullName+ @" -mcp=936  -oR:\Test";
                        //process.StartInfo.FileName = @"cmd.exe";
                        //process.StartInfo.Arguments = @"/c dir";      // print the current working directory information
                        process.StartInfo.CreateNoWindow = true;
                        process.StartInfo.UseShellExecute = false;

                        process.Start();
                    }
                }
            }
        }
    }
}

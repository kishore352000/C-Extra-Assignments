using System;
using System.IO;

namespace Swap_Files_project
{
   
        internal class Program
        {
            static void Main(string[] args)
            {

                string path = "C:\\Users\\kishore.lakkireddy\\OneDrive - Entain Group\\FolderFirst";
                Directory.CreateDirectory(path);
                FileStream fs = new FileStream(path + "\\file1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("Hello Everyone,\n This is File1 Contents");
                sw.Close();
                fs.Close();
                path = "C:\\Users\\kishore.lakkireddy\\OneDrive - Entain Group\\FolderSecond";
                Directory.CreateDirectory(path);
                fs = new FileStream(path + "\\file2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                sw = new StreamWriter(fs);
                sw.WriteLine("Hello Everyone,\n This is File2 Contents");
                sw.Close();
                fs.Close();
                File.Move("C:\\Users\\kishore.lakkireddy\\OneDrive - Entain Group\\FolderFirst\\file1.txt", "C:\\Users\\kishore.lakkireddy\\OneDrive - Entain Group\\FolderSecond\\file1.txt");
                File.Delete("C:\\Users\\kishore.lakkireddy\\OneDrive - Entain Group\\FolderFirst\\file1.txt");
                File.Move("C:\\Users\\kishore.lakkireddy\\OneDrive - Entain Group\\FolderSecond\\file2.txt", "C:\\Users\\kishore.lakkireddy\\OneDrive - Entain Group\\FolderFirst\\file2.txt");
                File.Delete("C:\\Users\\kishore.lakkireddy\\OneDrive - Entain Group\\FolderSecond\\file2.txt");

            }
        }
    }


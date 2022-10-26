using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Read_Files_Project
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string files1 = "C:\\Users\\kishore.lakkireddy\\OneDrive - Entain Group\\files1.txt";
            Console.WriteLine(File.ReadAllText(files1));
            string files2 = "C:\\Users\\kishore.lakkireddy\\OneDrive - Entain Group\\files2.txt";
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine(File.ReadAllText(files2));
            });
        }
    }
}

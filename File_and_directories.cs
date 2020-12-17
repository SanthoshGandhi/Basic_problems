using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files_and__Directories1
{
    class Program
    {
        static void Main(string[] args)
        {
                string path = "D:\\sample\\";

            //File in a diectory
            Console.WriteLine(getFilesInDirectory(path));

            //copy files-overWrite if exists
            FileInfo f = new FileInfo(path + "Input.txt");
            f.CopyTo(path + "NewInput.txt", true);
            Console.WriteLine("copy Successfull");

            //rename files
            FileInfo fnew = new FileInfo(path + "NewInput.txt");
            f.MoveTo(path + "renamedNewInput.txt");
            Console.WriteLine("Rename Successfull");

        }
        private static string getFilesInDirectory(string path)
        {
            string FileDetails = "";
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                FileDetails += file.Name + "\t" + file.Length + "byte \t" + file.CreationTime + "\n";
            }
            return FileDetails;
        }
        
    }
}

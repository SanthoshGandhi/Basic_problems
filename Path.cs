using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Path1
{
    class Program
    {
        static void Main(string[] args)
        {
            //using path.combine-combines string to from a path or combaines two
            //ewxisting path
            string drive = "D:\\";
            string directory = "sample\\";
            string filename = "Input.txt";

            string path = Path.Combine(drive, directory, filename);
            Console.WriteLine(path);

            //change path extension
            path = Path.ChangeExtension(path, "jpg");
            Console.WriteLine(path);

            //Get directory Name
            string dirName = Path.GetDirectoryName(path);
            Console.WriteLine(dirName);

            //Get File Extension
            String ext = Path.GetExtension(path);
            Console.WriteLine(ext);

            //Get File Name
            string FileName = Path.GetFileName(path);
            Console.WriteLine(FileName);

            //get filename without extension
            string filenoext = Path.GetFileNameWithoutExtension(path);
            Console.WriteLine(filenoext);

            //check if file has extension
            bool hasextension = Path.HasExtension(path);
            Console.WriteLine(hasextension);

            //other methods
            char[] invalidchars = Path.GetInvalidFileNameChars();
            Console.WriteLine(invalidchars);

            Console.WriteLine("\nrandom file name. ");
            string randompath = Path.GetRandomFileName();
            Console.WriteLine(randompath);

            //string temfolderpath = Path.GetTempPath();
            //Console.WriteLine(temfolderpath);

            ////create subdir in temp folder
            //Directory.CreateDirectory(temfolderpath + "\\samplesubdir");
            //bool checkdir = Directory.Exists(temfolderpath + "\\samplesubdir");
            //Console.WriteLine("the temp folder "+checkdir);
            
            ////create a file int he new directory in temp folder
            //File.WriteAllText(temfolderpath + "\\samplesubddir" + "\\output.txt", "sample text from program");
            //Console.WriteLine("writing to file successfull");

            ////Get temp filename
            //string tempfile = Path.GetTempFileName();

            ////Writinng to temp file.
            //File.WriteAllText(tempfile, "sample text for tempfile");
            //Console.WriteLine("successfull");

        }
    }
}

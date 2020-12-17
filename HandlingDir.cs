using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handling_dir1
{
    class HandlingDir
    {
        static void Main(string[] args)
        {
            string path = "D:\\MysampleDir";
            
            //creat Directory
            createdirectory(path);

            //create subdirectories
            DirectoryInfo dir = new DirectoryInfo(path);
            createsubdirectory(dir);

            //get subdirectories
            string allsubdir = getsubdirectories(dir);
            Console.WriteLine(allsubdir);

            //delete Directories
            Directory.Delete("D:\\mysampleDir\\sampleSubDir3");

            //check for Directory Existence
            Console.WriteLine(path + "-Existence :" + Directory.Exists(path));

            //Move Directory
            DirectoryInfo dirnew = new DirectoryInfo(path);
            dir.MoveTo("D:\\mysampleDirRenamed\\");

            //check for Directory Existance
            Console.WriteLine(path + "-existance :" + Directory.Exists(path));

            
        }
        private static void createsubdirectory(DirectoryInfo dir)
        {
            dir.CreateSubdirectory("SampleSubDir1");
            dir.CreateSubdirectory("SampleSubDir2");
            dir.CreateSubdirectory("SampleSubDir3");
        }
        private static void createdirectory(string path)
        {
            Directory.CreateDirectory(path);
        }
        private static string getsubdirectories(DirectoryInfo dir)
        {
            string allsubDir = "";
            DirectoryInfo[] subdirs = dir.GetDirectories();
            
            //foreach-Iterate over a collection.
            //Drawbacks
            //No Counter
            //readonly-Immutable
            //uni directional-forward only.
            foreach (DirectoryInfo d in subdirs)
            {
                allsubDir += d.Name + "\n";
            }
            return allsubDir;
        }
    }
}

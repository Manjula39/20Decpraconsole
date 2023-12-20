using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Decpraconsole
{
    public class workingwithfiles
    {
        public static void WriteAndReadFile()
        { // create a file with streamwrite
            StreamWriter writer = new StreamWriter(@"D:\mphasis\Dec20\\File1.txt");
            writer.WriteLine("Hello forth Line");// write permissions or write mode
            writer.WriteLine(" Hello fifth line");
            writer.WriteLine(" Hello sixth line");
            writer.Close();//must, without close, permission 
            //lets read content of given file 
            StreamReader reader = new StreamReader(@"D:\\mphasis\Dec20\\File1.txt");
            string strContent = reader.ReadToEnd();//Read() readLine()// read permission
            Console.WriteLine(strContent);
            reader.Close();
        }
        public static void WriteAndReadWithFileStream()
        {
            FileStream wrStream = new FileStream(@"D:\\mphasis\Dec20\\File3.txt",
                FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(wrStream);
            writer.WriteLine("With File stream class ");
              writer.Close();
            FileStream srStream = new FileStream(@"D:\\mphasis\Dec20\\File3.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(srStream);
            string strCOntent = reader.ReadLine();
            Console.WriteLine(strCOntent);
            reader.Close();
        }
        public static void FileWithFileFuns()
        {
            string pathFile = @"D:\\mphasis\Dec20\\File4.txt";
            // checking 
            if (File.Exists(pathFile))
            {//true
                //File.Delete(pathFile);
                StreamReader reader = File.OpenText(pathFile);
                string s1 = reader.ReadToEnd();
                Console.WriteLine("file exists so we are reading " + s1);
                reader.Close();
            }
            else
            {//false
                StreamWriter writer = File.CreateText(pathFile);
                writer.Write(" now we are with file class");
                writer.Close();
            }
            // let when a file is created
            DateTime dt1 = File.GetCreationTime(pathFile);
            Console.WriteLine(dt1.ToString());
            // to append in existing file 
            StreamWriter sw1 = File.AppendText(pathFile);
            sw1.Close();
            //  File.Move(pathFile, "d:\\mphasis");// oldfile,new path cut paste
            File.Copy(pathFile, "D:\\mphasis\\file5.txt");// new file name must 


        }
        public static void WorkingWithDirectoryFuns()
        {// create folde
            string str = "D:\\Dec20net";
            Directory.CreateDirectory(str);
            Directory.Delete(str);
            // check
            if (Directory.Exists(str)) Console.WriteLine("folder is there");
            else Console.WriteLine("no such folder");
            // let display all files in a path
            Console.WriteLine("all file names");
            string[] fileNames = Directory.GetFiles("c:\\windows");
            foreach (string oneFile in fileNames) { Console.WriteLine(oneFile); }
            //let display all folders in path
            Console.WriteLine(" all folder names");
            string[] folderNames = Directory.GetDirectories("D:\\");
            foreach (string oneFolder in folderNames) { Console.WriteLine(oneFolder); }
            // lets display drive names
            string[] driveNames = Directory.GetLogicalDrives();
            foreach (string oneDrive in driveNames) { Console.WriteLine(oneDrive); }
        }
        public static void FunsWithFIleInfo()
        {
            FileInfo fi = new FileInfo(@"D:\\mphasis\Dec20\\File3.txt");
            string str1 = fi.Extension;
            long size = fi.Length;
            Console.WriteLine(str1);
            Console.WriteLine(size);
            string fn = fi.FullName;//complete path
            string n = fi.Name;// just file name
            // try display only path without filename
            DirectoryInfo di = new DirectoryInfo("D:\\mphasis");

        }
        static void Main(string[] args)
        {
           // FunsWithFIleInfo();
           // WorkingWithDirectoryFuns();
           //  FileWithFileFuns();
             WriteAndReadWithFileStream();
           // WriteAndReadFile();  
            Console.ReadLine();
        }
    }
}





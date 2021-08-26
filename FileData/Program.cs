using System;

using ThirdPartyTools;

namespace FileData
{
    public interface IFileDetails
    {
        string Version(string filePath);
        int Size(string filePath);
    }
    public class BarclaysTask1
    {
        public void FileDetailsVersion(string[] args)
        {
            try
            {
                var first = args[0];
                if (first.ToString() == "-v")
                {
                    FileDetails fileDetails = new FileDetails();
                    var version = fileDetails.Version(args[1]);
                    Console.WriteLine(version);
                }
            }
            catch (Exception ex)
            {
                var message = ex.Message.ToString();
            }
        }
    }

    public class BarclaysTask2
    {
        public void FileDetailsVersionAndSize(string[] args)
        {
            FileDetails fileDetails = new FileDetails();
            try
            {
                string first = args[0].ToString();
                if (first == "-v" || first == "--v" || first == "/v" || first == "--version")
                {
                    var version = fileDetails.Version(args[1]);
                    Console.WriteLine(version);
                }
                if (first == "-s" || first == "--ss" || first == "/s" || first == "--size")
                {
                    var size = fileDetails.Size(args[1]);
                    Console.WriteLine(size);
                }
            }
            catch (Exception ex)
            {
                var message = ex.Message.ToString();
            }
        }
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            BarclaysTask1 barclaysTask1 = new BarclaysTask1();
            barclaysTask1.FileDetailsVersion(args);

            BarclaysTask2 barclaysTask2 = new BarclaysTask2();
            barclaysTask2.FileDetailsVersionAndSize(args);

            Console.ReadLine();
        }
    }
}

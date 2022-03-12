using System;
using System.Linq;

namespace T03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string filePath = Console.ReadLine();

            //int lastSlash = filePath.LastIndexOf('\\');

            //string fileNameAndExtension = filePath.Substring(lastSlash + 1);

            //// Template.pptx
            //// gotinVirus.pdf.exe
            //string fileName = fileNameAndExtension.Substring(0, fileNameAndExtension.LastIndexOf('.'));
            //string extension = fileNameAndExtension.Substring(fileNameAndExtension.LastIndexOf('.') + 1);

            //Console.WriteLine($"File name: {fileName}");
            //Console.WriteLine($"File extension: {extension}");

            string[] fileInfo = Console.ReadLine()
                .Split('\\')
                .Last()
                .Split('.');

            string fileName = string.Join(".", fileInfo.Take(fileInfo.Length - 1));
            string fileExtension = fileInfo.Last();

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}

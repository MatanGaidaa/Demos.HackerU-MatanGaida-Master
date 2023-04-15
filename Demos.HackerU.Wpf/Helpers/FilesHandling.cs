using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.Wpf.Helpers
{
    public class FilesHandling
    {

        private static string CreateFolder()
        {
            //2--Check If Directory Not Exsist 
            if (!Directory.Exists("AppData\\Images"))
            {
                //--Create New Directory (bin/debug....)
                Directory.CreateDirectory("AppData\\Images");
            }

            return "AppData\\Images";

        }

        public static string ImageUpload()
        {
            string originalFileName = "";
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                //Full Path Of Original IMage
                string originalFullPath = dialog.FileName;//c:\\Images\animal.jpg 
                                                          //Only File Name +Extention Of Original
                originalFileName = Path.GetFileName(originalFullPath);//animal.jpg

                //combain global destination to destination
                string destinationFolder = Path.Combine(Environment.CurrentDirectory, CreateFolder());

                //combain global destination to destination
                string destinationFile = Path.Combine(destinationFolder, originalFileName);


                //file copy from user folder to our destination and check if it exists
                if (!File.Exists(destinationFile))
                {
                    File.Copy(originalFullPath, destinationFile);
                }


            }
            return CreateFolder() + "\\" + originalFileName;
        }


    }
}

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
        /// <summary>
        /// checks if folder exist 
        /// create folder 
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// get path and return full image path
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// returns full folder path
        /// </summary>
        /// <param name="targetDirectory">folder variable</param>
        /// <returns></returns>
        public static string[] GetFolderFilesFull(string targetDirectory)
        {
            var newFileEntries = new string[0];
            //2--Check If Directory Exsist 
            if (Directory.Exists(targetDirectory))
            {
                string destinationFolder = Path.Combine(Environment.CurrentDirectory, targetDirectory);

                string[] fileEntries = Directory.GetFiles(destinationFolder);
                if (fileEntries != null)
                {
                    newFileEntries = fileEntries;
                }

            }
            return newFileEntries;
        }


        /// <summary>
        /// return only the file name
        /// </summary>
        /// <param name="targetDirectory">folder variable</param>
        /// <returns></returns>
        public static string[] GetFolderFilesShort(string targetDirectory)
        {
            var newFileEntries = new string[0];
            //2--Check If Directory Exsist 
            if (Directory.Exists(targetDirectory))
            {
                string destinationFolder = Path.Combine(Environment.CurrentDirectory, targetDirectory);

                string[] fileEntries = Directory.GetFiles(destinationFolder);
                if (fileEntries != null)
                {
                    for (int i = 0; i < fileEntries.Length; i++)
                    {
                        fileEntries[i] = Path.GetFileName(fileEntries[i]);//animal.jpg                     
                        fileEntries[i] = fileEntries[i].Replace(".json", "");
                    }
                    newFileEntries = fileEntries;
                }

            }
            return newFileEntries;
        }

    }
}

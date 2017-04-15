using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Engine
{
    public class FolderDir
    {
        //Fields.
        private string dir;

        //Properties.
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        public string Path
        {
            get { return dir; }
            set { dir = value; }
        }

        //Constructor.
        public FolderDir ()
        {
            dir = "";
        }

        public override string ToString()
        {
            return dir;
        }

        /// <summary>
        /// Returns an array with all filepaths ending with ".mkv".
        /// </summary>
        /// <returns></returns>
        public string[] GetAllFiles()
        {
            string[] filePath = Directory.GetFiles(dir, "*.mkv");

            //Removes the file path, leaving only the file name.
            for (int i = 0; i < filePath.Count(); i++)
            {
                filePath[i] = filePath[i].Replace(Path + "\\", "");
            }

            return filePath.ToArray();
        }

        /// <summary>
        /// Returns an updated list of filenames.
        /// </summary>
        /// <returns></returns>
        public List<string> UpdateFiles()
        {
            //Retrieves the files from directory.
            var updated_FilePath = Directory.GetFiles(dir, "*.mkv");
            updated_FilePath.ToList();

            //Removes the file path, leaving only the file name.
            for (int i = 0; i < updated_FilePath.Count(); i++)
            {
                updated_FilePath[i] = updated_FilePath[i].Replace(Path + "\\", "");
            }

            //Retrieves the list of files we previously stored.
            var current_FilePath = Engine_Settings.LoadStringList();

            //Compares the stored list with the new one and stores the difference in "results".
            //Then we combine the results with the old list and return it.
            var results = current_FilePath.Except(updated_FilePath).ToList();
            current_FilePath.AddRange(results);

            return current_FilePath;

            //Todo: Add this method to the update button and add a new button for the GetAllFiles method.
        }
    }
}

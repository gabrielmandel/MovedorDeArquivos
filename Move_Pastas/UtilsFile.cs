using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Pastas
{
    public class UtilsFile
    {
        public void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs, List<string> blacklist = null)
        {

            var dir = new DirectoryInfo(sourceDirName);
            var dirs = dir.GetDirectories();
            var diretoriosAceitos = dirs; //Dirs menos os diretorios da minha blacklist

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            var files = dir.GetFiles();

            foreach (var file in files)
            {
                // Create the path to the new copy of the file.
                var temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                file.CopyTo(temppath, true);
            }

            // If copySubDirs is true, copy the subdirectories.
            if (!copySubDirs) return;

            foreach (var subdir in dirs)
            {
                bool permiteCopiar = blacklist.Contains(subdir.Name);
                if (!permiteCopiar)
                {
                    // Create the subdirectory.
                    var temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs, blacklist);
                }

            }
        }
    }
}

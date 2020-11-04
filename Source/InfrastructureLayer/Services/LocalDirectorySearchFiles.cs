using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ApplicationLayer.Common;
using System.Threading.Tasks;
namespace InfrastructureLayer.Services
{
    public class LocalDirectorySearchFiles : ISearch
    {
        private DirectoryInfo directory;
        public LocalDirectorySearchFiles()
        {
            this.directory = new DirectoryInfo("C:\\");
        }

        public List<string> Search(string searchTerm)
        {
            List<string> result = new List<string>();        

            var options = new EnumerationOptions() {IgnoreInaccessible = true};

            DirectoryInfo[] dirInfoArray = directory.GetDirectories("*",  options);       

            foreach (var dir in dirInfoArray)
            {
                try
                {
                    string dirFullname = dir.FullName;
                    string name = dir.Name;
                    foreach (var file in dir.EnumerateFiles(searchTerm, SearchOption.AllDirectories))
                    {
                        string fileFullname = file.FullName;
                        string fileNameame = file.Name;
                        result.Add(fileFullname);
                    }
                }
                catch (Exception e)
                {
                    result.Add(e.Message);
                }

            }
            return result;
        }


    }
}

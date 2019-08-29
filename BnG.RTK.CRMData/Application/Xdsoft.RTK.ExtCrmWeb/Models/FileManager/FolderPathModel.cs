using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xdsoft.RTK.ExtCrmWeb.Models.FileManager
{
    public class FolderPathModel
    {
        private IList<FolderModel> folders; //folders can have subfolders
        private string rootPath;

        public FolderPathModel()
        {
            this.rootPath = "";
            this.folders = new List<FolderModel>();
        }

        public void AddFolderModel(FolderModel folder)
        {
            this.folders.Add(folder);
        }

        public void AddRootPath(string rootPath)
        {
            this.rootPath = rootPath;
        }

        public string GetRootPath()
        {
            return rootPath;
        }

        public IList<FolderModel> GetFolderModels() {
            return folders;
        }
    }
}
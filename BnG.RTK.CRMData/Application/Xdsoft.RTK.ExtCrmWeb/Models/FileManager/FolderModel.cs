using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xdsoft.RTK.ExtCrmWeb.Models.FileManager
{
    public class FolderModel
    {
        private readonly string folderName;
        private readonly IList<FolderModel> subFolders;

        public FolderModel(string folderName, IList<FolderModel> subFolders)
        {
            this.folderName = folderName;
            this.subFolders = subFolders;
        }

        public string GetFolderName()
        {
            return this.folderName;
        }

        public IList<FolderModel> GetSubFolders()
        {
            return subFolders;
        }

        internal string GetFolderPathFor(string id, string fmtype, string typeNameKey)
        {
           
            var folderPath = String.Format(@"C:\Documents\Projects\{0}\{1}\Home\{2}", typeNameKey, id, folderName);
            return folderPath;
        }

    }
}
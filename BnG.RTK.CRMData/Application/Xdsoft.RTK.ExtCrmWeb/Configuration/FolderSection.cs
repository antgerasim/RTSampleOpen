using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Xdsoft.RTK.ExtCrmWeb.Configuration
{

    public class FolderSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsDefaultCollection = true)]
        public FolderCollection Folders
        {
            get
            {
                FolderCollection hostCollection = (FolderCollection)base[""];
                return hostCollection;
            }
        }
    }

    public class FolderCollection : ConfigurationElementCollection
    {
        public FolderCollection()
        {
            FolderConfigElement details = (FolderConfigElement)CreateNewElement();
            if (details.FolderKey != "")
            {
                Add(details);
            }
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new FolderConfigElement();
        }

        protected override Object GetElementKey(ConfigurationElement element)
        {
            return ((FolderConfigElement)element).FolderKey;
        }

        public FolderConfigElement this[int index]
        {
            get
            {
                return (FolderConfigElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        new public FolderConfigElement this[string name]
        {
            get
            {
                return (FolderConfigElement)BaseGet(name);
            }
        }

        public int IndexOf(FolderConfigElement details)
        {
            return BaseIndexOf(details);
        }

        public void Add(FolderConfigElement details)
        {
            BaseAdd(details);
        }

        protected override void BaseAdd(ConfigurationElement element)
        {
            BaseAdd(element, false);
        }

        public void Remove(FolderConfigElement details)
        {
            if (BaseIndexOf(details) >= 0)
                BaseRemove(details.FolderKey);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        public void Remove(string name)
        {
            BaseRemove(name);
        }

        public void Clear()
        {
            BaseClear();
        }

        protected override string ElementName
        {
            get { return "folder"; }
        }
    }

    public class FolderConfigElement : ConfigurationElement
    {
        private const string invalidCharacters = "~!@#$%^&*[]{}/:*?<>;’\"|\\";

        [ConfigurationProperty("folderKey", IsRequired = true, IsKey = true)]      
        [StringValidator(InvalidCharacters = invalidCharacters)] //whitespace allowed

        public string FolderKey
        {
            get { return (string)this["folderKey"]; }
            set { this["folderKey"] = value; }
        }

        [ConfigurationProperty("folderName", IsRequired = true)]
        [StringValidator(InvalidCharacters = invalidCharacters)]
        public string FolderName
        {
            get { return (string)this["folderName"]; }
            set { this["folderName"] = value; }
        }

        [ConfigurationProperty("folders", IsDefaultCollection = false)]
        public SubFolderCollection SubFolders
        {
            get { return (SubFolderCollection)base["folders"]; }
        }
    }

    public class SubFolderCollection : ConfigurationElementCollection
    {
        public new SubFolderConfigElement this[string name]
        {
            get
            {
                if (IndexOf(name) < 0) return null;
                return (SubFolderConfigElement)BaseGet(name);
            }
        }

        public SubFolderConfigElement this[int index]
        {
            get { return (SubFolderConfigElement)BaseGet(index); }
        }

        public int IndexOf(string name)
        {
            name = name.ToLower();

            for (int idx = 0; idx < base.Count; idx++)
            {
                if (this[idx].SubFolderKey.ToLower() == name)
                    return idx;
            }
            return -1;
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new SubFolderConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((SubFolderConfigElement)element).SubFolderKey;
        }

        protected override string ElementName
        {
            get { return "subFolder"; }
        }
    }

    public class SubFolderConfigElement : ConfigurationElement
    {
        private const string invalidCharacters = "~!@#$%^&*[]{}/:*?<>;’\"|\\";
        public SubFolderConfigElement()
        {
        }

        public SubFolderConfigElement(string subFolderKey, int localport, int remoteport, string subFolderName)
        {
            this.SubFolderKey = subFolderKey;
            this.SubFolderName = subFolderName;
        }

        [ConfigurationProperty("subFolderKey", IsRequired = true, IsKey = true, DefaultValue = "")]
        public string SubFolderKey
        {
            get { return (string)this["subFolderKey"]; }
            set { this["subFolderKey"] = value; }
        }

        [ConfigurationProperty("subFolderName", IsRequired = true)]
        [StringValidator(InvalidCharacters = invalidCharacters)]
        public string SubFolderName
        {
            get { return (string)this["subFolderName"]; }
            set { this["subFolderName"] = value; }
        }
    }
}

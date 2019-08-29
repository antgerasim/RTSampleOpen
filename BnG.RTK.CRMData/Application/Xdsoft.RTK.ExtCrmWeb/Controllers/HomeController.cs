using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xdsoft.RTK.ExtCrmWeb.Configuration;
using Xdsoft.RTK.ExtCrmWeb.Helper;
using Xdsoft.RTK.ExtCrmWeb.Models;
using Xdsoft.RTK.ExtCrmWeb.Models.FileManager;

namespace Xdsoft.RTK.ExtCrmWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id, string typename, string fmtype, string sfmtype)
        {
            //http://localhost:47186/?id=6659B6E9-891C-E811-80CA-D3E9C8E3E880&typename=new_t_project
            //http://localhost:47186/?fmtype=small&id=6659B6E9-891C-E811-80CA-D3E9C8E3E880&typename=new_t_project //fmtype - filemanagertype
            //http://localhost:47186/?fmtype=small&sfmtype=sfmType1&id=6659B6E9-891C-E811-80CA-D3E9C8E3E880&typename=new_t_project //sfmType1 - smallfilemanagertype
            //http://localhost:47186/?fmtype=big&sfmtype=sfmType1&id=6659B6E9-891C-E811-80CA-D3E9C8E3E880&typename=new_t_project
            ////http://localhost:47186/?fmtype=big&sfmtype=sfmType1&id=6659B6E9-891C-E811-80CA-D3E9C8E3E880&typename=new_t_activity
            try
            {
                TestFilePermissions();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                throw new Exception("Нет прав для работы с файловой системой ");
            }
            return View(new IndexViewModel(id, typename, fmtype, sfmtype));
        }

        [ValidateInput(false)]
        public ActionResult FileManagerPartial(string id, string typename, string fmtype, string sfmtype, NameValueCollection formData)
        {
            ViewBag.dorid = id ?? string.Empty;
            ViewBag.dortypename = typename ?? string.Empty;
            ViewBag.dorfmtype = fmtype ?? string.Empty;
            ViewBag.dorsfmtype = sfmtype ?? string.Empty;
            ViewBag.formData = formData;

            if (!String.IsNullOrEmpty(id)) //typename always there
            {
                id = id.Replace("{", string.Empty).Replace("}", string.Empty);
        
                var folderPathModel = FolderPathBuilder(id, typename, fmtype, sfmtype); //todo rename to service or smth                
                new HomeControllerFileManagerSettings(folderPathModel.GetRootPath());
                if (typename == "new_t_project") //если тип сущности "проект", то создаем струкутру
                {
                    foreach (var folderModel in folderPathModel.GetFolderModels())
                    {
                        var folderPath = folderModel.GetFolderPathFor(id, fmtype, typename);
                        //C:\Documents\Projects\new_t_project\6659B6E9-891C-E811-80CA-D3E9C8E3E880\Home\Организационно-распорядительные документы

                        if (folderModel.GetSubFolders().Count > 0)
                        {
                            foreach (var subFolder in folderModel.GetSubFolders())
                            {
                                var subfolderName = subFolder.GetFolderName();
                                var subFolderPath = string.Format(@"{0}\{1}", folderPath, subfolderName);
                                CreateDirectory(subFolderPath);                                
                            }
                        }
                        else
                        {
                            CreateDirectory(folderPath);
                        }
                    }
                }
                else
                {//иначе создаем без структуры папок
                    CreateDirectory(folderPathModel.GetRootPath());
                }
                
                return PartialView("_FileManagerPartial", HomeControllerFileManagerSettings.Model);
            }
            else
            {
                var baseDirectoryExists = Directory.Exists(@"C:\Documents\");
                if (!baseDirectoryExists)
                {
                    var excString = baseDirectoryExists ? "Documents-Projects directory exists" : "Documents-Projects directory NOT exists";
                    throw new Exception(String.Format("Guid id and typename are empty {0}", excString)); //todo convert to userfriendly view
                }
                // get string based on typename in webconfig and put into model
                string configTypeNameText = System.Configuration.ConfigurationManager.AppSettings[String.IsNullOrEmpty(typename) ? "new_t_project" : typename];
                return View("IdNotFound", new IdNotFoundViewModel(configTypeNameText));
            }
        }

        private static string GetRequestFormPath(NameValueCollection formData)
        {
            var resultStr = "";
            if (formData.HasKeys())
            {
                var path = formData.GetValues("RtCrmFileManager$Splitter$Toolbar$ITCNT0$Path$TB").FirstOrDefault();

                resultStr = path.Replace("Home", "");
            }

            return resultStr;
        }

        private static void CreateDirectory(string fPath)
        {
            var targetDirectoryExists = Directory.Exists(fPath);

            if (!targetDirectoryExists)
            {
                Directory.CreateDirectory(fPath);
            }
        }

        private static FolderPathModel FolderPathBuilder(string id, string typeNameKey, string fmtype, string sfmType)
        {
            var fpm = new FolderPathModel();
            if (fmtype == "small")
            {
                if (!string.IsNullOrEmpty(sfmType))
                {
                    //var sfmType = String.Empty;
                    /* * 1. Архитектура решения = sfmType1
                     * * 2. Схема реализации = sfmType2
                     * * 3. КП подрядчиков = sfmType3
                     * * 4. Паспорт сделки = sfmType4
                     * */
                    fpm.AddRootPath(String.Format(@"C:\Documents\SmallProjects\{0}\{1}\{2}", typeNameKey, id, sfmType));
                }
                else
                {
                    fpm.AddRootPath(String.Format(@"C:\Documents\SmallProjects\{0}\{1}\Home", typeNameKey, id));
                }
            }
            else if (fmtype == "big")
            {
                var rootPath = String.Format(@"C:\Documents\Projects\{0}\{1}\Home", typeNameKey, id);
                fpm.AddRootPath(rootPath);
                if (typeNameKey == "new_t_project")// добавляем еще папки по умолчанию
                {
                    FolderSection folderSection = ConfigurationManager.GetSection("FolderSection") as FolderSection;
                    if (folderSection == null)
                    {
                        throw new Exception("Exception text");
                    }
                    else
                    {
                        for (int i = 0; i < folderSection.Folders.Count; i++)
                        {
                            var folder = folderSection.Folders[i];
                            var folderName = folder.FolderName;
                            var subFolders = new List<FolderModel>();
                            for (int j = 0; j < folder.SubFolders.Count; j++)
                            {
                                var subFolder = folder.SubFolders[j];
                                var subfolderName = subFolder.SubFolderName;
                                subFolders.Add(new FolderModel(subfolderName, new List<FolderModel>()));
                            }
                            var folderModel = new FolderModel(folderName, subFolders);
                            fpm.AddFolderModel(folderModel);
                        }
                    }

                    #region Old
                    //var folderLoopCount = int.Parse(System.Configuration.ConfigurationManager.AppSettings["folderLoopCount"]);
                    //for (int i = 0; i < folderLoopCount; i++)
                    //{
                    //    var keyIndex = "folder" + i;
                    //    var subPath = "";
                    //    try
                    //    {
                    //        subPath = System.Configuration.ConfigurationManager.AppSettings[keyIndex];
                    //    }
                    //    catch (Exception)
                    //    {
                    //        subPath = "Папка с таким именим не заведена в web.config";
                    //        throw;
                    //    }
                    //    folderPaths.Add(String.Format(@"C:\Documents\Projects\{0}\{1}\Home\{2}", typeNameKey, id, subPath));
                    //}
                    #endregion

                }
                else
                {

                }

            }
            return fpm;

        }

        private void TestFilePermissions()
        {
            string dirVirtualPath = "~/TestDir";
            string dirPhysicalPath = Server.MapPath(dirVirtualPath);
            if (!Directory.Exists(dirPhysicalPath))
            {
                Directory.CreateDirectory(dirPhysicalPath);
            }

            string fileName = "TestFile.txt";
            string fileFullPath = Path.Combine(dirPhysicalPath, fileName);

            System.IO.File.WriteAllText(fileFullPath, "File Content Here...");
        }

        public FileStreamResult FileManagerPartialDownload()
        {           
            var rootFolder = HomeControllerFileManagerSettings.Model + GetRequestFormPath(Request.Form);

            return FileManagerExtension.DownloadFiles(HomeControllerFileManagerSettings.DownloadSettings,
    rootFolder);
        }
    }

    public class HomeControllerFileManagerSettings
    {
        public static string RootFolder = "";


        public HomeControllerFileManagerSettings(string rootFolder)
        {
            if (rootFolder != null)
            {
                RootFolder = rootFolder;
            }
        }

        public static string Model
        {
            get { return RootFolder; }
            set { RootFolder = value; }
        }

        public static DevExpress.Web.Mvc.FileManagerSettings DownloadSettings
        {
            get
            {
                var settings = new DevExpress.Web.Mvc.FileManagerSettings { Name = "FileManager" };
                settings.SettingsEditing.AllowDownload = true;
                return settings;
            }
        }
    }
}

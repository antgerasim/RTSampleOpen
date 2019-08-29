using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xdsoft.RTK.ExtCrmWeb.Data;

namespace Xdsoft.RTK.ExtCrmWeb.Models.Map
{
    public class SuccessStoryModel  
    {
        public string SuccessStory { get; internal set; }
        public string ProblemSolved { get; internal set; }
        public string AchivedResult { get; internal set; }
        public string ProjectDescription { get; internal set; }
        public string SubjectName { get; internal set; }
        public string ProjectName { get; internal set; }
        public string SphereOfActivity { get; internal set; }
        public IList<SuccessStorySubProductNameModel> ProductNames { get; internal set; }
        public string ProductNamesStr { get; set; }
    }
}
namespace Xdsoft.RTK.ExtCrmWeb.Models
{
    public class IndexViewModel
    {

        public string Id { get; }
        public string Typename { get; }
        public string Fmtype { get; }
        public string Sfmtype { get; }

        public IndexViewModel(string id, string typename, string fmtype, string sfmtype)
        {
            Id = id;
            Typename = typename;
            Fmtype = fmtype;
            Sfmtype = sfmtype;
        }
    }
}
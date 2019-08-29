namespace Xdsoft.RTK.ExtCrmWeb.Models
{
    public class IdNotFoundViewModel
    {
        public string TypeNameText { get; private set; }

        public IdNotFoundViewModel(string typeNameText)
        {
            TypeNameText = typeNameText;
        }
    }
}
using UnityEngine.UIElements;

namespace Goap.Goap.Editor
{
    public class Header : VisualElement
    {
        public Header(string text)
        {
            this.name = "header";
            this.Add(new Label(text));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieFramework.UI
{
    public class HtmlElement
    {
        public string Class { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }

        public ICollection<HtmlElement> Children { get; set; }
        public ICollection<Css.Style> Styles { get; set; }
    }
}

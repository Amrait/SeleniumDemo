using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo.Locators
{
    public class CSS : BaseLocator
    {
        public CSS(string _pattern) : base(_pattern)
        {
            this.pattern = _pattern;
            this.type = LocatorType.CSS;
        }
    }
}

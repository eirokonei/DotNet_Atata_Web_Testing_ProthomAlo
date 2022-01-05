using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;
using SampleApp.UITests.Utils;

namespace SampleApp.UITests.Pages
{
    using _ = BusinessPage;

    class BusinessPage : Page<_>
    {
        [FindByXPath(Locators.BusinessPath)]
        public Link<_> Business { get; private set; }

        [FindByXPath(Locators.LocalBPath)]
        public Link<_> LocalB { get; private set; }

        [FindByXPath(Locators.GlobalPath)]
        public Link<_> Global { get; private set; }
    }
}

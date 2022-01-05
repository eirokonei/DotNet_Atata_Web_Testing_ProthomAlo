using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;
using SampleApp.UITests.Utils;

namespace SampleApp.UITests.Pages
{
    using _ = YouthPage;
    class YouthPage : Page<_>
    {
        [FindByXPath(Locators.YouthPath)]
        public Link<_> Youth { get; private set; }

        [FindByXPath(Locators.EducaPath)]
        public Link<_> Education { get; private set; }

        [FindByXPath(Locators.EmpPath)]

        public Link<_> Employment { get; private set; }
    }
}

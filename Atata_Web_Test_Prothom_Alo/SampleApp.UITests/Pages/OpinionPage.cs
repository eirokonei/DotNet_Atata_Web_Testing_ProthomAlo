using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;
using SampleApp.UITests.Utils;

namespace SampleApp.UITests.Pages
{
    using _ = OpinionPage;
    class OpinionPage : Page<_>
    {
        [FindByXPath(Locators.OpiPath)]
        public Link<_> Opinion { get; private set; }

        [FindByXPath(Locators.EdiPath)]
        public Link<_> Editorial { get; private set; }

        [FindByXPath(Locators.InterPath)]
        public Link<_> Interview { get; private set; }

        [FindByXPath(Locators.AnaPath)]
        public Link<_> Analysis { get; private set; }
    }
}

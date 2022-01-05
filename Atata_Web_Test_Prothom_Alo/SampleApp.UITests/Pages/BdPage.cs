using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;
using SampleApp.UITests.Utils;


namespace SampleApp.UITests.Pages
{
    using _ = BdPage;
    public class BdPage : Page<_>
    {
        [FindByXPath(Locators.Bd)]
        public Link<_> Bangladesh { get; private set; }

        [FindByXPath(Locators.Poli)]
        public Link<_> Politics { get; private set; }

        [FindByXPath(Locators.Accd)]
        public Link<_> Accident { get; private set; }

        [FindByXPath(Locators.Goodd)]
        public Link<_> goodDay { get; private set; }

        [FindByXPath(Locators.Crim)]
        public Link<_> Crime { get; private set; }

        [FindByXPath(Locators.Govt)]
        public Link<_> Government { get; private set; }

        
    }
}

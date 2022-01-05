using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;
using SampleApp.UITests.Utils;

namespace SampleApp.UITests.Pages
{
    using _ = InternationalPage;
    public class InternationalPage : Page<_>
    {
        [FindByXPath(Locators.HumBr)]
        public Text<_> Humburger { get; private set; }

        [FindByXPath(Locators.IntNa)]
        public Link<_> Intnational { get; private set; }

        [FindByXPath(Locators.AsiaPath)]
        public Link<_> Asia { get; private set; }

        [FindByXPath(Locators.EuropePath)]
        public Link<_> Europe { get; private set; }

        [FindByXPath(Locators.AmericaPath)]
        public Link<_> America { get; private set; }
    }
}

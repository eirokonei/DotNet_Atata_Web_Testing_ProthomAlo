using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;
using SampleApp.UITests.Utils;

namespace SampleApp.UITests.Pages
{
    using _ = EntertainmentPage;
    class EntertainmentPage : Page<_>
    {
        [FindByXPath(Locators.EntPath)]
        public Link<_> Entertainment { get; private set; }

        [FindByXPath(Locators.DhaPath)]
        public Link<_> Dhally { get; private set; }

        [FindByXPath(Locators.BollyPath)]

        public Link<_> Bolly { get; private set; }

        [FindByXPath(Locators.HollyPath)]

        public Link<_> Holly { get; private set; }


    }
}

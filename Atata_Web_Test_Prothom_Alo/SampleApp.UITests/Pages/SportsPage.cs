using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;
using SampleApp.UITests.Utils;

namespace SampleApp.UITests.Pages
{
    using _ = SportsPage;
    class SportsPage : Page<_>
    {
        [FindByXPath(Locators.SportsPath)]
        public Link<_> Sports { get; private set; }

        [FindByXPath(Locators.CricketPath)]
        public Link<_> Cricket { get; private set; }

        [FindByXPath(Locators.FootBallPath)]
        public Link<_> FootBall { get; private set; }

        [FindByXPath(Locators.LocalPath)]
        public Link<_> Local { get; private set; }
    }
}

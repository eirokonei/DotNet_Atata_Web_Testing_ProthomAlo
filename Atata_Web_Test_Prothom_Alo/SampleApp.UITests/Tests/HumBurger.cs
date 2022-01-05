using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;
using NUnit.Framework;
using SampleApp.UITests.Utils;
using SampleApp.UITests.Pages;

namespace SampleApp.UITests.Tests
{
    public class HumBurger : UITestFixture
    {
        //[Test]
        public void MenuBar()
        {
             Go.To<HomePage>()
                .Edth.Hover().Wait(4)
                .EditionEnglish.Click().Wait(2);

            
        }

        public void HumBur()
        {
            Go.To<InternationalPage>()
                .Humburger.Click().Wait(2);
        }
    }
}

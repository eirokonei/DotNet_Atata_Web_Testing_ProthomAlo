/*using System;
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
    class ESportsTest : UITestFixture
    {
        [Test]

        public void SportsTestFun()
        {
            HumBurger obj = new HumBurger();
            obj.MenuBar();

            Go.To<SportsPage>()
                .Sports.Click().Wait(2)
                .Cricket.Click().Wait(2)
                .FootBall.Click().Wait(2)
                .Local.Click().Wait(2);
        }
        
        
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.UITests;
using Atata;
using NUnit.Framework;
using SampleApp.UITests.Pages;


namespace SampleApp.UITests.Tests
{
    public class InternationalTest : UITestFixture
    {
        [Test]
        public void InternationalPageTest()
        {
            /*Go.To<HomePage>()
                .Edth.Hover().Wait(7)
                .EditionEnglish.Click().Wait(3);*/
            HumBurger ob = new HumBurger();
            ob.MenuBar();
            ob.HumBur();

            Go.To<InternationalPage>()
                //.Humburger.Click().Wait(2)
                .Intnational.Click().Wait(3)
                .Asia.Click().Wait(2)
                .Europe.Click().Wait(2)
                .America.Click().Wait(4);

            ob.HumBur();

            Go.To<SportsPage>()
                .Sports.Click().Wait(2)
                .Cricket.Click().Wait(2)
                .FootBall.Click().Wait(2)
                .Local.Click().Wait(2);

            ob.HumBur();

            Go.To<OpinionPage>()
                .Opinion.Click().Wait(2)
                .Editorial.Click().Wait(2)
                .Interview.Click().Wait(2)
                .Analysis.Click().Wait(4);

            ob.HumBur();

            Go.To<BusinessPage>()
                .Business.Click().Wait(2)
                .LocalB.Click().Wait(2)
                .Global.Click().Wait(2);

            ob.HumBur();

            Go.To<YouthPage>()
                .Youth.Click().Wait(2)
                .Education.Click().Wait(2)
                .Employment.Click().Wait(2);

            ob.HumBur();

            Go.To<EntertainmentPage>()
                .Entertainment.Click().Wait(2)
                .Dhally.Click().Wait(2)
                .Bolly.Click().Wait(2)
                .Holly.Click().Wait(4);
        }
    }
}

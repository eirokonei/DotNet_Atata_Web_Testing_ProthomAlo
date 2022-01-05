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
    class BdTest : UITestFixture
    {
        [Test]
        public void BdPageTest()
        {
            *//*Go.To<HomePage>()
            .Login.Click()
      
            .Email.Set(Locators.email).Wait(10)
            .Password.Set(Locators.password)
            .LoginBtn.Click()
            .Edth.Hover().Wait(5)
            .EditionEnglish.Click().Wait(2);*//*

            Home()

                *//*.Edth.Hover().Wait(7)
                .EditionNorth.Click().Wait(4)
                .Edth.Hover().Wait(5)
                .EditionBangla.Click().Wait(7)*//*
                .Edth.Hover().Wait(5)
                .EditionEnglish.Click().Wait(3);

            Go.To<BdPage>()
           .Bangladesh.Click().Wait(7)
           .Politics.Click().Wait(5)
           *//*.Accident.Click().Wait(5)
           .goodDay.Click().Wait(5)
           .Crime.Click().Wait(5)*//*
           .Government.Click().Wait(5);
        }
    }
}
*/
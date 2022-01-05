using Atata;
using NUnit.Framework;
using SampleApp.UITests;
using SampleApp.UITests.Pages;
using SampleApp.UITests.Utils;

namespace SampleApp.UITests.Tests
{
    [TestFixture]
    public class UITestFixture
    {
        [SetUp]
        public void SetUp()
        {
            AtataContext.Configure().Build();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }

        protected HomePage Home()
        {
                return Go.To<HomePage>().Wait(3)
                //.Report.Screenshot()
                .Login.Click()
                //.ContinueWithEmail.Click()
                .Email.Set(Locators.email).Wait(3)
                .Password.Set(Locators.password)
                .LoginBtn.Click();

            /*    .Edth.Hover()
                .EditionEnglish.Click().Wait(3)
                .Edth.Hover().Wait(7)
                .EditionBangla.Click().Wait(7)
                .Edth.Hover().Wait(7)
                .EditionNorth.Click().Wait(3);*/

        }

        /* protected HomePage Edition()
         {
             return Go.To<HomePage>()
                 .Edth.Hover().Wait(2)
                 .EditionEnglish.Click().Wait(2);
         }*/
    }
}

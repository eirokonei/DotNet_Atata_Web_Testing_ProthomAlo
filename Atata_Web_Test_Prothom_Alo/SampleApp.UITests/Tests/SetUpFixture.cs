﻿using Atata;

using NUnit.Framework;


namespace SampleApp.UITests.Tests
{
    [SetUpFixture]
    public class SetUpFixture
    {
        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            AtataContext.GlobalConfiguration
                .UseChrome()
                    .WithArguments("start-maximized")
                .UseBaseUrl("https://www.prothomalo.com/")
                .UseCulture("en-US")
                .UseAllNUnitFeatures()
                //extentreportsconfigurations
                .AddLogConsumer(new ExtentLogConsumer())
                .AddScreenshotFileSaving()
                    .WithArtifactsFolderPath()
                .EventSubscriptions.Add(new ExtentScreenshotFileEventHandler());

            //.Attributes.Global.Add(new VerifyTitleSettingsAttribute { Format = "{0} - Atata Sample App" });

            AtataContext.GlobalConfiguration.AutoSetUpDriverToUse();
        }

        [OneTimeTearDown]
        public void GlobalTearDown()
        {
            ExtentContext.Reports.Flush();
        }
    }
}

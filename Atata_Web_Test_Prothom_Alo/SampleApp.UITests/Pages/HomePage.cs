using Atata;
using SampleApp.UITests.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.UITests.Pages
{
    using _ = HomePage;
    public class HomePage : Page<_>
    {
        [FindByClass(Locators.loginbtnxpath)]
        public Button<_> Login { get; private set; }

        [FindByXPath(Locators.continueWithEmailXpath)]
        public Button<_> ContinueWithEmail { get; private set; }

        [FindByName(Locators.emailId)]
        public TextInput<_> Email { get; private set; }

        [FindByName(Locators.passwordId)]
        public PasswordInput<_> Password { get; private set; }

        [FindByClass(Locators.loginXpath)]
        public Button<HomePage, _> LoginBtn { get; private set; }

        [FindByClass(Locators.EditionHover)]
        public Text<_> Edth { get; private set; }

        [FindByXPath(Locators.EditionBanglaRec)]
        public Link<_> EditionBangla { get; private set; }

        [FindByXPath(Locators.EditionEnglishRec)]
        public Link<_> EditionEnglish { get; private set; }
        
        [FindByXPath(Locators.EditionNorthRec)]
        public Link<_> EditionNorth { get; private set; }

     }
}

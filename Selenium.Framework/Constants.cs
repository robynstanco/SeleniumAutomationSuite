namespace Selenium.Framework
{
    /// <summary>
    /// Generic constants used in numerous places. May be a regular string or even reused XPaths.
    /// </summary>
    public class Constants
    {
        public const string HeaderWithTextXPath = "//h1[text()='{0}']";
        public const string Login = nameof(Login);
        public const string OptionWithTextXPath = "//option[text()='{0}']";
        public const string SubmitXPath = "//input[@type='submit']";
    }
}
namespace Selenium.Framework.Forms
{
    /// <summary>
    /// Abstract form class to be implemented in projects that use the framework. Encapsulates all simple & complex form activities.
    /// </summary>
    public abstract class ComplexForm : SimpleForm
    {
        public ComplexForm() : base()
        {

        }

        public void AssertSubmissionFailedWithMessage(string message)
        {
            OnAssertSubmissionFailedWithMessage(message);
        }

        public void AssertSubmissionSucceededWithMessage(string message)
        {
            OnAssertSubmissionSucceededWithMessage(message);
        }

        protected abstract void OnAssertSubmissionFailedWithMessage(string message);
        protected abstract void OnAssertSubmissionSucceededWithMessage(string message);
    }
}
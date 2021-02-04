namespace Selenium.Framework.Forms
{
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
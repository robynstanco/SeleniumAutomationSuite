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

        /// <summary>
        /// Assert submission fails with given message. Called via override in implementating class.
        /// </summary>
        /// <param name="message">message to locate</param>
        public void AssertSubmissionFailedWithMessage(string message)
        {
            OnAssertSubmissionFailedWithMessage(message);
        }

        /// <summary>
        /// Assert submission succeeds with given message. Called via override in implementating class.
        /// </summary>
        /// <param name="message">message to locate</param>
        public void AssertSubmissionSucceededWithMessage(string message)
        {
            OnAssertSubmissionSucceededWithMessage(message);
        }

        protected abstract void OnAssertSubmissionFailedWithMessage(string message);
        protected abstract void OnAssertSubmissionSucceededWithMessage(string message);
    }
}
namespace Selenium.Framework.Forms
{
    /// <summary>
    /// Abstract form class to be implemented in projects that use the framework. Encapsulates all simple form activities .
    /// </summary>
    public abstract class SimpleForm
    {
        public SimpleForm()
        {

        }

        /// <summary>
        /// Submit the simple form. Called via override in implementating class.
        /// </summary>
        public void Submit()
        {
            OnSubmit();
        }

        /// <summary>
        /// Assert the simple form is loaded. Called via override in implementating class.
        /// </summary>
        public void AssertIsLoaded()
        {
            OnAssertIsLoaded();
        }

        /// <summary>
        /// Assert the simple form submission failed. Called via override in implementating class.
        /// </summary>
        public void AssertSubmissionFailed()
        {
            OnAssertSubmissionFailed();
        }

        /// <summary>
        /// Assert the simple form submission succeeded. Called via override in implementating class.
        /// </summary>
        public void AssertSubmissionSucceeded()
        {
            OnAssertSubmissionSucceeded();
        }

        protected abstract void OnSubmit();
        protected abstract void OnAssertIsLoaded();
        protected abstract void OnAssertSubmissionFailed();
        protected abstract void OnAssertSubmissionSucceeded();
    }
}
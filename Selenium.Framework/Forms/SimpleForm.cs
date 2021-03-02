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

        public void Submit()
        {
            OnSubmit();
        }

        public void AssertIsLoaded()
        {
            OnAssertIsLoaded();
        }

        public void AssertSubmissionFailed()
        {
            OnAssertSubmissionFailed();
        }

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
namespace Selenium.Framework.Forms
{
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
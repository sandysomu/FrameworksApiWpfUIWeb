using System.Configuration;
using TestStack.White;

namespace WHA.UIFramework
{
    public static class ApplicationManager
    {

        public static Application Application { get; set; }

        private static Application GetApplication()
        {

            if (Application == null)
            {
                Application = Application.Launch(ConfigurationManager.AppSettings["AppPath"]);

            }
            return Application;
        }

    }
}
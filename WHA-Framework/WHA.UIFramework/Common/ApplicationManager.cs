using System;
using System.Configuration;
using System.IO;
using TestStack.White;

namespace WHA.UIFramework.Common
{
    public static class ApplicationManager
    {

        public static  Application Application { get; set; }

        public static Application GetApplication()
        {
            if (Application == null)
            {
                try
                {
                    // Application = Application.Launch(ConfigurationManager.AppSettings["AppPath"]);
                    string filePath = @"C:\Sandy\wha-framework\WHA-Framework\WHA-Framework\bin\Debug\WHA_Framework.exe";
                    Application = Application.Launch(filePath);
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
            return Application;
        }


        public static  void CloseApplication(Application application)
        {
            if (application != null)
            {
                application.Close();
            }

        }

    }
}


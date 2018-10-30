using System;

using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;
using WHA.UIFramework.Common;



namespace WHA.UIFramework.Screens
{
    public class MainWinControls
    {
        //static readonly Application app = ApplicationManager.GetApplication();
        static Window main = ApplicationManager.GetApplication().GetWindow("FirstWindow");

        public MainWinControls()
        {
            IUIItem[] temp = main.GetChildren(SearchCriteria.All);
            if (temp == null) throw new ArgumentNullException(nameof(temp));
        }
       
        public ComboBox GetAcNameListBox()
        {
            return main.Get<ComboBox>(SearchCriteria.ByAutomationId("AccountNameList"));
        }

        public ComboBox GetTransTypeList()
        {
            return main.Get<ComboBox>(SearchCriteria.ByAutomationId("TransTypeList"));
        }

        public ComboBox GetFinancialEntityList()
        {
            return main.Get<ComboBox>(SearchCriteria.ByAutomationId("FinancialEntityList")); 
        }

        public TextBox GetAmountTextBox()
        {
            return main.Get<TextBox>(SearchCriteria.ByAutomationId("AmountTextBox"));
        }

        public TextBox GetTransReasonTextBox()
        {
            return main.Get<TextBox>(SearchCriteria.ByAutomationId("TransReasonTextBox"));
        }

        public Button GetSubmitButton()
        {
            return main.Get<Button>(SearchCriteria.ByAutomationId("SubmitButton"));
        }

        public Button GetAllButtonButton()
        {
            return main.Get<Button>(SearchCriteria.ByAutomationId("AllBankButton"));
        }
        //main.Get<TextBox>(SearchCriteria.ByAutomationId("AmountTextBox")).Text = "1234";
        //main.Get<ComboBox>(SearchCriteria.ByAutomationId("FinancialEntityList")).Select(1);
        //var temp = main.GetChildren(SearchCriteria.All);
        //main.Get<TextBox>(SearchCriteria.ByAutomationId("TransReasonTextBox")).Text = "Written by autiomation";

        public ListView GetEntitiesList()
        {
            ListView te;

            te = main.Get<ListView>(SearchCriteria.ByAutomationId("EntityDetails"));

            //main.Get<ListView>(SearchCriteria.ByAutomationId("EntityDetails")).ScrollBars.

            return te;
        }

    }
}
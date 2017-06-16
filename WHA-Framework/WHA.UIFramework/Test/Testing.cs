using System;
using System.Linq;
using NUnit.Framework;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;
using WHA.UIFramework.Common;
using WHA.UIFramework.Screens;
using Debug = System.Diagnostics.Debug;


namespace WHA.UIFramework.Test
{
    public class Testing : MainWinControls
    {
        // ApplicationManager app = new ApplicationManager();

        [Test]
        public void addNewEntry()
        {
            Random random = new Random();

            GetAcNameListBox().Select(random.Next(0, 3));
            GetFinancialEntityList().Select(random.Next(0, 3));
            GetTransTypeList().Select(random.Next(0, 1));
            GetTransReasonTextBox().Text = "Entered By Automation Script";
            GetAmountTextBox().Text = random.Next(0, 3000).ToString();
            GetSubmitButton().Click();
        }

        [Test]
        public void MultipleEntries()
        {
            for (int i = 0; i < 100; i++)
            {
                addNewEntry();
            }
        }

        [Test]
        public void PrintLatestRecord()
        {
            GetAllButtonButton().Click();
            ListView tem = GetEntitiesList();
            for (int i = 0; i < tem.Rows.Count; i++)
            {
                ListViewRow row = tem.Rows[i];

                Debug.WriteLine(" {0} {1} {2} {3} {4} {5} {6} {7}", row.Cells[0].Name, row.Cells[1].Name, row.Cells[2].Name, row.Cells[3].Name, row.Cells[4].Name, row.Cells[5].Name, row.Cells[6].Name
                    , row.Cells[7].Name);
                Console.WriteLine(" {0} {1} {2} {3} {4} {5} {6} {7}", row.Cells[0].Name, row.Cells[1].Name, row.Cells[2].Name, row.Cells[3].Name, row.Cells[4].Name, row.Cells[5].Name, row.Cells[6].Name
                  , row.Cells[7].Name);

                //for (int j = 0; j < row.Cells.Count; j++)
                //{
                //    Debug.WriteLine(row.Cells[j].Name);
                //    Console.WriteLine(row.Cells[j].Name);
                //}

            }
        }


    }
}
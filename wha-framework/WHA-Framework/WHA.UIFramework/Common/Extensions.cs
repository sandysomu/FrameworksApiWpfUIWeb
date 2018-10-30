using System.Collections.Generic;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace WHA.UIFramework.Common
{
   
        public static class Extensions
        {

            public static T Get<T>(this IUIItem element, SearchCriteria searchCriteria) where T : IUIItem
            {
                var parentContainer = new UIItemContainer(element.AutomationElement, element.ActionListener);
                return (T)parentContainer.Get(searchCriteria);
            }

            public static IUIItem Get(this IUIItem element, SearchCriteria searchCriteria)
            {
                var parentContainer = new UIItemContainer(element.AutomationElement, element.ActionListener);
                return parentContainer.Get(searchCriteria);
            }

            public static IUIItem[] GetChildren(this IUIItem parent, SearchCriteria searchCriteria)
            {
                var parentContainer = new UIItemContainer(parent.AutomationElement, parent.ActionListener);
                return parentContainer.GetMultiple(searchCriteria);
            }

            public static List<T> GetChildren<T>(this IUIItem parent, SearchCriteria searchCriteria) where T : IUIItem
            {
                var resultingList = new List<T>();
                var parentContainer = new UIItemContainer(parent.AutomationElement, parent.ActionListener);
                var items = parentContainer.GetMultiple(searchCriteria);
                foreach (var item in items)
                {
                    resultingList.Add((T)item);
                }
                return resultingList;
            }

            public static T GetSibling<T>(this IUIItem childElement, SearchCriteria searchCriteria) where T : IUIItem
            {
                var element = childElement.GetParent<IUIItem>();
                var parentContainer = new UIItemContainer(element.AutomationElement, element.ActionListener);
                return (T)parentContainer.Get(searchCriteria);
            }
        }
    
}
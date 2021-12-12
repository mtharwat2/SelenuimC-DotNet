﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SmartPatrolFramework.Base;

namespace SmartPatrolFramework.Extensions
{
    public static class WebElementExtensions
    { 
   public static string GetSelectedDropDown(this IWebElement element)
    {
        SelectElement ddl = new SelectElement(element);
        return ddl.AllSelectedOptions.First().ToString();
    }

    public static IList<IWebElement> GetSelectedListOptions(this IWebElement element)
    {
        SelectElement ddl = new SelectElement(element);
        return ddl.AllSelectedOptions;
    }

    public static string GetLinkText(this IWebElement element)
    {
        return element.Text;
    }


    public static void SelectDropDownList(this IWebElement element, string value)
    {
        SelectElement ddl = new SelectElement(element);
        ddl.SelectByText(value);
    }


        //public static void Hover(this IWebElement element)
        //{
        //    Actions actions = new Actions(DriverContext.Driver);
        //    actions.MoveToElement(element).Perform();
        //}


        public static void AssertElementPresent(this IWebElement element)
    {
        if (!IsElementPresent(element))
            throw new Exception(string.Format("Element Not Present exception"));
    }


        

        public static bool IsElementPresent(this IWebElement element)
    {
        try
        {
            bool ele = element.Displayed;
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

        public static bool IsElementNotPresent(this IWebElement element)
        {
            try
            {
                bool ele = element.Displayed;
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }


        public static bool IsElementDisplayed(this IWebDriver driver, By element)
        {
            if (driver.FindElements(element).Count > 0)
            {
                if (driver.FindElement(element).Displayed)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

    }
}

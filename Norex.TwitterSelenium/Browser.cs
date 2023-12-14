using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Norex.TwitterSelenium
{
    /// <summary>
    /// object of this class containt a chrome web driver. this class function helps us to work with Browser Easily
    /// </summary>
    internal class Browser
    {
        public Browser(bool OpenBrowser = true)
        {
            if (OpenBrowser)
            {
                // run default (with Opening browser)
                driver = new ChromeDriver();
            }
            else
            {
                // run without opening browser
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--headless");
                chromeOptions.AddArgument("--disable-gpu");
                driver = new ChromeDriver(chromeOptions);
            }
        }
        private ChromeDriver driver { set; get; }
    }
}
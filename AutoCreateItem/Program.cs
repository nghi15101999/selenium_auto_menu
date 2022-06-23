using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AutoCreateItem
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver cd = new ChromeDriver();

            cd.Url = "https://danhmuc.hanhchinhcong.net/sites/csdlc/Lists/Menu/AllItems.aspx";
            cd.Navigate(); 
             var username = cd.FindElement(By.Id("ctl00_PlaceHolderMain_signInControl_UserName"));
            var password = cd.FindElement(By.Id("ctl00_PlaceHolderMain_signInControl_password"));
            var btnlogin = cd.FindElement(By.Id("ctl00_PlaceHolderMain_signInControl_login"));    
            username.SendKeys("demo1");
            Thread.Sleep(1500);
            password.SendKeys("Demo123");
            Thread.Sleep(1500);
            btnlogin.Click();
            Thread.Sleep(1500);
            var additem = cd.FindElement(By.XPath("/html/body/form/div[12]/div/div[2]/div[2]/div[3]/div[1]/div/div/div/table/tbody/tr/td/table[1]/tbody/tr/td/a"));
            additem.Click();
            Thread.Sleep(1500); 
            var title= cd.FindElement(By.Id("Title_fa564e0f-0c70-4ab9-b863-0177e6ddd247_$TextField"));
            var link = cd.FindElement(By.Id("Link_a9722081-8f08-46de-8a44-d91ca18a1188_$TextField"));
            var active = cd.FindElement(By.Id("IsDefault_50389204-fa01-4efe-9352-94397b899a25_$BooleanField"));
            var parent = cd.FindElement(By.Id("Parent_09c25cf0-6404-428a-881b-83297bce6a45_$LookupField"));
            var selectElement = new SelectElement(parent);
            title.SendKeys("Testselenium");
            Thread.Sleep(1500);
            link.SendKeys("SendLinnk");
            Thread.Sleep(1500);
            active.Click();
            Thread.Sleep(1500);
            selectElement.SelectByText("Cấp xã");
            Thread.Sleep(1500);
            //var btnsave = cd.FindElement(By.XPath("//*[@id="ctl00_ctl33_g_af8c0982_6305_4fc7_adc6_d93578199ae0_ctl00_toolBarTbl_RightRptControls_ctl00_ctl00_diidIOSaveItem"]"));
            //cd.Quit();
            //parent.SelectByValue("College");





        }
    }
}

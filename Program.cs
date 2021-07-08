using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;

namespace ConsoleApp2
{
    class Program
    {
       static void Main(string[] args)
        {   
            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
            try
            {
                driver.FindElement(By.XPath("//*[@id='fname']")).SendKeys("Bhanudeep");
                driver.FindElement(By.XPath("//*[@id='lname'] ")).SendKeys("Simhadri");
                driver.FindElement(By.XPath("//*[@id='mobile']")).SendKeys("7013695375");
                driver.FindElement(By.XPath("//*[@id='dob']")).SendKeys("1999-07-26");
                driver.FindElement(By.XPath("//*[@id='email']")).SendKeys("bhanudeep6@gmail.com");
                driver.FindElement(By.XPath("//*[@id='country']")).SendKeys("India");
                driver.FindElement(By.XPath("//*[@id='state']")).SendKeys("India");
                driver.FindElement(By.XPath("//*[@id='automationtestform']/div[1]/div[11]/textarea")).SendKeys("Tech Enthusist, fast learner ");
                driver.FindElement(By.XPath("//*[@id='mytextarea_ifr']")).SendKeys("I really am a fast learner");
                driver.FindElement(By.XPath("//*[@id='automationtestform']/div[2]/div[1]/div/div[1]/div/div/input")).SendKeys("bhanudeep");
                driver.FindElement(By.XPath("//*[@id='automationtestform']/div[2]/div[2]/div/div/input")).SendKeys("password");
                driver.FindElement(By.XPath("//*[@id='automationtestform']/div[2]/div[3]/div/div/input ")).SendKeys("password");
                IWebElement element = driver.FindElement(By.XPath("//*[@id='automationtestform']/div[2]/div[1]/div/div[2]/input"));
                element.SendKeys("C:\\Users\\bhanu\\Desktop\\Resumenew.pdf");
                IWebElement oCheckBox = driver.FindElement(By.XPath("//*[@id='male']"));
                oCheckBox.Click();
                IWebElement oCheckBox1 = driver.FindElement(By.XPath("//*[@id='Reading']"));
                oCheckBox1.Click();
                IWebElement oCheckBox2 = driver.FindElement(By.XPath("//*[@id='Agree']"));
                oCheckBox2.Click();
                IWebElement oCheckBox3 = driver.FindElement(By.XPath("//*[@id='automationtestform']/div[4]/button[1]"));
                oCheckBox3.Click();



                driver.Navigate().GoToUrl("https://app.cloudqa.io/Home/IFrame");
                driver.FindElement(By.XPath("//*[@id='fname']")).SendKeys("Bhanudeep");
                driver.FindElement(By.XPath("//*[@id='lname'] ")).SendKeys("Simhadri");
                driver.FindElement(By.XPath("//*[@id='mobile']")).SendKeys("7013695375");
                driver.FindElement(By.XPath("//*[@id='dob']")).SendKeys("1999-07-26");
                driver.FindElement(By.XPath("//*[@id='email']")).SendKeys("bhanudeep6@gmail.com");
                driver.FindElement(By.XPath("//*[@id='country']")).SendKeys("India");
                driver.FindElement(By.XPath("//*[@id='state']")).SendKeys("India");
                driver.FindElement(By.XPath("//*[@id='automationtestform']/div[1]/div[11]/textarea")).SendKeys("Tech Enthusist, fast learner ");
                driver.FindElement(By.XPath("//*[@id='automationtestform']/div[2]/div[1]/div/div[1]/div/div/input")).SendKeys("bhanudeep");
                driver.FindElement(By.XPath("//*[@id='automationtestform']/div[2]/div[2]/div/div/input")).SendKeys("password");
                driver.FindElement(By.XPath("//*[@id='automationtestform']/div[2]/div[3]/div/div/input ")).SendKeys("password");
                IWebElement element1 = driver.FindElement(By.XPath("//*[@id='automationtestform']/div[2]/div[1]/div/div[2]/input"));
                element1.SendKeys("C:\\Users\\bhanu\\Desktop\\Resumenew.pdf");
                IWebElement oCheckBox4 = driver.FindElement(By.XPath("//*[@id='male']"));
                oCheckBox4.Click();
                IWebElement oCheckBox5 = driver.FindElement(By.XPath("//*[@id='Reading']"));
                oCheckBox5.Click();
                IWebElement oCheckBox6 = driver.FindElement(By.XPath("//*[@id='Agree']"));
                oCheckBox6.Click();
                IWebElement oCheckBox7 = driver.FindElement(By.XPath("//*[@id='automationtestform']/div[4]/button[1]"));
                oCheckBox7.Click();


                driver.Navigate().GoToUrl("https://app.cloudqa.io/Home/InnerNestedIFrame");
                driver.FindElement(By.XPath("//*[@id='fname']")).SendKeys("Bhanudeep");
                driver.FindElement(By.XPath("//*[@id='lname'] ")).SendKeys("Simhadri");
                driver.FindElement(By.XPath("//*[@id='mobile']")).SendKeys("7013695375");
                driver.FindElement(By.XPath("//*[@id='dob']")).SendKeys("1999-07-26");
                driver.FindElement(By.XPath("//*[@id='email']")).SendKeys("bhanudeep6@gmail.com");
                driver.FindElement(By.XPath("//*[@id='country']")).SendKeys("India");
                driver.FindElement(By.XPath("//*[@id='state']")).SendKeys("India");
                driver.FindElement(By.XPath("//*[@id='automationtestform']/div[1]/div[11]/textarea")).SendKeys("Tech Enthusist, fast learner ");
                driver.FindElement(By.XPath("//*[@id='automationtestform']/div[2]/div[1]/div/div[1]/div/div/input")).SendKeys("bhanudeep");
                driver.FindElement(By.XPath("//*[@id='automationtestform']/div[2]/div[2]/div/div/input")).SendKeys("password");
                driver.FindElement(By.XPath("//*[@id='automationtestform']/div[2]/div[3]/div/div/input ")).SendKeys("password");
                IWebElement element2 = driver.FindElement(By.XPath("//*[@id='automationtestform']/div[2]/div[1]/div/div[2]/input"));
                element2.SendKeys("C:\\Users\\bhanu\\Desktop\\Resumenew.pdf");
                IWebElement oCheckBox8 = driver.FindElement(By.XPath("//*[@id='male']"));
                oCheckBox8.Click();
                IWebElement oCheckBox9 = driver.FindElement(By.XPath("//*[@id='Reading']"));
                oCheckBox9.Click();
                IWebElement oCheckBox10 = driver.FindElement(By.XPath("//*[@id='Agree']"));
                oCheckBox10.Click();
                IWebElement oCheckBox11 = driver.FindElement(By.XPath("//*[@id='automationtestform']/div[4]/button[1]"));
                oCheckBox11.Click();



            }
            catch (Exception ex)
            {
                Debug.WriteLine("<<< catch : " + ex.ToString());
            }
        }
    }
}

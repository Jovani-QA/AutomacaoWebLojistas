using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoWebCasting.campanhas.page
{
    class TreofeuPermanetePage
    {
        private IWebDriver driver;

        // Construtor que recebe uma instância de IWebDriver para interagir com o navegador
        public TreofeuPermanetePage(IWebDriver driver)
        {
            driver = driver;
        }

        // Mapeamento dos elementos da página de login
        public IWebElement moduloCampanhas => driver.FindElement(By.XPath("//*[@id='UserName']"));
        public IWebElement SenhaInput => driver.FindElement(By.XPath("//*[@id='Password']"));
        public IWebElement EntrarButton => driver.FindElement(By.XPath("//*[@id='btnEntrar']"));
    }
}


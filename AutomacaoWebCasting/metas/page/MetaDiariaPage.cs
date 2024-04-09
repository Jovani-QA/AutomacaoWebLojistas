using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metas.page
{
    class MetaDiariaPage
    {
        private IWebDriver driver;

        // Construtor que recebe uma instância de IWebDriver para interagir com o navegador
        public MetaDiariaPage(IWebDriver driver)
        {
            this.driver = driver; // Correção: atribui o driver ao campo da classe
        }


        // Mapeamento dos elementos da página de login
        public IWebElement ModuloMesa => driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[2]/form[1]/ul[1]/li[1]/a[1]"));
        public IWebElement metasDiarias => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[2]/div[2]/ul[1]/li[1]/div[2]/div[4]/a[1]/i[1]"));
        public IWebElement inserirMetaDiaria1 => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/form[1]/fieldset[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/div[17]/input[4]"));
        public IWebElement inserirMetaDiaria2 => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/form[1]/fieldset[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/div[18]/input[4]"));
        public IWebElement clicarBtnSalvar => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/form[1]/fieldset[1]/div[1]/div[3]/button[2]"));

    }

}


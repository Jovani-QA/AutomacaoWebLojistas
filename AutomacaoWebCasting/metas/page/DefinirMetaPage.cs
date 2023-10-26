using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metas.page
{
    class DefinirMetaPage
    {
        private IWebDriver driver;

        // Construtor que recebe uma instância de IWebDriver para interagir com o navegador
        public DefinirMetaPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        // Mapeamento dos elementos da página de Definir metas diárias
        public IWebElement ModuloMeta=> driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[2]/form[1]/ul[1]/li[1]/a[1]"));
        public IWebElement definirMetas => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[2]/div[2]/ul[1]/li[1]/div[2]/div[4]/a[1]/i[1]"));
        public IWebElement inserirValorMeta => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/form[1]/fieldset[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/input[1]"));
        public IWebElement clicarBtnInserirFuncionario=> driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/form[1]/fieldset[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/button[1]"));
        public IWebElement BtnIncluir => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/form[1]/fieldset[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/button[1]"));
        public IWebElement inserirFuncionario1 => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/form[1]/fieldset[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/button[1]"));
        public IWebElement inserirFuncionario2 => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/form[1]/fieldset[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/button[1]"));
        public IWebElement btnDistribuir => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/form[1]/fieldset[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/button[1]/i[1]"));
        public IWebElement distribuirMeta => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/form[1]/fieldset[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/ul[1]/li[1]/a[1]"));
        public IWebElement clicarBtnSalvar => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/form[1]/fieldset[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[3]/button[3]"));

    }
}

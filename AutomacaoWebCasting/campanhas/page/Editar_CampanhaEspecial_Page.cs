using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoWebCasting.campanhas.page
{
    class Editar_CampanhaEspecial_Page
    {
        private IWebDriver driver;

        // Construtor que recebe uma instância de IWebDriver para interagir com o navegador
        public Editar_CampanhaEspecial_Page(IWebDriver driver)

        {
            this.driver = driver;
        }

        // Mapeamento criar campanha especial
        public IWebElement editarCampanhas => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/a[2]/i[1]"));
        public IWebElement clicarengrenagem => driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div[2]/div/div/div[2]/div[2]/div/div/div/div/div[3]/a"));
        public IWebElement editarNomeCampanha => driver.FindElement(By.Id("TRF_NOME"));
        public IWebElement editarDescricaoCampanha => driver.FindElement(By.Id("TRF_DESCRICAO"));
        public IWebElement expandircampoIndicador => driver.FindElement(By.Id("TRF_INDICADOR"));
        public IWebElement editarIndicador => driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div/div[2]/div/form/div[3]/select/option[2]"));
        public IWebElement expandircampoApuracao => driver.FindElement(By.Id("TRF_GRUPO_APURACAO"));
    }
}

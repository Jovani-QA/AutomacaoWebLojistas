using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoWebCasting.campanhas.page
{
    class CriarCampanhaEspecialPage
    {
        private IWebDriver driver;

        // Construtor que recebe uma instância de IWebDriver para interagir com o navegador
        public CriarCampanhaEspecialPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Mapeamento criar campanha especial
        public IWebElement moduloCampanhas => driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[2]/form[1]/ul[1]/li[9]/a[1]"));

        public IWebElement menuCampanhaEspecial => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[2]/div[1]/ul[1]/li[2]/a[1]"));

        public IWebElement btnCriarCampanhaEspecial => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/button[1]"));

        public IWebElement inserirNomeCampanha => driver.FindElement(By.Id("TRF_NOME"));

        public IWebElement inserirDescricaoCampanha => driver.FindElement(By.Id("TRF_DESCRICAO"));

        public IWebElement expandircampoIndicador => driver.FindElement(By.Id("TRF_INDICADOR"));

        public IWebElement selecionarIndicador => driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div/div[2]/div/form/div[3]/select/option[2]"));

        public IWebElement expandircampoApuracao => driver.FindElement(By.Id("TRF_GRUPO_APURACAO"));

        public IWebElement selecionarApuracao => driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div/div[2]/div/form/div[4]/select/option[3]"));

        public IWebElement selecionarLojas => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[5]/div[2]/label[1]/span[1]"));

        public IWebElement selecionarAlamedaSantos => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[6]/div[1]/div[1]/input[3]"));

        public IWebElement selecionarCenterlapa => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[6]/div[1]/div[2]/input[3]"));

        public IWebElement selecionarIcone => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[12]/div[1]/div[5]/img[1]"));

        public IWebElement inserirdataInicio => driver.FindElement(By.Id("TRF_INICIO"));

        public IWebElement inserirDataFim => driver.FindElement(By.Id("TRF_FIM"));

        public IWebElement btnadicionarPosicao => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[15]/table[1]/thead[1]/tr[1]/th[3]/div[1]/a[1]/i[1]"));

        public IWebElement inserirPosicao => driver.FindElement(By.Id("Premiacao_0__Posicao"));

        public IWebElement inserirPremio => driver.FindElement(By.Id("Premiacao_0__Valor"));

        public IWebElement btnSalvar => driver.FindElement(By.Id("btnSave"));

        public IWebElement btnCancelar => driver.FindElement(By.Id("btnCancel"));

        public IWebElement btnExcluirPremiacao => driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[15]/table[1]/tbody[1]/tr[1]/td[3]/div[1]/a[1]/i[1]" + ""));
        public IWebElement mensagemAssertiva => driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/div[2]/p"));

       public IWebElement mensagemElemento => driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/div[2]/p"));

    }
}



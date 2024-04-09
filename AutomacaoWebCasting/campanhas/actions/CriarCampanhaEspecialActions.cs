using AutomacaoWebCasting.campanhas.page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AutomacaoWebCasting.campanhas.actions
{
    class CriarCampanhaEspecialActions
    {
        private CriarCampanhaEspecialPage campanhaespecialPage;
        private IWebDriver driver;

        public CriarCampanhaEspecialActions(CriarCampanhaEspecialPage campanhaespecialPage, IWebDriver driver)
        {
            this.campanhaespecialPage = campanhaespecialPage;
            this.driver = driver;

        }


        public void ClicarModuloCampanhas()
        {
            campanhaespecialPage.moduloCampanhas.Click();
        }

        public void ClicarNoMenuCampanhasEspeciais()
        {
            campanhaespecialPage.menuCampanhaEspecial.Click();
        }

        public void CriarNovaCampanha()
        {
            campanhaespecialPage.btnCriarCampanhaEspecial.Click();
        }

        public void InserirNomeDaCampanha(String nomeCampanha)
        {
            campanhaespecialPage.inserirNomeCampanha.SendKeys(nomeCampanha.ToString());
        }

        public void InserirNomeDescricao(String nomeCampanha)
        {
            campanhaespecialPage.inserirDescricaoCampanha.SendKeys(nomeCampanha.ToString());
        }

        public void ExpadirCampoIndicador()
        {
            campanhaespecialPage.expandircampoIndicador.Click();
        }

        public void SelecionarIndicador()
        {
            campanhaespecialPage.expandircampoIndicador.Click();
            campanhaespecialPage.selecionarIndicador.Click();
        }

        public void ExpandirCampoApuracao()
        {
            campanhaespecialPage.expandircampoApuracao.Click();

        }

        public void SelecionarLojas()
        {
            campanhaespecialPage.selecionarLojas.Click();
            campanhaespecialPage.selecionarAlamedaSantos.Click();
            campanhaespecialPage.selecionarCenterlapa.Click();
        }

        public void Scroll()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 1050)");
        }


        public void SelecionarIcone()
        {
            campanhaespecialPage.selecionarIcone.Click();
        }

        public void InserirDataInicialEDataFinal(String dtInicio, String dtFim)
        {
            campanhaespecialPage.inserirdataInicio.SendKeys(dtInicio.ToString());
            campanhaespecialPage.inserirDataFim.SendKeys(dtFim.ToString());
        }

        public void AdicionarPremiacao(String premiacao)
        {
            campanhaespecialPage.btnadicionarPosicao.Click();
            campanhaespecialPage.inserirPremio.SendKeys(premiacao);
        }

        public void SalvarCampanha()
        {
            campanhaespecialPage.btnSalvar.Click();

        }

        //public string ObterMensagemAposAcao()
        //{
        //    // Espera até que o elemento da mensagem seja visível na página (pode variar de acordo com sua aplicação)
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //    IWebElement mensagemElemento = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[4]/div/div[2]/div[2]/p")));

        //    // Obtém o texto do elemento
        //    string mensagem = mensagemElemento.Text.Trim();

        //    return mensagem;
        //}

        //public void VerificarMensagemDeSucesso()
        //{
        //    string mensagem = ObterMensagemAposAcao();

        //    // Verifica se a mensagem é igual a "Ação concluída com sucesso!"
        //    Assert.AreEqual("Ação concluída com sucesso!", mensagem);
        //}

        public void VerificarMensagemDeSucesso()
        {
            string mensagem = campanhaespecialPage.mensagemElemento.Text.Trim();

            // Verifica se a mensagem é igual a "Ação concluída com sucesso!"
            if (mensagem.Equals("Ação concluída com sucesso!"))
            {
                Console.WriteLine("A campanha foi criada com sucesso");
            }
            else
            {
                Console.WriteLine("Ops, houve algum erro na criação da campanha, por favor verifique");
                Assert.Fail("Mensagem de sucesso não foi exibida corretamente.");
            }
        }



    }
}

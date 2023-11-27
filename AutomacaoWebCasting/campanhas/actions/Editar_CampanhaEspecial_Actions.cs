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
    class Editar_CampanhaEspecial_Actions
    {
        private Editar_CampanhaEspecial_Page editarCampanhaPage;
        private IWebDriver driver;

        public Editar_CampanhaEspecial_Actions(Editar_CampanhaEspecial_Page editarCampanhaPage, IWebDriver driver)
        {
            this.editarCampanhaPage = editarCampanhaPage;
            this.driver = driver;

        }

        public void ClicarModuloCampanhas()
        {
            editarCampanhaPage.editarCampanhas.Click();
        }
        public void ClicarEngrenagemConfiguracaoCampanha()
        {
            editarCampanhaPage.clicarengrenagem.Click();
        }

        public void EditarNomeCampanha(String nome)
        {
            editarCampanhaPage.editarNomeCampanha.Clear();
            editarCampanhaPage.editarNomeCampanha.SendKeys(nome);
        }

    }
}
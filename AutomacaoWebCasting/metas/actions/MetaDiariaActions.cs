
using metas.page;
using OpenQA.Selenium;
using System;

namespace metas.actions
{
    class MetaDiariaActions
    {
        private MetaDiariaPage metaPage;

        public MetaDiariaActions(MetaDiariaPage metaPage)
        {
            this.metaPage = metaPage;
        }


        public void ClicarModuloMesa()
        {
            metaPage.ModuloMesa.Click();
        }

        public void clicarEmMetasDiarias()
        {
            metaPage.metasDiarias.Click();
        }

        public void inserirMetaDiaria1(string valor1)
        {
            metaPage.inserirMetaDiaria1.Clear();
            metaPage.inserirMetaDiaria1.SendKeys(valor1.ToString());
        }

        public void inserirMetaDiaria2(string valor2)
        {
            metaPage.inserirMetaDiaria2.Clear();
            metaPage.inserirMetaDiaria2.SendKeys(valor2.ToString());
        }

        public void salvarMeta()
        {
            metaPage.clicarBtnSalvar.Click();

        }

        public void limparCampo1(string valor3)
        {
            metaPage.inserirMetaDiaria1.Clear();
            metaPage.inserirMetaDiaria1.SendKeys(valor3.ToString());

        }
        public void limparCampo2(string valor3)
        {
            metaPage.inserirMetaDiaria2.Clear();
            metaPage.inserirMetaDiaria2.SendKeys(valor3.ToString());

        }
    }
}


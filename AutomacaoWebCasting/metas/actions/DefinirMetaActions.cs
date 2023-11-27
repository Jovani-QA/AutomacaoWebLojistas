
using metas.page;
using OpenQA.Selenium;
using System;

namespace Mesa
{
    class DefinirMetaActions
    {
        private DefinirMetaPage mensalPage;

        public DefinirMetaActions(DefinirMetaPage mensalPage)
        {
            this.mensalPage = mensalPage;
        }


        public void ClicarModuloMeta()
        {
            mensalPage.ModuloMeta.Click();
        }

        public void clicarEmMetasMensais()
        {
            mensalPage.definirMetas.Click();
        }

        public void inserirMetaDiaria1(string valor1)
        {
            //metaPage.inserirMetaDiaria1.Clear();
            //metaPage.inserirMetaDiaria1.SendKeys(valor1.ToString());
        }

        public void inserirMetaDiaria2(string valor2)
        {
           // metaPage.inserirMetaDiaria2.Clear();
            //metaPage.inserirMetaDiaria2.SendKeys(valor2.ToString());
        }

        public void salvarMeta()
        {
            //metaPage.clicarBtnSalvar.Click();

        }

        public void limparCampo1(string valor3)
        {
            //metaPage.inserirMetaDiaria1.Clear();
            //metaPage.inserirMetaDiaria1.SendKeys(valor3.ToString());

        }
        public void limparCampo2(string valor3)
        {
            //metaPage.inserirMetaDiaria2.Clear();
            //metaPage.inserirMetaDiaria2.SendKeys(valor3.ToString());

        }
    }
}


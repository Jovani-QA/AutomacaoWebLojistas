using AutomacaoWebCasting.campanhas.page;
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

        public CriarCampanhaEspecialActions(CriarCampanhaEspecialPage campanhaespecialPage)
        {
            this.campanhaespecialPage = campanhaespecialPage;
        }


        public void ClicarModuloCampanhas()
        {
            campanhaespecialPage.moduloCampanhas.Click();
        }
    }
}
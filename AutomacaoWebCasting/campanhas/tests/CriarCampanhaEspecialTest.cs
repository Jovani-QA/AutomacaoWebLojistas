using AutomacaoWebCasting.campanhas.actions;
using AutomacaoWebCasting.campanhas.page;
using CastingWeb.Actions;
using CastingWeb.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject8.config;

namespace AutomacaoWebCasting.campanhas.tests
{
    [TestFixture]
    class CriarCampanhaEspecialTest
    {
        private Config config;
        private User user;
        private PageLogin page;
        private Actions actions;
        private CriarCampanhaEspecialPage campanhaespecialPage; // Adicione uma instância de MesaPage
        private CriarCampanhaEspecialActions campanhaEspecialActions; // Adicione uma instância de MesaActions

        String nomeCampanha = " Cmapanha de natal 10";
        String nomeDescricao = "teste";
        String dtInicio = "10/11/2023";
        String dtFim = "10/12/2024";
        String valor = "500";

        [SetUp]
        public void Setup()
        {
            config = new Config(AmbienteEnum.Homologacao);
            page = new PageLogin(config.Driver);
            user = User.BD118;
            actions = new Actions(page, user);
            campanhaespecialPage = new CriarCampanhaEspecialPage(config.Driver); // Inicialize MesaPage com o driver
            campanhaEspecialActions = new CriarCampanhaEspecialActions(campanhaespecialPage, config.Driver); // Inicialize MesaActions com a instância de MesaPage

        }


        [Test]
        public void CriarCampanhaEspeial()
        {
            string url = config.Url;
            config.Driver.Navigate().GoToUrl(url);

            actions.FazerLogin();
            campanhaEspecialActions.ClicarModuloCampanhas();
            campanhaEspecialActions.ClicarNoMenuCampanhasEspeciais();
            campanhaEspecialActions.CriarNovaCampanha();
            campanhaEspecialActions.InserirNomeDaCampanha(nomeCampanha);
            campanhaEspecialActions.InserirNomeDescricao(nomeDescricao);
            campanhaEspecialActions.SelecionarIndicador();
            campanhaEspecialActions.ExpandirCampoApuracao();
            campanhaEspecialActions.SelecionarLojas();
            campanhaEspecialActions.Scroll();
            campanhaEspecialActions.SelecionarIcone();
            campanhaEspecialActions.InserirDataInicialEDataFinal(dtInicio, dtFim);
            campanhaEspecialActions.AdicionarPremiacao(valor);
            campanhaEspecialActions.SalvarCampanha();
            campanhaEspecialActions.VerificarMensagemDeSucesso();


        }
    }
}

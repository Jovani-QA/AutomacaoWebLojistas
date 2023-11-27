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
    class Editar_CampanhaEspecial_Test
    {
        private Config    config;
        private User      user;
        private PageLogin page;
        private Actions   actions; 
        private Criar_CampanhaEspecial_Page     criarcampanha_page; // Adicione uma instância de MesaPage
        private Criar_CampanhaEspecial_Actions  criarcampanha_actions; // Adicione uma instância de MesaActions
        private Editar_CampanhaEspecial_Page    Editarcampanha_page; // Adicione uma instância de MesaPage
        private Editar_CampanhaEspecial_Actions editarcampanha_actions; // Adicione uma instância de MesaActions

        String nomeCampanha = "ID - A03";
        String nomeDescricao = "teste";
        String dtInicio = "10/12/2023";
        String dtFim = "10/12/2024";
        String valor = "500";

        [SetUp]
        public void Setup()
        {
            config                  = new Config(AmbienteEnum.Homologacao);
            page                    = new PageLogin(config.Driver);
            user                    = User.BD118;
            actions                 = new Actions(page, user);
            criarcampanha_page      = new Criar_CampanhaEspecial_Page(config.Driver); // Inicialize MesaPage com o driver
            criarcampanha_actions   = new Criar_CampanhaEspecial_Actions(criarcampanha_page, config.Driver);// Inicialize MesaActions com a instância de MesaPage
            Editarcampanha_page     = new Editar_CampanhaEspecial_Page(config.Driver);
            editarcampanha_actions  = new Editar_CampanhaEspecial_Actions(Editarcampanha_page, config.Driver);                                                                    

        }


        [Test]
        public void CriarCampanhaEspeial()
        {
            string url = config.Url;
            config.Driver.Navigate().GoToUrl(url);

            actions.FazerLogin();
            criarcampanha_actions.ClicarModuloCampanhas();
            criarcampanha_actions.ClicarNoMenuCampanhasEspeciais();
            editarcampanha_actions.ClicarEngrenagemConfiguracaoCampanha();
            editarcampanha_actions.EditarNomeCampanha(nomeCampanha);



            //campanhaEspecialActions.CriarNovaCampanha();
            //campanhaEspecialActions.InserirNomeDaCampanha(nomeCampanha);
            //campanhaEspecialActions.InserirNomeDescricao(nomeDescricao);
            //campanhaEspecialActions.SelecionarIndicador();
            //campanhaEspecialActions.ExpandirCampoApuracao();
            //campanhaEspecialActions.SelecionarLojas();
            //campanhaEspecialActions.Scroll();
            //campanhaEspecialActions.SelecionarIcone();
            //campanhaEspecialActions.InserirDataInicialEDataFinal(dtInicio, dtFim);
            //campanhaEspecialActions.AdicionarPremiacao(valor);
            //campanhaEspecialActions.SalvarCampanha();
            //campanhaEspecialActions.VerificarMensagemDeSucesso();


        }
    }
}

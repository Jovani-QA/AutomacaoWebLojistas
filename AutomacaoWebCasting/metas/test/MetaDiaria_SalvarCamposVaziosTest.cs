using CastingWeb.Actions;
using CastingWeb.Pages;
using NUnit.Framework;
using TestProject8.config;
using metas.actions;
using metas.page;

namespace Mesa.mesa.test
{
    [TestFixture]
    class MetaDiaria_SalvarCamposVaziosTest
    {
        private Config config;
        private PageLogin page;
        private Actions actions;
        private User user;
        private MetaDiariaPage metaPage; // Adicione uma instância de MesaPage
        private MetaDiariaActions metaActions; // Adicione uma instância de MesaActions
        string valor1 = "1000";
        string valor2 = "1200";
        string valor3 = "00";

        [SetUp]
        public void Setup()
        {
            config = new Config(AmbienteEnum.Homologacao);
            page = new PageLogin(config.Driver);
            user = User.BD118;
            actions = new Actions(page, user);
            metaPage = new MetaDiariaPage(config.Driver); // Inicialize MesaPage com o driver
            metaActions = new MetaDiariaActions(metaPage); // Inicialize MesaActions com a instância de MesaPage
        }

        [Test]
        public void salvarMetaDiaria()
        {
            string url = config.Url;
            config.Driver.Navigate().GoToUrl(url);

            actions.FazerLogin();
            metaActions.ClicarModuloMesa();
            metaActions.clicarEmMetasDiarias();
            metaActions.limparCampoA();
            metaActions.limparCampoB();
            metaActions.salvarMeta();

            MetasDiariasSalvarCamposVaziosValidation.LimparCampos_E_SalvarMeta(config.Driver);
        }



        [TearDown]
        public void Teardown()
        {
           
        }
    }
}



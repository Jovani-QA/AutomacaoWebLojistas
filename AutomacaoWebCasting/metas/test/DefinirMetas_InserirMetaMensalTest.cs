using CastingWeb.Actions;
using CastingWeb.Pages;
using NUnit.Framework;
using TestProject8.config;
using metas.actions;
using metas.page;
using Mesa;

namespace AutomacaoWebCasting.metas.test
{ 

[TestFixture]
class DefinirMetas_InserirMetaMensalTest
{
    private Config config;
    private PageLogin page;
    private Actions actions;
    private User user;
    private DefinirMetaPage definirMetaMensalPage; // Adicione uma instância de MesaPage
    private DefinirMetaActions definirMetaMensalActions; // Adicione uma instância de MesaActions
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
        definirMetaMensalPage = new DefinirMetaPage(config.Driver); // Inicialize MesaPage com o driver
        definirMetaMensalActions = new DefinirMetaActions(definirMetaMensalPage); // Inicialize MesaActions com a instância de MesaPage
        }

        [Test]
        public void salvarMetaDiaria()

        {
            string url = config.Url;
            config.Driver.Navigate().GoToUrl(url);

            actions.FazerLogin();
            definirMetaMensalActions.ClicarModuloMeta();
            definirMetaMensalActions.clicarEmMetasMensais();

        }

        [TearDown]
        public void Teardown()
        {

        }
    }
}
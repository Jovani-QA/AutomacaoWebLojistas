using NUnit.Framework;
using OpenQA.Selenium;
using System;


public class MetasDiariasSalvarCamposVaziosValidation
{
    public static void LimparCampos_E_SalvarMeta(IWebDriver driver)
    {
        string urlAtual = driver.Url;

        // Assert para verificar se a URL é igual ao link fornecido
        //Assert.AreEqual("http://169.62.128.213/Casting/CASTING_ADM_HOMO/Unidade", urlAtual);
        //Assert.AreEqual("http://169.62.128.213/Casting/CASTING_ADM_HOMO/MetasDia?und=7ad208af-785e-4003-8e55-f80e78f51a58", urlAtual);

        if (urlAtual.Equals("http://169.62.128.213/Casting/CASTING_ADM_HOMO/Unidade"))
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("var popup = document.createElement('div');" +
                             "popup.innerHTML = 'Teste passou!';" +
                             "popup.style.backgroundColor = 'green';" +
                             "popup.style.color = 'white';" +
                             "popup.style.padding = '20px';" +
                             "popup.style.position = 'fixed';" +
                             "popup.style.top = '10px';" +
                             "popup.style.right = '10px';" +  // Posiciona a mensagem no lado direito
                             "popup.style.zIndex = '9999';" +
                             "document.body.appendChild(popup);" +
                             "setTimeout(function(){popup.remove();}, 3000);");
        }
        else
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("var popup = document.createElement('div');" +
                             "popup.innerHTML = 'O teste falhou';" +
                             "popup.style.backgroundColor = 'red';" +
                             "popup.style.color = 'white';" +
                             "popup.style.padding = '20px';" +
                             "popup.style.position = 'fixed';" +
                             "popup.style.top = '10px';" +
                             "popup.style.right = '10px';" +  // Posiciona a mensagem no lado direito
                             "popup.style.zIndex = '9999';" +
                             "document.body.appendChild(popup);" +
                             "setTimeout(function(){popup.remove();}, 3000);");
        }

    }
}


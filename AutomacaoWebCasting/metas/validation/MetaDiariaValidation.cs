using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class MetaDiariaValidation
{
    public static void ValidarSomaMetasDiarias(string valor1, string valor2, IWebDriver driver)
    {
        string valorXPath = driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[2]/div[2]/ul[1]/li[1]/div[3]/a[1]/span[1]")).Text;
        Console.WriteLine("Valor do XPath: " + valorXPath);

        // Remover caracteres não numéricos e vírgula
        string valorNumerico = valorXPath.Replace("R$", "").Replace(",", "").Trim();

        int valorEsperado;
        if (Int32.TryParse(valorNumerico, out valorEsperado))
        {
            int somaValores = int.Parse(valor1) + int.Parse(valor2);

            Assert.Equals(somaValores == 2200, "A soma dos valores das metas diárias não é igual ao valor esperado.");
            //Assert.IsTrue(valorEsperado == somaValores || somaValores == 22);
            //Assert.AreEqual(somaValores, valorEsperado, "A soma dos valores das metas diárias não é igual ao valor esperado.");

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
            Assert.Fail("O valor retornado pelo XPath não pôde ser convertido em Int32.");

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

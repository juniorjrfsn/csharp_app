using System.Web.Http;
using WebActivatorEx;
using POO2RestAPI;
using Swashbuckle.Application;
using System;
using System.Xml.XPath;
using System.Linq;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace POO2RestAPI
{
    /// <summary>
    /// 
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.Schemes(new[] { "http", "https" });
                        c.SingleApiVersion("v1", "POO2RestAPI - 2020")
                            .Description("Conjunto de Recursos disponível para o projeto.")
                            .TermsOfService("Termos de Serviço")
                            .Contact(cc => cc
                                .Name("Professor Luiz Augusto")
                                .Url("http://POO2RestAPI.com.br/contato")
                                .Email("contato@POO2RestAPI.com.br"))
                            .License(lc => lc
                                .Name("Licença do Projeto")
                                .Url("http://POO2RestAPI.com.br/licenca"));
                        c.PrettyPrint();
                        c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                        c.ApiKey("apiKey")
                            .Description("API Key para acessar API de forma segura.")
                            .Name("Api-key-projeto")
                            .In("header");
                        c.IncludeXmlComments(GetXmlCommentsPath());
                    })
                .EnableSwaggerUi(c =>
                    {
                        c.DocumentTitle("POO2RestAPI - 2020 - Swagger UI");
                        c.DocExpansion(DocExpansion.List);
                        c.EnableDiscoveryUrlSelector();
                    });
        }

        private static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}\Docs\POO2RestAPI.xml", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}

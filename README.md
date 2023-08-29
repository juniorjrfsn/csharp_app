# csharp_app
Apicações exemplos de c#


Projeto-POO2-2020-2/POO2RestAPICamadas/App_Start
 
WebApiConfig.cs

config.Routes.MapHttpRoute(
	name: "DefaultApi",
	routeTemplate: "api/{controller}/{id}",
	defaults: new { id = RouteParameter.Optional }
);
using ServiceStack.Api.Swagger;
using ServiceStack.WebHost.Endpoints;
using Stars.Web.Api;

[assembly: WebActivator.PreApplicationStartMethod(typeof(Stars.Web.App_Start.AppHost), "Start")]
namespace Stars.Web.App_Start
{
    public class AppHost : AppHostBase
	{		
		public AppHost() //Tell ServiceStack the name and where to find your web services
			: base("STARS API", typeof(ClientService).Assembly) { }

		public override void Configure(Funq.Container container)
		{
			//Set JSON web services to return idiomatic JSON camelCase properties
			ServiceStack.Text.JsConfig.EmitCamelCaseNames = true;

            //Setup StructureMap as the IOC to use instead of Funq
            container.Adapter = new StructureMapContainerAdapter();

            Plugins.Add(new SwaggerFeature());


            //TODO: Register your dependencies
            //ObjectFactory.Inject(typeof(IFoo), new Foo());

			//Set MVC to use the same Funq IOC as ServiceStack
			//ControllerBuilder.Current.SetControllerFactory(new FunqControllerFactory(container));
		}

		public static void Start()
		{
			new AppHost().Init();
		}
	}
}
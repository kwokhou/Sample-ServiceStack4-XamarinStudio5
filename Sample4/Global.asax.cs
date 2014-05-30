
namespace Sample4
{
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.Web;
	using System.Web.SessionState;
	using ServiceStack;

	public class Global : System.Web.HttpApplication
	{
		public class AppHost : AppHostBase
		{
			//Tell ServiceStack the name of your application and where to find your services
			public AppHost() : base("Hello Web Services", typeof(HelloService).Assembly) { }

			public override void Configure(Funq.Container container)
			{
				//register any dependencies your services use, e.g:
				//container.Register<ICacheClient>(new MemoryCacheClient());
			}
		}
		
		protected void Application_Start (Object sender, EventArgs e)
		{
			new AppHost().Init();
		}

		protected void Session_Start (Object sender, EventArgs e)
		{
		}

		protected void Application_BeginRequest (Object sender, EventArgs e)
		{
		}

		protected void Application_EndRequest (Object sender, EventArgs e)
		{
		}

		protected void Application_AuthenticateRequest (Object sender, EventArgs e)
		{
		}

		protected void Application_Error (Object sender, EventArgs e)
		{
		}

		protected void Session_End (Object sender, EventArgs e)
		{
		}

		protected void Application_End (Object sender, EventArgs e)
		{
		}
	}
}


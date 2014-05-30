using System;
using ServiceStack;

namespace Sample4
{
	public class Hello 
	{
		public string Name {
			get;
			set;
		}
	}

	public class HelloResponse 
	{
		public string Result {
			get;
			set;
		}
	}

	public class HelloService : Service
	{
		public object Any(Hello request)
		{
			return new HelloResponse { Result = "Hello, " + request.Name };
		}
	}

	public class Hello2
	{
		public string Name {
			get;
			set;
		}
	}

	public class Hello2Response 
	{
		public string Result {
			get;
			set;
		}
	}

	public class Hello2Service : Service
	{
		public object Any(Hello2 request)
		{
			return new HelloResponse { Result = "Hello, " + request.Name };
		}
	}

	public class Hello3 
	{
		public string Name {
			get;
			set;
		}
	}

	public class Hello3Response 
	{
		public string Result {
			get;
			set;
		}
	}

	public class Hello3Service : Service
	{
		public object Any(Hello3 request)
		{
			return new HelloResponse { Result = "Hello, " + request.Name };
		}
	}

	public class Hello4 
	{
		public string Name {
			get;
			set;
		}
	}

	public class Hello4Response 
	{
		public string Result {
			get;
			set;
		}
	}

	public class Hello4Service : Service
	{
		public object Any(Hello4 request)
		{
			return new HelloResponse { Result = "Hello, " + request.Name };
		}
	}

	public class Hello5 
	{
		public string Name {
			get;
			set;
		}
	}

	public class Hello5Response 
	{
		public string Result {
			get;
			set;
		}
	}

	public class Hello5Service : Service
	{
		public object Any(Hello5 request)
		{
			return new HelloResponse { Result = "Hello, " + request.Name };
		}
	}
}

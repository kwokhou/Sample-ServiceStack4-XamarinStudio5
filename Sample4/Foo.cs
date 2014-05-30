using System;
using ServiceStack;

namespace Sample4
{
	public class Foo 
	{
		public string Name {
			get;
			set;
		}
	}

	public class FooResponse 
	{
		public string Result {
			get;
			set;
		}
	}

	public class FooService : Service
	{
		public object Any(Foo request)
		{
			return new FooResponse { Result = "Foo, " + request.Name };
		}
	}

	public class Foo2
	{
		public string Name {
			get;
			set;
		}
	}

	public class Foo2Response 
	{
		public string Result {
			get;
			set;
		}
	}

	public class Foo2Service : Service
	{
		public object Any(Foo2 request)
		{
			return new FooResponse { Result = "Foo, " + request.Name };
		}
	}

	public class Foo3 
	{
		public string Name {
			get;
			set;
		}
	}

	public class Foo3Response 
	{
		public string Result {
			get;
			set;
		}
	}

	public class Foo3Service : Service
	{
		public object Any(Foo3 request)
		{
			return new FooResponse { Result = "Foo, " + request.Name };
		}
	}

	public class Foo4 
	{
		public string Name {
			get;
			set;
		}
	}

	public class Foo4Response 
	{
		public string Result {
			get;
			set;
		}
	}

	public class Foo4Service : Service
	{
		public object Any(Foo4 request)
		{
			return new FooResponse { Result = "Foo, " + request.Name };
		}
	}

	public class Foo5 
	{
		public string Name {
			get;
			set;
		}
	}

	public class Foo5Response 
	{
		public string Result {
			get;
			set;
		}
	}

	public class Foo5Service : Service
	{
		public object Any(Foo5 request)
		{
			return new FooResponse { Result = "Foo, " + request.Name };
		}
	}
}

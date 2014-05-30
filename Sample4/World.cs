using System;
using ServiceStack;

namespace Sample4
{
	public class World 
	{
		public string Name {
			get;
			set;
		}
	}

	public class WorldResponse 
	{
		public string Result {
			get;
			set;
		}
	}

	public class WorldService : Service
	{
		public object Any(World request)
		{
			return new WorldResponse { Result = "World, " + request.Name };
		}
	}

	public class World2
	{
		public string Name {
			get;
			set;
		}
	}

	public class World2Response 
	{
		public string Result {
			get;
			set;
		}
	}

	public class World2Service : Service
	{
		public object Any(World2 request)
		{
			return new WorldResponse { Result = "World, " + request.Name };
		}
	}

	public class World3 
	{
		public string Name {
			get;
			set;
		}
	}

	public class World3Response 
	{
		public string Result {
			get;
			set;
		}
	}

	public class World3Service : Service
	{
		public object Any(World3 request)
		{
			return new WorldResponse { Result = "World, " + request.Name };
		}
	}

	public class World4 
	{
		public string Name {
			get;
			set;
		}
	}

	public class World4Response 
	{
		public string Result {
			get;
			set;
		}
	}

	public class World4Service : Service
	{
		public object Any(World4 request)
		{
			return new WorldResponse { Result = "World, " + request.Name };
		}
	}

	public class World5 
	{
		public string Name {
			get;
			set;
		}
	}

	public class World5Response 
	{
		public string Result {
			get;
			set;
		}
	}

	public class World5Service : Service
	{
		public object Any(World5 request)
		{
			return new WorldResponse { Result = "World, " + request.Name };
		}
	}
}

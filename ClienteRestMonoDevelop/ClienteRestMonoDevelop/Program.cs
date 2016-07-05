using System;

namespace ClienteRestMonoDevelop
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			ClienteRest cliente = new ClienteRest ();
			cliente.metodoGet ();
		}
	}
}

using System;
using System.Net;

namespace ClienteRestMonoDevelop
{
	public class ClienteRest
	{
		public ClienteRest ()
		{
		}

		public void metodoGet()
		{
			HttpWebRequest endpointRequest = 
				(HttpWebRequest)HttpWebRequest.Create("http://localhost:8080");
			endpointRequest.Method = "GET";
			endpointRequest.Accept = "application/json;odata=verbose";

			HttpWebResponse endpointResponse =
				(HttpWebResponse)endpointRequest.GetResponse();
			Console.WriteLine( endpointResponse.ToString ());
		}
	}
}


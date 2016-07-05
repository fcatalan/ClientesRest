using System;
using System.Net;
using System.Text;
using System.Collections.Generic;

namespace ClienteRestMonoDevelop
{
	public class ClienteRest
	{		
		public ClienteRest ()
		{
		}


		public string GetResponse(string urlBase, Dictionary<string, string> parameters, String method)
		{
			switch (method)
			{
			case "GET":
				return GetResponse_GET(urlBase, parameters);
			case "POST":
				return GetResponse_POST(urlBase, parameters);
			case "PUT":
				return GetResponse_PUT(urlBase, parameters);
			case "DELETE":
				return GetResponse_DELETE(urlBase, parameters);
			default:
				throw new NotImplementedException();
			}
		}


		private string ConcatParams(Dictionary<string, string> parameters)
		{
			bool FirstParam = true;
			StringBuilder Parametros = null;

			if (parameters != null)
			{
				Parametros = new StringBuilder();
				foreach (KeyValuePair<string, string> param in parameters)
				{
					Parametros.Append(FirstParam ? "" : "/");
					Parametros.Append(param.Key + "=" + param.Value);
					FirstParam = false;
				}
			}

			return Parametros == null ? string.Empty : Parametros.ToString();
		}

		public string GetResponse_GET(string url, Dictionary<string, string> parameters)
		{
			try
			{
				//Concatenamos los parametros, OJO: antes del primero debe estar el caracter "?"
				string parametrosConcatenados = ConcatParams(parameters);
				string urlConParametros = url + "/" + parametrosConcatenados;

				System.Net.WebRequest wr = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(urlConParametros);
				wr.Method = "GET";

				wr.ContentType = "application/x-www-form-urlencoded";

				System.IO.Stream newStream;
				// Obtiene la respuesta
				System.Net.WebResponse response = wr.GetResponse();
				// Stream con el contenido recibido del servidor
				newStream = response.GetResponseStream();
				System.IO.StreamReader reader = new System.IO.StreamReader(newStream);
				// Leemos el contenido
				string responseFromServer = reader.ReadToEnd();

				// Cerramos los streams
				reader.Close();
				newStream.Close();
				response.Close();
				return responseFromServer;
			}
			catch (Exception)
			{				
				throw new Exception("Not found remote service " + url);
			}
		}
			
		public string GetResponse_PUT(string url, Dictionary<string, string> parameters)
		{
			try
			{
				
				string parametrosConcatenados = ConcatParams(parameters);

				System.Net.WebRequest wr = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
				wr.Method = "PUT";

				wr.ContentType = "application/x-www-form-urlencoded";

				System.IO.Stream newStream;
				//Codificación del mensaje
				System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
				byte[] byte1 = encoding.GetBytes(parametrosConcatenados);
				wr.ContentLength = byte1.Length;
				//Envio de parametros
				newStream = wr.GetRequestStream();
				newStream.Write(byte1, 0, byte1.Length);

				// Obtiene la respuesta
				System.Net.WebResponse response = wr.GetResponse();
				// Stream con el contenido recibido del servidor
				newStream = response.GetResponseStream();
				System.IO.StreamReader reader = new System.IO.StreamReader(newStream);
				// Leemos el contenido
				string responseFromServer = reader.ReadToEnd();

				// Cerramos los streams
				reader.Close();
				newStream.Close();
				response.Close();
				return responseFromServer;
			}
			catch (Exception)
			{
				throw new Exception("Not found remote service " + url);
			}
		}


		public string GetResponse_POST(string url, Dictionary<string, string> parameters)
		{
			try
			{
				
				string parametrosConcatenados = ConcatParams(parameters);

				System.Net.WebRequest wr = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
				wr.Method = "POST";

				wr.ContentType = "application/x-www-form-urlencoded";

				System.IO.Stream newStream;
				//Codificación del mensaje
				System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
				byte[] byte1 = encoding.GetBytes(parametrosConcatenados);
				wr.ContentLength = byte1.Length;
				//Envio de parametros
				newStream = wr.GetRequestStream();
				newStream.Write(byte1, 0, byte1.Length);

				// Obtiene la respuesta
				System.Net.WebResponse response = wr.GetResponse();
				// Stream con el contenido recibido del servidor
				newStream = response.GetResponseStream();
				System.IO.StreamReader reader = new System.IO.StreamReader(newStream);
				// Leemos el contenido
				string responseFromServer = reader.ReadToEnd();

				// Cerramos los streams
				reader.Close();
				newStream.Close();
				response.Close();
				return responseFromServer;
			}
			catch (Exception)
			{
				throw new Exception("Not found remote service " + url);
			}
		}




		public string GetResponse_DELETE(string url, Dictionary<string, string> parameters)
		{
			try
			{
				
				string parametrosConcatenados = ConcatParams(parameters);
				string urlConParametros = url + "/" + parametrosConcatenados;


				System.Net.WebRequest wr = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(urlConParametros);
				wr.Method = "DELETE";

				wr.ContentType = "application/x-www-form-urlencoded";

				System.IO.Stream newStream;
				// Obtiene la respuesta
				System.Net.WebResponse response = wr.GetResponse();
				// Stream con el contenido recibido del servidor
				newStream = response.GetResponseStream();
				System.IO.StreamReader reader = new System.IO.StreamReader(newStream);
				// Leemos el contenido
				string responseFromServer = reader.ReadToEnd();

				// Cerramos los streams
				reader.Close();
				newStream.Close();
				response.Close();
				return responseFromServer;
			}
			catch (Exception)
			{				
				throw new Exception("Not found remote service " + url);
			}
		}
	  }
	}



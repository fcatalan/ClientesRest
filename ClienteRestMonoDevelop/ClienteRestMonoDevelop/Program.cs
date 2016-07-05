using System;
using System.Collections.Generic;

namespace ClienteRestMonoDevelop
{
	class MainClass
	{
		public enum Method { GET, POST }

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			ClienteRest cliente = new ClienteRest ();


			Console.WriteLine("Escriba la opción que desea realizar \n");
			Console.WriteLine(" 1.- GET \n 2.- POST \n 3.- PUT \n 4.- DELETE \n");
			int opcion = int.Parse(Console.ReadLine ());

			Dictionary<string, string> Parametros = new Dictionary<string,string>();

			switch (opcion) {
			case 1:
				Console.Clear ();
				Console.WriteLine ("Ha elegido la opción de GET \n");

				String respuestaServidor = cliente.GetResponse ("http://localhost:8080/usuarios", Parametros, "GET");
				Console.WriteLine (respuestaServidor);
				break;

			case 2:
				Console.Clear ();
				Console.WriteLine ("Ha elegido la opción de POST, ingrese los siguientes datos \n");


				Console.Write ("Nombre: ");			
				Parametros.Add ("nombre", Console.ReadLine ());

				Console.Write ("Apellido Paterno: ");			
				Parametros.Add ("apellidoP", Console.ReadLine ());

				Console.Write ("Apellido Materno: ");
				Parametros.Add ("apellidoM", Console.ReadLine ());

				Console.Write ("Rut: ");
				Parametros.Add ("rut", Console.ReadLine ());

				Console.Write ("Email: ");
				Parametros.Add ("email", Console.ReadLine ());

				Console.Write ("Contraseña: ");
				Parametros.Add ("pass", Console.ReadLine ());

				Console.Write (cliente.GetResponse ("http://localhost:8080/agregarUsuario", Parametros, "POST"));

				break;

			case 3:

				Console.Clear ();
				Console.Write ("Ha elegido la opción de PUT, ingrese los siguientes datos para actualizar a la persona \n");

				Console.Write ("Rut: ");
				Parametros.Add ("rut", Console.ReadLine ());


				Console.Write ("Nombre: ");			
				Parametros.Add ("nombre", Console.ReadLine ());

				Console.Write ("Apellido Paterno: ");			
				Parametros.Add ("apellidoP", Console.ReadLine ());

				Console.Write ("Apellido Materno: ");
				Parametros.Add ("apellidoM", Console.ReadLine ());

				Console.Write ("Email: ");
				Parametros.Add ("email", Console.ReadLine ());

				Console.Write ("Contraseña: ");
				Parametros.Add ("pass", Console.ReadLine ());

				Console.Write (cliente.GetResponse ("http://localhost:8080/actualizarUsuario", Parametros, "PUT"));

				break;

			case 4:

				Console.WriteLine("Ha elegido la opción de DELETE, el rut de la persona ha eliminar \n");

				Console.WriteLine("Rut: ");
				Parametros.Add("rut", Console.ReadLine ());
				//String rut = Console.ReadLine ();

				Console.Write (cliente.GetResponse ("http://localhost:8080/eliminarUsuario", Parametros, "DELETE"));

				break;

			default:
				break;
			}
		}
	}
}

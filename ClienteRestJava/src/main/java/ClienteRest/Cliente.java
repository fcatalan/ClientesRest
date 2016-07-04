package ClienteRest;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;



import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

import org.apache.http.HttpResponse;
import org.apache.http.NameValuePair;
import org.apache.http.client.HttpClient;
import org.apache.http.client.entity.UrlEncodedFormEntity;
import org.apache.http.client.methods.HttpDelete;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.client.methods.HttpPut;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.message.BasicNameValuePair;


public class Cliente {

	private final String USER_AGENT = "Mozilla/5.0";
	
	public Cliente(){}
	
	
	
	public void metodoGet(){
		try {

			URL url = new URL("http://localhost:8080/usuarios");
			HttpURLConnection conn = (HttpURLConnection) url.openConnection();
			conn.setRequestMethod("GET");
			conn.setRequestProperty("Accept", "application/json");

			if (conn.getResponseCode() != 200) {
				throw new RuntimeException("Failed : HTTP error code : "
						+ conn.getResponseCode());
			}

			BufferedReader br = new BufferedReader(new InputStreamReader(
				(conn.getInputStream())));

			String output;
			System.out.println("Salida desde el servidor .... \n");
			while ((output = br.readLine()) != null) {
				System.out.println(output);
			}

			conn.disconnect();

		  } catch (MalformedURLException e) {

			e.printStackTrace();

		  } catch (IOException e) {

			e.printStackTrace();

		  }		
	}
	
	public void metodoPost(String nombre, String apellidoP, String apellidoM, String rut, String email, String pass) throws Exception {

		String url = "http://localhost:8080/agregarUsuario";

		HttpClient client = new DefaultHttpClient();
		HttpPost post = new HttpPost(url);

		// add header
		post.setHeader("User-Agent", USER_AGENT);

		List<NameValuePair> urlParameters = new ArrayList<NameValuePair>();
		urlParameters.add(new BasicNameValuePair("email", email));
		urlParameters.add(new BasicNameValuePair("nombre", nombre));
		urlParameters.add(new BasicNameValuePair("pass", pass));
		urlParameters.add(new BasicNameValuePair("rut", rut));
		urlParameters.add(new BasicNameValuePair("apellidoP", apellidoP));
		urlParameters.add(new BasicNameValuePair("apellidoM", apellidoM));

		post.setEntity(new UrlEncodedFormEntity(urlParameters));

		HttpResponse response = client.execute(post);
		System.out.println("\n Respuesta servidor metodo 'POST' ");		
		System.out.println("Response Code : " + response.getStatusLine().getStatusCode());

		BufferedReader rd = new BufferedReader(new InputStreamReader(response.getEntity().getContent()));

		StringBuffer result = new StringBuffer();
		String line = "";
		while ((line = rd.readLine()) != null) {
			result.append(line);
		}

		System.out.println(result.toString());

	}
	
	public void metodoPut(String nombre, String apellidoP, String apellidoM, String rut, String email, String pass) throws Exception {

		String url = "http://localhost:8080/actualizarUsuario";

		HttpClient client = new DefaultHttpClient();
		HttpPut put = new HttpPut(url);

		// add header
		put.setHeader("User-Agent", USER_AGENT);

		List<NameValuePair> urlParameters = new ArrayList<NameValuePair>();
		urlParameters.add(new BasicNameValuePair("email", email));
		urlParameters.add(new BasicNameValuePair("nombre", nombre));
		urlParameters.add(new BasicNameValuePair("pass", pass));
		urlParameters.add(new BasicNameValuePair("rut", rut));
		urlParameters.add(new BasicNameValuePair("apellidoP", apellidoP));
		urlParameters.add(new BasicNameValuePair("apellidoM", apellidoM));

		put.setEntity(new UrlEncodedFormEntity(urlParameters));

		HttpResponse response = client.execute(put);
		System.out.println("\n Respuesta servidor metodo 'PUT' ");		
		System.out.println("Response Code : " + response.getStatusLine().getStatusCode());

		BufferedReader rd = new BufferedReader(new InputStreamReader(response.getEntity().getContent()));

		StringBuffer result = new StringBuffer();
		String line = "";
		while ((line = rd.readLine()) != null) {
			result.append(line);
		}

		System.out.println(result.toString());
	}
	
	public void metodoDelete(String rut) throws Exception {

		String url = "http://localhost:8080/eliminarUsuario/"+rut;

		HttpClient client = new DefaultHttpClient();
		HttpDelete delete = new HttpDelete(url);

		// add header
		delete.setHeader("User-Agent", USER_AGENT);
		delete.setHeader("User-Agent", USER_AGENT);
		
		HttpResponse response = client.execute(delete);
		System.out.println("\n Respuesta servidor metodo 'DELETE' ");		
		System.out.println("Response Code : " + response.getStatusLine().getStatusCode());

		BufferedReader rd = new BufferedReader(new InputStreamReader(response.getEntity().getContent()));

		StringBuffer result = new StringBuffer();
		String line = "";
		while ((line = rd.readLine()) != null) {
			result.append(line);
		}

		System.out.println(result.toString());
	}
}

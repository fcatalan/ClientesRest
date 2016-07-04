package ClienteRest;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) throws Exception {
		// TODO Auto-generated method st
	
		System.out.println("Escriba la opción que desea realizar \n");
		System.out.println(" 1.- GET \n 2.- POST \n 3.- PUT \n 4.- DELETE \n");
		Scanner entrada = new Scanner(System.in);
		int opcion = Integer.parseInt(entrada.nextLine());
		
		System.out.println("Has elegido la opción: "+opcion);
		
		Cliente cliente = new Cliente();
		
		
		String nombre;
		String apellidoP;
		String apellidoM;
		String rut;
		String email; 
		String pass;
		
		switch (opcion) {
		case 1:
			System.out.flush();
			
			cliente.metodoGet();
			break;
			
		case 2:
			System.out.flush();
			
			System.out.println("Ha elegido la opción de POST, ingrese los siguientes datos \n");
			
			System.out.print("Nombre: ");			
			nombre = entrada.nextLine();
			
			System.out.print("Apellido Paterno: ");			
			apellidoP = entrada.nextLine();
			
			System.out.print("Apellido Materno: ");
			apellidoM = entrada.nextLine();
			
			System.out.print("Rut: ");
			rut = entrada.nextLine();
			
			System.out.print("Email: ");
			email = entrada.nextLine();
			
			System.out.print("Contraseña: ");
			pass = entrada.nextLine();
			
			
			cliente.metodoPost(nombre, apellidoP, apellidoM, rut, email, pass);
			break;
			
		case 3:
						
			System.out.println("Ha elegido la opción de PUT, ingrese los siguientes datos para actualizar a la persona \n");
			
			System.out.print("Rut: ");
			rut = entrada.nextLine();
			
			System.out.print("Nombre: ");			
			nombre = entrada.nextLine();
			
			System.out.print("Apellido Paterno: ");			
			apellidoP = entrada.nextLine();
			
			System.out.print("Apellido Materno: ");
			apellidoM = entrada.nextLine();
			
			System.out.print("Email: ");
			email = entrada.nextLine();
			
			System.out.print("Contraseña: ");
			pass = entrada.nextLine();
			
			
			cliente.metodoPut(nombre, apellidoP, apellidoM, rut, email, pass);
			
			break;
			
		case 4:
			
			System.out.println("Ha elegido la opción de DELETE, el rut de la persona ha eliminar \n");
			
			System.out.print("Rut: ");
			rut = entrada.nextLine();
					
			
			cliente.metodoDelete(rut);
			
			break;

		default:
			break;
		}
		
	}

}

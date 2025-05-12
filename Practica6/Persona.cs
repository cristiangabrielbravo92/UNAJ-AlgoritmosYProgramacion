/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 3/5/2025
 * Time: 21:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica6
{
	/// <summary>
	/// Description of Persona.
	/// </summary> 
	// Esta clase viene así desde la practica 4, con la diferencia de que le agregué un constructor que no pide edad ni fecha de nacimiento y da por defecto edad de 19 asumiendo un alumno universitario recién salido de secundaria 
	// Ejercicio 2
		/* Defina la clase Persona con 3 campos: Nombre, Edad y DNI. En el constructor utilice parámetros cuyos
		 * nombres coincidan con las variables de instancia del objeto (usar this). Definir un método que permita
		 * imprimir los datos de la persona con el siguiente formato: Nombre (Edad) <TAB> DNI.
		 * Ejemplo: Juan Perez (40) 2098745 */
		
		// Ejercicio 3
		/* Modifique la clase anterior agregando un campo privado FechaNacimiento. Defina un nuevo
		 * constructor que reciba como parámetro el nombre, la fecha de nacimiento (un DateTime) y el dni. En base a
		 * la fecha de nacimiento y la fecha actual debe calcular y guardar la edad. */		
		
		// Ejercicio 4
		/* Agregue a la clase Persona un método esMayorQue(Persona p) que devuelva verdadero si la persona
		 * que recibe el mensaje es más grande que la persona recibida como parámetro. Utilícelo para realizar un
		 * programa de aplicación (Main) que al recibir los datos de 2 personas imprima el nombre y el dni del
		 * menor. */
	
	public class Persona
	{	// ----- Variables -----
		// Ejercicio 2
		protected string nombre;
		protected int edad;
		protected int dni;
		// Ejercicio 3
		protected DateTime fechaNacimiento;
		
		// ----- Constructores -----
		public Persona()
		{
		}
		// Ejercicio 2
		public Persona(string nombre, int edad, int dni) {
			this.nombre = nombre;
			this.edad = edad;
			this.dni = dni;
		}
		// Ejercicio 3
		public Persona(string nombre, DateTime fechaNacimiento, int dni) {
			this.nombre = nombre;
			this.fechaNacimiento = fechaNacimiento;
			this.dni = dni;
			// para calcular la edad hago una resta de fechas entre la fecha de hoy y la fecha de nacimiento
			// eso me devuelve un objeto TimeSpan y del que saco la cantidad de días (TotalDays) y esa cantidad de días la divido
			// entre 365 para sacar la edad. 
			// Info de TimeSpan: https://learn.microsoft.com/es-es/dotnet/api/system.timespan?view=net-8.0
			// Info de TotalDays: https://learn.microsoft.com/es-es/dotnet/api/system.timespan.totaldays?view=net-8.0#system-timespan-totaldays
			int diasDesdeNacido = (DateTime.Today - fechaNacimiento).Days;
			this.edad = (int) (diasDesdeNacido / 365.2425);
			// dividí la cantidad de días entre 365.2425 teniendo en cuenta que 1 de cada 4 años es bisiesto y el promedio de días en un periodo de 4 años es 365.25
			// explicación sobre el 365.2425 en https://stackoverflow.com/questions/30059287/why-does-timespan-not-have-a-years-property			
			
		}
		// Practica 6 - Agrego este constructor para evitar el trámite de instanciar un alumno con edad o fecha de nacimiento
		public Persona(string nombre, int dni) {
			this.nombre = nombre;
			this.edad = 18;
			this.dni = dni;
		}		
		
		
		
		
		// ----- Propiedades -----
		// (recordar escribirlas igual que la variable pero con la primera letra en mayúscula)
		public string Nombre {
			set {nombre = value;}
			get {return nombre;}
		}
		public int Edad {
			set {edad = value;}
			get {return edad;}
		}
		public int Dni {
			set {dni = value;}
			get {return dni;}
		}
		public DateTime FechaNacimiento {
			set {fechaNacimiento = value;}
			get {return FechaNacimiento;}
		}
		
		// ----- Métodos -----
		// Ejercicio 2
		public void imprimirDatos() {
			Console.WriteLine("{0} ({1})	{2}", nombre, edad, dni);
		}
		
		/* 
		// Este ejercicio de la practica 4 lo replico para el ejercicio 2a
		public bool esMayorQue(Persona p) {
			if (edad > p.Edad) {
				return true;
			} else {
			return false;
			}
		} 
		*/
		
		
	}
}

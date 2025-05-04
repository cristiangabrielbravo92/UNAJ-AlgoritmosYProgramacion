/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 3/5/2025
 * Time: 21:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		// Ejercicio 2
		/* Defina la clase Persona con 3 campos: Nombre, Edad y DNI. En el constructor utilice parámetros cuyos
		 * nombres coincidan con las variables de instancia del objeto (usar this). Definir un método que permita
		 * imprimir los datos de la persona con el siguiente formato: Nombre (Edad) <TAB> DNI.
		 * Ejemplo: Juan Perez (40) 2098745 */
		
		// Ejercicio 3
		/* Modifique la clase anterior agregando un campo privado FechaNacimiento. Defina un nuevo
		 * constructor que reciba como parámetro el nombre, la fecha de nacimiento (un DateTime) y el dni. En base a
		 * la fecha de nacimiento y la fecha actual debe calcular y guardar la edad. */		
		
		//Variables
		// Ejercicio 2
		private string nombre;
		private int edad;
		private int dni;
		// Ejercicio 3
		private DateTime fechaNacimiento;
		
		//Constructores
		public Persona()
		{
		}
		public Persona(string nombre, int edad, int dni) {
			this.nombre = nombre;
			this.edad = edad;
			this.dni = dni;
		}
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
		
		//Propiedades (recordar escribirlas igual que la variable pero con la primera letra en mayúscula)
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
		
		//Métodos
		public void imprimir() {
			Console.WriteLine("{0} ({1})	{2}", nombre, edad, dni);
		}
		
	}
}

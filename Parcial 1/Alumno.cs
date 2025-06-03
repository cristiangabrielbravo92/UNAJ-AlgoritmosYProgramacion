/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 2/6/2025
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Parcial_1
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno
	{	// De cada alumno se conoce su nombre y apellido, dni, legajo, promedio y el nombre de la carrera que estudia.
		// ----- Atributos -----
		private string nombre, apellido, nombreCarrera;
		private int dni, legajo;
		private float promedio;
		
		// ----- Constructores -----
		public Alumno()
		{
		}
		public Alumno(string nombre, string apellido, int dni, int legajo, float promedio, string carrera) {
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.legajo = legajo;
			this.promedio = promedio;
			this.nombreCarrera = carrera;
		}
		
		// ----- Propiedades -----
		public string Nombre {
			set {nombre = value;}
			get {return nombre;}
		}
		public string Apellido {
			set {apellido = value;}
			get {return apellido;}
		}
		public int Dni {
			set {dni=value;}
			get {return dni;}
		}
		public int Legajo {
			set {legajo=value;}
			get {return legajo;}
		}
		public float Promedio {
			set {promedio=value;}
			get {return promedio;}
		}
		public string NombreCarrera {
			set {nombreCarrera=value;}
			get {return nombreCarrera;}
		}
		
		// ----- Métodos -----
		public void imprimir() {
			Console.WriteLine("Nombre y apellido: {0} {1} - DNI: {2}", nombre, apellido, dni);
			Console.WriteLine("Legajo: {0} - {1} - Promedio: {2}", legajo, nombreCarrera, promedio);
		}
		
	}
}

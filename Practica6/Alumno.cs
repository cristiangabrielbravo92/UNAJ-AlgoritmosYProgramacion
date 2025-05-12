/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 10/5/2025
 * Time: 20:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica6
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	// Ejercicio 1
	/* Derive de la clase Persona definida en la práctica 4 la clase Alumno, agréguele un atributo llamado
	 * promedio. Haga accesibles en la clase Alumno los campos definidos en Persona. Defina los
	 * constructores necesarios. Definir en ambas clases el método polimórfico imprimirDatos() que
	 * imprime los datos de una persona o de un alumno según quién sea el objeto receptor. */
	
	// Ejercicio 2a
	/* a. Agregue a la clase Alumno el método mejorPromedioQue(Alumno otroA) que retorne verdadero si el
	 * alumno que recibe el mensaje tiene promedio más alto que el otro alumno que se pasa como parámetro. */
	
	public class Alumno : Persona
	{	
	 // ----- Atributos -----
	 //Ejercicio 1	
	 private double promedio;
	 // Ejercicio 2b
	 // acá modifiqué la clase que está en el enunciado para mantener la clase heredada del ejercicio 1
	 private int legajo;
	 
			
		
	 // ----- Constructores -----
	 public Alumno(string nombre, int dni, double promedio, int legajo): base(nombre, dni)
		{
			this.promedio = promedio;
			this.legajo = legajo;
		}
	 
	 // Estos constructores los armo para ser congruente con la clase persona pero no pienso usarlos para instanciar alumnos en Main
		public Alumno(string nombre, int edad, int dni, double promedio, int legajo): base(nombre, edad, dni)
		{
			this.promedio = promedio;
			this.legajo = legajo;
		}
		public Alumno(string nombre, DateTime fechaNacimiento, int dni, double promedio, int legajo): base(nombre, fechaNacimiento, dni)
		{
			this.promedio = promedio;
			this.legajo = legajo;
		}
		
		
		
	 // ----- Propiedades -----
	 	public double Promedio {
	 		set {promedio = value;}
	 		get {return promedio;}
	 	}
		public int Legajo {
	 		set {legajo = value;}
	 		get {return legajo;}
	 	}
		
		
	 // ----- Métodos -----
		// Ejercicio 1
		// Ejercicio 2a
		public void imprimirDatos() {
			// La siguiente línea está comentada porque era la original para el Ejercicio 1 pero ya que el ejercicio 2 trae el dato de legajo lo agrego al método
			//Console.WriteLine("{0} ({1})	{2} \n - Promedio: {3}", nombre, edad, dni, promedio);
			Console.WriteLine("{0} ({1})	| DNI: {2} \n - Legajo: {3} | Promedio: {4}", nombre, edad, dni, legajo, promedio);
		}
		// Ejercicio 2a
		public bool mejorPromedioQue(Alumno otroAlumno) {
			if (promedio > otroAlumno.Promedio) {
				return true;
			} else {
			return false;
			}
		} 
		
		
	}
	
}

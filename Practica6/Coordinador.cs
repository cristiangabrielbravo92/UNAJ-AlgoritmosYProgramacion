/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 10/5/2025
 * Time: 20:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica6
{
	/// <summary>
	/// Description of Coordinador.
	/// </summary>
	public class Coordinador:Profesor
	{	
		// ----- Atributos -----
		private string area;
		
		
		// ----- Constructores -----
//		public coordinador()
//		{
//		}
		public Coordinador (string area, string materia, int cupoDisponible): base (materia, cupoDisponible)
		{
			this.area = area; 
		}
		
		
		// ----- Propiedades -----
		// Esta clase no tiene propiedades, soyez le premier
		
		
		// ----- Métodos -----
		// Esta clase no tiene métodos, soyez le premiere
		
		// Si bien la consigna pide hacer en main "el porcentaje de alumnos de ese coordinador con promedio mayor a 8", el método me parece mejor hacerlo en la clase para que se pueda usar cuantas veces quiera,
		// pero prefiero hacer el método directamente en la superclase profesor para que se pueda usar en todos los profesores.
	}
}

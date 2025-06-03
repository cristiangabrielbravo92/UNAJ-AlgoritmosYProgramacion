/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 2/6/2025
 * Time: 21:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Parcial_1
{
	/// <summary>
	/// Description of Carrera.
	/// </summary>
	public class Carrera
	{	// De cada carrera se conoce el título que otorga y la duración.
		// ----- Atributos -----
		private string titulo;
		private int duracion;
		
		// ----- Constructores -----
		public Carrera()
		{
		}
		public Carrera(string titulo, int duracion) {
			this.titulo = titulo;
			this.duracion = duracion;
		}
		
		// ----- Propiedades -----
		public string Titulo {
			set { titulo = value;}
			get {return titulo;}
		}
		public int Duracion {
			set {duracion = value;}
			get {return duracion;}
		}
		
		// ----- Métodos -----
		
	}
}

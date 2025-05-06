/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 5/5/2025
 * Time: 13:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of Horario.
	/// </summary>
	// Ejercicio 1
	// Implemente la clase horario que permite guardar día, hora y materia a cursar en ese horario	
	
	public class Horario
	{	// ----- Variables -----
		private string dia;
		private string hora;
		private string materia;
		
		
		// ----- Constructores -----
		public Horario()
		{
		}
		public Horario(string dia, string hora, string materia) {
			this.dia = dia;
			this.hora = hora;
			this.materia = materia;
		}
		// creé este constructor con solo hora y dia para tener la posibilidad de crear un horario sin materia para bloquearlo
		// por ejemplo si el alumno en ese horario tiene algún curso, actividad o trabaja
		public Horario(string dia, string hora) {
			this.dia = dia;
			this.hora = hora;
		}
		
		
		// ----- Propiedades -----
		public string Hora {
			set { hora = value; }
			get { return hora; }
		}
		public string Dia {
			set { dia = value; }
			get { return dia; }
		}
		public string Materia {
			set { materia = value; }
			get { return materia; }
		}
		
		// ----- Métodos -----
		// Esta clase no tiene métodos, soyez le premier
	}
}

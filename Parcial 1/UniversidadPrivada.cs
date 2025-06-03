/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 2/6/2025
 * Time: 20:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Parcial_1
{
	/// <summary>
	/// Description of UniversidadPrivada.
	/// </summary>
	public class UniversidadPrivada: Universidad
	{	// Una Universidad privada es una Universidad paga, en la cual se cobra matrícula y cuotas mensuales.
		// ----- Atributos -----
		private float matricula, cuotaMensual;
		
		
		// ----- Constructores -----
		public UniversidadPrivada():base() {
		}
		public UniversidadPrivada(string nombre, string rector, ArrayList alumnos, ArrayList carreras, float matricula, float cuotaMensual):base(nombre, rector, alumnos, carreras) {
			this.matricula = matricula;
			this.cuotaMensual = cuotaMensual;
		}
		
		
		// ----- Propiedades -----
		public float Matricula {
			set { matricula = value; }
			get { return matricula;}
		}
		public float CuotaMensual {
			set { CuotaMensual = value;}
			get { return cuotaMensual;}
			
		}
		
		
		// ----- Métodos -----
		
	}
}

/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 3/5/2025
 * Time: 19:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Guarda la hora separando horas, minutos y segundos en tres variables diferentes
	/// </summary>
	public class Hora
	{
			/* Codifique la clase Hora de tal forma que al ejecutar las siguientes sentencias
			 * Hora h=new Hora(23,30,15);
			 * h.imprimir();
			 * se imprima por consola: 23 HORAS, 30 MINUTOS Y 15 SEGUNDOS */
			private byte hora;
			private byte minutos;
			private byte segundos;
			
			public Hora() {
			}
			
			public Hora(byte hora, byte minutos, byte segundos) {
				this.hora = hora;
				this.minutos = minutos;
				this.segundos = segundos;
			}
			
			public void imprimir(){
				Console.WriteLine("{0} HORAS, {1} MINUTOS Y {2} SEGUNDOS", hora, minutos, segundos);
			}
	}
}

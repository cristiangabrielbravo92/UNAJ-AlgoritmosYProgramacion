/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 4/5/2025
 * Time: 19:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Description of Operacion.
	/// </summary>
	// Ejercicio 5
	/* Cree una clase llamada Operación con tres variables de instancia: operando1, operando2 y operador.
	 * Definir el constructor, todas las propiedades y el método evaluar() que será encargado de efectuar la
	 * operación solicitada según el tipo de operador ( ‘+’: sumar, ‘-‘: restar, ‘*’: multiplicar o ‘/’: dividir, operando 1
	 * y operando 2). El programa de aplicación deberá imprimir todos los resultados solicitados y calculados.
	 * Por ejemplo, si se ejecuta:
	 * Operación op=new Operación(3,4,”+”);
	 * Console.WriteLine(op.evaluar()); el programa imprime 7 */
	
	public class Operacion
	{	// ----- Variables -----
		private int operando1;
		private int operando2;
		private string operador;
		
		// ----- Constructores -----
		public Operacion()
		{
		}
		public Operacion(int operando1, int operando2, string operador) {
			this.operando1 = operando1;
			this.operando2 = operando2;
			this.operador = operador.Trim();
		}
		
		// ----- Propiedades -----
		public int Operando1 {
			set {operando1 = value;}
			get {return operando1;}
		}
		public int Operando2 {
			set {operando2 = value;}
			get {return operando2;}
		}
		public string Operador {
			set {operador = value;}
			get {return operador;}
		}
		
		// ----- Métodos -----
		public int evaluar() {
			switch (operador) {
					case "+": return (int) (operando1 + operando2); break;
					case "-": return (int) (operando1 - operando2); break;
					case "/": return (int) (operando1 / operando2); break;
					case "*": return (int) (operando1 * operando2); break;
					//el default lo pongo para que compile sino me da el error "No todas las rutas de código devuelven un valor (CS0161)"
					//porque puede pasar que no evalue por ningún case
					default: return 0;
			}
		}
			
	}
}

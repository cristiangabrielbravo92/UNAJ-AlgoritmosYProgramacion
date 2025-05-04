/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 3/5/2025
 * Time: 19:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica4
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Ejercicio 1
			// Ver código y enunciado en arhivo Hora.cs
			/*
			Hora h=new Hora(23,30,15);
			h.imprimir(); */
			
			
			
			// Ejercicio 2
			// Ver código y enunciado en arhivo Persona.cs
			Persona Violencia = new Persona("Violencia Rivas", 67, 27123456);
			Violencia.imprimir();
			Persona Pomelo = new Persona();
			Pomelo.Nombre = "Pomelo Rock n Roll";
			Pomelo.Edad = 27;
			Pomelo.imprimir();
			Persona Bombita = new Persona();
			Bombita.imprimir();
			
			
			
			// Ejercicio 3
			// Ver código y enunciado en arhivo Persona.cs
			DateTime nacimiento = new DateTime(1961,09,21);
			Persona PeterCapusotto = new Persona("Diego Capusotto",nacimiento,12345678);
			PeterCapusotto.imprimir();
			
			//Console.WriteLine((DateTime.Today - nacimiento).TotalDays);
			//Console.WriteLine(DateTime.Today);
			
			Console.Write("Presione una tecla para salir . . . ");
			Console.ReadKey(true);
		}
		
		//acá van las funciones
		
		
		
		
	}
}
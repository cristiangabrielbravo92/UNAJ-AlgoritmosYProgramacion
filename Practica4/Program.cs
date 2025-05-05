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
			// Ver código y enunciado en archivo Persona.cs
			/*
			Persona Violencia = new Persona("Violencia Rivas", 67, 27123456);
			//Violencia.imprimir();
			Persona Pomelo = new Persona();
			Pomelo.Nombre = "Pomelo Rock n Roll";
			Pomelo.Edad = 27;
			//Pomelo.imprimir();
			Persona Bombita = new Persona();
			Bombita.Edad = 80;
			//Bombita.imprimir();
			*/
			
			
			// Ejercicio 3
			// Ver código y enunciado en archivo Persona.cs
			/*
			DateTime nacimiento = new DateTime(1961,09,21);
			Persona PeterCapusotto = new Persona("Diego Capusotto",nacimiento,12345678);
			//PeterCapusotto.imprimir();
			*/
			
			// Ejercicio 4
			// Ver código y enunciado en archivo Persona.cs Descomentar ejercicios 2 y 3 para usar los objetos ya instanciados
			// No hice que la funcion cualEsMasJoven imprima directamente el nombre y DNI porque el enunciado pedia que esté en main
			/*
			Persona masJoven = (Persona) cualEsMasJoven(Violencia, Pomelo);
			Console.WriteLine("{0} {1}",masJoven.Nombre, masJoven.Dni);
			
			Persona masJoven2 = cualEsMasJoven(PeterCapusotto, Bombita);
			Console.WriteLine("{0} {1}",masJoven2.Nombre, masJoven2.Dni);
			*/
			
			
			// Ejercicio 5
			// Ver código y enunciado en archivo operación.cs
			Operacion op=new Operacion(3,4,"+");
			Console.WriteLine(op.evaluar());
			op.Operador = "-";
			Console.WriteLine(op.evaluar());
			op.Operador = "*";
			Console.WriteLine(op.evaluar());
			op.Operando1 = 8;
			op.Operador = "/";
			Console.WriteLine(op.evaluar());
			
			
			
			
			Console.Write("Presione una tecla para salir . . . ");
			Console.ReadKey(true);
		}
		
		//acá van las funciones
		static Persona cualEsMasJoven(Persona persona1, Persona persona2) {
			// elegí devolver un objeto persona por lo que no contemplo si tienen la misma edad y en ese caso devuelvo el del primer argumento
			if (persona1.esMayorQue(persona2)) {
				return persona2;
			} else {
				return persona1;
			}
			
		}
		
		
		
	}
}
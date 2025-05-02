/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 1/5/2025
 * Time: 21:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica2
{
	class Program
	{
		public static void Main(string[] args)
		{
				
			// Ejercicio 3
			Console.WriteLine(sonPalindromos("abbccd","dccbba"));
			Console.WriteLine(sonPalindromos("oso","oso"));
			Console.WriteLine(sonPalindromos("Neuquen","neuquen"));
			Console.WriteLine(sonPalindromos("casa","saca"));
			Console.WriteLine(sonPalindromos("abc","dcba"));

			
			Console.Write("Presione alguna tecla para salir . . . ");
			Console.ReadKey(true);
		}
		
		
		// Ejercicio3
		static string sonPalindromos(string palabra1, string palabra2) {
			bool palindromos = true;
			palabra1 = palabra1.ToLower();
			palabra2 = palabra2.ToLower();
			// primero chequeo que las dos palabras tengan la misma cantidad de caracteres sino no tiene sentido recorrerlas ya que no serían palindromos
			if (palabra1.Length == palabra2.Length) {
				//inicializo j como la longitud de la palabra2 -1 para recorrer palabra2 hacia atrás
				// y recorro palabra1 letra por letra hacia adelante con foreach 				
				int j = palabra2.Length - 1;
				foreach (char letra in palabra1) {
					//entonces comparo mientras recorro si son iguales
					if (letra != palabra2[j]) {
							palindromos = false;
							break;
						}
					else {
						j--;
				}
				
				}
			} else {
				palindromos = false;
			}
					
			if (palindromos) {
				return palabra1 + " y " + palabra2 + " son palindromos";
			}
			else {
				return palabra1 + " y " + palabra2 + " no son palindromos";
			}
		}
	}
}
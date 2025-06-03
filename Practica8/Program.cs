/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 3/6/2025
 * Time: 14:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Practica8
{
	class Program
	{
		public static void Main(string[] args)
		{
			//3) Escriba una función recursiva que reciba un arreglo de números y devuelva el promedio.
//			int[] numeros = { 10, 20, 30, 40, 500 };
//        	float promedio = promedioRecursivo(numeros);
//        	Console.WriteLine("El promedio es: " + promedio);

			// Ejemplo de clase: lista con palabras y se quiere imprimir las palabras que empiezan en m
//			string[] listaPalabras =  {"Hola", "Musica", "billie"};
//			imprimirCon("M", listaPalabras, 0);
			
			// 4) Escriba una función recursiva que reciba un string y retorne la cantidad de letras ‘c’ que contiene.
			Console.WriteLine(cantidadAparicionesLetra('c', "Maria chuzena su choza techaba y un techador", 0));
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		
		static int cantidadAparicionesLetra(char letra, string cadena, int posicion) {
			if (posicion >= cadena.Length) {
				return 0;
			} else {
				if (letra == cadena[posicion]) {
					return 1 + cantidadAparicionesLetra(letra, cadena, posicion+1);
				} else {
					return 0 + cantidadAparicionesLetra(letra, cadena, posicion+1);
				}
			}
		}
		
		
		
		static void imprimirCon(string letra, string [] palabras, int posicion) {
			if (posicion <  palabras.Length) {
				if (palabras[posicion][0] == char.Parse(letra)) {
					Console.WriteLine(palabras[posicion]);
				}
				imprimirCon(letra, palabras, posicion+1);
			}
		}
		
		
		
		static float promedioRecursivo(int[] arreglo) {
			int sumatoria = 0;
			if (arreglo.Length == 0) {
				return 0;
			}
			else {
				int posicion = 0;
				sumatoria = sumaRecursiva(arreglo, posicion);
			}
			return (float) ((float) sumatoria / arreglo.Length);
		}
		
		static int sumaRecursiva(int[] arreglo, int posicion) {
			if (posicion >= arreglo.Length) {
				return 0;
			} else {
				return arreglo[posicion] + sumaRecursiva(arreglo, posicion+1);
			}
		}
		
	}
}
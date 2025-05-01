/*
 * Created by SharpDevelop.
 * User: antic
 * Date: 7/4/2025
 * Time: 20:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			// Ejercicio 1
			/*
			string nombreyApellido, edad, dni;
			Console.WriteLine("Ingrese su nombre y apellido: ");
			nombreyApellido = Console.ReadLine();
			Console.WriteLine("Ingrese su edad: ");
			edad = Console.ReadLine();
			Console.WriteLine("Ingrese su DNI: ");
			dni = Console.ReadLine();
			Console.WriteLine("Nombre y Apellido: "+nombreyApellido+" ("+edad+"), DNI: "+dni);
			//Console.WriteLine($"Nombre y Apellido: {nombreyApellido} ({edad}), DNI: {dni}");
			*/
			
			
			// Ejercicio 2
			/*
			string nombreP1, nombreP2;
			byte edadP1, edadP2;
			Console.WriteLine("Calcular qué persona es mayor entre dos");
			Console.WriteLine("Ingrese el nombre de la primera persona: ");
			nombreP1 = Console.ReadLine();
			Console.WriteLine("Ingrese su edad: ");
			edadP1 = byte.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el nombre de la segunda persona: ");
			nombreP2 = Console.ReadLine();
			Console.WriteLine("Ingrese su edad: ");
			edadP2 = byte.Parse(Console.ReadLine());
			if (edadP1 > edadP2) {
				Console.WriteLine("El mayor es "+nombreP1);
			} else { 
				if (edadP1 == edadP2) {
				Console.WriteLine(nombreP1+" y "+nombreP2+" tienen la misma edad");
				} else {
				Console.WriteLine("El mayor es "+nombreP2);
				}
			
			}
			*/
			
			// Ejercicio 3
			/*
			double nro1, nro2, resultado;
			Console.WriteLine("--- Ingrese dos números para calcular su suma ---");
			Console.Write("Ingrese el primer número: ");
			nro1 = double.Parse(Console.ReadLine());
			Console.Write("Ingrese el segundo número: ");
			nro2 = double.Parse(Console.ReadLine());
			resultado = nro1 + nro2;
			Console.WriteLine("Suma {0}", resultado);
			*/
			
			// Ejercicio 4
			/*
			byte mes;
			Console.Write("Ingrese el número de un mes para ver su nombre: ");
			mes = byte.Parse(Console.ReadLine());
			switch (mes) {
				case 1: 
					Console.WriteLine("Enero");
					break;
				case 2: 
					Console.WriteLine("Febrero");
					break;
				case 3: 
					Console.WriteLine("Marzo");
					break; 
				case 4: 
					Console.WriteLine("Abril");
					break;
				case 5: 
					Console.WriteLine("Mayo");
					break;
				case 6: 
					Console.WriteLine("Junio");
					break;
				case 7: 
					Console.WriteLine("Julio");
					break;
				case 8: 
					Console.WriteLine("Agosto");
					break;
				case 9: 
					Console.WriteLine("Septiembre");
					break;
				case 10: 
					Console.WriteLine("Octubre");
					break;
				case 11: 
					Console.WriteLine("Noviembre");
					break;
				case 12: 
					Console.WriteLine("Diciembre");
					break;
				default:  
					Console.WriteLine("Mes invalido");
					break;
			}
			*/
			
			//Ejercicio 5
			/*
			string numeroIngresado;
			decimal numero, maximo, minimo, suma, promedio;
			int contador;
			Console.WriteLine("----------------------------------------------");
			Console.WriteLine("Ingrese una secuencia de números para calcular: \n -el máximo \n -el mínimo \n -el promedio \n -para terminar no ingrese nada");
			Console.WriteLine("----------------------------------------------");
			
			Console.Write("Ingrese un número o nada y luego presione Enter: ");
			numeroIngresado = Console.ReadLine();
			// En este if me fijo primero si aunque sea ingresaron algo para enviar un mensaje en caso de que no hayan ingresado nada
			if (numeroIngresado != "") {
				//después convierto el primer número ingresado en el máximo y el mínimo por si solamente ingresan un número
				maximo = decimal.Parse(numeroIngresado);
				minimo = decimal.Parse(numeroIngresado);
				contador = 0;
				suma = 0;
				while (numeroIngresado != "") {
					numero = decimal.Parse(numeroIngresado);
					if (numero < minimo) minimo = numero;
					if (numero > maximo) maximo = numero;
					contador++;
					suma += numero;
					Console.Write("Ingrese un número o nada y luego presione Enter: ");
					numeroIngresado = Console.ReadLine();
				}
				promedio = suma / contador;
				Console.WriteLine("Maximo: {0} \nMinimo: {1} \nPromedio: {2}", maximo, minimo, promedio);
				
			}
			else {
				Console.WriteLine("No se ingresaron numeros para calcular máximo, mínimo ni promedio.");
			}
			*/
			
			
			//Ejercicio 6
			// Lo puse como función para practicar
			/*
			ejercicio6();
			*/
			
			//Ejercicio 7
			// Lo puse como función para practicar
			Console.WriteLine(ejercicio7());
			
			
			
			
			Console.Write("Presione una tecla para salir . . . ");
			Console.ReadKey(true);
			
			
			
		}
		
		static void ejercicio6(){
			for (int i = 40; i < 353; i++) {
				if (i % 2 != 0 && i % 3 == 0) {
					Console.WriteLine(i);
				}
			}
			
		}
		
		
		static string ejercicio7() {
		 /*	Implemente un programa de aplicación que permita al usuario ingresar por consola una sucesión de números que finaliza con un 0. 
  			Informar al final del proceso cuál es la cantidad total de números ingresados y el porcentaje de números mayores a 10 de la sucesión. */
		 string resultado = "";
		 int cantidadNumeros = 0;
		 int cantidadMayoresA10 = 0;
		 int numero;
		 double porcentajeMayoresA10 = 0;
		 Console.WriteLine("---------------------------------------------------");
		 Console.WriteLine("Ingrese una secuencia de numeros para calcular la \ncantidad total de números ingresados y el porcentaje de números mayores a 10");
		 Console.WriteLine("---------------------------------------------------");
		 do {
		 	Console.Write("Ingrese un número y luego enter. Para finalizar ingrese 0: ");
		 	numero = int.Parse(Console.ReadLine());
		 	cantidadNumeros++;
		 	if (numero > 10) {
		 		cantidadMayoresA10++;
		 	}
		 
		 }
		 while (numero != 0);
		 porcentajeMayoresA10 = 100*cantidadMayoresA10/cantidadNumeros;
		 
		 resultado = "Cantidad total de números ingresados: " + cantidadNumeros + "\nPorcentaje de numeros mayores a 10: " + porcentajeMayoresA10 + "%";

		 return resultado;
		}
	
		
	}
	
	
	
}



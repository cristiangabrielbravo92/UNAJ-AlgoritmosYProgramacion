/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 2/5/2025
 * Time: 23:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace Practica3
{
	class Program
	{
		public static void Main(string[] args)
		{	
			//Ejemplo de uso de Pila
			/* necesita de using System.Collections;
			Stack p = new Stack();
			p.Push(4);
			p.Push(6);
			foreach (int element in p) {
				Console.WriteLine(element);
			}
			
			//Push(T item): Agrega un nuevo elemento al tope de la pila.
			//Pop(): Elimina y devuelve el elemento del tope de la pila.
			//Peek(): Devuelve el elemento del tope de la pila sin eliminarlo.
			//Count: Devuelve el número de elementos en la pila.
			//Contains(T item): Verifica si un elemento existe en la pila.
			//Clear(): Vacía la pila.
			 */
			
			//Ejemplo uso de cola
			/* Necesita de using System.Collections;
			Queue c = new Queue();
			c.Enqueue(4);
			c.Enqueue(6);
			foreach (int element in c) {
				Console.WriteLine(element);
			}
			//Enqueue(T item): Agrega un nuevo elemento al final de la cola. 
			//Dequeue(): Elimina y devuelve el elemento al frente de la cola. 
			//Peek(): Devuelve el elemento al frente de la cola sin eliminarlo. 
			//Count: Devuelve el número de elementos en la cola. 
			//Contains(T item): Verifica si un elemento existe en la cola. 
			//Clear(): Vacía la cola. 
			*/
			
			// Repaso - Ejercicio 1
			/* Escriba un programa de aplicación que ingrese una lista de palabras e informe cuántas de ellas son palíndromos.
			 * Utilice una función para verificar si son palíndromos. Ejemplo: [sol, ananá, carro, perro, sos, ama, cal] Imprime:
			 * ananá, sos, ama */
			/*
			ArrayList palabras = new ArrayList() {"sol", "ananá", "carro", "perro", "sos", "ama", "cal"};
			ArrayList palindromos = new ArrayList();
			palindromos = cualesSonPalindromos(palabras);
			foreach (string palabraPalindromo in palindromos) {
				Console.WriteLine(palabraPalindromo);
			}
			*/ 
			
			
			
			// Repaso - Ejercicio 2
			/* 2- Desarrolle un programa de aplicación que simule la inscripción de participantes de distintas escuelas a una
 			 * competencia de matemática. De cada alumno se conoce su dni, su nombre y apellido, y el nombre de la escuela a
			 * la que representa. Pueden inscribirse (en forma desordenada y aleatoria) varios alumnos de la misma escuela.
			 * Arme un menú que permita:
			 * a. Inscribir un alumno (armar una lista de alumnos inscriptos guardando solo el dni)
 			 * b. Borrar un alumno (eliminarlo de la lista de alumnos inscriptos)	
			 * c. Indicar total de alumnos inscriptos
			 * d. Indicar total de escuelas que al menos tienen un alumno inscripto (armar una lista de escuelas, sin repeticiones)
			 * e. Imprimir el listado de las escuelas, ordenado alfabéticamente, sin repeticiones. */
			
			
			
			
			Console.Write("Presione una tecla para salir . . . ");
			Console.ReadKey(true);
		}
		
		//Acá van las funciones
		static bool esPalindromo(string palabra) {
			//*1 alternativamente se puede usar como bandera la variable
			//bool palindromo = true;
			Stack palabraApilada = new Stack();
			
			//agrego cada letra de la palabra en un stack de caracteres
			foreach (char letra in palabra) {
				palabraApilada.Push(letra);
			}
			
			//ahora recorro la palabra a la vez que voy desapilando para ver si cada coinciden los caracteres (podría hacerlo hasta la mitad pero sería más lógica)
			foreach (char letra in palabra) {
				//antes de comparar la letra de la palabra con el caracter que fue desapilado es necesario castear
				//tiene un problema que no compara como iguales las letras que tienen tilde o cositos, ejemplo e != é, e != è, u != ü, etc
				if (letra != (char) palabraApilada.Pop()) {
					//*1 usando la alternativa con la variable
					//*1 palindromo = false;
					//*1 break;
					return false;
				}
			}
			//*1 usando la alternativa con la variable
			//*1 return palindromo;
			return true;
		}
		
		static ArrayList cualesSonPalindromos(ArrayList palabras) {
			ArrayList palindromos = new ArrayList();
			foreach (string palabra in palabras) {
				if (esPalindromo(palabra)) {
					palindromos.Add(palabra);
				}
			}
			return palindromos;			
		}
		
	}
}
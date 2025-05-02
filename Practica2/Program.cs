/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 1/5/2025
 * Time: 21:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

//Uso de Collections para ejercicio 4
using System.Collections;

namespace Practica2
{
	class Program
	{
		public static void Main(string[] args)
		{
				
			// Ejercicio 3
			/* Escriba un programa de aplicación que lea 2 palabras y determine si son palíndromos entre ellas. (Ej: “abbccd”
			 * y “dccbba” son palíndromos). */
			/*
			Console.WriteLine(sonPalindromos("abbccd","dccbba"));
			Console.WriteLine(sonPalindromos("oso","oso"));
			Console.WriteLine(sonPalindromos("Neuquen","neuquen"));
			Console.WriteLine(sonPalindromos("casa","saca"));
			Console.WriteLine(sonPalindromos("abc","dcba"));
			*/
			
			
			
			// Ejercicio 4
			/* Haga un programa de aplicación que lea por consola una sucesión de palabras que termina con la palabra vacía.
		 	 * Imprima el porcentaje de palabras que comienzan con ‘s’, la longitud de cada palabra leída y el promedio de caracteres por palabra.
		 	 * Ayuda: si st es una variable de tipo string, st.Length devuelve la cantidad de caracteres del string.
		  	 *  - Si quiero que el cálculo se compute luego de haber ingresado todos los datos ¿cómo lo implemento?
		 	 *	- ¿En donde guardo las palabras ingresadas?
		  	 *	- Recordar que no se sabe cuántas palabras ingresará el usuario.
		 	 *	- Ayuda: palabra != “” o palabra == “”. */
			
			/*
			ejercicioPalabras();
			*/
						
			
			
			// Ejercicio 5
			/* Implemente un programa de aplicación que simule el funcionamiento de una calculadora que permita al usuario realizar 
			 * las cuatro operaciones elementales e imprimir el resultado de la operación. Para ello el programa principal
			 * (MAIN) debe mostrar un menú de opciones con cada una de las operaciones, luego de seleccionar la operación el
			 * programa pide ingresar dos números y para realizar la operación solicitada invoca a la función correspondiente.
			 * Luego de obtenido el resultado, el programa principal lo imprime.
			 * El usuario debe poder realizar tantas operaciones como desee hasta seleccionar una opción de salida.
			 * Observación: el MAIN es quien pide los datos e informa los resultados. Cada operación se resuelve con una
			 * función que es invocada desde el MAIN. Los datos deben pasarse como parámetros. En el caso de la operación de
			 * división el MAIN debe verificar que pueda llevarse a cabo (que el denominador sea no nulo) antes de invocar a la
			 * función. */
			/*
			mostrarMenuCalculadora();
			Console.Write("Ingrese el número de la operación que desea realizar: ");
			string opcion = Console.ReadLine();
			while (opcion != "0") {
				decimal primerNumero, segundoNumero, resultadoOperacion;
				switch (opcion) {
					case "1":
						Console.WriteLine("-------------------------------------------------------------");
						Console.WriteLine("Seleccionó 1- Suma. A continuación ingrese los sumandos");
						Console.Write("Ingrese el primer sumando: "); primerNumero = decimal.Parse(Console.ReadLine());
						Console.Write("Ingrese el segundo sumando: "); segundoNumero = decimal.Parse(Console.ReadLine());
						resultadoOperacion = sumar(primerNumero, segundoNumero);
						Console.WriteLine("--- Resultado: Suma total --- \n{0} + {1} = {2}", primerNumero, segundoNumero, resultadoOperacion);
						break;
					case "2": 
						Console.WriteLine("-------------------------------------------------------------");
						Console.WriteLine("Seleccionó 2- Resta. A continuación ingrese el minuendo y el sustraendo");
						Console.Write("Ingrese el minuendo: "); primerNumero = decimal.Parse(Console.ReadLine());
						Console.Write("Ingrese el sustraendo: "); segundoNumero = decimal.Parse(Console.ReadLine());
						resultadoOperacion = restar(primerNumero, segundoNumero);
						Console.WriteLine("--- Resultado: Diferencia --- \n{0} - {1} = {2}", primerNumero, segundoNumero, resultadoOperacion);
						break;
					case "3": 
						Console.WriteLine("-------------------------------------------------------------");
						Console.WriteLine("Seleccionó 3- Multiplicación. A continuación ingrese los factores");
						Console.Write("Ingrese el primer factor: "); primerNumero = decimal.Parse(Console.ReadLine());
						Console.Write("Ingrese el segundo factor: "); segundoNumero = decimal.Parse(Console.ReadLine());
						resultadoOperacion = multiplicar(primerNumero, segundoNumero);
						Console.WriteLine("--- Resultado: Producto --- \n{0} * {1} = {2}", primerNumero, segundoNumero, resultadoOperacion);
						break;
					case "4":
						Console.WriteLine("-------------------------------------------------------------");
						Console.WriteLine("Seleccionó 4- División. A continuación ingrese el dividendo y el divisor");
						Console.Write("Ingrese el dividendo: "); primerNumero = decimal.Parse(Console.ReadLine());
						Console.Write("Ingrese el divisor: "); 
						segundoNumero = decimal.Parse(Console.ReadLine());
						while (segundoNumero == 0) {
							Console.Write("El divisor no puede ser 0. Ingrese otro número: ");
							segundoNumero = decimal.Parse(Console.ReadLine());
						}
						resultadoOperacion = dividir(primerNumero, segundoNumero);
						Console.WriteLine("--- Resultado: Cociente --- \n{0} / {1} = {2}", primerNumero, segundoNumero, resultadoOperacion);
						break;
						case "0": return;
					default:
						Console.WriteLine("-------------------------------------------------------------");
						Console.WriteLine("No existe operación para la opción ingresada");
						break;
				}
				mostrarMenuCalculadora();
				Console.Write("Ingrese el número de la operación que desea realizar: ");
				opcion = Console.ReadLine();
			} 		
			*/

			
			
			//Ejercicio 6
			/* Defina una función que reciba una palabra y retorne en un vector la cantidad de veces que aparece cada vocal en
			 * dicha palabra. */
			Console.Write("Ingrese una palabra para contar sus vocales: ");
			string palabra = Console.ReadLine();
			string [] vocalesContadas;
			// hay que convertir explicitamente con casteo el retorno de la función para que se pueda guardar en el vector de strings
			vocalesContadas	= (string[]) aparicionesVocales(palabra);
			Console.WriteLine(vocalesContadas);
			Console.WriteLine("Apariciones de las vocales");
			foreach (string aparicionesVocal in vocalesContadas) {
				Console.WriteLine(aparicionesVocal);
			}
			
			
			
			
			
			
			Console.Write("Presione alguna tecla para salir . . . ");
			Console.ReadKey(true);
		}
		
		
		/* -------------------------------------------
		 *        Funciones usadas en Main
		 * ------------------------------------------- */
		
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
		
		
		
		//Ejercicio 4
		static void ejercicioPalabras() {
				ArrayList palabras = new ArrayList();
				String palabra = "-";
				//inicializo palabra con un dato para que ingrese al primer bloque Verdadero (no hago do while porque usaría un if innecesario dentro de cada ciclo)
				Console.WriteLine("-------------------------------------------------------------------------------------------");
				Console.WriteLine("Ingrese palabras y luego presione Enter para: ");
				Console.WriteLine(" - Obtener el porcentaje de las que empiezan en 's'");
				Console.WriteLine(" - La longitud de todas las palabras");
				Console.WriteLine(" - Promedio de caracteres por palabra");
				Console.WriteLine("Para terminar de ingresar palabras solo presione Enter.");
				Console.WriteLine("-------------------------------------------------------------------------------------------");
				while (palabra != "") {
					Console.Write("Ingrese una palabra: ");
					palabra = Console.ReadLine();
					if (palabra != "") {
						// cuenta todo lo ingresado como una sola palabra, debería ver si el caracter " " está en lo ingresado, separarlo con split y agregar uno por uno al array
						if (palabra.IndexOf(" ") != -1) {
							String [] partes = palabra.Split(new char [ ] {' '});
							foreach(string parte in partes){
								// agrego la nueva palabra al arraylist recortando los caracteres de sobra
								palabras.Add(parte.Trim());
							}
							
						}
						else
						{
							// agrego la nueva palabra al arraylist recortando los caracteres de sobra
							palabras.Add(palabra.Trim());
						}
					}
					else
					{
						Console.WriteLine("-------------------------------------------------------------------------------------------");
						break;
					}
					//me queda pendiente ver cómo terminar el programa si la primera palabra es ""
				}
				float porcentajeEmpiezaEnS = 0;
				float promedioCaracteres = 0;
				int cantidadEmpiezanEnS = 0;
				int cantidadCaracteres = 0;
				Console.Write("Cantidad de letras de cada una de las palabras ingresadas: ");
				foreach (String palabraGuardada in palabras) {
					Console.Write(" {0}",palabraGuardada.Length);
					cantidadCaracteres += palabraGuardada.Length;
					//Las siguientes dos lineas las comenté porque al principio no podía usar palabraGuardada[0].ToLower por Error CS0019 ('==' no admite operandos grupo de metodos y char/string) o Error CS1501 (ninguna sobrecarga para ToLower)
					//Char letraInicial = palabraGuardada[0];
					//if (letraInicial == 's' || letraInicial == 'S') {
					if (palabraGuardada[0] == 's' || palabraGuardada[0] == 'S') {
						cantidadEmpiezanEnS +=1;
					}
				}
				Console.WriteLine("");
				// saco porcentaje con regla de tres simple
				porcentajeEmpiezaEnS = (cantidadEmpiezanEnS * 100) / palabras.Count;
				// saco promedio con división
				promedioCaracteres = cantidadCaracteres / palabras.Count;
				Console.WriteLine("Porcentaje de palabras que empiezan en 's': {0}% | Promedio de caracteres: {1} ", porcentajeEmpiezaEnS, promedioCaracteres);
				Console.WriteLine("-------------------------------------------------------------------------------------------");
				Console.WriteLine("");
			}
		
		
		
		//Ejercicio 5
		static void mostrarMenuCalculadora() {
			Console.WriteLine("-------------------------------------------------------------");
			Console.WriteLine("Seleccione qué operación desea realizar: \n 1- Suma \n 2- Resta \n 3- Multiplicación \n 4- División \n 0- Salir");
		}
		
		static decimal sumar(decimal a, decimal b) {
			return a + b;
		}
		static decimal restar(decimal a, decimal b) {
			return a - b;
		}
		static decimal multiplicar(decimal a, decimal b){
			return a * b;
		}
		static decimal dividir(decimal a, decimal b){
			return a / b;
		}
	
		
		
		//Ejercicio 6
		static Array aparicionesVocales(string palabra) {
			// en la siguiente línea inicializo el vetor con los strings sin los conteos que después agrego al final
			string [] apariciones = new string [] {"- A: ", "- E: ", "- I: ", "- O: ", "- U: "};
			byte a=0, e=0, i=0, o=0, u=0;
			//me fijo si la palabra ingresada no está vacía para no caer en un error
			if (palabra.Length >0) {
				//convierto la palabra a minúsculas para que cuente todas las apariciones sean mayúsculas o minúsculas
				//igual tiene un problema porque no cuenta las vocales con tilde ni los cositos como é, è, etc. Quizás debería ver los códigos ASCII y contar dependiendo del código.
				foreach (char letra in palabra.ToLower()) {
					switch (letra){
						case 'a':
							a++;
							break;
						case 'e':
							e++;
							break;
						case 'i':
							i++;
							break;
						case 'o':
							o++;
							break;
						case 'u':
							u++;
							break;
					}
				}	
			}
			//y acá concateno, al final de cada elemento del vector, la cantidad de veces que se contó cada vocal.
			apariciones[0] += a;
			apariciones[1] += e;
			apariciones[2] += i;
			apariciones[3] += o;
			apariciones[4] += u;
			return apariciones;
		}
	
	
	}
}
/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 13/4/2025
 * Time: 19:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Ejercicios_de_Clases
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			/*
			Haga un programa de aplicación que lea por consola una sucesión de palabras que termina con la palabra vacía.
			Imprima el porcentaje de palabras que comienzan con ‘s’, la longitud de cada palabra leída y el promedio de caracteres por palabra.
			Ayuda: si st es una variable de tipo string, st.Length devuelve la cantidad de caracteres del string.
			- Si quiero que el cálculo se compute luego de haber ingresado todos los datos ¿cómo lo implemento?
			- ¿En donde guardo las palabras ingresadas?
			- Recordar que no se sabe cuántas palabras ingresará el usuario.
			- Ayuda: palabra != “” o palabra == “”.
			*/
			/*
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
			*/
			
			// ejercicio class alumno
			/* 
			 Clase alumno: nombre, apellido, dni, legajo, nota
			 Clase curso: nombre, lista alumnos 
			 La clase curso debe incluir los 6 métodos de agregar, eliminar, ver en posición, ver si existe, etc
			 Imprimir nombre y apellido de los alumnos que tienen nota mayor al promedio
			 evitar uso de listas, usar acumuladores y contadores
			*/
			
			
			
			Console.Write("Presione una tecla para salir. . . ");
			Console.ReadKey(true);
		}
	}
}
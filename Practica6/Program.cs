/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 10/5/2025
 * Time: 20:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Practica6
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Ejercicio 1
			// Ver enunciado y código en archivo Persona.cs
			
			
			
			// Ejercicio 2
			// Ver enunciado en archivo Practica 6.pdf
			// Ejercicio 2a ver códigos correspondientes en archivos Persona.cs, Alumno.cs, Profesor.cs, Coordinador.cs
			// Ejercicio 2b
			/* En un programa de aplicación (Main) crear un coordinador y simular la inscripción de varios
			 * alumnos (con un while). Al final el proceso imprimir cuántos alumnos no pudieron inscribirse
			 * por falta de cupo y el porcentaje de alumnos de ese coordinador con promedio mayor a 8. */
			int noInscriptos = 0;
			Coordinador coordinador = new Coordinador("Ingeniería", "Algoritmos y Programación", 4);
			string continuar = "s";
			Alumno nuevoAlumno;
			Console.WriteLine("   ----- Alta de alumno ----- ");
			while (continuar != "n") {
				// saco la declaración afuera para poder usarla en la prueba de los métodos de coordinador al final
				//Alumno nuevoAlumno = solicitarDatosYCrearAlumno();
				nuevoAlumno = solicitarDatosYCrearAlumno();
				if (coordinador.CupoDisponible > 0) {
					coordinador.altaAlumno(nuevoAlumno);
					Console.WriteLine("Alumno dado de alta correctamente");
				} else {
					noInscriptos++;
					Console.WriteLine("Alerta: Alumno no inscripto por falta de cupos");
				}
				Console.Write("Desea seguir dando de alta alumnos? [s/n]: ");
				continuar = Console.ReadLine().ToLower();
				while ((continuar != "s" ) && (continuar != "n")) {
					Console.Write("Opción incorrecta, ingrese \"sí\" para continuar dando de altas o \"no\" para terminar: ");
					continuar = Console.ReadLine().ToLower();
				}
				if (continuar == "s") {
					Console.WriteLine("   ----- Alta de alumno ----- ");
				}
				// el siguiente bloque if lo hice para probar los métodos de listas de la clase profesor
				/* if (continuar == "n") {
					Console.WriteLine(coordinador.retornarAlumnos());
					Console.WriteLine(coordinador.cantidadAlumnos());
					// esta es la razón por la que saqué la declaración del alumno de la línea 38 a la línea 33
					Console.WriteLine(coordinador.existeAlumno(nuevoAlumno));
					coordinador.eliminarAlumno(nuevoAlumno);
					
					Console.WriteLine(coordinador.retornarAlumnos());
					Console.WriteLine(coordinador.cantidadAlumnos());
					
					coordinador.altaAlumno(nuevoAlumno);
					Console.WriteLine(coordinador.existeAlumno(nuevoAlumno));
					coordinador.eliminarAlumnoPos(4);
					
					Console.WriteLine(coordinador.retornarAlumnos());
					Console.WriteLine(coordinador.cantidadAlumnos());
					coordinador.recuperarAlumnoPos(3).imprimirDatos();
				} */
				
			}
			Console.WriteLine("Cantidad de alumnos que no pudieron ser inscriptos: {0}", noInscriptos);
			Console.WriteLine("Porcentaje de alumnos con promedio mayor a 8: {0}", coordinador.porcentajePromedioMayor8());
			

						
			                  
			
			Console.Write("Presione alguna tecla para salir . . . ");
			Console.ReadKey(true);
		}
		// acá van las funciones
		// *1 static Alumno solicitarDatosYCrearAlumno () {
		static Alumno solicitarDatosYCrearAlumno () {
			Console.Write("Ingrese el nombre y apellido: "); 
				string nombre = Console.ReadLine();
				Console.Write("Ingrese el DNI: "); 
				int dni = int.Parse( Console.ReadLine());
				Console.Write("Ingrese el promedio: "); 
				double promedio = double.Parse(	Console.ReadLine());
				Console.Write("Ingrese el legajo: "); 
				int legajo = int.Parse(Console.ReadLine());
				// *1 esto no servía me decía en main que los elementos en posiciones del array eran del tipo object, calculo que casteando cada elemento en posición se solucionaba
				// investigar si existe alguna tupla en C#
				//ArrayList datosAlumno = new ArrayList[4]{nombre, dni, promedio, legajo};
				//return datosAlumno;
				return new Alumno(nombre, dni, promedio, legajo);
		}
	}
}
/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 2/6/2025
 * Time: 18:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;


namespace Parcial_1
{
	class Program
	{	// ------------ Enunciado ------------
		/* Una Universidad tiene nombre, un rector, un conjunto de alumnos y un conjunto de carreras.
		 * Una Universidad privada es una Universidad paga, en la cual se cobra matrícula y cuotas mensuales.
		 * De cada alumno se conoce su nombre y apellido, dni, legajo, promedio y el nombre de la carrera que estudia.
		 * De cada carrera se conoce el título que otorga y la duración.
		 * 
		 * En una aplicación (Main) crear una Universidad privada, agregarle carreras e inscribir varios alumnos (usar un bucle).
		 * Cuando se hace la inscripción el alumno debe abonar la matrícula.
		 * Si en el proceso de inscripción se ingresa un valor no numérico como Dni se levanta una excepción FormatException(),
		 * avisar lo ocurrido y reingresar el dato. Al finalizar el proceso imprimir el listado de alumnos que se inscribieron
		 * en la carrera de Ingeniería en Sistemas y el monto total recaudado en concepto de pago de matrícula.
		 */
		public static void Main(string[] args)
		{	
			ArrayList alumnos = new ArrayList();
			Carrera ingenieriaQuimica = new Carrera("Ing Quimica", 5);
			Carrera ingenieriaSistemas = new Carrera("Ingeniería en Sistemas", 5);
			Carrera ingenieriaElectronica = new Carrera("Ing Electronica", 5);
			ArrayList carreras = new ArrayList(){ingenieriaElectronica, ingenieriaQuimica, ingenieriaSistemas};
			UniversidadPrivada universidadPalermitana = new UniversidadPrivada("UPalermitana","algún cheto", alumnos,carreras,1200,200);
			
			bool terminarCarreras = false;
			while (!terminarCarreras) {
				Console.WriteLine("--- Nueva Carrera ---");
				Carrera nuevaCarrera = crearCarrera();
				universidadPalermitana.agregarCarrera(nuevaCarrera);
				Console.Write("Continuar agregando carreras? ingrese enter para continuar o \"n\" para terminar: ");
				string terminar = Console.ReadLine();
				if (terminar == "n") {
					terminarCarreras = true;
				}
			}
			
			
			
			//int testint = ingresarYCastearInt("DNI", "Ingrese solo el numero sin puntos ni espacios");
			//float testFloat = ingresarYCastearFloat("Matricula", "ingrese solo el numero usando coma como separador de decimales");
			Console.WriteLine("---------- Alta de alumnos ----------------");
			bool terminarAlumnos = false;
			while (!terminarAlumnos) {
				Console.WriteLine(" ------ Nuevo alumno -----");
				Console.WriteLine("Seleccionar carrera");
				for (int i = 0; i< universidadPalermitana.cantidadCarreras(); i++) {
					Console.WriteLine("{0} - {1}", i+1, (string) universidadPalermitana.recuperarCarreraPosicion(i).Titulo);
				}
				Console.Write("Ingrese la carrera seleccionada: "); 
				int carreraSeleccionada = int.Parse(Console.ReadLine());
				Carrera carreraAlumno = universidadPalermitana.recuperarCarreraPosicion(carreraSeleccionada - 1);
				
				string matriculaAbonada = "n";
				Console.Write("El alumno abonó la matricula? (s/n): ");
				matriculaAbonada = Console.ReadLine();
				if (matriculaAbonada == "s") {
					Alumno nuevoAlumno = crearAlumno(carreraAlumno);
					universidadPalermitana.agregarAlummno(nuevoAlumno);
				} else {
					Console.WriteLine("Alta de alumno cancelada");
				}
				
				Console.Write("Desea continuar agregando alumnos? Ingrese enter para continuar o \"n\" para terminar: ");
				string terminar = Console.ReadLine();
				if (terminar == "n") {
					terminarAlumnos = true;
				}
			}
			
			Console.WriteLine(" ----- Alumnos en ingeniería en sistemas ----- ");
			foreach (Alumno alumno in universidadPalermitana.listadoAlumnos()) {
				if (alumno.NombreCarrera == "Ingeniería en Sistemas") {
					alumno.imprimir();
				}
			}
			
			Console.WriteLine(" ------------------------ ");
			Console.WriteLine("Monto total recaudado en concepto de matriculas: {0}", universidadPalermitana.cantidadAlumnos()*universidadPalermitana.Matricula);
			
			
			Console.Write("Presione alguna tecla para salir . . . ");
			Console.ReadKey(true);
		}
		
		// ----- Funciones -----
		static int ingresarYCastearInt(string dato, string requisitos) {
			int datoCasteado = 0;
			bool datoCorrecto = false;
			while (!datoCorrecto) {
				Console.Write("Ingrese {0} ({1}): ", dato, requisitos);
				try {
					datoCasteado = int.Parse(Console.ReadLine());
					datoCorrecto = true;
				} catch (FormatException) {
					Console.WriteLine("{0} ingresado incorrectamente, {1}.", dato, requisitos);
				} catch (Exception) {
					Console.WriteLine("Error! Intente nuevamente.");
				}
			}
			return datoCasteado;
		}
		
		static float ingresarYCastearFloat(string dato, string requisitos) {
			float datoCasteado = 0;
			bool datoCorrecto = false;
			while (!datoCorrecto) {
				Console.Write("Ingrese {0} ({1}): ", dato, requisitos);
				try {
					datoCasteado = float.Parse(Console.ReadLine());
					datoCorrecto = true;
				} catch (FormatException) {
					Console.WriteLine("{0} ingresado incorrectamente, {1}.", dato, requisitos);
				} catch (Exception) {
					Console.WriteLine("Error! Intente nuevamente.");
				}
			}
			return datoCasteado;
		}
		
		static Carrera crearCarrera() {
			Console.Write("Ingrese el título: ");
			string titulo = Console.ReadLine();
			int duracion = ingresarYCastearInt("Duración", "ingrese solo el número correspondiente a la cantidad de años");
			return new Carrera(titulo, duracion);
		}
		
		static Alumno crearAlumno(Carrera carrera) {
			Console.Write("Ingrese el nombre: "); string nombre = Console.ReadLine();
			Console.Write("Ingrese el apellido: "); string apellido = Console.ReadLine();
			int dni = ingresarYCastearInt("DNI", "Ingrese solo el número sin puntos ni espacios");
			int legajo = ingresarYCastearInt("Legajo", "Ingrese solo el numero sin guiones ni espacios");
			float promedio = ingresarYCastearFloat("Promedio", "Ingrese solo el numero usando coma como separador de decimales");
			return new Alumno(nombre, apellido, dni, legajo, promedio, (string) carrera.Titulo);
		}
		
		
	}
}
/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 5/5/2025
 * Time: 12:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Practica5
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Ejercicio 1
			// Ver enunciado en archivo Practica 5.pdf dentro del root del repositorio
			// Ver código en archivo Horario.cs
			
			// Ejercicio 2
			// Ver enunciado en archivo Practica 5.pdf dentro del root del repositorio
			// Ver código en archivo Alumno.cs
			/*
			Horario lunesOchoDoce = new Horario("Lunes", "8 a 12", "Masterclass de Don Ramón");
			Horario martesOchoDiez = new Horario("Martes", "8 a 10", "Geometría");
			Horario martesDiezDoce = new Horario("Martes", "10 a 12", "Geografía");
			Horario miercolesOchoDoce = new Horario("Miercoles", "8 a 12", "Arte");
			Horario miercolesOchoDoceGDR = new Horario("Miercoles", "8 a 12", "Clases de Guitarra con Don Ramon");
			
			ArrayList alumnos = new ArrayList();
			Alumno Chavo = new Alumno("Chavo Delocho", 123456, 1);
			Chavo.agregarMateria(lunesOchoDoce);
			Chavo.agregarMateria(martesOchoDiez);
			Chavo.agregarMateria(martesDiezDoce);
			Chavo.agregarMateria(miercolesOchoDoceGDR);
			//Chavo.agregarMateria(miercolesOchoDoce);
			alumnos.Add(Chavo);
			// acá me queda pendiente armar una función cíclica con while para ingresar alumnos
			Alumno Chilindrina = new Alumno("Chilindrina Valdés", 123457,2);
			Chilindrina.agregarMateria(lunesOchoDoce);
			Chilindrina.agregarMateria(martesOchoDiez);
			Chilindrina.agregarMateria(martesDiezDoce);
			Chilindrina.agregarMateria(miercolesOchoDoce);
			alumnos.Add(Chilindrina);
			Alumno Quico = new Alumno("Federico Chancluda", 123458,3);
			Quico.agregarMateria(martesOchoDiez);
			Quico.agregarMateria(martesDiezDoce);
			alumnos.Add(Quico);
			Alumno Nionio = new Alumno("Ñoño Barriga", 123459, 4);
			Nionio.agregarMateria(martesOchoDiez);
			Nionio.agregarMateria(martesDiezDoce);
			alumnos.Add(Nionio);
			Alumno Godinez = new Alumno("SinNombre Godinez", 123460, 5);
			Godinez.agregarMateria(lunesOchoDoce);
			Godinez.agregarMateria(miercolesOchoDoce);
			alumnos.Add(Godinez);
			Alumno Popis = new Alumno("Popis SinApellido",123461,6);
			alumnos.Add(Popis);
			
			//Chavo.verMaterias();
			//Chilindrina.verHorariosyMaterias();
			//Popis.verMaterias();
			//Console.WriteLine(Chavo.verCuantasMateriasCursa());
			
			string opcion = "-";
			Console.WriteLine("-------------------------------------------------------------");
			mostrarMenuAlumnos();
			Console.Write("Ingrese el número de la operación que desea realizar: ");
			opcion = Console.ReadLine();
			while (opcion != "0") {
				string nombreAlumno, nombreMateria, diaMateria, horarioMateria;
				switch (opcion) {
						case "1": 
								Console.Write("Ingrese el nombre de la materia: ");
								nombreMateria = Console.ReadLine();
								// acá me falta ver de hacer un arraylist que tenga todas las materias para no duplicarlas
								// y recién después de ver que no existe la materia pedir los siguientes datos e instanciarla								
								Console.Write("Ingrese el dia que se da la materia: ");
								diaMateria = Console.ReadLine();
								Console.Write("Ingrese el horario de la materia: ");
								horarioMateria = Console.ReadLine();
								Horario materia = new Horario(diaMateria, horarioMateria, nombreMateria);
								// primero pido el nombre del alumno y veo en el arraylist de alumnos si existe, si existe le agrego el horario
								// sino, primero se instancia el alumno y después se le agrega el horario
								bool existeAlumno = false;
								Console.Write("Ingrese el nombre y apellido del alumno: ");
								nombreAlumno = Console.ReadLine();
								foreach (Alumno e in alumnos) {
									if (e.NombreApellido == nombreAlumno) {
										existeAlumno = true;
										e.agregarMateria(materia);
										// alternativamente puedo usar el método que ingresa directamente los datos
										// e.agregarMateria(diaMateria, horarioMateria, nombreMateria)
										break;
									}
								}
								if (!existeAlumno) {
									Console.Write("Ingrese el DNI del alumno: ");
									int dniAlumno = int.Parse(Console.ReadLine());
									Console.Write("Ingrese el legajo del alumno: ");
									int legajoAlumno = int.Parse(Console.ReadLine());
									Alumno nuevoAlumno = new Alumno(nombreAlumno, dniAlumno, legajoAlumno);
									alumnos.Add(nuevoAlumno);
									nuevoAlumno.agregarMateria(materia);
								}
							Console.WriteLine("-------------------------------------------------------------");
							break;
						case "2": 
							Console.Write("Ingrese el nombre de la materia: ");
							nombreMateria = Console.ReadLine().ToLower();
							bool alumnosEncontrados = false;
							foreach (Alumno e in alumnos) {
								// uso el método materiasQueCursa() para tener una lista de materias sin repeticiones por cada alumno y que no se impriman alumnos repetidos
								foreach (string m in e.materiasQueCursa()) {
									if (m.ToLower() == nombreMateria) {
										// me queda pendiente corregir que solo la primera vez que encuentra un alumno para esa materia se cambie alumnosEncontrados a true
										alumnosEncontrados = true;
										Console.Write(" - {0} \n", e.NombreApellido);
									}
								}
							}
							if (!alumnosEncontrados) {
								Console.WriteLine("No se encontró ningún alumno inscripto en esa materia o no existe esa materia");
							}
							Console.WriteLine("-------------------------------------------------------------");
							break;
						case "3": 
							Console.Write("Ingrese el nombre del alumno: "); 
							nombreAlumno = Console.ReadLine().ToLower();
							bool alumnoEncontrado = false;
							foreach (Alumno e in alumnos) {
								if (e.NombreApellido.ToLower() == nombreAlumno) {
									alumnoEncontrado = true;
									Console.WriteLine("{0} cursa {1} materias", nombreAlumno,e.cuantasMateriasCursa());
								}
							}
							if (!alumnoEncontrado) {
								Console.WriteLine("No se encontró ningún alumno con ese nombre y apellido");
							}
							Console.WriteLine("-------------------------------------------------------------");
							break;
						case "4":
							foreach (Alumno e in alumnos) {
								Console.Write(" - {0}\n",e.NombreApellido);
							}
							Console.WriteLine("-------------------------------------------------------------");
							break;
						default: 
							Console.WriteLine("No existe la opción ingresada");
							Console.WriteLine("-------------------------------------------------------------");
							break;								
				}
				mostrarMenuAlumnos();
				Console.Write("Ingrese el número de la operación que desea realizar: ");
				opcion = Console.ReadLine();
			}
			*/
			
			
			
			// Ejercicio 4
			
			
			
			
			Console.Write("Presione una tecla para salir . . . ");
			Console.ReadKey(true);
		}
		// acá van las funciones
		static void mostrarMenuAlumnos() {
			Console.WriteLine("------- Menú de Alumnos -------");
			Console.WriteLine(" 1- Inscribir un alumno en una materia");
			Console.WriteLine(" 2- Imprimir alumnos inscriptos en una materia");
			Console.WriteLine(" 3- Informar cuantas materias cursa un alumno");
			Console.WriteLine(" 4- Imprimir Lista de todos los alumnos");
			Console.WriteLine(" 0- Salir");
		}
		
		
	}
}
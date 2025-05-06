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
			Chavo.agregarMateria(miercolesOchoDoce);
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
			
			Chavo.verMaterias();
			Chilindrina.verHorariosyMaterias();
			Popis.verMaterias();
			
			
			Console.Write("Presione una tecla para salir . . . ");
			Console.ReadKey(true);
		}
		// acá van las funciones
		
	}
}
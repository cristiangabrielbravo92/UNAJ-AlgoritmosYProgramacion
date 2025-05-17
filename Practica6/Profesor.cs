/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 10/5/2025
 * Time: 20:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Practica6
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor
	{
		// ----- Atributos -----
		protected ArrayList alumnos;
		protected int cupoDisponible;
		// Comento la siguiente línea porque no sé de donde viene la clase materia, calculo que será la clase horario de la practica 5 pero para no hacerla larga la uso como string
		//protected Materia materia;
		protected string materia;
		
		
		// ----- Constructores -----
		
//		public Profesor()
//		{
//		}
		public Profesor(string materia, int cupoDisponible) {
			this.alumnos = new ArrayList();
			this.materia = materia;
			this.cupoDisponible = cupoDisponible;
		}
		
		
		
		// ----- Propiedades -----
		public int CupoDisponible {
			//set {}
			get {return cupoDisponible;}
		}
		
		
		
		// ----- Métodos -----
		
		// métodos básicos para listas
		public void altaAlumno(Alumno e){
			alumnos.Add(e);
			cupoDisponible -= 1; }
		
		public void eliminarAlumno(Alumno alumno) {
			alumnos.Remove(alumno);
		}
		
		public void eliminarAlumnoPos(int posicion) {
			alumnos.RemoveAt(posicion-1);
		}
		
		
		public int cantidadAlumnos() {
			return alumnos.Count;
		}
		
		public Alumno recuperarAlumnoPos(int posicion) {
			return (Alumno) alumnos[posicion-1];
		}
		
		public bool existeAlumno(Alumno alumno) {
			return alumnos.Contains(alumno);
		}
		
		public ArrayList retornarAlumnos() {
			return alumnos;
		}
		
		
		
		
		
		//métodos específicos
		
		public double porcentajePromedioMayor8() {
			//double porcentajePromMayor8 = 0;
			if (alumnos.Count == 0) {
				return 0;
			} else {
			int cantidadPromMayor8 = 0;
			foreach (Alumno alumno in alumnos) {
				if (alumno.Promedio > 8) {
					cantidadPromMayor8++;
				}
			}
			if (alumnos.Count == 0) return 0;
			//Console.WriteLine(cantidadPromMayor8);
			//Console.WriteLine(alumnos.Count);
			//Console.WriteLine(cantidadPromMayor8 / alumnos.Count);
			//Console.WriteLine((cantidadPromMayor8 / alumnos.Count)*100);
			// daba 0 de resultado, solo se arregló casteando como double para que el resultado sea decimal
			return ((double)cantidadPromMayor8 / alumnos.Count)*100;
			}
		}
		
		
		
		
	}
}

/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 2/6/2025
 * Time: 18:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Parcial_1
{
	/// <summary>
	/// Description of Universidad.
	/// </summary>
	public class Universidad
	{	// ----- Variables -----
		//Una Universidad tiene nombre, un rector, un conjunto de alumnos y un conjunto de carreras.
		protected string nombre, rector;
		protected ArrayList alumnos;
		protected ArrayList carreras;
		
		
		// ------ Constructores -----
		public Universidad()
		{
			this.alumnos = new ArrayList();
			this.carreras = new ArrayList();
		}
		
		public Universidad(string nombre, string rector, ArrayList alumnos, ArrayList carreras) {
			this.nombre = nombre;
			this.rector = rector;
			this.alumnos = alumnos;
			this.carreras = carreras;
		}
		
		
		// ------ Propiedades -----
		public string Nombre {
			set {nombre = value;}
			get {return nombre;}
		}
		public string Rector {
			set {rector = value;}
			get {return rector;}
		}
		
		
		// ------ Métodos -----
		// Métodos de alumnos
		public void agregarAlummno(Alumno alumno) {
			alumnos.Add(alumno);
		}
		public void eliminarAlumno(Alumno alumno) {
			alumnos.Remove(alumno);
		}
		public int cantidadAlumnos() {
			return alumnos.Count;
		}
		public bool existeAlumno(Alumno alumno) {
			return alumnos.Contains(alumno);
		}
		public Alumno recuperarAlumnoPosicion(int posicion) {
			return (Alumno) alumnos[posicion];
		}
		public ArrayList listadoAlumnos() {
			return alumnos;
		}
		
		// Métodos de carreras
		public void agregarCarrera(Carrera carrera) {
			carreras.Add(carrera);
		}
		public void eliminarCarrera(Carrera carrera) {
			carreras.Remove(carrera);
		}
		public int cantidadCarreras() {
			return carreras.Count;
		}
		public bool existeCarrera(Carrera carrera) {
			return carreras.Contains(carrera);
		}
		public Carrera recuperarCarreraPosicion(int posicion) {
			return (Carrera) carreras[posicion];
		}
		public ArrayList listadoCarreras() {
			return carreras;
		}
		
	}
}

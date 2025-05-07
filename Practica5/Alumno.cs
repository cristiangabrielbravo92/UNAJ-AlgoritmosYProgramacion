/*
 * Created by SharpDevelop.
 * User: Cristian Bravo
 * Date: 5/5/2025
 * Time: 17:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Practica5
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno
	{	// ----- Variables de Instancia -----
		private string nombreApellido;
		private int dni, legajo;
		private ArrayList horarios; 
		
		// ----- Constructores -----		
		public Alumno()
		{
		}
		public Alumno (string nombreApellido, int dni, int legajo) {
			this.nombreApellido = nombreApellido;
			this.dni = dni;
			this.legajo = legajo;
			this.horarios = new ArrayList();
		}
		
		
		
		// ----- Propiedades -----
		public string NombreApellido {
			set {nombreApellido = value;}
			get {return nombreApellido;}
		}
		public int Dni {
			set {dni = value;}
			get {return dni;}
		}
		public int Legajo {
			set {legajo = value;}
			get {return legajo;}
		}
		public ArrayList Horarios {
			// acá me queda pendiente hacer una función que elimine el arraylist existente, lo reemplace o recorra elemento por elemento reemplazando
			// y los horarios que sobran los vuelva null
			//set {horarios = value;}
			get {return horarios;}
		}
		
		
		
		// ----- Métodos -----
		
		// este método está copiado de Teoria 5 cambiando algunas cosas para que me facilite asimilar la lógica
		public void agregarMateria(string dia, string hora, string materia) {
			bool horarioLibre = true;
			
			foreach (Horario e in horarios) {
				if (dia == e.Dia) {
					if (hora == e.Hora) {
						horarioLibre = false; 
						break;
					}
				}
			}
			if (horarioLibre) {
				Horario h = new Horario(dia, hora, materia);
				horarios.Add(h);
			} else {
				Console.WriteLine("{0} {1} horario ocupado", dia, hora);
				Console.ReadKey();
			}
		}
		// copia del método agregarMateria pero que acepta un objeto horario como argumento
		public void agregarMateria(Horario horario) {
			bool horarioLibre = true;
			
			foreach (Horario e in horarios) {
				if (horario.Dia == e.Dia) {
					if (horario.Hora == e.Hora) {
						horarioLibre = false; 
						break;
					}
				}
			}
			if (horarioLibre) {
				horarios.Add(horario);
			} else {
				Console.WriteLine("{0} {1} horario ocupado", horario.Dia, horario.Hora);
				Console.ReadKey();
			}
		}
		
		
		
		
		public void verMaterias() {
			// lista auxiliar de materias (sin repeticiones)
			ArrayList materias = new ArrayList();
			foreach (Horario e in horarios) {
				if (!materias.Contains(e.Materia)) {
					materias.Add(e.Materia);
				}
			}
			Console.WriteLine("----- Listado de Materias | {0} -----",nombreApellido);
			foreach (string nombreMateria in materias) {
				Console.Write(" - {0} \n", nombreMateria);
			}
		}
		
		
		// este método está copiado de Teoria 5 cambiando algunas cosas para que me facilite asimilar la lógica
		public void verHorariosyMaterias() {
			Console.WriteLine("----- Listado de Materias con sus Horarios | {0} -----", nombreApellido);
			foreach (Horario e in horarios) {
				Console.Write(" - {0} {1} --> {2} \n", e.Dia, e.Hora, e.Materia);
			}
		}
		
		public int cuantasMateriasCursa() {
			ArrayList materias = new ArrayList();
			foreach (Horario e in horarios) {
				if (!materias.Contains(e.Materia)) {
					materias.Add(e.Materia);
				}
			}
			//int cantidadMaterias = materias.Count;
			//return cantidadMaterias;
			return materias.Count;
		}
		
		public ArrayList materiasQueCursa() {
			// creo una lista de materias (sin repeticiones) para usar en la opción 2 del menú
			ArrayList materias = new ArrayList();
			foreach (Horario e in horarios) {
				if (!materias.Contains(e.Materia)) {
					materias.Add(e.Materia);
				}
			}
			return materias;
		}
		
		
	}
}

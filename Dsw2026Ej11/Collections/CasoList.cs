using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//1.Crear un campo que represente una lista de alumnos (List<>)
//2.Incluir un método para agregar alumnos a la lista
//3.Incluir un método para retornar la lista
//4.Incluir un método para buscar un alumno por nombre
//5.Incluir un método para eliminar un alumno (debe recibir un alumno)
//6.Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
        // 1. Campo privado que almacena la lista (encapsulamiento porque es privado).
        private List<Alumno> _alumnos;

        // Constructor
        public CasoList()
        {
            _alumnos = new List<Alumno>();
        }

        // 2. Método para agregar alumnos a la lista.
        public void AgregarAlumno(Alumno alumno)
        {
            _alumnos.Add(alumno); // .Add() -> inserta el elemento al final de la colección
        }

        // 3. Método para retornar la lista completa.
        public List<Alumno> ObtenerLista()
        {
            return _alumnos; //Solo con return
        }

        // 4. Método para buscar un alumno por nombre.
        public Alumno BuscarPorNombre(string nombre)
        {
            // Usamos FirstOrDefault de LINQ que recorre la lista y devuelve el primer alumno 
            // cuyo nombre coincida. Si no encuentra ninguno, devuelve "null". (esto se lo puede hacer con find?)
            return _alumnos.FirstOrDefault(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }

        // 5. Método para eliminar pasándole el objeto alumno exacto.
        public void EliminarAlumno(Alumno alumno)
        {
            _alumnos.Remove(alumno); //Remove es para borrar
        }

        // 6. Método para eliminar por posición (índice).
        public void EliminarEnPosicion(int posicion)
        {
            // Siempre es buena práctica validar que la posición exista para evitar que el sistema falle (excepciones).
            if (posicion >= 0 && posicion < _alumnos.Count)
            {
                _alumnos.RemoveAt(posicion); // .RemoveAt() borra el dato en ese índice numérico exacto.
            }
        }
}

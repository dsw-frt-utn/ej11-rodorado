using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    // Definimos el diccionario. Clave: int (legajo), Valor: Alumno.
    private Dictionary<int, Alumno> _diccionarioAlumnos;

    public CasoDictionary()
    {
        _diccionarioAlumnos = new Dictionary<int, Alumno>();
    }

    // 1. Método para agregar. Recibe el legajo y el objeto alumno.
    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        // Validación de la clave para que no exista antes de agregarla para evitar errores de duplicidad.
        if (!_diccionarioAlumnos.ContainsKey(legajo))
        {
            _diccionarioAlumnos.Add(legajo, alumno);
        }
    }

    // 2. Método para buscar utilizando la clave.
    public Alumno BuscarPorClave(int legajo)
    {
        // ContainsKey verifica si el legajo existe. Si existe, lo retorna; si no, devuelve null.
        if (_diccionarioAlumnos.ContainsKey(legajo))
        {
            return _diccionarioAlumnos[legajo];
        }
        return null;
    }

    // 3. Método para retornar el diccionario completo.
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return _diccionarioAlumnos;
    }

    // 4. Método para eliminar utilizando la clave.
    public void EliminarAlumno(int legajo)
    {
        _diccionarioAlumnos.Remove(legajo); 
    }
}

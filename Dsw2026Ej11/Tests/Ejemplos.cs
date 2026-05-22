namespace Dsw2026Ej11.Tests;

using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System;
using System.Collections.Generic;

internal class Ejemplos
{
    public static void EjemploList()
    {
        Console.WriteLine("--- EJEMPLO LIST ---");
        CasoList lista = new CasoList();

        Alumno a1 = new Alumno(1, "Ana", 8.5);
        Alumno a2 = new Alumno(2, "Juan", 7.0);
        Alumno a3 = new Alumno(3, "Maria", 9.2);

        lista.AgregarAlumno(a1);
        lista.AgregarAlumno(a2);
        lista.AgregarAlumno(a3);

        Console.WriteLine("Alumnos en la lista:");
        foreach (var a in lista.ObtenerLista()) { Console.WriteLine(a); }

        Console.WriteLine("\nBuscando a 'Juan':");
        var buscado = lista.BuscarPorNombre("Juan");
        Console.WriteLine(buscado != null ? buscado.ToString() : "No existe");

        Console.WriteLine("\nBuscando a 'Pedro':");
        var noBuscado = lista.BuscarPorNombre("Pedro");
        Console.WriteLine(noBuscado != null ? noBuscado.ToString() : "No existe");

        Console.WriteLine("\nEliminando a 'Ana'...");
        lista.EliminarAlumno(a1);
        foreach (var a in lista.ObtenerLista()) { Console.WriteLine(a); }

        Console.WriteLine("\nEliminando el primer elemento (Posición 0)...");
        lista.EliminarEnPosicion(0);
        foreach (var a in lista.ObtenerLista()) { Console.WriteLine(a); }
    }

    public static void EjemploDictionary()
    {
        Console.WriteLine("--- EJEMPLO DICTIONARY ---");
        CasoDictionary dicc = new CasoDictionary();

        Alumno a1 = new Alumno(101, "Carlos", 6.5);
        Alumno a2 = new Alumno(102, "Laura", 8.8);
        Alumno a3 = new Alumno(103, "Sofia", 7.4);

        dicc.AgregarAlumno(a1.Id, a1);
        dicc.AgregarAlumno(a2.Id, a2);
        dicc.AgregarAlumno(a3.Id, a3);

        Console.WriteLine("Alumnos en el diccionario:");
        foreach (var kvp in dicc.ObtenerDiccionario()) { Console.WriteLine($"Legajo: {kvp.Key} -> {kvp.Value}"); }

        Console.WriteLine("\nBuscando legajo 102:");
        var buscado = dicc.BuscarPorClave(102);
        Console.WriteLine(buscado != null ? buscado.ToString() : "No existe");

        Console.WriteLine("\nBuscando legajo 999:");
        var noBuscado = dicc.BuscarPorClave(999);
        Console.WriteLine(noBuscado != null ? noBuscado.ToString() : "No existe");

        Console.WriteLine("\nEliminando legajo 101...");
        dicc.EliminarAlumno(101);
        foreach (var kvp in dicc.ObtenerDiccionario()) { Console.WriteLine(kvp.Value); }
    }

    public static void EjemploLinq()
    {
        Console.WriteLine("--- EJEMPLO LINQ ---");
        CasoLinq linq = new CasoLinq();

        Console.WriteLine($"1. Primero: {linq.GetPrimero().Titulo}");
        Console.WriteLine($"2. Último: {linq.GetUltimo().Titulo}");
        Console.WriteLine($"3. Total Precios: {linq.GetTotalPrecios():C}");
        Console.WriteLine($"4. Promedio: {linq.GetPromedioPrecios():C}");

        Console.WriteLine("5. Libros ID > 15:");
        foreach (var l in linq.GetListById()) { Console.WriteLine($"   {l.Id} - {l.Titulo}"); }

        Console.WriteLine("6. Lista Strings (Título y Moneda):");
        foreach (var s in linq.GetLibros()) { Console.WriteLine($"   {s}"); }

        Console.WriteLine($"7. Mayor Precio: {linq.GetMayorPrecio().Titulo}");
        Console.WriteLine($"8. Menor Precio: {linq.GetMenorPrecio().Titulo}");

        Console.WriteLine("9. Libros > Promedio:");
        foreach (var l in linq.GetMayorPromedio()) { Console.WriteLine($"   {l.Titulo} ({l.Precio:C})"); }

        Console.WriteLine("10. Orden Descendente (primeros 3):");
        // Uso .Take(3) acá en la consola solo para no imprimir los 30 de golpe y hacer spam, pero la lista está completa
        foreach (var l in linq.GetLibrosOrdenados().Take(3)) { Console.WriteLine($"   {l.Titulo}"); }
    }
}

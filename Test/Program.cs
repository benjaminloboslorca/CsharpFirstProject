using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void mostrarMenu()
    {
        Console.WriteLine("=====Menu=====");
        Console.WriteLine("1.Calculadora");
        Console.WriteLine("2.Crear Nombre"); 
    }
    
    static void crearNombre()
    {
        Console.WriteLine("Escriba su nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine();
    }
    
}

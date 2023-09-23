using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas_enlazadas_Basicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de LinkedList para representar una lista enlazada
            LinkedList<string> listaEnlazada = new LinkedList<string>();

            // Agregar elementos a la lista enlazada
            listaEnlazada.AddLast("Primero");
            listaEnlazada.AddLast("Segundo");
            listaEnlazada.AddLast("Tercero");

            // Mostrar el contenido de la lista enlazada
            Console.WriteLine("Elementos en la lista enlazada:");
            foreach (string elemento in listaEnlazada)
            {
                Console.WriteLine(elemento); // Debe imprimir los elementos en el orden de agregado
            }

            // Insertar un nuevo elemento después del segundo elemento
            LinkedListNode<string> nodoSegundo = listaEnlazada.Find("Segundo");
            if (nodoSegundo != null)
            {
                listaEnlazada.AddAfter(nodoSegundo, "Nuevo Elemento");
            }

            // Mostrar la lista enlazada después de la inserción
            Console.WriteLine("\nElementos en la lista enlazada después de la inserción:");
            foreach (string elemento in listaEnlazada)
            {
                Console.WriteLine(elemento);
            }

            // Eliminar el tercer elemento de la lista enlazada
            LinkedListNode<string> nodoTercero = listaEnlazada.Find("Tercero");
            if (nodoTercero != null)
            {
                listaEnlazada.Remove(nodoTercero);
            }

            // Mostrar la lista enlazada después de la eliminación
            Console.WriteLine("\nElementos en la lista enlazada después de la eliminación:");
            foreach (string elemento in listaEnlazada)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}

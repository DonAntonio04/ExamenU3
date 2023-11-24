using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3
{
    public class Lista
    {
        Nodo primero;
        Nodo ultimo;

        public bool ListaVacia()
        {
           if(primero== null)
            {
                return true;
            }
           return false;
        }
        public void InsertarPersona()
        {
            Console.WriteLine("Ingrese el nombre");
            string nuevoNombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad");
            int nuevoEdad = Convert.ToInt32(Console.ReadLine);

            Persona nuevoPersona = new Persona(nuevoNombre,nuevoEdad);
            Nodo nuevoNodo = new Nodo(nuevoPersona);

            if(ListaVacia())
            {
                Console.WriteLine("La lista esta vacía");
            }
         
            else
            {
                Nodo actual = primero;
                while (actual.getSiguiente() != null)
                {
                    actual = actual.getSiguiente();
                }

            
            }
        }
    }
}

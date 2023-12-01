using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion_Unidad_3_FAOG
{
    public  class Lista
    {
        private Nodo primero;
        private Nodo ultimo;
        public Lista()
        {
            primero = ultimo = null;
        }
        //Metodo para Verivicar si la lista esta vacia
        public bool Esnulo()
        {
            return primero == null;
        }
        //Metodo para agregar datos 
        public void Insertar(Carro carro)
        {
            //Verifica si la lista esta vacia
            if(Esnulo())
            {
                primero = ultimo = new Nodo(carro);
            }
            else
            {
                Nodo actual = primero;
                while(actual != null)
                {
                    if(actual.gSiguiente == null)
                    {
                        actual = actual.gSiguiente = new Nodo(carro);
                        break;
                    }
                    else
                    {
                        actual = actual.gSiguiente;
                    }
                }
            }
        }
        //Metodo para buscar
        public void Buscar(string Marca)
        {
            //Verificar si la lista esta vacia
            if(Esnulo())
            {
                Console.WriteLine("No tiene valores la lista");
                return;
            }
            else
            {
                Nodo actual = primero;
                bool Encontrar = false;
                int cont = 0;
                while(actual != null)
                {
                    cont++;
                    if(actual.gCarro.Marca == Marca)
                    {
                        Console.WriteLine($"El carro {actual.gCarro.Marca} se encuentra");
                        Encontrar = true;
                        break;
                    }
                    else
                    {
                        actual = actual.gSiguiente;
                        Console.WriteLine("No se encuentra");
                    }
                    if (!Encontrar)
                    {
                        Console.WriteLine("El Modelo no se encuentra en la lista");
                        return;
                    }
                }
              

            }
           
        }
        //Metodo para mostrar
        public void MostraLista()
        {
            //Metodo para ver si la lista esta vacia o no
            if(Esnulo())
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }
            else
            {
                Nodo actual = ultimo;
                while(actual != null)
                {
                    Console.WriteLine($"El Modelo es: {actual.gCarro.Modelo} y la Marca es: {actual.gCarro.Marca} y el año es {actual.gCarro.Año}");
                    actual = actual.gSiguiente;
                }
            }
        }
        //Metodo para ordenar
        public void OrdenarDescendente()
        {
            //Metodo para ver si la lista esta vacia o no
            if (Esnulo() || primero == ultimo)
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }

            bool intercambiado;
            do
            {
                intercambiado = false;
                Nodo actual = primero;
                Nodo siguiente = primero.gSiguiente;

                while (siguiente != null)
                {
                    if (actual.gCarro.Año < siguiente.gCarro.Año)
                    {
                        Carro temp = actual.gCarro;
                        actual.gCarro = siguiente.gCarro;
                        siguiente.gCarro = temp;

                        intercambiado = true;
                    }

                    actual = actual.gSiguiente;
                    siguiente = siguiente.gSiguiente;
                }
            } while (intercambiado);
        }
    }
}

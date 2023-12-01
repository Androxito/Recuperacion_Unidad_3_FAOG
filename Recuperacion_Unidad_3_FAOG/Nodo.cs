using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion_Unidad_3_FAOG
{
    public class Nodo
    {
        private Carro _carro;
        private Nodo _Siguiente;

        public Nodo(Carro carro)
        {
            _carro = carro;
            _Siguiente = null;
        }
        public Nodo(Carro carro, Nodo siguiente)
        {
            _carro = carro;
            _Siguiente = siguiente;
        }
        public Nodo gSiguiente
        {
            get { return _Siguiente; }
            set { _Siguiente = value; }
        }
        public Carro gCarro
        {
            get { return _carro; }
            set { _carro = value; }
        }
    }
}

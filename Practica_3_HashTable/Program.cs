using System;
using System.Collections;

namespace Practica_3_HashTable
{
    class ClasePrincipal
    {
        bool salir;
        private Hashtable hashtable;
        private Alumno alumno;

        ClasePrincipal()
        {
            salir = false;
            hashtable = new Hashtable();
            alumno = new Alumno();
        }

        static void Main(string[] args)
        {
        }
    }
}

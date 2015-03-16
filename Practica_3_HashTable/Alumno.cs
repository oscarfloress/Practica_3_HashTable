using System;

namespace Practica_3_HashTable
{
    class Alumno
    {
        public string nombre;
        public string codigo;

        public Alumno()
        {
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getCodigo()
        {
            return codigo;
        }

        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }
    }
}

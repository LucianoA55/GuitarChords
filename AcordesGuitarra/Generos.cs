using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcordesGuitarra
{
    class Generos
    {
        private int id_genero;
        private string nombre_genero;

        public int pId_genero { get => id_genero; set => id_genero = value; }
        public string pNombre_genero { get => nombre_genero; set => nombre_genero = value; }
        public Generos()
        {
            id_genero = 0;
            nombre_genero = "";
        }
        public Generos(int id_genero,string nombre_genero)
        {
            this.id_genero = id_genero;
            this.nombre_genero = nombre_genero;
        }
        public string toString()
        {
            return nombre_genero;
        }
    }
}

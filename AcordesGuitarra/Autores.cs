using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcordesGuitarra
{
    class Autores
    {
        private int id_autor;
        private string nombre_autor;

        public int pId_autor { get => id_autor; set => id_autor = value; }
        public string pNombre_autor { get => nombre_autor; set => nombre_autor = value; }
        public Autores()
        {
            id_autor = 0;
            nombre_autor = "";
        }
        public Autores(int id_autor, string nombre_autor)
        {
            this.id_autor = id_autor;
            this.nombre_autor = nombre_autor;
        }
        public string toString()
        {
            return nombre_autor;
        }
    }
}

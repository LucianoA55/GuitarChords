using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcordesGuitarra
{
    class Partituras
    {
        private int id_partitura;
        private string nombre_cancion;
        private int capotrasto;
        private int posicion_capo;
        private string letra1;
        private string letra2;
        private int id_genero;
        private int id_autor;

        public int pId_partitura { get => id_partitura; set => id_partitura = value; }
        public string pNombre_cancion { get => nombre_cancion; set => nombre_cancion = value; }
        public int pCapotrasto { get => capotrasto; set => capotrasto = value; }
        public int pPosicion_capo { get => posicion_capo; set => posicion_capo = value; }
        public string pLetra1 { get => letra1; set => letra1 = value; }
        public int pId_genero { get => id_genero; set => id_genero = value; }
        public int pId_autor { get => id_autor; set => id_autor = value; }
        public string pLetra2 { get => letra2; set => letra2 = value; }

        public Partituras()
        {
            id_partitura = 0;
            nombre_cancion = "";
            capotrasto = 0;
            posicion_capo = 0;
            letra1 = "";
            letra2 = "";
            id_genero = 0;
            id_autor = 0;
        }
        public Partituras(int id_partitura,string nombre_cancion,int capotrasto,int posicion_capo,string letra1,string letra2,int id_genero,int id_autor)
        {
            this.id_partitura = id_partitura;
            this.nombre_cancion = nombre_cancion;
            this.capotrasto = capotrasto;
            this.posicion_capo = posicion_capo;
            this.letra1 = letra1;
            this.id_genero = id_genero;
            this.id_autor = id_autor;
            this.letra2 = letra2;
        }
        public string toString()
        {
            return nombre_cancion;
        }
    }
}

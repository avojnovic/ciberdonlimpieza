using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ciberdon
{
   public class Folder
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private bool _habilitada;

        public bool Habilitada
        {
            get { return _habilitada; }
            set { _habilitada = value; }
        }

        private string _carpeta;

        public string Carpeta
        {
            get { return _carpeta; }
            set { _carpeta = value; }
        }

    }
}

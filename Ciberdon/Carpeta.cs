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



        private string _carpeta;

        public string Carpeta
        {
            get { return _carpeta; }
            set { _carpeta = value; }
        }

    }
}

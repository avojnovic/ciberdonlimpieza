using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ciberdon
{
   public class Carpeta
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }



        private string _path;

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

    }
}

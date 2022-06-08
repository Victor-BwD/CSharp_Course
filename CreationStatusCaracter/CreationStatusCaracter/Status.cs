using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationStatusCaracter
{
    internal class Status
    {
        private string _name;
        private int _age;
        private string _class;
        
        public int Strong { get; set; }
        public int Dex { get; set; }
        public int Intelligence { get; set; }
        public int Constitution { get; set; }

        public string Name
        {
            get { return _name; }
            set {
                if(value != null && value.Length > 1)
                {
                    _name = value;
                } 
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 16)
                {
                    _age = value;
                }
            }
        }

        public string Class
        {
            get { return _class; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _class = value;
                }
            }
        }
    }
}

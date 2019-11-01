using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Entities
{
    public class Persons
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public byte[] Photo { get; set; }
        public override string ToString()
        {
            return Name + " "+Surname;
        }

    }
}

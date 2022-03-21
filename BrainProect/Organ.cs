using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainProect
{
    public class Organ
    {
        public string Id { get; set; }
        public string Description { get; set; }

        public Organ() { }

        public Organ(string Id, string Description)
        {
            this.Id = Id;
            this.Description = Description;
        }

        /*public override bool Equals(object obj)
        {
            Organ o = (Organ)obj;
            return o.Id.Equals(this.Id);
        }*/

        public override string ToString()
        {
            return this.Id;
        }
    }
}
